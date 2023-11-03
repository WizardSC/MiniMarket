using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.MyCustom;

namespace GUI
{

    public partial class BanHangGUI : Form
    {
        private int ProductsPerPage = 9;  // Số sản phẩm trên mỗi trang
        private int TotalPages;  // Tổng số trang
        private int CurrentPage = 1;  // Trang hiện tại
        private int diemTLCuaKhachHang = 0; //Điểm TL hiện tại của khách hàng mua hàng
        private float phanTramKM = 0; //Phần trăm KM
        private List<ChiTietKhuyenMaiDTO> listCTKM; //Dưới đây là list CTKM lấy từ form MiniCTKM;

        private int soLuongTrongKhoLucBanDau = 0;
        private float giaTienLanDauLucCoKM = 0;
        private bool isClickedMiniDTL = false;
        private SanPhamBLL spBLL;
        private HoaDonBLL hdBLL;
        private KhachHangBLL khBLL;
        private NhanVienBLL nvBLL;
        private CTHoaDonBLL cthdBLL;
        //private NhanVienBLL nvBLL;
        private DataTable dtSanPham;
        private DataTable dtKhachHang;
        private DataTable dtNhanVien;
        private DataTable dtHoaDon;
        private List<SanPhamDTO> listSP;
        private List<NhanVienDTO> listNV;
        Dictionary<string, ProductInfo> gioHang = new Dictionary<string, ProductInfo>();
        //Lưu trữ giỏ hàng tạm thời
        public struct ProductInfo
        {
            public ProductInfo(string maSP, string tenSP, int soLuong, int donGiaBanDau, int donGiaDaGiam, int phanTramKM, float thanhTien)
            {
                MaSP = maSP;
                TenSP = tenSP;
                SoLuong = soLuong;
                DonGiaBanDau = donGiaBanDau;
                DonGiaDaGiam = donGiaDaGiam;
                PhanTramKM = phanTramKM;
                ThanhTien = thanhTien;
            }

            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int SoLuong { get; set; }

            public int DonGiaBanDau { get; set; }
            public int DonGiaDaGiam { get; set; }
            public int PhanTramKM { get; set; }

            public float ThanhTien { get; set; }




        }
        public BanHangGUI()
        {
            InitializeComponent();
            spBLL = new SanPhamBLL();
            hdBLL = new HoaDonBLL();
            khBLL = new KhachHangBLL();
            nvBLL = new NhanVienBLL();
            cthdBLL = new CTHoaDonBLL();
            dtSanPham = spBLL.getListSanPham();
            dtHoaDon = hdBLL.getListHoaDon();
            dtKhachHang = khBLL.getListKhachHang();
            listNV = nvBLL.getListNV();
            listSP = spBLL.getListSP();
            listCTKM = new List<ChiTietKhuyenMaiDTO>();
            // Gọi hàm tính toán số trang
            CalculateTotalPages(listSP);

            // Hiển thị trang hiện tại
            loadNgayThang();

            loadMaHD();
        }
        private void BanHangGUI_Load(object sender, EventArgs e)
        {
            UpdateCurrentPage(dtSanPham);

        }
        // Các hàm khác ở đây
        private List<Tuple<string, string, string>> ConvertDataTableToList(DataTable dt)
        {
            List<Tuple<string, string, string>> listKH = new List<Tuple<string, string, string>>();
            foreach (DataRow row in dt.Rows)
            {
                string maKH = row["MaKH"].ToString();
                string hoKH = row["Ho"].ToString();
                string tenKH = row["Ten"].ToString();
                listKH.Add(new Tuple<string, string, string>(maKH, hoKH, tenKH));
            }

            return listKH;
        }

        private void loadMaHD()
        {
            if (hdBLL.getListHoaDon().Rows.Count > 0)
            {
                var lastMaHD = hdBLL.getListHoaDon().AsEnumerable().Last()["MaHD"].ToString();
                int lastNumber = int.Parse(lastMaHD.Substring(2));
                int newNumber = lastNumber + 1;
                string newMaHD = "HD" + newNumber.ToString("D3");
                lblMaHD.Text = $"#{newMaHD}";
            }
            else
            {
                lblMaHD.Text = "#HD001";

            }
        }
        private void loadNgayThang()
        {
            lblNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void refreshThongTin()
        {
            txtMaSP.Texts = "";
            txtTenSP.Texts = "";
            txtTonKho.Texts = "";
            txtDonGia.Texts = "";
            pbImage.Image = pbImage.InitialImage;
            nudSoLuongMua.Value = 0;
        }
        private void CalculateTotalPages(List<SanPhamDTO> productList)
        {
            TotalPages = (int)Math.Ceiling((double)productList.Count / ProductsPerPage);
        }

        private byte[] convertImageToBinaryString(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            return ms.ToArray();

        }

        //chuyển đổi một dạng biểu diễn nhị phân thành một hình ảnh 
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
        }

