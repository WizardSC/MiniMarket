using BLL;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DTO;
using GUI.MyCustom;
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
        int quyenTaiKhoan;
        public TaiKhoanGUI(int isTaiKhoan, string maNVHienTai)
        {
            InitializeComponent();
            tkBLL = new TaiKhoanBLL();
            nvBLL = new NhanVienBLL();
            cvBLL = new ChucVuBLL();
            dtChucVu = cvBLL.getListChucVu();
            dtTaiKhoan = tkBLL.getListTaiKhoan();
            dgvNhanVien.DataSource = dtNhanVien;
            dtpNgayLap.Value = DateTime.Now;
            quyenTaiKhoan = isTaiKhoan;

            loadMaTK();
            resetField();
            unHideError();

            dgvNhanVien.DataSource = nvBLL.getListNVNoHasTaiKhoan();
            checkQuyen(isTaiKhoan, maNVHienTai);
        }
        private void checkQuyen(int quyen, string maNV)
        {
            if (quyen == 1)
            {
                isFuncThayDoiTTCN = true;
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
        private void resetField()
        {
            if (isFuncTaoTK) dgvNhanVien.DataSource = nvBLL.getListNVNoHasTaiKhoan();
            if (isFuncThayDoiTTCN) dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
            if (isFuncThayDoiTT) dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
            dtTaiKhoan = tkBLL.getListTaiKhoan();

            loadMaTK();
            cbxTrangThai.SelectedIndex = -1;
            txtMatKhau.Texts = string.Empty;
            txtTenDangNhap.Texts = string.Empty;
            txtNhanVien.Texts = string.Empty;
            txtQuyen.Texts = string.Empty;

        }
        #region Các hàm bổ trợ
        private void unHideError()
        {
            lblErrTrangThai.ForeColor = Color.Transparent;
            lblErrUsername.ForeColor = Color.Transparent;
            lblErrPassword.ForeColor = Color.Transparent;
        }
        private string CheckAndSetColor(object control, Label label, int minLength = 0)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text) || (minLength > 0 && text.Length < minLength))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);

                    if (string.IsNullOrWhiteSpace(text))
                    {
                        if (label.Name == "lblErrUsername") // Kiểm tra label của tên đăng nhập
                        {
                            label.Text = "* Vui lòng điền tên đăng nhập";
                        }
                        else if (label.Name == "lblErrPassword") // Kiểm tra label của mật khẩu
                        {
                            label.Text = "* Vui lòng điền mật khẩu";
                        }
                    }
                    else if (text.Length < minLength)
                    {
                        if (label.Name == "lblErrUsername")
                        {
                            label.Text = $"* Tên đăng nhập tối thiểu {minLength} ký tự";
                        }
                        else if(label.Name == "lblErrPassword")
                        {
                            label.Text = $"* Mật khẩu tối thiểu {minLength} ký tự";
                        }
                    }
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                    label.Text = ""; // Xóa nội dung lỗi nếu có
                }
                return text;
            }
            // ... (các trường hợp khác tương tự)
            else if (control is RJComboBox comboBox)
            {
                string selectedValue = comboBox.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(selectedValue))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "* Vui lòng chọn trạng thái";
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                    label.Text = ""; // Clear the error text
                }
                return selectedValue;
            }
            return null; // Nếu kiểu dữ liệu không hợp lệ.
        }
        #endregion
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
            unHideError();
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

        private void btnThayDoiTTCN_Click(object sender, EventArgs e)
        {
            isFuncTaoTK = false;
            isFuncThayDoiTTCN = true;
            isFuncThayDoiTT = false;
            unHideError();

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
            unHideError();

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

            if (isFuncTaoTK)

            {

                maNV = dgvNhanVien.Rows[i].Cells["MaNV1"].Value.ToString();
                txtNhanVien.Texts = dgvNhanVien.Rows[i].Cells["Ho"].Value.ToString() + " " + dgvNhanVien.Rows[i].Cells["Ten"].Value.ToString();
                txtQuyen.Texts = searchTenCVbyMaCV(dgvNhanVien.Rows[i].Cells["MaCV1"].Value.ToString());
                maCV = dgvNhanVien.Rows[i].Cells["MaCV1"].Value.ToString();
            }

            if (isFuncThayDoiTTCN)
            {
                txtNhanVien.Texts = dgvNhanVien.Rows[i].Cells["Ho"].Value.ToString() + " " + dgvNhanVien.Rows[i].Cells["Ten"].Value.ToString();
                txtQuyen.Texts = searchTenCVbyMaCV(dgvNhanVien.Rows[i].Cells["MaCV1"].Value.ToString());
                maNV = dgvNhanVien.Rows[i].Cells["MaNV1"].Value.ToString();
                maCV = dgvNhanVien.Rows[i].Cells["MaCV1"].Value.ToString();
                (string TenDangNhap, string MatKhau, int TrangThai) result = GetTenDNandMK(maNV, dtTaiKhoan);
                txtMaTK.Texts = dgvNhanVien.Rows[i].Cells["MaTK"].Value.ToString();
                dtpNgayLap.Value = DateTime.Parse(dgvNhanVien.Rows[i].Cells["NgayLap"].Value.ToString());
                txtTenDangNhap.Texts = result.TenDangNhap;
                txtMatKhau.Texts = result.MatKhau;
            }
            if (isFuncThayDoiTT)
            {
                txtNhanVien.Texts = dgvNhanVien.Rows[i].Cells["Ho"].Value.ToString() + " " + dgvNhanVien.Rows[i].Cells["Ten"].Value.ToString();
                txtQuyen.Texts = searchTenCVbyMaCV(dgvNhanVien.Rows[i].Cells["MaCV1"].Value.ToString());
                maNV = dgvNhanVien.Rows[i].Cells["MaNV1"].Value.ToString();
                maCV = dgvNhanVien.Rows[i].Cells["MaCV1"].Value.ToString();
                (string TenDangNhap, string MatKhau, int TrangThai) result = GetTenDNandMK(maNV, dtTaiKhoan);
                txtMaTK.Texts = dgvNhanVien.Rows[i].Cells["MaTK"].Value.ToString();
                dtpNgayLap.Value = DateTime.Parse(dgvNhanVien.Rows[i].Cells["NgayLap"].Value.ToString());
                cbxTrangThai.SelectedItem = (result.TrangThai == 1) ? "Hoạt động" : "Không hoạt động";
                if (result.TrangThai == 1)
                {
                    btnThucHienChucNang.Text = "KHÓA TÀI KHOẢN";
                }
                else
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
                string tenDangNhap = CheckAndSetColor(txtTenDangNhap, lblErrUsername, 6);
                string matKhau = CheckAndSetColor(txtMatKhau, lblErrPassword, 6);
                tk.NgayLap = dtpNgayLap.Value;
                tk.MaNV = maNV;
                tk.Quyen = txtQuyen.Texts;
                string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
                if (!(tenDangNhap != "" && matKhau != "" && trangThai != ""))
                {
                    return;
                }
                tk.TenDangNhap = tenDangNhap;
                tk.MatKhau = matKhau;
                if (trangThai == "Hoạt động")
                {
                    tk.TrangThai = 1;
                }
                else if (trangThai == "Không hoạt động")
                {
                    tk.TrangThai = 0;
                }
                else
                {
                    return;
                }
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
                dgvNhanVien.DataSource = nvBLL.getListNVNoHasTaiKhoan();

                resetField();
                return;
            }
            if (isFuncThayDoiTTCN)
            {
                unHideError();

                string tenDangNhap = CheckAndSetColor(txtTenDangNhap, lblErrUsername, 6);
                string matKhau = CheckAndSetColor(txtMatKhau, lblErrPassword, 6);
                if (string.IsNullOrWhiteSpace(tenDangNhap) || string.IsNullOrWhiteSpace(matKhau))
                {
                    return;
                }
                int flag = tkBLL.updateTTCN(maNV, tenDangNhap, matKhau) ? 1 : 0;
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
                if (quyenTaiKhoan == 2)
                {
                    dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();
                    return;
                }
                dgvNhanVien.DataSource = nvBLL.getCurrentNVHasTK(maNV);
                return;
            }
            if (isFuncThayDoiTT)
            {
                
                    unHideError();
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
                dgvNhanVien.DataSource = nvBLL.getListNVHasTaiKhoan();


            }
        }

        private void txtTenDangNhap__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtTenDangNhap, lblErrUsername, 6);
        }

        private void txtMatKhau__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtMatKhau, lblErrPassword, 6);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }
    }
}
