using BLL;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DTO;

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
        private DataTable dtTaiKhoan;
        private string maCV;
        private string maNV;
        public TaiKhoanGUI()
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
            nvBLL = new NhanVienBLL();
            cvBLL = new ChucVuBLL();
            dtNhanVien = nvBLL.getListNVHasTaiKhoan();
            dtChucVu = cvBLL.getListChucVu();
            dtTaiKhoan = tkBLL.getListTaiKhoan();
            dgvNhanVien.DataSource = dtNhanVien;
            dtpNgayLap.Value = DateTime.Now;
            loadMaTK();
        }
        private void loadMaTK()
        {
            string maTK = tkBLL.getLastMaTK();
            if (string.IsNullOrWhiteSpace(maTK))
            {
                txtMaTK.Texts = "TK001";
            }
            else
            {
                txtMaTK.Texts = maTK;
            }
        }
        private string searchTenCVbyMaCV(string maCV)
        {
            string tenCV = dtChucVu.AsEnumerable()
                .Where(row => (row.Field<string>("MaCV") == maCV))
                .Select(row => row.Field<string>("TenCV"))
                .FirstOrDefault();
            return tenCV;
        }

        //private void resetField()
        //{
        //    dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
        //}
        private void resetField() {
            dgvNhanVien.DataSource= nvBLL.getListNVHasTaiKhoan();

            loadMaTK();
            cbxTrangThai.SelectedIndex = 0;
            txtMatKhau.Texts = string.Empty;
            txtTenDangNhap.Texts = string.Empty;
            txtNhanVien.Texts = string.Empty;
            txtQuyen.Texts = string.Empty;

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
            maNV = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            maCV = dgvNhanVien.Rows[i].Cells[4].Value.ToString();

        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tk = new TaiKhoanDTO();
            tk.MaTK = txtMaTK.Texts;
            tk.TenDangNhap = txtTenDangNhap.Texts;
            tk.MatKhau = txtMatKhau.Texts;
            tk.NgayLap = dtpNgayLap.Value;
            tk.MaNV = maNV;
            tk.Quyen = txtQuyen.Texts;
            string trangThai = cbxTrangThai.SelectedItem.ToString();
            tk.TrangThai = (trangThai == "Hoạt động") ? 1 : 0;

            int flag = tkBLL.insertTaiKhoan(tk) ? 1 : 0;
            if (flag == 1)
            {
                MessageBox.Show("Tạo tài khoản thành công",
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
            resetField();

        }
    }
}