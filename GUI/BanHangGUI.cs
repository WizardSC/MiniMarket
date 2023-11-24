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
using AForge.Video.DirectShow;
using BLL;
using DevExpress.Office.Utils;
using DevExpress.XtraReports.UI;
using DTO;
using GUI.MyCustom;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using ZXing;

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

        private DataTable dtThongTinKhachHang;
        private DataTable dtNhanVien;
        private DataTable dtHoaDon;
        private List<SanPhamDTO> listSP;
        private List<NhanVienDTO> listNV;
        Dictionary<string, ProductInfo> gioHang = new Dictionary<string, ProductInfo>();
        private List<MyCustom.MyProductItem> allProductItems = new List<MyCustom.MyProductItem>(); //List chứa tất cả các item trong flpDanhSachSanPham
        private List<string> maSPSearchList = new List<string>();
        private List<DataRow> resultRows;
        private string searchValue;
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
        public BanHangGUI(string tenNV)
        {
            InitializeComponent();
            spBLL = new SanPhamBLL();
            hdBLL = new HoaDonBLL();
            khBLL = new KhachHangBLL();
            nvBLL = new NhanVienBLL();
            cthdBLL = new CTHoaDonBLL();
            dtSanPham = spBLL.getListSanPham();
            dtHoaDon = hdBLL.getListHoaDon();
            lblNhanVien.Text = tenNV;
            dtThongTinKhachHang = khBLL.getMiniListKhachHang();
            listNV = nvBLL.getListNV();
            listSP = spBLL.getListSP();
            listCTKM = new List<ChiTietKhuyenMaiDTO>();
            // Gọi hàm tính toán số trang
            searchValue = txtTimKiem.Texts;
            resultRows = GetDataRowsFromSearchTextBox(searchValue);

            CalculateTotalPages(listSP);
            UpdateCurrentPage(resultRows);

            // Hiển thị trang hiện tại
            loadNgayThang();

            loadMaHD();
            init();
        }
        // Các hàm khác ở đây
        public void init()
        {
            btnInHoaDon.Enabled = false;
            txtMaSP.Enabled = false;
            txtTenSP.Enabled = false;
            txtTonKho.Enabled = false;
            txtDonGia.Enabled = false;
            btnThanhToan.Enabled = false;

        }
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
        private string searchMaKHbyTenKH(string tenKH)
        {
            string maKH = dtThongTinKhachHang.AsEnumerable()
                .Where(row => (row.Field<string>("Ho") + " " + row.Field<string>("Ten")).ToLower() == tenKH.ToLower())
                .Select(row => row.Field<string>("MaKH"))
                .FirstOrDefault();
            return maKH;
        }

        private int searchDiemTLbyTenKH(string tenKH)
        {

            int diemTL = dtThongTinKhachHang.AsEnumerable()
                .Where(row => (row.Field<string>("Ho") + " " + row.Field<string>("Ten")).ToLower() == tenKH.ToLower())
                .Select(row => row.Field<int>("DiemTichLuy"))
                .FirstOrDefault();
            return diemTL;
        }
        private string searchLoaibyMaSP(string maSP)
        {
            string maLoai = dtSanPham.AsEnumerable()
                .Where(row => row.Field<string>("MaSP").ToLower() == maSP.ToLower())
                .Select(row => row.Field<string>("MaLoai"))
                .FirstOrDefault();
            return maLoai;
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

        private void CalculateTotalPagesMini(List<string> productList)
        {
            TotalPages = (int)Math.Ceiling((double)productList.Count / ProductsPerPage);
        }

        private void UpdateCurrentPage(List<DataRow> rows)
        {
            int startIndex = (CurrentPage - 1) * ProductsPerPage;
            int endIndex = Math.Min(startIndex + ProductsPerPage, rows.Count);

            this.flpDanhSachSanPham.Controls.Clear();

            for (int i = startIndex; i < endIndex; i++)
            {
                MyCustom.MyProductItem item = new MyCustom.MyProductItem();
                DataRow row = rows[i];

                item.lblMaSP.Text = row.Field<string>("MaSP");
                item.lblTenSP.Text = row.Field<string>("TenSP");
                item.lblDonGia.Text = ConvertIntToVND(row.Field<int>("DonGiaBan"));
                item.maLoai = row.Field<string>("MaLoai");
                string image = row.Field<string>("IMG");
                string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string folderPath = Path.Combine(appDirectory, "resources", "image", "SanPham", image);
                if (File.Exists(folderPath))
                {
                    item.pbxIMG.Image = Image.FromFile(folderPath);
                }
                else
                {
                    item.pbxIMG.Image = item.pbxIMG.InitialImage;
                }

                // Kiểm tra giá trị của cột TrangThai
                if (row.Field<int>("TrangThai") == 0)
                {
                    // Nếu TrangThai == 0, thay đổi màu của item
                    item.BackColor = Color.Gray; // Hoặc bất kỳ màu nào bạn muốn
                    item.Enabled = false;
                    
                }

                item.Margin = new Padding(4, 6, 4, 6);
                item.ItemClicked += Item_ItemClicked;

                this.flpDanhSachSanPham.Controls.Add(item);
            }

            // Cập nhật thông tin phân trang
            lblPagination.Text = $"{CurrentPage}/{TotalPages}";
        }

        private List<DataRow> GetDataRowsFromSearchTextBox(string textValue)
        {
            string columnName;

            if (cbxTimKiem.SelectedItem != null)
            {
                if (cbxTimKiem.SelectedItem.ToString() == "Mã SP")
                {
                    columnName = "MaSP";
                }
                else if (cbxTimKiem.SelectedItem.ToString() == "Tên SP")
                {
                    columnName = "TenSP";
                }
                else
                {
                    columnName = "MaSP";
                }
            }
            else
            {
                columnName = "MaSP";
            }
            var query = from DataRow row in dtSanPham.AsEnumerable()
                        where row.Field<string>(columnName).ToLower().Contains(textValue.ToLower())
                        select row;
            List<DataRow> resultRows = query.ToList();
            foreach (DataRow row in resultRows)
            {
                maSPSearchList.Add(row.Field<string>("MaSP"));
            }

            return resultRows;
        }
        // Các sự kiện nút "Previous" và "Next" ở đây

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                UpdateCurrentPage(resultRows);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                UpdateCurrentPage(resultRows);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void PerformSearch()
        {
            string searchValue = txtTimKiem.Texts;
            CurrentPage = 1;
            maSPSearchList.Clear();
            List<DataRow> resultRows = GetDataRowsFromSearchTextBox(searchValue);

            this.flpDanhSachSanPham.Controls.Clear();
            UpdateCurrentPage(resultRows);
            foreach (DataRow row in resultRows)
            {
                string loai = searchLoaibyMaSP(row.Field<string>("MaSP"));
                Console.WriteLine(loai);
            }
            CalculateTotalPagesMini(maSPSearchList);
            if (TotalPages == 0)
            {
                CurrentPage = 0;
            }
            lblPagination.Text = $"{CurrentPage}/{TotalPages}";
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
        private void ThemSanPhamVaoGio(int soLuongMua)
        {
            string maSP = txtMaSP.Texts;
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
            if (gioHang.ContainsKey(maSP))
            {
                ProductInfo existingProduct = gioHang[maSP];
                int soLuongTrongGio = existingProduct.SoLuong;

                soLuong -= soLuongTrongGio;
            }

            if (soLuong == 0)
            {
                btnThemVaoGio.Enabled = false;
                btnThemVaoGio.BackColor = Color.FromArgb(153, 160, 159);
                MessageBox.Show("Sản phẩm đã hết hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                btnThemVaoGio.Enabled = true;
                btnThemVaoGio.BackColor = Color.FromArgb(58, 191, 186);
            }
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
            string tenSP = txtTenSP.Texts;
            int soLuongTonKho = int.Parse(txtTonKho.Texts);
            int donGia = int.Parse(txtDonGia.Texts);
            //soLuongMua = Convert.ToInt32(Math.Round(nudSoLuongMua.Value, 0));
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
        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            ThemSanPhamVaoGio(Convert.ToInt32(Math.Round(nudSoLuongMua.Value, 0)));
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

            List<Tuple<string, string, string>> listKH = ConvertDataTableToList(dtThongTinKhachHang);
            //Dùng LINQ
            hd.MaKH = listKH
                .Where(tuple => (tuple.Item2 + " " + tuple.Item3).Equals(lblKhachHang.Text))
                .Select(tuple => tuple.Item1)
                .FirstOrDefault();


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
                cthd.ThanhTien = (int)product.DonGiaDaGiam * (int)product.SoLuong;
                //Cập nhật lại sản phẩm trên DB
                int resultSP = spBLL.updateTonKho(product.MaSP, -product.SoLuong) ? 1 : 0;


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
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm chi tiết hóa đơn");
            }
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
            btnInHoaDon.Enabled = true;
            btnThanhToan.Enabled = false;
            btnThemVaoGio.Enabled = false;

        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            Reports.HoaDonCreator hdCreator = new Reports.HoaDonCreator();
            hdCreator.DtThongTinCTHD = cthdBLL.getListCTHDbyMaHD(lblMaHD.Text.Substring(1));
            hdCreator.MaHD = lblMaHD.Text;
            hdCreator.NgayLap = DateTime.ParseExact(lblNgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString();
            hdCreator.TenNV = lblNhanVien.Text;
            hdCreator.TenKH = lblKhachHang.Text;
            hdCreator.MaKH = searchMaKHbyTenKH(lblKhachHang.Text);

            hdCreator.DiemTLHienTai = searchDiemTLbyTenKH(lblKhachHang.Text);
            hdCreator.DiemTLNhanDuoc = (int)(ConvertVNDToFloat(lblTongTien.Text) / 10000.0f); ;
            hdCreator.DiemTLSuDung = int.Parse(lblDiemTL.Text);
            hdCreator.MaKM = (lblKhuyenMai.Text == "Không KM") ? null : lblKhuyenMai.Text;
            hdCreator.TongTien = ConvertVNDToFloat(lblTongTien.Text);
            hdCreator.TongTienTT = ConvertVNDToInt(lblTongTienTT.Text);
            hdCreator.showHoaDonRP();
            List<Tuple<string, string, string>> listKH = ConvertDataTableToList(dtThongTinKhachHang);

            string maKH = listKH
                .Where(tuple => (tuple.Item2 + " " + tuple.Item3).Equals(lblKhachHang.Text))
                .Select(tuple => tuple.Item1)
                .FirstOrDefault();

            listSP = spBLL.getListSP();

            clearThongTinSauKhiTaoHD();
            btnInHoaDon.Enabled = false;
            btnThanhToan.Enabled = true;
            btnThemVaoGio.Enabled = true;


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
            using (MiniKhachHangGUI khGUI = new MiniKhachHangGUI())
            {
                khGUI.ShowDialog();
                string hoTenKH = khGUI.hoTenKH;
                diemTLCuaKhachHang = khGUI.diemTL;
                lblKhachHang.Text = hoTenKH;
            }
        }
        private bool miniChonKMOpened = false;

        private void btnChonKM_Click(object sender, EventArgs e)
        {
            if (ConvertVNDToInt(lblTongTienTT.Text) == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!miniChonKMOpened)
            {
                // Đặt biến cờ thành true để biết rằng form đã được mở
                miniChonKMOpened = true;

                MiniChonKMGUI chonKMGUI = new MiniChonKMGUI(ConvertVNDToInt(lblTongTienTT.Text));
                chonKMGUI.Show();
                chonKMGUI.FormClosed += (s, args) =>
                {
                    // Đặt biến cờ lại thành false khi form được đóng
                    miniChonKMOpened = false;

                    string maKM = chonKMGUI.MaKM1;
                    phanTramKM = chonKMGUI.PhanTramKM1;

                    // Lưu danh sách CTKM từ form mini chọn CTKM
                    listCTKM = chonKMGUI.listCTKMinFormMini;

                    int result = capNhatGioHangKhiChonCTKM() ? 1 : 0;
                    if (result == 1)
                    {
                        lblKhuyenMai.Text = maKM;
                    }
                    else
                    {
                        lblKhuyenMai.Text = string.Empty;
                    }
                };
            }



            lblDiemTL.Text = "0";
            giaTienLanDauLucCoKM = 0;
            isClickedMiniDTL = false;
            btnThanhToan.Enabled = true;

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

            using (MiniChonDTLGUI chonDTLGUI = new MiniChonDTLGUI(diemTLCuaKhachHang, diemTLCoTheSD))
            {
                chonDTLGUI.ShowDialog();

                lblDiemTL.Text = chonDTLGUI.diemTLSuDung.ToString();
                tinhTongTien(true);

            }

            //Tính tiền sau khi sử dụng ĐTL: 1đ = giảm 10k
        }


        #region barcode
        private bool isBarcode = true;
        private VideoCaptureDevice videoCaptureDevice;
        private bool isScanning = false;

        private void btnQuetBarcode_Click(object sender, EventArgs e)
        {
            FilterInfoCollection filterInfoCollection;

            if (isBarcode)
            {
                flpDanhSachSanPham.SendToBack();
                btnPrevious.Visible = false;
                btnNext.Visible = false;
                lblPagination.Visible = false;
                filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                // Kiểm tra nếu có ít nhất một thiết bị
                if (filterInfoCollection.Count > 0)
                {
                    // Lấy ngay MonikerString của thiết bị đầu tiên
                    string monikerString = filterInfoCollection[0].MonikerString;

                    // Sử dụng MonikerString trực tiếp
                    videoCaptureDevice = new VideoCaptureDevice(monikerString);
                    videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                    videoCaptureDevice.Start();
                }
                else
                {
                    // Hiển thị thông báo nếu không có thiết bị
                    MessageBox.Show("Không tìm thấy thiết bị camera.");
                }

                // Đánh dấu là đã click lần đầu
                isBarcode = false;
            }
            else
            {
                btnPrevious.Visible = true;
                btnNext.Visible = true;
                lblPagination.Visible = true;
                if (videoCaptureDevice != null && videoCaptureDevice.IsRunning)
                {
                    videoCaptureDevice.Stop();
                    flpDanhSachSanPham.BringToFront();
                }
                isBarcode = true;
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            if (isScanning)
            {
                return; // Nếu đang quét thì không làm gì
            }

            isScanning = true;

            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            BarcodeReader reader = new BarcodeReader();
            var result = reader.Decode(bitmap);
            if (result != null)
            {
                txtMaSP.Invoke(new MethodInvoker(delegate ()
                {
                    txtMaSP.Texts = result.ToString();
                    string maSPCanTim = txtMaSP.Texts;
                    PlayBeepSound();



                    //foreach (Control control in flpDanhSachSanPham.Controls)
                    //{
                    //    if (control is MyCustom.MyProductItem)
                    //    {
                    //        MyCustom.MyProductItem productItem = (MyCustom.MyProductItem)control;

                    //        // Kiểm tra giá trị mã SP của control với mã SP cần tìm
                    //        if (productItem.lblMaSP.Text == maSPCanTim)
                    //        {
                    //            Item_ItemClicked(productItem, EventArgs.Empty);
                    //            //ThemSanPhamVaoGio(1);


                    //            // Reset lại camera

                    //            break; // Kết thúc vòng lặp sau khi tìm thấy
                    //        }
                    //    }
                    //}
                    bool needToMoveToNextPage = true;
                    bool alreadyMovedToFirstPage = false;
                    bool alreadyRolledBack = false;

                    foreach (Control control in flpDanhSachSanPham.Controls)
                    {
                        if (control is MyCustom.MyProductItem)
                        {
                            MyCustom.MyProductItem productItem = (MyCustom.MyProductItem)control;
                            Console.WriteLine($"{productItem.lblMaSP.Text}: Enabled = {productItem.Enabled}");
                            
                            if (productItem.lblMaSP.Text == maSPCanTim)
                            {
                                if (productItem.Enabled == false)
                                {
                                    txtMaSP.Texts = string.Empty;
                                    MessageBox.Show("Sản phẩm không hoạt động", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    break;
                                }
                                Item_ItemClicked(productItem, EventArgs.Empty);
                                needToMoveToNextPage = false;
                                break;
                            }
                        }
                    }

                    if (needToMoveToNextPage && CurrentPage < TotalPages)
                    {
                        CurrentPage++;
                    }
                    else if (needToMoveToNextPage && CurrentPage == TotalPages && !alreadyMovedToFirstPage)
                    {
                        CurrentPage = 1;
                        alreadyMovedToFirstPage = true;
                    }
                    else if (needToMoveToNextPage && alreadyMovedToFirstPage && !alreadyRolledBack)
                    {
                        CurrentPage--;
                        alreadyRolledBack = true;
                    }
                    UpdateCurrentPage(resultRows);
                }));
            }
            pbShowCamera.Image = bitmap;

            isScanning = false; // Cho phép quét tiếp theo
        }

        private void PlayBeepSound()
        {
            try
            {
                string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string folderPath = Path.Combine(appDirectory, "resources", "sound");

                // Thêm tên tệp tin âm thanh vào đường dẫn
                string soundFilePath = Path.Combine(folderPath, "barcode_reader.wav");

                // Kiểm tra xem tệp tin âm thanh có tồn tại không trước khi phát
                if (File.Exists(soundFilePath))
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(soundFilePath);
                    player.Play();
                }
                else
                {
                    Console.WriteLine("Tệp tin âm thanh không tồn tại: " + soundFilePath);
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi khi phát âm thanh
                Console.WriteLine("Lỗi khi phát âm thanh: " + ex.Message);
            }
        }

        #endregion

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Ngăn chặn ký tự Enter từ việc xuất hiện trong TextBox
                e.Handled = true;
                PerformSearch();
                refreshThongTin();

            }
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            txtTimKiem.Texts = string.Empty;
            PerformSearch();
            refreshThongTin();
        }

        private void btnResetThongTinSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Texts = string.Empty;
            txtTenSP.Texts = string.Empty;
            txtDonGia.Texts = string.Empty;
            txtTonKho.Texts = string.Empty;
            nudSoLuongMua.Value = 0;
            pbImage.Image = pbImage.InitialImage;
            btnThemVaoGio.Enabled = true;
            btnThemVaoGio.BackColor = Color.FromArgb(58, 191, 186);

        }
    }
}
