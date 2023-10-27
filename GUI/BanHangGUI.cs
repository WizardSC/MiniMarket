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
        private int ProductsPerPage = 10;  // Số sản phẩm trên mỗi trang
        private int TotalPages;  // Tổng số trang
        private int CurrentPage = 1;  // Trang hiện tại
        private int soLuongTrongKhoLucBanDau = 0;
        private SanPhamBLL spBLL;
        private HoaDonBLL hdBLL;
        private KhachHangBLL khBLL;
        //private NhanVienBLL nvBLL;
        private DataTable dt;
        private DataTable dtKhachHang;
        private DataTable dtNhanVien;
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
            dt = spBLL.getListSanPham();
            
            dtKhachHang = khBLL.getListKhachHang();
            listSP = spBLL.getListSP();
            // Gọi hàm tính toán số trang
            CalculateTotalPages(listSP);

            // Hiển thị trang hiện tại
            UpdateCurrentPage(dt);
            loadNgayThang();

            
        }

        // Các hàm khác ở đây
        private List<Tuple<string, string, string>> ConvertDataTableToList(DataTable dt)
        {
            List<Tuple<string, string, string>> listKH = new List<Tuple<string, string, string>>();
            foreach(DataRow row in dt.Rows)
            {
                string maKH = row["MaKH"].ToString();
                string hoKH = row["Ho"].ToString();
                string tenKH = row["Ten"].ToString() ;
                listKH.Add(new Tuple<string, string, string>(maKH, hoKH,tenKH));
            }

            return listKH;
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
        private void addProductToCart()
        {
            this.flpGioHang.Controls.Clear();
            for (int i = 0; i < 5; i++)
            {
                MyCustom.MyProductInCart item = new MyCustom.MyProductInCart();
                this.flpGioHang.Controls.Add(item);
            }
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
                UpdateCurrentPage(dt);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < TotalPages)
            {
                CurrentPage++;
                UpdateCurrentPage(dt);
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
            tinhTongTien();

            refreshThongTin();

        }

        private void MyProductInCart_GiamButtonClicked(object sender, EventArgs e)
        {

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
            tinhTongTien();

            refreshThongTin();

        }
        private void MyProductInCart_DeleteButtonClicked(object sender, EventArgs e)
        {
            MyCustom.MyProductInCart item = (MyCustom.MyProductInCart)sender;
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

            refreshThongTin();

        }
        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
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
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            
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
            //cách dùng forEach truyền thống
            //foreach (var tuple in listKH) 
            //{
            //    string tenKH = tuple.Item3;
            //    string hoKH = tuple.Item2;
            //    if ((hoKH + " " + tenKH).Equals(hoVaTen))
            //    {
            //        maKH = tuple.Item1;
            //    }
            int result = hdBLL.insertHoaDon(hd) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công",
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

        }
    }

}