        public string ConvertIntToVND(int amount)
        {
            // Sử dụng định dạng số nguyên của tiền VND và thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N0}đ", amount);
            return formattedAmount;
        }
        public string ConvertFloatToVND(float amount)
        {
            // Sử dụng định dạng số float của tiền VND, thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N}đ", amount);
            return formattedAmount;
        }
        public int ConvertVNDToInt(string vndAmount)
        {
            // Loại bỏ ký hiệu "đ" và dấu phẩy (,) trong chuỗi
            string cleanedAmount = vndAmount.Replace("đ", "").Replace(",", "");

            // Chuyển đổi chuỗi thành số nguyên
            if (int.TryParse(cleanedAmount, out int result))
            {
                return result;
            }
            else
            {
                // Xử lý lỗi nếu chuỗi không thể chuyển đổi thành số nguyên
                throw new ArgumentException("Không thể chuyển đổi chuỗi thành số nguyên.");
            }
        }
        public float ConvertVNDToFloat(string vndAmount)
        {
            // Loại bỏ ký hiệu "đ" và dấu phẩy (,) trong chuỗi
            string cleanedAmount = vndAmount.Replace("đ", "").Replace(",", "");

            // Chuyển đổi chuỗi thành số float
            if (float.TryParse(cleanedAmount, out float result))
            {
                return result;
            }
            else
            {
                // Xử lý lỗi nếu chuỗi không thể chuyển đổi thành số float
                throw new ArgumentException("Không thể chuyển đổi chuỗi thành số float.");
            }
        }
        private void UpdateCurrentPage(DataTable dt)
        {
            int startIndex = (CurrentPage - 1) * ProductsPerPage;
            int endIndex = Math.Min(startIndex + ProductsPerPage, dt.Rows.Count);

            this.flpDanhSachSanPham.Controls.Clear();

            for (int i = startIndex; i < endIndex; i++)
            {
                MyCustom.MyProductItem item = new MyCustom.MyProductItem();

                item.lblMaSP.Text = dt.Rows[i]["MaSP"].ToString();
                item.lblTenSP.Text = dt.Rows[i]["TenSP"].ToString();
                item.lblDonGia.Text = ConvertIntToVND(int.Parse(dt.Rows[i]["DonGiaNhap"].ToString()));

                byte[] imageBytes = (byte[])dt.Rows[i]["IMG"];
                item.pbxIMG.Image = convertBinaryStringToImage(imageBytes);
                item.Margin = new Padding(4); // 4 pixels cho mỗi hướng
                item.ItemClicked += Item_ItemClicked; // Gán sự kiện ở đây

                this.flpDanhSachSanPham.Controls.Add(item);
            }

            // Cập nhật thông tin phân trang
            lblPagination.Text = $"{CurrentPage}/{TotalPages}";
        }

