using BLL;
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
    public partial class TaiKhoanGUI : Form
    {
        private TaiKhoanBLL tkBLL;
        public TaiKhoanGUI()
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
        }

        private void btnRandomPassword_Click(object sender, EventArgs e)
        {
            string matKhau = tkBLL.GenerateRandomPassword();
            txtMatKhau.Texts = matKhau;
        }

        private void btnTaoTK_Click(object sender, EventArgs e)
        {
            btnTaoTK.BackColor = Color.FromArgb(224, 252, 237);
            btnThayDoiMK.BackColor = Color.Transparent;
            btnThayDoiTrangThai.BackColor = Color.Transparent;

        }

        private void btnThayDoiMK_Click(object sender, EventArgs e)
        {
            btnThayDoiMK.BackColor = Color.FromArgb(224, 252, 237);
            btnThayDoiTrangThai.BackColor = Color.Transparent;
            btnTaoTK.BackColor = Color.Transparent;

        }

        private void btnThayDoiTrangThai_Click(object sender, EventArgs e)
        {
            btnThayDoiTrangThai.BackColor = Color.FromArgb(224, 252, 237);
            btnThayDoiMK.BackColor = Color.Transparent;
            btnTaoTK.BackColor = Color.Transparent;

        }
    }
}
