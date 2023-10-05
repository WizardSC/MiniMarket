using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GiaoDienGUI : Form
    {
        private bool isClicked = false;
        private bool isMaximized = false;
        public GiaoDienGUI()
        {
            InitializeComponent();
        }
        private void GiaoDienGUI_Load(object sender, EventArgs e)
        {
            pnSubQuanLy.Visible = false;
            Console.WriteLine(123);


        }
        private void hideSubMenu()
        {

            if (pnSubQuanLy.Visible == true)

                pnSubQuanLy.Visible = false;

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
                hideSubMenu();
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
            this.Close();
        }



        private void pnQuanLy_Click(object sender, EventArgs e)
        {

        }

        
        

        private void pnQuanLyContainer_Click(object sender, EventArgs e)
        {
            showSubMenu(pnSubQuanLy);
           
        }

        private void pnNhanVienContainer_Click(object sender, EventArgs e)
        {
            pnNhanVienContainer.BackColor = Color.White;
            openChildForm(new KhachHangGUI());
            
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
            } else
            {
                isMaximized = true;

                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pnKhachHangContainer_Click(object sender, EventArgs e)
        {
            if (sender is Control)
            {
                Control container = (Control)sender;
                container.BackColor = Color.White;
            }

            openChildForm(new KhachHangGUI());
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