        // Các sự kiện nút "Previous" và "Next" ở đây

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                UpdateCurrentPage(dtSanPham);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                UpdateCurrentPage(dtSanPham);
                Console.WriteLine("a");
            }
        }
        private void Item_ItemClicked(object sender, EventArgs e)
        {
            // Đây là nơi bạn có thể xử lý khi item được click
            // Dựa vào item để lấy thông tin sản phẩm và hiển thị nó lên màn hình
            MyCustom.MyProductItem clickedItem = (MyCustom.MyProductItem)sender;
            string maSP = clickedItem.lblMaSP.Text;
            string tenSP = clickedItem.lblTenSP.Text;
            int donGia = ConvertVNDToInt(clickedItem.lblDonGia.Text);
            int soLuong = 0;

            foreach (SanPhamDTO sp in listSP)
            {
                if (sp.MaSP == maSP)
                {
                    soLuong = sp.SoLuong;
                    soLuongTrongKhoLucBanDau = sp.SoLuong;
                    txtTonKho.Texts = soLuong.ToString();
                    break;
                }
            }

            txtMaSP.Texts = maSP;
            txtTenSP.Texts = tenSP;
            txtDonGia.Texts = donGia.ToString();
            pbImage.Image = clickedItem.pbxIMG.Image;

            if (gioHang.ContainsKey(maSP))
            {
                ProductInfo existingProduct = gioHang[maSP];
                int soLuongTrongGio = existingProduct.SoLuong;

                soLuong -= soLuongTrongGio;
            }

            // Cập nhật số lượng tồn kho
            txtTonKho.Texts = soLuong.ToString();

            // Cập nhật giá trị tối đa cho nudSoLuongMua
            nudSoLuongMua.Maximum = soLuong;

            // Kiểm tra số lượng và cập nhật nút "Thêm vào giỏ"
            if (soLuong == 0)
            {
                btnThemVaoGio.Enabled = false;
                btnThemVaoGio.BackColor = Color.FromArgb(153, 160, 159);
            }
            else
            {
                btnThemVaoGio.Enabled = true;
                btnThemVaoGio.BackColor = Color.FromArgb(58, 191, 186);
            }

        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            string tenKH = lblKhachHang.Text;
            if (string.IsNullOrWhiteSpace(tenKH))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!string.IsNullOrEmpty(lblKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng bỏ áp dụng chương trình khuyến mãi trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblDiemTL.Text != "0")
            {
                MessageBox.Show("Vui lòng bỏ áp dụng điểm tích lũy trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string maSP = txtMaSP.Texts;
            string tenSP = txtTenSP.Texts;
            int soLuongTonKho = int.Parse(txtTonKho.Texts);
            int donGia = int.Parse(txtDonGia.Texts);
            int soLuongMua = Convert.ToInt32(Math.Round(nudSoLuongMua.Value, 0));
            if (soLuongMua == 0)

            {
                MessageBox.Show("Vui lòng chọn số lượng cần thêm", "Thông báo");
                return;
            }

            //Cập nhật tồn kho(chưa cập nhật trên database)
            if (gioHang.ContainsKey(maSP))
            {
                ProductInfo existingProduct = gioHang[maSP];
                existingProduct.SoLuong += soLuongMua;

                existingProduct.ThanhTien = existingProduct.SoLuong * existingProduct.DonGiaBanDau;

                gioHang[maSP] = existingProduct;
            }
            else
            {
                ProductInfo product = new ProductInfo(maSP, tenSP, soLuongMua, donGia, 0, 0, soLuongMua * donGia);
                gioHang[maSP] = product;


            }


            // Tìm sản phẩm trong flpGioHang bằng Mã SP
            MyCustom.MyProductInCart existingItem = null;
            foreach (Control control in flpGioHang.Controls)
            {
                if (control is MyCustom.MyProductInCart)
                {
                    MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)control;
                    if (item.lblMaSP.Text == maSP)
                    {
                        existingItem = item;
                        break;
                    }

                }
            }

            if (existingItem != null)
            {
                //Nếu sản phẩm đã tồn tại trong flpGioHang, cộng dồn số lượng và tổng tiền
                int tempDonGia = ConvertVNDToInt(existingItem.lblDonGia.Text);

                existingItem.soLuongMuaThem = int.Parse(existingItem.txtSoLuong.Texts);
                existingItem.txtSoLuong.Texts = (existingItem.soLuongMuaThem + soLuongMua).ToString();
                int tempSoLuong = int.Parse(existingItem.txtSoLuong.Texts);
                existingItem.lblTongTien.Text = ConvertIntToVND(tempSoLuong * tempDonGia);

            }
            else
            {
                // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới
                MyCustom.MyProductInCart item = new MyCustom.MyProductInCart();
                //Đây là số lượng ban đầu trong db
                item.soLuongTrongKho = soLuongTrongKhoLucBanDau;

                //Đây là đơn giá lúc ban đầu
                item.donGiaBanDau = donGia;
                item.lblMaSP.Text = maSP;
                item.lblTenSP.Text = tenSP;
                item.txtSoLuong.Texts = soLuongMua.ToString();
                item.lblDonGia.Text = ConvertIntToVND(donGia);
                item.lblTongTien.Text = ConvertIntToVND(soLuongMua * donGia);
                item.TangButtonClicked += MyProductInCart_TangButtonClicked;
                item.GiamButtonClicked += MyProductInCart_GiamButtonClicked;
                item.DeleteButtonClicked += MyProductInCart_DeleteButtonClicked;
                flpGioHang.Controls.Add(item);

                soLuongTrongKhoLucBanDau = 0; //Xóa giá trị của nó đi để cho sản phẩm sau


            }
            tinhTongTien(false);
            refreshThongTin();
        }

        private void MyProductInCart_TangButtonClicked(object sender, EventArgs e)
        {
            if (listCTKM.Any() || !string.IsNullOrWhiteSpace(lblKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng bỏ áp dụng chương trình khuyến mãi trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblDiemTL.Text != "0")
            {
                MessageBox.Show("Vui lòng bỏ áp dụng điểm tích lũy trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)sender;

            string maSP = item.lblMaSP.Text;
            int donGia = ConvertVNDToInt(item.lblDonGia.Text);

            int soLuongMua = int.Parse(item.txtSoLuong.Texts);
            soLuongMua += 1;
            int soLuongTrongKho = item.soLuongTrongKho; //Số lượng hiện tại của sản phẩm trong kho nha
            if (soLuongMua > soLuongTrongKho)
            {
                return;
            }
            item.txtSoLuong.Texts = soLuongMua.ToString();
            item.lblTongTien.Text = ConvertIntToVND(soLuongMua * donGia);


            if (gioHang.ContainsKey(maSP))
            {
                ProductInfo existingProduct = gioHang[maSP];
                existingProduct.SoLuong += 1;

                existingProduct.ThanhTien = existingProduct.SoLuong * existingProduct.DonGiaBanDau;

                gioHang[maSP] = existingProduct;
            }

            phanTramKM = 0;
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;
            tinhTongTien(false);

            refreshThongTin();

        }

        private void MyProductInCart_GiamButtonClicked(object sender, EventArgs e)
        {

            if (listCTKM.Any() || !string.IsNullOrWhiteSpace(lblKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng bỏ áp dụng chương trình khuyến mãi trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblDiemTL.Text != "0")
            {
                MessageBox.Show("Vui lòng bỏ áp dụng điểm tích lũy trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MyCustom.MyProductInCart clickedItem = (MyCustom.MyProductInCart)sender;
            string maSP = clickedItem.lblMaSP.Text;
            int donGia = ConvertVNDToInt(clickedItem.lblDonGia.Text);
            int soLuongMua = int.Parse(clickedItem.txtSoLuong.Texts);
            soLuongMua -= 1;
            if (soLuongMua < 0)
            {
                return;
            }
            clickedItem.txtSoLuong.Texts = soLuongMua.ToString();
            clickedItem.lblTongTien.Text = ConvertIntToVND(soLuongMua * donGia);



            //Cập nhật tồn kho(chưa cập nhật trên database)
            if (gioHang.ContainsKey(maSP))
            {
                ProductInfo existingProduct = gioHang[maSP];
                existingProduct.SoLuong -= 1;

                existingProduct.ThanhTien = existingProduct.SoLuong * existingProduct.DonGiaBanDau;

                gioHang[maSP] = existingProduct;
            }
            //Khi click về 0 thì xóa sản phẩm
            if (clickedItem.txtSoLuong.Texts == "0")
            {
                var result = MessageBox.Show("Bạn có muốn xóa sản phẩm khỏi giỏ hàng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    flpGioHang.Controls.Remove(clickedItem);
                    List<string> keysToRemove = new List<string>();
                    foreach (var pair in gioHang)
                    {
                        if (pair.Key == maSP)
                        {
                            keysToRemove.Add(pair.Key);
                        }
                    }

                    foreach (string key in keysToRemove)
                    {
                        gioHang.Remove(key);
                    }
                    tinhTongTien(false);

                    return;

                }
            }
            else
            {

            }
            phanTramKM = 0;
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;
            refreshThongTin();

        }
        private void MyProductInCart_DeleteButtonClicked(object sender, EventArgs e)
        {
            if (listCTKM.Any() || !string.IsNullOrWhiteSpace(lblKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng bỏ áp dụng chương trình khuyến mãi trước khi xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblDiemTL.Text != "0")
            {
                MessageBox.Show("Vui lòng bỏ áp dụng điểm tích lũy trước khi xóa sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)sender;
            var result = MessageBox.Show("Bạn có muốn xóa sản phẩm khỏi giỏ hàng không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.Cancel)
            {
                return;
            }

            List<string> keysToRemove = new List<string>();

            string maSP = item.lblMaSP.Text;

            Console.WriteLine("Đã chạy dc tới 564");

            foreach (KeyValuePair<string, ProductInfo> pair in gioHang)
            {
                ProductInfo product = pair.Value;
                if (product.MaSP == maSP)
                {
                    Console.WriteLine("Đã chạy dc tới 570");

                    keysToRemove.Add(pair.Key);
                }
            }
            Console.WriteLine("Đã chạy dc tới 576");

            foreach (string key in keysToRemove)
            {
                gioHang.Remove(key);
                Console.WriteLine("Đã chạy dc tới 581");

            }
            tinhTongTien(false);



            if (!gioHang.Any())
            {
                lblKhuyenMai.Text = string.Empty;
                lblDiemTL.Text = "0";
            }
            flpGioHang.Controls.Remove(item);
            phanTramKM = 0;
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;
            refreshThongTin();

        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {

            if (gioHang.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HoaDonDTO hd = new HoaDonDTO();

            hd.MaHD = lblMaHD.Text.Substring(1);
            hd.NgayLapHD = DateTime.ParseExact(lblNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            hd.TongTienTT = ConvertVNDToInt(lblTongTienTT.Text);
            hd.DiemSuDung = int.Parse(lblDiemTL.Text);
            hd.TongTien = ConvertVNDToFloat(lblTongTien.Text);
            hd.DiemNhanDuoc = (int)(ConvertVNDToFloat(lblTongTien.Text) / 10000.0f);
            hd.MaKM = (lblKhuyenMai.Text == "Không KM") ? null : lblKhuyenMai.Text;
            hd.MaNV = listNV
                .Where(row => (row.Ho + " " + row.Ten).Equals(lblNhanVien.Text))
                .Select(row => row.MaNV)
                .FirstOrDefault();

            List<Tuple<string, string, string>> listKH = ConvertDataTableToList(dtKhachHang);
            //Dùng LINQ
            hd.MaKH = listKH
                .Where(tuple => (tuple.Item2 + " " + tuple.Item3).Equals(lblKhachHang.Text))
                .Select(tuple => tuple.Item1)
                .FirstOrDefault();
            int resultDiemTL = khBLL.updateDiemTL(hd.MaKH, -hd.DiemSuDung) ? 1 : 0;
            if (resultDiemTL == 1)
            {
                MessageBox.Show($"Khách hàng đã sử dụng {hd.DiemSuDung} điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            int resultDiemTL1 = khBLL.updateDiemTL(hd.MaKH, hd.DiemNhanDuoc) ? 1 : 0;
            if (resultDiemTL1 == 1)
            {
                MessageBox.Show($"Khách hàng sẽ nhận được {hd.DiemNhanDuoc} điểm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            int result = hdBLL.insertHoaDon(hd) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công hóa đơn",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

            }
            //Tạo CTHD

            bool success = true;

            foreach (KeyValuePair<string, ProductInfo> pair in gioHang)
            {
                string key = pair.Key;
                ProductInfo product = pair.Value;

                CTHoaDonDTO cthd = new CTHoaDonDTO();
                cthd.MaHD = hd.MaHD;
                cthd.MaSP = product.MaSP;
                cthd.TenSP = product.TenSP;
                cthd.SoLuong = product.SoLuong;
                cthd.DonGiaBanDau = product.DonGiaBanDau;
                cthd.DonGiaDaGiam = product.DonGiaDaGiam;
                cthd.PhanTramKM = product.PhanTramKM;
                cthd.ThanhTien = (int)product.ThanhTien;
                //Cập nhật lại sản phẩm trên DB
                int resultSP = spBLL.updateTonKho(product.MaSP, -product.SoLuong) ? 1 : 0;
                if (resultSP == 1)
                {
                    MessageBox.Show("Cập nhật dữ liệu sản phẩm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                int resultCTHD = cthdBLL.insertCTHoaDon(cthd) ? 1 : 0;

                if (resultCTHD != 1)
                {
                    success = false;
                    break; // Thoát khỏi vòng lặp nếu có lỗi
                }
            }

            if (success)
            {
                MessageBox.Show("Thêm thành công tất cả chi tiết hóa đơn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearThongTinSauKhiTaoHD();

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết hóa đơn");
            }
            listSP = spBLL.getListSP();

            clearThongTinSauKhiTaoHD();

        }
        //Làm mới thông tin hóa đơn sau khi thêm hóa đơn thành công
        private void clearThongTinSauKhiTaoHD()
        {
            gioHang.Clear();
            lblKhachHang.Text = string.Empty;
            lblTongTienTT.Text = ConvertIntToVND(0);
            lblTongTien.Text = ConvertIntToVND(0);
            lblKhuyenMai.Text = string.Empty;
            lblDiemTL.Text = "0";
            lblTongTien.Text = ConvertIntToVND(0);
            while (flpGioHang.Controls.Count > 0)
            {
                Control control = flpGioHang.Controls[0];
                flpGioHang.Controls.Remove(control);
                control.Dispose(); // Loại bỏ control và giải phóng tài nguyên
            }
            loadMaHD();

        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
            if (listCTKM.Any() || !string.IsNullOrWhiteSpace(lblKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng bỏ áp dụng chương trình khuyến mãi trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lblDiemTL.Text != "0")
            {
                MessageBox.Show("Vui lòng bỏ áp dụng điểm tích lũy trước khi thay đổi số lượng sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (gioHang.Any())
            {
                MessageBox.Show("Không thể thay đổi thông tin khách hàng khi giỏ hàng vẫn còn sản phẩm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MiniKhachHangGUI khGUI = new MiniKhachHangGUI();
            khGUI.Show();
            khGUI.FormClosed += (s, args) =>
            {
                string hoTenKH = khGUI.hoTenKH;
                diemTLCuaKhachHang = khGUI.diemTL;
                lblKhachHang.Text = hoTenKH;

                Console.WriteLine(diemTLCuaKhachHang);
            };
        }

        private void btnChonKM_Click(object sender, EventArgs e)
        {
            if (ConvertVNDToInt(lblTongTienTT.Text) == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MiniChonKMGUI chonKMGUI = new MiniChonKMGUI(ConvertVNDToInt(lblTongTienTT.Text));
            chonKMGUI.Show();
            chonKMGUI.FormClosed += (s, args) =>
            {
                string maKM = chonKMGUI.MaKM1;
                phanTramKM = chonKMGUI.PhanTramKM1;



                //Lưu danh sách CTKM từ form mini chọn CTKM
                listCTKM = chonKMGUI.listCTKMinFormMini;

                int result = capNhatGioHangKhiChonCTKM() ? 1 : 0;
                if(result == 1)
                {
                    lblKhuyenMai.Text = maKM;

                } else
                {
                    lblKhuyenMai.Text = string.Empty;

                }


            };



            lblDiemTL.Text = "0";
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;


        }

        private bool capNhatGioHangKhiChonCTKM()
        {
            bool flagKhongKhopMaSP = true; // Biến cờ để kiểm tra xem có chi tiết khuyến mãi nào không khớp mã SP trong giỏ hàng

            if (listCTKM.Count == 0)
            {
                foreach (Control control in flpGioHang.Controls)
                {
                    if (control is MyCustom.MyProductInCart)
                    {

                        MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)control;
                        string maSP = item.lblMaSP.Text;
                        item.lblDonGia.Text = ConvertIntToVND(item.donGiaBanDau);
                        item.lblTongTien.Text = ConvertIntToVND(item.donGiaBanDau * int.Parse(item.txtSoLuong.Texts));
                        item.lblDonGia.ForeColor = Color.Black;


                        if (gioHang.ContainsKey(maSP))
                        {
                            ProductInfo existingProduct = gioHang[maSP];
                            existingProduct.DonGiaBanDau = item.donGiaBanDau;
                            existingProduct.DonGiaDaGiam = item.donGiaBanDau;
                            existingProduct.PhanTramKM = 0;
                            existingProduct.ThanhTien = existingProduct.SoLuong * existingProduct.DonGiaBanDau;

                            gioHang[maSP] = existingProduct;
                        }
                    }
                }
                tinhTongTien(true);


                return true;
            }
            else
            {
                foreach (Control control in flpGioHang.Controls)
                {
                    if (control is MyCustom.MyProductInCart)
                    {
                        MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)control;
                        bool flagKhuyenMai = false; // Đặt biến này là false ở đầu mỗi sản phẩm

                        foreach (var ctkm in listCTKM)
                        {
                            //Nếu sản phẩm đó có CTKM
                            if (item.lblMaSP.Text == ctkm.Masp)
                            {
                                flagKhuyenMai = true; // Đánh dấu rằng có sản phẩm khớp với chi tiết khuyến mãi
                                                      // Ở đây bạn có thể thay đổi thuộc tính của item
                                item.lblDonGia.ForeColor = Color.Red;
                                item.phanTramKM = ctkm.PhanTramKm;
                                int donGia = ConvertVNDToInt(item.lblDonGia.Text);
                                int soLuong = int.Parse(item.txtSoLuong.Texts);
                                int donGiaSauKhuyenMai = donGia - (donGia * ctkm.PhanTramKm / 100);
                                item.lblDonGia.Text = ConvertIntToVND(donGiaSauKhuyenMai);
                                item.lblTongTien.Text = ConvertIntToVND(donGiaSauKhuyenMai * soLuong);
                            }
                        }

                        if (gioHang.ContainsKey(item.lblMaSP.Text))
                        {
                            ProductInfo existingProduct = gioHang[item.lblMaSP.Text];
                            existingProduct.DonGiaBanDau = item.donGiaBanDau;
                            existingProduct.DonGiaDaGiam = ConvertVNDToInt(item.lblDonGia.Text);
                            existingProduct.PhanTramKM = item.phanTramKM;
                            existingProduct.ThanhTien = existingProduct.SoLuong * existingProduct.DonGiaDaGiam;
                            gioHang[item.lblMaSP.Text] = existingProduct;
                        }

                        // Kiểm tra biến cờ flagKhuyenMai cho từng sản phẩm
                        if (flagKhuyenMai)
                        {
                            flagKhongKhopMaSP = false; // Có ít nhất một sản phẩm khớp
                        }
                    }

                    tinhTongTien(true);
                }

                // Kiểm tra biến cờ flagKhongKhopMaSP và hiển thị thông báo nếu không có sản phẩm nào khớp
                if (flagKhongKhopMaSP)
                {
                    MessageBox.Show("Giỏ hàng không có sản phẩm nào sử dụng được khuyến mãi này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;

        }
        private void tinhTongTien(bool applyDiscount)
        {

            int tongTienTT = 0;
            float tongTien = 0;
            foreach (KeyValuePair<string, ProductInfo> pair in gioHang)
            {

                ProductInfo product = pair.Value;
                int thanhTienTT = (int)product.ThanhTien;
                float thanhTien = product.ThanhTien;
                tongTienTT += thanhTienTT;
                tongTien += thanhTien;
            }
            lblTongTienTT.Text = ConvertIntToVND(tongTienTT);

            if (applyDiscount)
            {
                int tongTienTTTruocKM = ConvertVNDToInt(lblTongTienTT.Text);
                float tongTienTTSauKM = tongTienTTTruocKM;

                if (phanTramKM != 0)
                {
                    tongTienTTSauKM = tongTienTTSauKM - (tongTienTTTruocKM * (phanTramKM / 100));
                }

                int diemTL = int.Parse(lblDiemTL.Text);
                float tongTienSauDiscount = tongTienTTSauKM - (diemTL * 1000);
                lblTongTien.Text = ConvertFloatToVND(tongTienSauDiscount);
            }
            else
            {
                lblTongTien.Text = ConvertFloatToVND(tongTien);
            }

        }

        private void btnChonDTL_Click(object sender, EventArgs e)
        {


            if (ConvertVNDToInt(lblTongTienTT.Text) == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(lblKhuyenMai.Text))
            {
                MessageBox.Show("Vui lòng chọn khuyến mãi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!isClickedMiniDTL)
            {
                giaTienLanDauLucCoKM = ConvertVNDToFloat(lblTongTien.Text);
                isClickedMiniDTL = true;
            }



            int diemTLCoTheSD;
            float tongTien = phanTramKM != 0 ? giaTienLanDauLucCoKM : ConvertVNDToInt(lblTongTienTT.Text);
            diemTLCoTheSD = (int)(tongTien / 1000);

            MiniChonDTLGUI chonDTLGUI = new MiniChonDTLGUI(diemTLCuaKhachHang, diemTLCoTheSD);

            chonDTLGUI.Show();
            chonDTLGUI.FormClosed += (s, args) =>
            {
                lblDiemTL.Text = chonDTLGUI.diemTLSuDung.ToString();
                tinhTongTien(true);


            };

            //Tính tiền sau khi sử dụng ĐTL: 1đ = giảm 10k
        }


    }

}
