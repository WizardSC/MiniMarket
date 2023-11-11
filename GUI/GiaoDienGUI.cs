using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class GiaoDienGUI : Form
    {
        private bool isClicked = false;
        private bool isMaximized = false;
        List<RJButton> allPanels = new List<RJButton>();
        List<Panel> allPnLeftBorders = new List<Panel>();
        List<Panel> allSubPanels = new List<Panel>();
        List<RJButton> allBtns = new List<RJButton>();
        public GiaoDienGUI()
        {
            InitializeComponent();

            addAllPnContainer();
            addAllPnLeftBorders();
            addAllPnSubPanels();
            addAllBtns();
            Console.WriteLine(123);

        }
        private void addAllPnContainer()
        {
            allPanels.Add(pnNhanVienContainer);
            allPanels.Add(pnKhachHangContainer);
            allPanels.Add(pnBanHangContainer);
            allPanels.Add(pnSanPhamContainer);
            allPanels.Add(pnQuanLyContainer);
            allPanels.Add(pnHangHoaContainer);
            allPanels.Add(pnNhaSanXuatContainer);
            allPanels.Add(pnDanhMucContainer);
            allPanels.Add(pnNhaCCContainer);
            allPanels.Add(pnKhuyenMaiContainer);
            allPanels.Add(pnNhapHangContainer);
            allPanels.Add(pnThongKeContainer);
            allPanels.Add(pnTaiKhoanContainer);
        }
        private void addAllPnLeftBorders()
        {
            allPnLeftBorders.Add(pnLeftBorderHangHoa);
            allPnLeftBorders.Add(pnLeftBorderQuanLy);
            allPnLeftBorders.Add(pnLeftBorderNhanVien);
            allPnLeftBorders.Add(pnLeftBorderKhachHang);
            allPnLeftBorders.Add(pnLeftBorderSanPham);
            allPnLeftBorders.Add(pnLeftBorderBanHang);
            allPnLeftBorders.Add(pnLeftBorderNSX);
            allPnLeftBorders.Add(pnLeftBorderDanhMuc);
            allPnLeftBorders.Add(pnLeftBorderNhaCC);
            allPnLeftBorders.Add(pnLeftBorderNhapHang);
            allPnLeftBorders.Add(pnLeftBorderKhuyenMai);
            allPnLeftBorders.Add(pnLeftBorderThongKe);
            allPnLeftBorders.Add(pnLeftBorderTaiKhoan);
        }

        private void addAllPnSubPanels()
        {
            allSubPanels.Add(pnSubHangHoa);
            
            allSubPanels.Add(pnSubQuanLy);
        }

        private void addAllBtns()
        {
            allBtns.Add(pnHangHoaContainer);
            allBtns.Add(pnQuanLyContainer);
            allBtns.Add(pnThongKeContainer);
            allBtns.Add(pnTaiKhoanContainer);
        }
        private void GiaoDienGUI_Load(object sender, EventArgs e)
        {
            pnSubQuanLy.Visible = false;
            

        }
        private void hideSubMenu(Panel pn, object rjBtn)
        {
            foreach(Panel tempPn in allSubPanels)
            {

                if (tempPn != pn)
                {
                    
                    tempPn.Visible = false;
                }
            }
            if(rjBtn is RJButton)
            {
                
                RJButton clickedButton = (RJButton)rjBtn;
                foreach (RJButton button in allBtns)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
            }


        }

        //private void hidePnLB(Panel pn)
        //{
        //    pnLBTrangChu.Visible = false;
        //    pnLBHangHoa.Visible = false;
        //    pnLBBanHang.Visible = false;
        //    pnLBHoaDon.Visible = false;
        //    pnLBKhachHang.Visible = false;
        //    pnLBNhanVien.Visible = false;
        //    pnLBNhapHang.Visible = false;
        //    pnLBQuanLy.Visible = false;
        //    pnLBPhieuNhap.Visible = false;
        //    pn.Visible = true;
        //}
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnForm.Controls.Add(childForm);
            pnForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void pnQuanLyContainer_Click(object sender, EventArgs e)
        {
          
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                clickedButton.BackColor = Color.White;

            }
            foreach (Panel pn in allPnLeftBorders)
            {
                if (pn != pnLeftBorderQuanLy)
                {
                    pn.BackColor = Color.Transparent;
                }
            }
            pnLeftBorderQuanLy.BackColor = Color.FromArgb(58, 191, 186);
            showSubMenu(pnSubQuanLy);
            hideSubMenu(pnSubQuanLy, sender);

        }
        private void pnHangHoaContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                clickedButton.BackColor = Color.White;

            }
            foreach (Panel pn in allPnLeftBorders)
            {
                if (pn != pnLeftBorderHangHoa)
                {
                    pn.BackColor = Color.Transparent;
                }
            }
            pnLeftBorderHangHoa.BackColor = Color.FromArgb(58, 191, 186);
            showSubMenu(pnSubHangHoa);

            hideSubMenu(pnSubHangHoa, sender);

        }

        private void pnNhanVienContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderNhanVien)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                clickedButton.BackColor = Color.White;
                pnLeftBorderNhanVien.BackColor = Color.FromArgb(58, 191, 186);

                openChildForm(new NhanVienGUI());
            }

        }
        private void pnKhachHangContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderKhachHang)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {                
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderKhachHang.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new KhachHangGUI());
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Console.WriteLine(isMaximized);

            if (isMaximized)
            {
                isMaximized = false;

                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                isMaximized = true;

                this.WindowState = FormWindowState.Maximized;

                pnForm.Dock = DockStyle.Fill;
            }
        }



        private void rjButton3_Click(object sender, EventArgs e)
        {

        }

        private void pnBanHangContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderBanHang)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderBanHang.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new BanHangGUI());
            }
        }

        private void pnSanPhamContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderSanPham)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderSanPham.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new SanPhamGUI());
            }
        }

        private void pnForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnDanhMuc_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderDanhMuc)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderDanhMuc.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new LoaiGUI());
            }
        }

        private void pnNhaSanXuat_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderNSX)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderNSX.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new NhaSanXuatGUI());
            }
        }

        private void pnKhuyenMaiContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderKhuyenMai)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderKhuyenMai.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new KhuyenMaiGUI());
            }
        }
        private void pnNhaCCContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderNhaCC)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderNhaCC.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new NhaCCGUI());
            }
        }

        private void pnNhapHangContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderNhapHang)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderNhapHang.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new NhapHangGUI());
            }
        }

        private void pnThongKeContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderThongKe)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                // Đặt màu của RJButton được nhấn
                clickedButton.BackColor = Color.White;
                pnLeftBorderThongKe.BackColor = Color.FromArgb(58, 191, 186);
                // Mở form con tương ứng (KhachHangGUI)
                openChildForm(new ThongKeGUI());
            }
            hideSubMenu(pnSubQuanLy, sender);

            hideSubMenu(pnSubHangHoa, sender);

        }

        private void pnTaiKhoanContainer_Click(object sender, EventArgs e)
        {
            if (sender is RJButton)
            {
                RJButton clickedButton = (RJButton)sender;

                // Đặt màu của tất cả các RJButton khác thành màu transparent
                foreach (RJButton button in allPanels)
                {
                    if (button != clickedButton)
                    {
                        button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                    }
                }
                foreach (Panel pn in allPnLeftBorders)
                {
                    if (pn != pnLeftBorderTaiKhoan)
                    {
                        pn.BackColor = Color.Transparent;
                    }
                }
                foreach (RJButton button in allBtns)
                {
                    button.BackColor = Color.Transparent; // hoặc màu nền mặc định của bạn
                }
                clickedButton.BackColor = Color.White;
                pnLeftBorderTaiKhoan.BackColor = Color.FromArgb(58, 191, 186);
                openChildForm(new TaiKhoanGUI());
            }
            hideSubMenu(pnSubQuanLy, sender);

            hideSubMenu(pnSubHangHoa, sender);

        }
    }
}
