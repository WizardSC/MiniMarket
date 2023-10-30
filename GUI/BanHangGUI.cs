using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        //private NhanVienBLL nvBLL;
        private DataTable dtSanPham;
        private DataTable dtKhachHang;
        private DataTable dtNhanVien;
        private DataTable dtHoaDon;
        private List<SanPhamDTO> listSP;
        Dictionary<string, ProductInfo> gioHang = new Dictionary<string, ProductInfo>();
        //Lưu trữ giỏ hàng tạm thời
        public struct ProductInfo
        {
            public string MaSP { get; set; }
            public string TenSP { get; set; }
            public int SoLuong { get; set; }
            public int DonGia { get; set; }
            public int ThanhTienTT { get; set; }
            public float ThanhTien { get; set; }

            public ProductInfo(string maSP, string tenSP, int soLuong, int donGia, int thanhTienTT, float thanhTien)
            {
                MaSP = maSP;
                TenSP = tenSP;
                SoLuong = soLuong;
                DonGia = donGia;
                ThanhTienTT = thanhTienTT;
                ThanhTien = thanhTien;
            }
        }
        public BanHangGUI()
        {
            InitializeComponent();
            spBLL = new SanPhamBLL();
            hdBLL = new HoaDonBLL();
            khBLL = new KhachHangBLL();
            dtSanPham = spBLL.getListSanPham();
            dtHoaDon = hdBLL.getListHoaDon();
            dtKhachHang = khBLL.getListKhachHang();
            listSP = spBLL.getListSP();
            listCTKM = new List<ChiTietKhuyenMaiDTO>();
            // Gọi hàm tính toán số trang
            CalculateTotalPages(listSP);

            // Hiển thị trang hiện tại
            UpdateCurrentPage(dtSanPham);
            loadNgayThang();

            loadMaHD();
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
            if (dtHoaDon.Rows.Count > 0)
            {
                var lastMaHD = dtHoaDon.AsEnumerable().Last()["MaHD"].ToString();
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
        private void tinhTongTien()
        {
            int tongTienTT = 0;
            float tongTien = 0;
            foreach (KeyValuePair<string, ProductInfo> pair in gioHang)
            {

                ProductInfo product = pair.Value;
                int thanhTienTT = product.ThanhTienTT;
                float thanhTien = product.ThanhTien;
                tongTienTT += thanhTienTT;
                tongTien += thanhTien;
            }
            lblTongTienTT.Text = ConvertIntToVND(tongTienTT);
            lblTongTien.Text = ConvertFloatToVND(tongTien);
        }
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            string tenKH = lblKhachHang.Text;
            if (string.IsNullOrWhiteSpace(tenKH))
            {
                MessageBox.Show("Vui lòng nhập thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (listCTKM.Count != 0)
            {
                MessageBox.Show("Vui lòng bỏ áp dụng chương trình khuyến mãi trước khi thêm sản phẩm mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                existingProduct.ThanhTienTT = existingProduct.SoLuong * existingProduct.DonGia;
                existingProduct.ThanhTien = existingProduct.ThanhTienTT;

                gioHang[maSP] = existingProduct;
            }
            else
            {
                ProductInfo product = new ProductInfo(maSP, tenSP, soLuongMua, donGia, soLuongMua * donGia, soLuongMua * donGia);
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
            tinhTongTien();
            refreshThongTin();
        }

        private void MyProductInCart_TangButtonClicked(object sender, EventArgs e)
        {
            if (listCTKM.Any() || lblKhuyenMai.Text!="Không KM")
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
                existingProduct.ThanhTienTT = existingProduct.SoLuong * existingProduct.DonGia;
                existingProduct.ThanhTien = existingProduct.ThanhTienTT;

                gioHang[maSP] = existingProduct;
            }
            
            phanTramKM = 0;
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;
            tinhTongTien();
            tinhTien();
            refreshThongTin();

        }

        private void MyProductInCart_GiamButtonClicked(object sender, EventArgs e)
        {

            if (listCTKM.Any() || lblKhuyenMai.Text != "Không KM")
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
                existingProduct.ThanhTienTT = existingProduct.SoLuong * existingProduct.DonGia;
                existingProduct.ThanhTien = existingProduct.ThanhTienTT;

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
                    return;

                }
            }
            else
            {

            }
            
            
            phanTramKM = 0;
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;
            
            tinhTongTien();
            tinhTien();

            refreshThongTin();

        }
        private void MyProductInCart_DeleteButtonClicked(object sender, EventArgs e)
        {
            if (listCTKM.Any() || lblKhuyenMai.Text != "Không KM")
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
            flpGioHang.Controls.Remove(item);
            List<string> keysToRemove = new List<string>();

            string maSP = item.lblMaSP.Text;



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
            
            phanTramKM = 0;
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;
            tinhTongTien();

            refreshThongTin();

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }



        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (gioHang.Count == 0)
            {
                MessageBox.Show("Không có sản phẩm trong giỏ hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            HoaDonDTO hd = new HoaDonDTO();

            hd.MaHD = "HD004";
            hd.NgayLapHD = DateTime.Now;
            hd.TongTienTT = 100000;
            hd.DiemSuDung = 0;
            hd.TongTien = 0;
            hd.DiemNhanDuoc = 0;
            hd.MaKM = null;
            hd.MaNV = "NV001";
            List<Tuple<string, string, string>> listKH = ConvertDataTableToList(dtKhachHang);
            //Dùng LINQ
            hd.MaKH = listKH
                .Where(tuple => (tuple.Item2 + " " + tuple.Item3).Equals(lblKhachHang.Text))
                .Select(tuple => tuple.Item1)
                .FirstOrDefault();
            Console.WriteLine(hd.MaKH);
            //cách dùng forEach truyền thống
            //foreach (var tuple in listKH) 
            //{
            //    string tenKH = tuple.Item3;
            //    string hoKH = tuple.Item2;
            //    if ((hoKH + " " + tenKH).Equals(hoVaTen))
            //    {
            //        maKH = tuple.Item1;
            //    }
            //int result = hdBLL.insertHoaDon(hd) ? 1 : 0;
            //if (result == 1)
            //{
            //    MessageBox.Show("Thêm thành công",
            //      "Thông báo",
            //      MessageBoxButtons.OK,
            //      MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Thêm thất bại",
            //        "Lỗi",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);
            //}

        }

        private void btnChonKH_Click(object sender, EventArgs e)
        {
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

                lblKhuyenMai.Text = maKM;

                tinhTien();
                //Lưu danh sách CTKM từ form mini chọn CTKM
                listCTKM = chonKMGUI.listCTKMinFormMini;
                Console.WriteLine(listCTKM.Count);
                capNhatGioHangKhiChonCTKM();

            };



            lblDiemTL.Text = "0";
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;


        }

        private void capNhatGioHangKhiChonCTKM()
        {
            if (listCTKM.Count == 0)
            {
                foreach (Control control in flpGioHang.Controls)
                {
                    if (control is MyCustom.MyProductInCart)
                    {

                        MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)control;
                        item.lblDonGia.Text = ConvertIntToVND(item.donGiaBanDau);
                        item.lblTongTien.Text = ConvertIntToVND(item.donGiaBanDau * int.Parse(item.txtSoLuong.Texts));
                        item.lblDonGia.ForeColor = Color.Black;


                        if (gioHang.ContainsKey(item.lblMaSP.Text))
                        {
                            ProductInfo existingProduct = gioHang[item.lblMaSP.Text];
                            existingProduct.DonGia = item.donGiaBanDau;
                            existingProduct.ThanhTienTT = existingProduct.SoLuong * existingProduct.DonGia;
                            existingProduct.ThanhTien = existingProduct.ThanhTienTT;

                            gioHang[item.lblMaSP.Text] = existingProduct;
                        }
                    }
                }
                tinhTien();
                tinhTongTien();
                //Duyệt thử qua cái Dictionary giỏ hàng
                Console.WriteLine("Lúc chưa có ctkm");
                foreach (KeyValuePair<string, ProductInfo> pair in gioHang)
                {
                    string key = pair.Key;
                    ProductInfo product = pair.Value;

                    string maSP = product.MaSP;
                    string tenSP = product.TenSP;
                    int soLuong = product.SoLuong;
                    int donGia = product.DonGia;
                    int thanhTienTT = product.ThanhTienTT;
                    float thanhTien = product.ThanhTien;

                    Console.WriteLine(maSP + " " + tenSP + " " + soLuong + " " + donGia + " " + thanhTienTT + " " + thanhTien);

                }
                return;
            }
            else
            {
                foreach (Control control in flpGioHang.Controls)
                {
                    if (control is MyCustom.MyProductInCart)
                    {

                        MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)control;

                        foreach (var ctkm in listCTKM)
                        {
                            if (item.lblMaSP.Text == ctkm.Masp)
                            {
                                // Ở đây bạn có thể thay đổi thuộc tính của item
                                item.lblDonGia.ForeColor = Color.Red;
                                int donGia = ConvertVNDToInt(item.lblDonGia.Text);
                                int soLuong = int.Parse(item.txtSoLuong.Texts);
                                int donGiaSauKhuyenMai = donGia - (donGia * ctkm.PhanTramKm / 100);
                                item.lblDonGia.Text = ConvertIntToVND(donGiaSauKhuyenMai);
                                item.lblTongTien.Text = ConvertIntToVND((donGiaSauKhuyenMai * soLuong));
                            }
                        }

                        if (gioHang.ContainsKey(item.lblMaSP.Text))
                        {
                            ProductInfo existingProduct = gioHang[item.lblMaSP.Text];
                            existingProduct.DonGia = ConvertVNDToInt(item.lblDonGia.Text);
                            existingProduct.ThanhTienTT = existingProduct.SoLuong * existingProduct.DonGia;
                            existingProduct.ThanhTien = existingProduct.ThanhTienTT;

                            gioHang[item.lblMaSP.Text] = existingProduct;
                        }
                    }
                }
                tinhTien();
                tinhTongTien();
                //Duyệt thử qua cái Dictionary giỏ hàng
                Console.WriteLine("Lúc đã có ctkm");

                foreach (KeyValuePair<string, ProductInfo> pair in gioHang)
                {
                    string key = pair.Key;
                    ProductInfo product = pair.Value;

                    string maSP = product.MaSP;
                    string tenSP = product.TenSP;
                    int soLuong = product.SoLuong;
                    int donGia = product.DonGia;
                    int thanhTienTT = product.ThanhTienTT;
                    float thanhTien = product.ThanhTien;

                    Console.WriteLine(maSP + " " + tenSP + " " + soLuong + " " + donGia + " " + thanhTienTT + " " + thanhTien);

                }
            }

        }
        private void tinhTien()
        {
            int tongTienTT = ConvertVNDToInt(lblTongTienTT.Text);
            float tempTongTienTTTruocKM = ConvertVNDToInt(lblTongTienTT.Text);
            float tongTienTTSauKM = 0;
            if (phanTramKM != 0)
            {
                tongTienTTSauKM = tempTongTienTTTruocKM - (tempTongTienTTTruocKM * (phanTramKM / 100));
            }
            if (tongTienTTSauKM != 0)
            {
                int diemTL = int.Parse(lblDiemTL.Text);
                float tongTien = tongTienTTSauKM - (diemTL * 1000);
                lblTongTien.Text = ConvertFloatToVND(tongTien);

            }
            else
            {
                int diemTL = int.Parse(lblDiemTL.Text);
                float tongTien = tongTienTT - (diemTL * 1000);
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
                tinhTien();

            };

            //Tính tiền sau khi sử dụng ĐTL: 1đ = giảm 10k
        }
        private void rjButton3_Click(object sender, EventArgs e)
        {

            foreach (Control control in flpGioHang.Controls)
            {
                if (control is MyCustom.MyProductInCart)
                {

                    MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)control;

                    foreach (var ctkm in listCTKM)
                    {
                        if (item.lblMaSP.Text == ctkm.Masp)
                        {
                            // Ở đây bạn có thể thay đổi thuộc tính của item

                            int donGia = ConvertVNDToInt(item.lblDonGia.Text);
                            int soLuong = int.Parse(item.txtSoLuong.Texts);
                            int donGiaSauKhuyenMai = donGia - (donGia * ctkm.PhanTramKm / 100);
                            item.lblDonGia.Text = ConvertIntToVND(donGiaSauKhuyenMai);
                            item.lblTongTien.Text = ConvertIntToVND((donGiaSauKhuyenMai * soLuong));
                        }
                    }

                    if (gioHang.ContainsKey(item.lblMaSP.Text))
                    {
                        ProductInfo existingProduct = gioHang[item.lblMaSP.Text];
                        existingProduct.DonGia = ConvertVNDToInt(item.lblDonGia.Text);
                        existingProduct.ThanhTienTT = existingProduct.SoLuong * existingProduct.DonGia;
                        existingProduct.ThanhTien = existingProduct.ThanhTienTT;

                        gioHang[item.lblMaSP.Text] = existingProduct;
                    }
                }
            }
            tinhTien();
            tinhTongTien();
            //Duyệt thử qua cái Dictionary giỏ hàng
            foreach (KeyValuePair<string, ProductInfo> pair in gioHang)
            {
                string key = pair.Key;
                ProductInfo product = pair.Value;

                string maSP = product.MaSP;
                string tenSP = product.TenSP;
                int soLuong = product.SoLuong;
                int donGia = product.DonGia;
                int thanhTienTT = product.ThanhTienTT;
                float thanhTien = product.ThanhTien;

                Console.WriteLine(maSP + " " + tenSP + " " + soLuong + " " + donGia + " " + thanhTienTT + " " + thanhTien);

            }

            //Thay đổi SL trong Dictionary giỏ hàng
            //if (gioHang.ContainsKey(maSP))
            //{
            //    ProductInfo existingProduct = gioHang[maSP];
            //    existingProduct.SoLuong += 1;
            //    existingProduct.ThanhTienTT = existingProduct.SoLuong * existingProduct.DonGia;
            //    existingProduct.ThanhTien = existingProduct.ThanhTienTT;

            //    gioHang[maSP] = existingProduct;
            //}
        }
    }

}
