using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        List<Product> productList = new List<Product>();
        private SanPhamBLL spBLL;
        private DataTable dt;

        public void loadSP()
        {
            productList.Add(new Product
            {
                ProductId = "SP001",
                ProductName = "Bánh quy Cosy Marie",
                Price = 20000
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
            productList.Add(new Product
            {
                ProductId = "P001",
                ProductName = "Sản phẩm 1",
                Price = 19.99
            });
        }
        public BanHangGUI()
        {
            InitializeComponent();
            spBLL = new SanPhamBLL();
            dt = spBLL.getListSanPham();

            // Thêm dữ liệu mẫu vào danh sách
            //loadSP();
            // Gọi hàm tính toán số trang
            CalculateTotalPages(productList);

            // Hiển thị trang hiện tại
            UpdateCurrentPage(dt);
            //addProductToCart();



        }

        // Các hàm khác ở đây

        private void CalculateTotalPages(List<Product> productList)
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
                item.Margin = new Padding(4); // 4 pixels cho mỗi hướng
                item.ItemClicked += Item_ItemClicked; // Gán sự kiện ở đây, đảm bảo chỉ gán một lần

                this.flpDanhSachSanPham.Controls.Add(item);
            }

            // Cập nhật thông tin phân trang
            lblPagination.Text = $"{CurrentPage}/{TotalPages}";
        }
        private void Item_ItemClicked(object sender, EventArgs e)
        {
            // Đây là nơi bạn có thể xử lý khi item được click
            // Dựa vào item để lấy thông tin sản phẩm và hiển thị nó lên màn hình
            MyCustom.MyProductItem clickedItem = (MyCustom.MyProductItem)sender;
            string maSP = clickedItem.lblMaSP.Text;
            string tenSP = clickedItem.lblTenSP.Text;
            string donGia = clickedItem.lblDonGia.Text.Substring(0,clickedItem.lblDonGia.Text.Length - 1);

            txtMaSP.Texts = maSP;
            txtTenSP.Texts = tenSP;
            txtDonGia.Texts = donGia;

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
            }
        }

        private void btnThemVaoGio_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Texts;
            string tenSP = txtTenSP.Texts;
            int soLuongTonKho = int.Parse(txtTonKho.Texts);
            int donGia = int.Parse(txtDonGia.Texts);
            int soLuongMua = Convert.ToInt32(Math.Round(nudSoLuongMua.Value, 0));

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
