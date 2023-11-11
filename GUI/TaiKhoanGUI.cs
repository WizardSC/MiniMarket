using BLL;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
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
        private NhanVienBLL nvBLL;
        private ChucVuBLL cvBLL;
        private DataTable dtNhanVien;
        private DataTable dtChucVu;
        public TaiKhoanGUI()
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
            nvBLL = new NhanVienBLL();
            cvBLL = new ChucVuBLL();
            dtNhanVien = nvBLL.getListNVHasTaiKhoan();
            dtChucVu = cvBLL.getListChucVu();
            dgvNhanVien.DataSource = dtNhanVien;
            dtpNgayLap.Value = DateTime.Now;
        }
        private string searchTenCVbyMaCV(string maCV)
        {
            string tenCV = dtChucVu.AsEnumerable()
                .Where(row => (row.Field<string>("MaCV") == maCV))
                .Select(row => row.Field<string>("TenCV"))
                .FirstOrDefault();
            return tenCV;
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

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            txtNhanVien.Texts = dgvNhanVien.Rows[i].Cells[1].Value.ToString() + " " + dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtQuyen.Texts = searchTenCVbyMaCV(dgvNhanVien.Rows[i].Cells[4].Value.ToString());
        }
    }
}
