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
    public partial class DangNhapGUI : Form
    {
        private TaiKhoanBLL tkBLL;
        private DataTable dtTaiKhoan;
        public string maNV { get; set; }
        public DangNhapGUI()
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
            dtTaiKhoan = tkBLL.getListTaiKhoan();
        }

        private (string MaNV, string TenDangNhap, string MatKhau, byte TrangThai) getTaiKhoan(string tenDangNhap, string matKhau)
        {

            var query = from row in dtTaiKhoan.AsEnumerable()
                        where (row.Field<string>("TenDangNhap") == tenDangNhap && row.Field<string>("MatKhau") == matKhau)
                        select new
                        {
                            TenDangNhap = row.Field<string>("TenDangNhap"),
                            MatKhau = row.Field<string>("MatKhau"),
                            TrangThai = row.Field<byte>("TrangThai"),
                            MaNV = row.Field<string>("MaNV")
                        };
            var result = query.FirstOrDefault(); 
            if (result != null)
            {
                return (result.MaNV, result.TenDangNhap, result.MatKhau, result.TrangThai);
            }

            // Trả về một giá trị mặc định hoặc throw exception nếu cần
            return (string.Empty, string.Empty, string.Empty, 0);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Texts;
            string matKhau = txtPassword.Texts;

            (string MaNV, string TenDangNhap, string MatKhau, byte TrangThai) = getTaiKhoan(tenDangNhap, matKhau);
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
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
