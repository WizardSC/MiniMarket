
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using GUI.MyCustom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{

    public partial class KhachHangGUI : Form
    {
        private KhachHangBLL khBLL;
        private bool isFormFilter = false;
        private string cbxItemsMacDinh;
        private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string genderCondition = ""; // Biến để lưu trữ điều kiện từ checkbox "Giới Tính"
        private string statusCondition = "";
        private string activeCondition = "";
        private int tuoiStart = 0;
        private int tuoiEnd = 0;
        private int diemTLStart = 0;
        private int diemTLEnd = 0;
        private bool isGioiTinh = false;
        private bool isTuoi = false;
        private bool isDiemTL = false;
        private bool isTrangThai = false;
        private bool isNam = false;
        private bool isNu = false;

        private bool isHoatDong = false;
        private bool isKoHD = false;
        public KhachHangGUI()
        {
            InitializeComponent();
            khBLL = new KhachHangBLL();

        }
        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = khBLL.getListKhachHang();

            cbxTimKiem.Refresh();
            loadDataToCBX(cbxTimKiem);
            chkNam.Enabled = isGioiTinh;
            chkNu.Enabled = isGioiTinh;
            Console.WriteLine(DateTime.Now.Year);
        }
        //Xóa bỏ tự chọn dòng đầu tiên của DataGridView khi load form

        #region các hàm bổ trợ
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã KH");
            cbx.Items.Add("Họ");
            cbx.Items.Add("Tên");
            cbx.Items.Add("Địa chỉ");
            cbxItemsMacDinh = cbx.Items[0].ToString();
        }

        private string returnDieuKien(string text)
        {
            return text;
        }
        #endregion


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

        private void dgvKhachHang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvKhachHang.ClearSelection();
            dgvKhachHang.CurrentCell = null;
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();

        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã KH":
                    return returnDieuKien($"MaKH like '%{searchText}%'");
                case "Họ":
                    return returnDieuKien($"Ho like '%{searchText}%'");
                case "Tên":
                    return returnDieuKien($"Ten like '%{searchText}%'");
                case "Địa chỉ":
                    return returnDieuKien($"DiaChi like '%{searchText}%'");
                default:
                    return "";
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, genderCondition);
            combinedCondition = ApplyOrRemoveTuoiCondition(combinedCondition, isTuoi);
            combinedCondition = CombineConditions(combinedCondition, statusCondition);
            combinedCondition = ApplyOrRemoveDiemTLCondition(combinedCondition, isDiemTL);
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

        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvKhachHang = khBLL.getListKhachHang().DefaultView;
            dvKhachHang.RowFilter = currentSearch;
            dgvKhachHang.DataSource = dvKhachHang.ToTable();
        }

        private bool toggleDieuKien(bool value)
        {
            return !value;
        }


        private void chkGioiTinh_CheckedChanged(object sender, EventArgs e)
        {
            isGioiTinh = toggleDieuKien(isGioiTinh);

            // Bật hoặc tắt chkNam và chkNu dựa trên trạng thái của chkGioiTinh
            chkNam.Enabled = isGioiTinh;
            chkNu.Enabled = isGioiTinh;

            // Nếu chkGioiTinh được kiểm tra, thực hiện hành động của chkNam và chkNu
            if (isGioiTinh)
            {

                if (isNam)
                {

                    chkNam_CheckedChanged(sender, e);
                }

                if (isNu)
                {

                    chkNu_CheckedChanged(sender, e);
                }
            }
            else
            {
                // Nếu chkGioiTinh không được kiểm tra, tắt chkNam và chkNu và xóa check
                chkNam.Checked = false;
                chkNu.Checked = false;
                chkNam.Enabled = isGioiTinh;
                chkNu.Enabled = isGioiTinh;
            }
        }
        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            isNam = toggleDieuKien(isNam);
            UpdateGenderCondition();
            btnTimKiem.PerformClick();
        }

        // Thay đổi sự kiện khi checkbox "Nữ" thay đổi
        private void chkNu_CheckedChanged(object sender, EventArgs e)
        {
            isNu = toggleDieuKien(isNu);
            UpdateGenderCondition();
            btnTimKiem.PerformClick();
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

        private void UpdateGenderCondition()
        {
            List<string> genderConditions = new List<string>();

            if (isNam)
            {
                genderConditions.Add("GioiTinh = 'Nam'");
            }

            if (isNu)
            {
                genderConditions.Add("GioiTinh = 'Nữ'");
            }

            genderCondition = string.Join(" OR ", genderConditions);
        }

        private void chkTuoi_CheckedChanged(object sender, EventArgs e)
        {
            isTuoi = toggleDieuKien(isTuoi);
            txtTuoiStart.Enabled = isTuoi;
            txtTuoiEnd.Enabled = isTuoi;

            if (!isTuoi)
            {
                tuoiStart = 0;
                tuoiEnd = 0;

            }
            if (isTuoi)
            {
                if (int.TryParse(txtTuoiStart.Texts, out int tuoiStartResult))
                {
                    // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                    tuoiStart = tuoiStartResult;
                }
                if (int.TryParse(txtTuoiEnd.Texts, out int tuoiEndResult))
                {
                    // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                    tuoiEnd = tuoiEndResult;

                }


            }
            btnTimKiem_Click(sender, e);



        }
        private void txtTuoiStart__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTuoiStart.Texts))
            {
                tuoiStart = 0;
            }
            if (int.TryParse(txtTuoiStart.Texts, out int tuoiStartResult))
            {
                // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                tuoiStart = tuoiStartResult;
                btnTimKiem_Click(sender, e);
            }
            else
            {
                // Chuỗi không hợp lệ, bạn có thể xử lý lỗi hoặc thông báo cho người dùng
                return;
            }


        }

        private void txtTuoiEnd__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTuoiEnd.Texts))
            {
                tuoiEnd = 0;
            }
            if (int.TryParse(txtTuoiEnd.Texts, out int tuoiEndResult))
            {
                // Chuyển đổi thành công, giá trị tuoiStartResult là số nguyên từ chuỗi
                tuoiEnd = tuoiEndResult;
                btnTimKiem_Click(sender, e);
            }
            else
            {
                // Chuỗi không hợp lệ, bạn có thể xử lý lỗi hoặc thông báo cho người dùng
                return;
            }

        }
        private string ApplyOrRemoveTuoiCondition(string condition, bool isTuoi)
        {
            if (isTuoi)
            {
                if (tuoiStart > 0 && tuoiEnd > 0 && tuoiStart <= tuoiEnd)
                {
                    DateTime currentDate = DateTime.Now;
                    int currentYear = currentDate.Year;

                    int yearOfBirthStart = currentYear - tuoiStart;
                    int yearOfBirthEnd = currentYear - tuoiEnd;

                    return CombineConditions(condition, $"NgaySinh >= '{yearOfBirthEnd}-01-01' AND NgaySinh <= '{yearOfBirthStart}-12-31'");
                }
            }
            else
            {
                // Nếu không có checkbox Tuoi được chọn, xóa điều kiện lọc theo ngày sinh
                condition = condition.Replace("NgaySinh >= 'yyyy-01-01' AND NgaySinh <= 'yyyy-12-31' AND ", "");
            }

            return condition;
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
                // Nếu chkGioiTinh không được kiểm tra, tắt chkNam và chkNu và xóa check
                chkHoatDong.Checked = false;
                chkKoHD.Checked = false;
                chkHoatDong.Enabled = isGioiTinh;
                chkKoHD.Enabled = isGioiTinh;
            }
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
        private void chkDiemTL_CheckedChanged(object sender, EventArgs e)
        {
            isDiemTL = toggleDieuKien(isDiemTL);
            Console.WriteLine(isDiemTL);
            txtDiemTLEnd.Enabled = isDiemTL;
            txtDiemTLStart.Enabled = isDiemTL;
            if (!isDiemTL)
            {
                diemTLEnd = 0;
                diemTLStart = 0;
            }
            if (isDiemTL)
            {
                if (int.TryParse(txtDiemTLStart.Texts, out int result))
                {
                    diemTLStart = result;
                }
                if (int.TryParse(txtDiemTLEnd.Texts, out int result1))
                {
                    diemTLEnd = result1;
                }
            }
            btnTimKiem_Click(sender, e);
        }
        private void txtDiemTLStart__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiemTLStart.Texts))
            {
                diemTLStart = 0;
            }
            if (int.TryParse(txtDiemTLStart.Texts, out int result))
            {
                diemTLStart = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
           

        }

        private void txtDiemTLEnd__TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiemTLEnd.Texts))
            {
                diemTLEnd = 0;
            }
            if (int.TryParse(txtDiemTLEnd.Texts, out int result))
            {
                diemTLEnd = result;
                btnTimKiem_Click(sender, e);

            }
            else
            {
                return;
            }
        }

        private string ApplyOrRemoveDiemTLCondition(string condition, bool isDiemTL)
        {
            // Tạo một biến mới để lưu trữ điều kiện `DiemTL`
            string diemTLCondition = $"DiemTichLuy >= {diemTLStart} AND DiemTichLuy <= {diemTLEnd}";

            if (isDiemTL)
            {
                if (diemTLStart > 0 && diemTLEnd > 0 && diemTLStart <= diemTLEnd)
                {
                    // Thêm điều kiện `DiemTL` vào chuỗi điều kiện nếu có
                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = CombineConditions(condition, diemTLCondition);
                    }
                    else
                    {
                        condition = diemTLCondition;
                    }
                }
            }
            else
            {
                // Nếu không có checkbox DiemTL được chọn, xóa điều kiện `DiemTL` khỏi chuỗi điều kiện
                condition = condition.Replace(diemTLCondition, "");
            }

            return condition;
        }


    }
}

