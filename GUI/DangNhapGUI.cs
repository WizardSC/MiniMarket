using BLL;
using DevExpress.XtraWaitForm;
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
    public partial class DangNhapGUI : Form
    {
        private TaiKhoanBLL tkBLL;
        private DataTable dtTaiKhoan;
        public string maNV { get; set; }
        public string tenPQ { get; set; }
        public DangNhapGUI()
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
            dtTaiKhoan = tkBLL.getListTaiKhoan();
        }

        private (string MaNV, string TenDangNhap, string MatKhau, string Quyen, byte TrangThai) getTaiKhoan(string tenDangNhap, string matKhau)
        {

            var query = from row in dtTaiKhoan.AsEnumerable()
                        where (row.Field<string>("TenDangNhap") == tenDangNhap && row.Field<string>("MatKhau") == matKhau)
                        select new
                        {
                            TenDangNhap = row.Field<string>("TenDangNhap"),
                            MatKhau = row.Field<string>("MatKhau"),
                            TrangThai = row.Field<byte>("TrangThai"),
                            MaNV = row.Field<string>("MaNV"),
                            Quyen = row.Field<string>("Quyen")
                        };
            var result = query.FirstOrDefault();
            if (result != null)
            {
                return (result.MaNV, result.TenDangNhap, result.MatKhau, result.Quyen, result.TrangThai);
            }

            // Trả về một giá trị mặc định hoặc throw exception nếu cần
            return (string.Empty, string.Empty, string.Empty, string.Empty, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Texts;
            string matKhau = txtPassword.Texts;
            if (string.IsNullOrWhiteSpace(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            (string MaNV, string TenDangNhap, string MatKhau, string Quyen, byte TrangThai) = getTaiKhoan(tenDangNhap, matKhau);
            if (TenDangNhap == string.Empty || MatKhau == string.Empty)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TrangThai == 0)
            {
                MessageBox.Show("Tài khoản đang bị khóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            maNV = MaNV;
            tenPQ = Quyen;
            GiaoDienGUI mainForm = new GiaoDienGUI(maNV, tenPQ);

            this.Hide();
            mainForm.ShowDialog();
            this.Dispose();

        }



        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn ký tự Enter hiển thị trong TextBox
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Ngăn chặn âm thanh "beep" khi nhấn Enter
                btnDangNhap_Click(sender, e); // Gọi phương thức btnDangNhap_Click khi nhấn Enter
            }
        }

    }
}
