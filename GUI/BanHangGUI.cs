using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{

    public partial class BanHangGUI : Form
    {
        private int ProductsPerPage = 10;  // Số sản phẩm trên mỗi trang
        private int TotalPages;  // Tổng số trang
        private int CurrentPage = 1;  // Trang hiện tại
        
        private SanPhamBLL spBLL;
        private DataTable dt;
        private List<SanPhamDTO> listSP;
        Dictionary<string, int> gioHang = new Dictionary<string, int>(); //theo dõi số lượng sản phẩm đã thêm vào giỏ hàng
        
        public BanHangGUI()
        {
            InitializeComponent();
            spBLL = new SanPhamBLL();
            dt = spBLL.getListSanPham();
            listSP = spBLL.getListSP();
            // Thêm dữ liệu mẫu vào danh sách
            //loadSP();
            // Gọi hàm tính toán số trang
            CalculateTotalPages(listSP);

            // Hiển thị trang hiện tại
            UpdateCurrentPage(dt);
            //addProductToCart();
           

        }

        // Các hàm khác ở đây
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
                item.lblDonGia.Text = dt.Rows[i]["DonGiaNhap"].ToString() + "đ";

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
            string donGia = clickedItem.lblDonGia.Text.Substring(0, clickedItem.lblDonGia.Text.Length - 1);
            int soLuong = 0;

            foreach (SanPhamDTO sp in listSP)
            {
                if (sp.MaSP == maSP)
                {
                    soLuong = sp.SoLuong;
                    txtTonKho.Texts = soLuong.ToString();
                    break;
                }
            }

            txtMaSP.Texts = maSP;
            txtTenSP.Texts = tenSP;
            txtDonGia.Texts = donGia;
            pbImage.Image = clickedItem.pbxIMG.Image;

            if (gioHang.ContainsKey(maSP))
            {
                int soLuongTrongGio = gioHang[maSP];
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
                gioHang[maSP] += soLuongMua;
            }
            else
            {
                gioHang[maSP] = soLuongMua;
            }
            txtTonKho.Texts = (soLuongTonKho - gioHang[maSP]).ToString(); //trừ đi số lượng đã thêm vào giỏ
                                                                          //chỉ cập nhật tạm thời chứ chưa lưu vào DB


            
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
                // Nếu sản phẩm đã tồn tại trong flpGioHang, cộng dồn số lượng và tổng tiền
                existingItem.soLuong += soLuongMua;
                existingItem.txtSoLuong.Texts = existingItem.soLuong.ToString();
                existingItem.tinhTongTien(); // Cập nhật tổng tiền
            }
            else
            {
                // Nếu sản phẩm chưa tồn tại, thêm sản phẩm mới
                MyCustom.MyProductInCart item = new MyCustom.MyProductInCart(maSP, donGia, soLuongMua); // Đảm bảo đơn giá ở đây là donGia
                item.lblMaSP.Text = maSP;
                item.lblTenSP.Text = tenSP;
                item.txtSoLuong.Texts = soLuongMua.ToString();
                item.lblDonGia.Text = donGia.ToString() + "đ";

                flpGioHang.Controls.Add(item);

            }
            refreshThongTin();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
    public class Product
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public double Price
        {
            get; set;
        }
    }
}
