using BLL;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DTO;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
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

        private bool isFuncTaoTK = true;
        private bool isFuncThayDoiMK = false;
        private bool isFuncThayDoiTT = false;
        private bool isFuncXemDSTK = false;
        public TaiKhoanGUI()
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
            nvBLL = new NhanVienBLL();
            cvBLL = new ChucVuBLL();
            dtNhanVien = nvBLL.getListNVNoHasTaiKhoan();
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
        private void resetField() {
            if(isFuncTaoTK) dgvNhanVien.DataSource = nvBLL.getListNVNoHasTaiKhoan();
            if(isFuncThayDoiMK) dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
            loadMaTK();
            cbxTrangThai.SelectedIndex = -1;
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
            isFuncTaoTK = true;
            isFuncThayDoiMK = false;
            isFuncThayDoiTT = false;
            isFuncXemDSTK = false;
            if (isFuncTaoTK)
            {
                btnTaoTK.BackColor = Color.FromArgb(224, 252, 237);
                btnThayDoiMK.BackColor = Color.Transparent;
                btnThayDoiTrangThai.BackColor = Color.Transparent;
                lblTitleDGV.Text = "DANH SÁCH NHÂN VIÊN CHƯA CÓ TÀI KHOẢN";
                lblTitleFunction.Text = "TẠO TÀI KHOẢN MỚI";
                btnThucHienChucNang.Text = "TẠO TÀI KHOẢN";
                dgvNhanVien.DataSource = nvBLL.getListNVNoHasTaiKhoan();

            }


        }

        private void btnThayDoiMK_Click(object sender, EventArgs e)
        {
            isFuncTaoTK = false;
            isFuncThayDoiMK = true;
            isFuncThayDoiTT = false;
            isFuncXemDSTK = false;
            if (isFuncThayDoiMK)
            {
                btnThayDoiMK.BackColor = Color.FromArgb(224, 252, 237);
                btnThayDoiTrangThai.BackColor = Color.Transparent;
                btnTaoTK.BackColor = Color.Transparent;
                lblTitleDGV.Text = "DANH SÁCH TÀI KHOẢN";
                lblTitleFunction.Text = "CHỈNH SỬA MẬT KHẨU";
                btnThucHienChucNang.Text = "SỬA MẬT KHẨU";
                dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
            }


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

        private void btnThucHienChucNang_Click(object sender, EventArgs e)
        {
            if (isFuncTaoTK)
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
                return;
            }
            if (isFuncThayDoiMK)
            {

            }
        }
    }
}
