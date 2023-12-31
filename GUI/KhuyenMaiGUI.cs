﻿using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class KhuyenMaiGUI : Form
    {
        private KhuyenMaiBLL kmBLL;
        private ChiTietKhuyenMaiGUI CTKhuyenMai;
        private ThongTinSPKMGUI ThongTinSPKM;
        private DataTable dt = new DataTable();
        private bool isFormFilter = false;
        private string cbxItemsMacDinh;
         private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private bool isTrangThai = false;
        private bool isHoatDong = false;
        private bool isKoHD = false;
        private string statusCondition = "";
        private int quyenKhuyenMai;
        public KhuyenMaiGUI(int isKhuyenMai)
        {
            
            InitializeComponent();
            btnThongTinKM.Visible = false;
            kmBLL = new KhuyenMaiBLL();
            CTKhuyenMai = new ChiTietKhuyenMaiGUI();
            dt = kmBLL.getListDsKm();
            loadMaKM();
            loadDataToCBX(cbxTimKiem);
            checkQuyen(isKhuyenMai);
            quyenKhuyenMai = isKhuyenMai;
            hideError();
        }
        private void checkQuyen(int quyen)
        {
            if (quyen == 1)
            {
                
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnXemChiTietKM.Enabled = false;
                cbxTrangThai.Enabled = false;
                dtpNgayBD.Enabled = false;
                dtpNgayKT.Enabled   = false;
                
            }
        }

        private void hideError()
        {
            lblErrDieuKienKM.ForeColor = Color.Transparent;
            lblErrNgayKT.ForeColor = Color.Transparent;
            lblErrPhanTramKM.ForeColor = Color.Transparent;
            lblErrTenKM.ForeColor = Color.Transparent;
        }
        private void loadMaKM()
        {

            string MaKM;

            MaKM = kmBLL.getMaxMaKM();
            if (MaKM == "")
            {
                txtMaKM.Texts = "KM001";
                return;
            }
            int tempNum = int.Parse(MaKM.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaKM.Texts = "KM0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaKM.Texts = "KM00" + (tempNum + 1).ToString();
            }
        }

        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã KM");
            cbx.Items.Add("Tên KM");
            cbxTimKiem.SelectedIndex = 0;
        }

        private string returnDieuKien(string text)
        {
            return text;
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã KM":
                    return returnDieuKien($"MaKM like '%{searchText}%'");
                case "Tên KM":
                    return returnDieuKien($"TenKM like '%{searchText}%'");
                default:
                    return "";
            }
        }

        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvKhuyenMai = dt.DefaultView;
            dvKhuyenMai.RowFilter = currentSearch;
            dgvKhuyenMai.DataSource = dvKhuyenMai.ToTable();
        }
        private void UpdateStatusCondition()
        {
            List<string> statusConditions = new List<string>();

            if (isHoatDong)
            {
                statusConditions.Add("TrangThai = 1");
            }

            if (isKoHD)
            {
                statusConditions.Add("TrangThai = 0");
            }

            statusCondition = string.Join(" OR ", statusConditions);
        }
        // Hàm để kết hợp các điều kiện
        private string CombineConditions(string condition1, string condition2)
        {
            if (!string.IsNullOrEmpty(condition1) && !string.IsNullOrEmpty(condition2))
            {
                return $"({condition1}) AND ({condition2})";
            }
            else if (!string.IsNullOrEmpty(condition1))
            {
                return condition1;
            }
            else if (!string.IsNullOrEmpty(condition2))
            {
                return condition2;
            }
            else
            {
                return "";
            }
        }

        public void clearForm()
        {
            loadMaKM();
            cbxTrangThai.SelectedIndex = 0;
            txtTenKm.Texts = "";
            txtDkKM.Texts = "";
            dtpNgayBD.MinDate = DateTime.Now;
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now.AddDays(1);
            dtpNgayKT.MinDate = DateTime.Now.AddDays(1);
            txtPhanTramKM.Texts = "";
            cbxTrangThai.SelectedIndex = 0;
            btnThongTinKM.Visible = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;

            hideError();

        }
        //load form DataTable
        public void init()
        {
            dgvKhuyenMai.DataSource = kmBLL.getListDsKm();

            cbxTrangThai.SelectedIndex = 0;
            loadMaKM();
        }
        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            init();
            // Gán sự kiện CellFormatting
            dgvKhuyenMai.CellFormatting += dgvKhuyenMai_CellFormatting;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            checkQuyen(quyenKhuyenMai);
            dtpNgayBD.MinDate = DateTime.Now;
            dtpNgayKT.MinDate = DateTime.Now.AddDays(1);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            CTKhuyenMai = new ChiTietKhuyenMaiGUI();
            CTKhuyenMai.Show();
            
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearForm();
            cbxTrangThai.SelectedIndex = 0;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = true;
        }

        private void btnThongTinKM_Click(object sender, EventArgs e)
        {
            string MaKM = txtMaKM.Texts;            
            string TenKM = txtTenKm.Texts;
            DataTable dataTable = kmBLL.getThongTinSPKM(MaKM);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                ThongTinSPKMGUI ThongTin = new ThongTinSPKMGUI(this, MaKM,TenKM);
                ThongTin.Show();
            }
            else
            {
                MessageBox.Show("Khuyến mãi này chưa áp dụng cho sản phẩm nào.", "Thông báo");

            }
        }


        private string CheckAndSetColor(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                label.ForeColor = string.IsNullOrWhiteSpace(text) ? Color.FromArgb(230, 76, 89) : Color.Transparent;
                return text;
            }
            return null; // Nếu kiểu dữ liệu không hợp lệ.
        }
        private DateTime CheckAndSetColorDate(DateTime dateTime, Label label)
        {
            DateTime currentDate = dtpNgayBD.Value; // Lấy ngày hiện tại

            if (dateTime != default(DateTime))
            {
                if (dateTime <= currentDate)
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                   
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                }
            }
            else
            {
                label.ForeColor = Color.FromArgb(230, 76, 89);
            }

            return dateTime;
        }

        // check phantramkm nhập int
        private const int MaxPercentage = 99;
        private string CheckAndSetColorPhanTramKM(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "* Bạn phải nhập % KM";
                }
                else if (!int.TryParse(text, out int result))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "* Bạn phải nhập số nguyên";
                }
                else if (!int.TryParse(text, out int percentage) || percentage > MaxPercentage)
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "* Bạn phải nhập bé hơn 100";
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                    label.Text = "";
                }
                return text;
            }
            return null; // Nếu kiểu dữ liệu không hợp lệ.
        }
        private string CheckAndSetColorDieuKienKM(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "* Bạn phải nhập DKKM";
                }
                else if (!int.TryParse(text, out int result))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "* Bạn phải nhập số nguyên";
                }
                
                else
                {
                    label.ForeColor = Color.Transparent;
                    label.Text = "";
                }
                return text;
            }
            return null; // Nếu kiểu dữ liệu không hợp lệ.
        }
        private bool IsInteger(string text)
        {
            int result;
            return int.TryParse(text, out result);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKM = CheckAndSetColor(txtTenKm, lblErrTenKM);
            string phantramkm = CheckAndSetColorPhanTramKM(txtPhanTramKM, lblErrPhanTramKM);
            string dieukienkm = CheckAndSetColorDieuKienKM(txtDkKM, lblErrDieuKienKM);
            DateTime ngaykt = CheckAndSetColorDate(dtpNgayKT.Value, lblErrNgayKT);
            DateTime Ngaybd = dtpNgayBD.Value;
            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;

            if (string.IsNullOrWhiteSpace(tenKM) || ngaykt <= Ngaybd  || !IsInteger(phantramkm) || !IsInteger(dieukienkm) || int.Parse(phantramkm)>99)
            {
                return;
            }
            

            // Tiếp tục xử lý dữ liệu nếu tất cả điều kiện đều đúng.

            KhuyenMaiDTO KM_DTO = new KhuyenMaiDTO();
            KM_DTO.Makm = txtMaKM.Texts;
            KM_DTO.TenKm = tenKM;
            KM_DTO.NgayBd = Ngaybd;
            KM_DTO.NgayKt = ngaykt;
            KM_DTO.PhanTramKm = int.Parse(phantramkm);
            KM_DTO.DieuKiemKm = dieukienkm;


            KM_DTO.TrangThai = trangthai;

            bool result = kmBLL.insertKhuyenMai(KM_DTO);

            if (result)
            {
                MessageBox.Show("Thêm khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                init();
                clearForm();
            }
            else
            {
                MessageBox.Show("Thêm thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
            {
            string tenKM = CheckAndSetColor(txtTenKm, lblErrTenKM);
            string phantramkm = CheckAndSetColorPhanTramKM(txtPhanTramKM, lblErrPhanTramKM);
            string dieukienkm = CheckAndSetColorDieuKienKM(txtDkKM, lblErrDieuKienKM);
            DateTime ngaykt = CheckAndSetColorDate(dtpNgayKT.Value, lblErrNgayKT);
            DateTime Ngaybd = dtpNgayBD.Value;
            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;

            if (string.IsNullOrWhiteSpace(tenKM) || ngaykt <= Ngaybd || !IsInteger(phantramkm) || !IsInteger(dieukienkm) || int.Parse(phantramkm) > 99)
            {
                return;
            }

            // Tiếp tục xử lý dữ liệu nếu tất cả điều kiện đều đúng.

            KhuyenMaiDTO KM_DTO = new KhuyenMaiDTO();
            KM_DTO.Makm = txtMaKM.Texts;
            KM_DTO.TenKm = tenKM;
            KM_DTO.NgayBd = Ngaybd;
            KM_DTO.NgayKt = ngaykt;
            KM_DTO.PhanTramKm = int.Parse(phantramkm);
            KM_DTO.DieuKiemKm = dieukienkm;
            KM_DTO.TrangThai = trangthai;

            bool result = kmBLL.UpdateKhuyenMai(KM_DTO);

            if (result)
            {
                MessageBox.Show("Sửa khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                init();
                clearForm();
            }
            else
            {
                MessageBox.Show("Sửa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            string maKM = txtMaKM.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa khuyến mãi này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                bool kq = kmBLL.deleteKhuyenMai(maKM, out isLoiKhoaNgoai);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                        loadMaKM();
                        init();
                        clearForm();

                }
                else
                {
                    if (isLoiKhoaNgoai)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        var result = MessageBox.Show("Không thể xóa sản phẩm này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            if (trangThai == 1)
                            {
                                var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result1 == DialogResult.OK)
                                {
                                    int flag = kmBLL.updateTrangThai(trangThai, maKM) ? 1 : 0;
                                    if (flag == 1)
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        loadMaKM();
                                        init();
                                        clearForm();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    }
                                }
                                else if (result1 == DialogResult.Cancel)
                                {
                                    return;
                                }
                            }
                            else return;

                        }

                    }

                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            isFormFilter = !isFormFilter;
            if (isFormFilter)
            {
                btnFilter.BackColor = Color.FromArgb(224, 224, 224);
                flpFilter.Visible = true;
                flpFilter.BringToFront();

            }
            else
            {
                btnFilter.BackColor = Color.FromArgb(224, 252, 237);
                flpFilter.Visible = false;
                flpFilter.SendToBack();
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            checkQuyen(quyenKhuyenMai);
            dtpNgayBD.MinDate = DateTime.Parse("1 / 1 / 2023");
            dtpNgayKT.MinDate = DateTime.Parse("1 / 1 / 2023");
            
            int i = dgvKhuyenMai.CurrentRow.Index;
            txtMaKM.Texts = dgvKhuyenMai.Rows[i].Cells[0].Value.ToString();
            DateTime NgayBd = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[2].Value.ToString());
            DateTime NgayKt = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[3].Value.ToString());
            txtTenKm.Texts = dgvKhuyenMai.Rows[i].Cells[1].Value.ToString();
            dtpNgayBD.Value = NgayBd;
            dtpNgayKT.Value = NgayKt;
            txtPhanTramKM.Texts = dgvKhuyenMai.Rows[i].Cells[4].Value.ToString();
            txtDkKM.Texts = dgvKhuyenMai.Rows[i].Cells[5].Value.ToString();
            int TrangThai = int.Parse(dgvKhuyenMai.Rows[i].Cells[6].Value.ToString());
            if (TrangThai == 1)
            {
                cbxTrangThai.SelectedIndex = 0;
            }
            else
            {
                cbxTrangThai.SelectedIndex = 1;
            }

            if (int.Parse(txtDkKM.Texts) == 0 && int.Parse(txtPhanTramKM.Texts) == 0)
            {
                btnThongTinKM.Visible = true;
            }
            else
            {
                btnThongTinKM.Visible = false;
            }
            

        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, statusCondition);
            applySearchs(combinedCondition);
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.Handled = true;
            }
        }

        private void chkHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            isHoatDong = toggleDieuKien(isHoatDong);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
        }

        private void chkKoHD_CheckedChanged(object sender, EventArgs e)
        {
            isKoHD = toggleDieuKien(isKoHD);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
        }
        private bool toggleDieuKien(bool value)
        {
            return !value;
        }

        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            isTrangThai = toggleDieuKien(isTrangThai);
            chkHoatDong.Enabled = isTrangThai;
            chkKoHD.Enabled = isTrangThai;
            if (isTrangThai)
            {

                if (isHoatDong)
                {

                    chkHoatDong_CheckedChanged(sender, e);
                }

                if (isKoHD)
                {
                    chkKoHD_CheckedChanged(sender, e);
                }
            }
            else
            {
                // Nếu chkHoatDong không được kiểm tra, tắt chkHd và chkKhd và xóa check
                chkHoatDong.Checked = false;
                chkKoHD.Checked = false;
                chkHoatDong.Enabled = isHoatDong;
                chkKoHD.Enabled = isKoHD;
            }
        }

        private void dgvKhuyenMai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 2) // Thay yourDateColumnIndex bằng chỉ số cột ngày của bạn.
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng lại ngày thành "ngày/tháng/năm".
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == 3) // Thay yourDateColumnIndex bằng chỉ số cột ngày của bạn.
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng lại ngày thành "ngày/tháng/năm".
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == 6) // Thay 4 bằng chỉ số cột thứ 5 (chú ý: chỉ số cột bắt đầu từ 0).
            {
                if (e.Value != null && e.Value is int)
                {
                    int value = (int)e.Value;
                    if (value == 1)
                    {
                        e.Value = "Hoạt động";
                    }
                    else if (value == 0)
                    {
                        e.Value = "Không hoạt động";
                    }
                    e.FormattingApplied = true;
                }
            }
            if (e.Value != null)
            {
                // Đặt chữ nằm ở giữa cho tất cả các cột
                dgvKhuyenMai.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void txtTenKm__TextChanged(object sender, EventArgs e)
        {
          CheckAndSetColor(txtTenKm, lblErrTenKM);
        }

        private void txtPhanTramKM__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorPhanTramKM(txtPhanTramKM, lblErrPhanTramKM);
        }

        private void txtDkKM__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorDieuKienKM(txtDkKM, lblErrDieuKienKM);
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            CheckAndSetColorDate(dtpNgayKT.Value, lblErrNgayKT);
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            CheckAndSetColorDate(dtpNgayKT.Value, lblErrNgayKT);
        }
    }
}
