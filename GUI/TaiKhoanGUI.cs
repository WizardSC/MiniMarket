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
        private string maNVHienTai;
        private bool isFuncTaoTK = true;
        private bool isFuncThayDoiTTCN = false;
        private bool isFuncThayDoiTT = false;
        private bool isFuncXemDSTK = false;
        public TaiKhoanGUI(int isTaiKhoan, string maNVHienTai)
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
            checkQuyen(isTaiKhoan,maNVHienTai);
        }
        private void checkQuyen(int quyen, string maNV)
        {
            if (quyen == 1)
            {
                btnTaoTK.Enabled = false;
                btnThayDoiTrangThai.Enabled = false;
                btnThayDoiTTCN.Enabled = false;
                cbxTrangThai.Enabled = false;

                btnThayDoiTTCN_Click(this, EventArgs.Empty);
                dgvNhanVien.DataSource = nvBLL.getCurrentNVHasTK(maNV);

            }
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

        private (string TenDangNhap, string MatKhau, byte TrangThai) GetTenDNandMK(string maNV, DataTable dtTaiKhoan)
        {
            var query = from row in dtTaiKhoan.AsEnumerable()
                        where row.Field<string>("MaNV") == maNV
                        select new
                        {
                            TenDangNhap = row.Field<string>("TenDangNhap"),
                            MatKhau = row.Field<string>("MatKhau"),
                            TrangThai = row.Field<byte>("TrangThai")
                        };

            var result = query.FirstOrDefault(); // Lấy dòng đầu tiên hoặc null nếu không có dòng nào thỏa mãn điều kiện

            if (result != null)
            {
                return (result.TenDangNhap, result.MatKhau, result.TrangThai);
            }

            // Trả về một giá trị mặc định hoặc throw exception nếu cần
            return (string.Empty, string.Empty, 0);
        }
        private void resetField() {
            if(isFuncTaoTK) dgvNhanVien.DataSource = nvBLL.getListNVNoHasTaiKhoan();
            if(isFuncThayDoiTTCN) dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
            if(isFuncThayDoiTT) dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
            dtTaiKhoan = tkBLL.getListTaiKhoan();

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
            isFuncThayDoiTTCN = false;
            isFuncThayDoiTT = false;
            isFuncXemDSTK = false;
            if (isFuncTaoTK)
            {
                resetField();

                btnTaoTK.BackColor = Color.FromArgb(224, 252, 237);
                btnThayDoiTTCN.BackColor = Color.Transparent;
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
            isFuncThayDoiTTCN = true;
            isFuncThayDoiTT = false;
            isFuncXemDSTK = false;
            if (isFuncThayDoiTTCN)
            {
                resetField();

                btnThayDoiTTCN.BackColor = Color.FromArgb(224, 252, 237);
                btnThayDoiTrangThai.BackColor = Color.Transparent;
                btnTaoTK.BackColor = Color.Transparent;
                lblTitleDGV.Text = "DANH SÁCH TÀI KHOẢN";
                lblTitleFunction.Text = "CHỈNH SỬA THÔNG TIN";
                btnThucHienChucNang.Text = "SỬA THÔNG TIN";
                dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
            }


        }
        private void btnThayDoiTTCN_Click(object sender, EventArgs e)
        {
            isFuncTaoTK = false;
            isFuncThayDoiTTCN = true;
            isFuncThayDoiTT = false;
            isFuncXemDSTK = false;
            if (isFuncThayDoiTTCN)
            {
                resetField();
                
                btnThayDoiTTCN.BackColor = Color.FromArgb(224, 252, 237);
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
            isFuncTaoTK = false;
            isFuncThayDoiTTCN = false;
            isFuncThayDoiTT = true;
            isFuncXemDSTK = false;
            if (isFuncThayDoiTT)
            {
                resetField();
                btnThayDoiTrangThai.BackColor = Color.FromArgb(224, 252, 237);
                btnThayDoiTTCN.BackColor = Color.Transparent;
                btnTaoTK.BackColor = Color.Transparent;
                lblTitleDGV.Text = "DANH SÁCH TÀI KHOẢN";
                lblTitleFunction.Text = "KHÓA/MỞ KHÓA TÀI KHOẢN";
                btnThucHienChucNang.Text = "KHÓA TÀI KHOẢN";
                dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();

            }


        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            txtNhanVien.Texts = dgvNhanVien.Rows[i].Cells[1].Value.ToString() + " " + dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            txtQuyen.Texts = searchTenCVbyMaCV(dgvNhanVien.Rows[i].Cells[4].Value.ToString());
            maNV = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            maCV = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            if (isFuncThayDoiTTCN)
            {
                (string TenDangNhap, string MatKhau, int TrangThai) result = GetTenDNandMK(maNV, dtTaiKhoan);
                txtTenDangNhap.Texts = result.TenDangNhap;
                txtMatKhau.Texts = result.MatKhau;
            }
            if (isFuncThayDoiTT)
            {
                (string TenDangNhap, string MatKhau, int TrangThai) result = GetTenDNandMK(maNV, dtTaiKhoan);
                cbxTrangThai.SelectedItem = (result.TrangThai == 1) ? "Hoạt động" : "Không hoạt động";
                if(result.TrangThai == 1)
                {
                    btnThucHienChucNang.Text = "KHÓA TÀI KHOẢN";
                } else
                {
                    btnThucHienChucNang.Text = "MỞ KHÓA TÀI KHOẢN";

                }
            }

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
                nvBLL.updateTaiKhoan(tk.MaTK, maNV);
               
                resetField();
                return;
            }
            if (isFuncThayDoiTTCN)
            {
                Console.WriteLine(maNV);
                string tenDangNhap = txtTenDangNhap.Texts;
                string matKhau = txtMatKhau.Texts;
                int flag = tkBLL.updateTTCN(maNV,tenDangNhap,matKhau) ? 1 : 0;
                if (flag == 1)
                {
                    MessageBox.Show("Thay đổi thông tin thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thay đổi thông tin thất bại",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                resetField();
                return;
            }
            if (isFuncThayDoiTT)
            {
                int trangThai = (cbxTrangThai.SelectedItem.ToString() == "Hoạt động") ? 0 : 1;
                Console.WriteLine(trangThai);
                int flag = tkBLL.updateTrangThai(maNV, trangThai) ? 1 : 0;
                if (flag == 1)
                {
                    MessageBox.Show("Thành công",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thất bại",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                resetField();

            }
        }

    }
}
