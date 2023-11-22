
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
using System.IO;
using System.Runtime.InteropServices.ComTypes;

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
        private DataTable dt;
        private string maKH;

        private int quyenKhachHang;

        private string fileName;
        public KhachHangGUI(int isKhachHang)
        {
            InitializeComponent();
            khBLL = new KhachHangBLL();
            dt = khBLL.getListKhachHang();
            DateTime currentDate = DateTime.Now;
            dtpNgaySinh.MaxDate = DateTime.Now.Date.AddYears(-18); 
            //dtpNgaySinh.MaxDate = currentDate; //không cho chọn ngày lớn hơn ngày hiện tại
            unhideError(); //set màu trong suốt cho các label lỗi
            loadMaKH();
            txtMaKH.Enabled = false;
            //Check phân quyền
            quyenKhachHang = isKhachHang;
            checkQuyen(isKhachHang);
            loadBtn();
        }
        private void checkQuyen(int quyenKhachHang)
        {
            if (quyenKhachHang == 1)
            {
                btnDeleteIMG.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                cbxTrangThai.Enabled = false;
                dtpNgaySinh.Enabled = false;
                btnUploadIMG.Enabled = false;
            }
        }
        private void KhachHangGUI_Load(object sender, EventArgs e)
        {
            dgvKhachHang.DataSource = dt;

            cbxTimKiem.Refresh();
            loadDataToCBX(cbxTimKiem);
            chkNam.Enabled = isGioiTinh;
            chkNu.Enabled = isGioiTinh;

        }
        private void loadForm()
        {
            dgvKhachHang.DataSource = khBLL.getListKhachHang();
            cbxTimKiem.Refresh();
            loadDataToCBX(cbxTimKiem);
            chkNam.Enabled = isGioiTinh;
            chkNu.Enabled = isGioiTinh;
        }
        //Xóa bỏ tự chọn dòng đầu tiên của DataGridView khi load form

        #region các hàm bổ trợ
        private void loadBtn()
        {
            btnThem.Enabled = true; btnSua.Enabled = false; btnXoa.Enabled = false;
        }
        //chuyển đổi một hình ảnh thành một dạng biểu diễn nhị phân 
        private byte[] convertImageToBinaryString(System.Drawing.Image img, string tag)
        {

            if (tag == "Placeholder")
            {
                lblErrIMG.ForeColor = Color.FromArgb(230, 76, 89);
                return null;
            }
            else
            {
                lblErrIMG.ForeColor = Color.Transparent;

            }

            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);

            return ms.ToArray();

        }

        //chuyển đổi một dạng biểu diễn nhị phân thành một hình ảnh 
        private System.Drawing.Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);
            return img;
        }

        //Load mã khách hàng cuối cùng lên form
        private void loadMaKH()
        {
            khBLL = new KhachHangBLL();
            maKH = khBLL.getMaxMaKhachHang();
            string lastMaNV = maKH;
            if (lastMaNV == "")
            {
                txtMaKH.Texts = "KH001";
            }
            int tempNum = int.Parse(lastMaNV.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaKH.Texts = "KH0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaKH.Texts = "KH00" + (tempNum + 1).ToString();
            }
        }
        private void unhideError()
        {
            lblErrMaKH.ForeColor = Color.Transparent;
            lblErrHo.ForeColor = Color.Transparent;
            lblErrTen.ForeColor = Color.Transparent;
            lblErrGioiTinh.ForeColor = Color.Transparent;
            lblErrSoDT.ForeColor = Color.Transparent;
            lblErrDiaChi.ForeColor = Color.Transparent;

            lblErrTrangThai.ForeColor = Color.Transparent;
            lblErrIMG.ForeColor = Color.Transparent;
        }
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

        private string CheckAndSetColor(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                label.ForeColor = string.IsNullOrWhiteSpace(text) ? Color.FromArgb(230, 76, 89) : Color.Transparent;
                return text;
            }
            else if (control is RJComboBox comboBox)
            {
                string selectedValue = comboBox.SelectedItem?.ToString();
                if (string.IsNullOrWhiteSpace(selectedValue))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                }
                return selectedValue;
            }

            return null; // Nếu kiểu dữ liệu không hợp lệ.
        }
        private bool ContainsLetter(string text)
        {
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    return true;
                }
            }
            return false;
        }
        private string CheckAndSetColorSDT(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Bạn phải nhập so DT";
                    return null;
                }
                else if (ContainsLetter(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "    *Số DT không thể chứa chữ";
                    return null;
                }
                else if (text.ToString().Length > 10)
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "    *Số DT không được quá 10 số";
                    return null;
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                    label.Text = "";
                }
                return text;
            }
            return null;
        }
        private string CheckAndSetColorHo(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Bạn phải nhập họ";
                    return null;
                }
                else if (int.TryParse(text, out int result))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "    *Họ không thể chứa chữ số";
                    return null;
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                    label.Text = "";

                }
                return text;
            }
            return null;
        }
        private string CheckAndSetColorTen(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Bạn phải nhập tên";
                    return null;
                }
                else if (int.TryParse(text, out int result))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "    *Tên không thể chứa chữ số";
                    return null;
                }
                else
                {
                    label.ForeColor = Color.Transparent;
                    label.Text = "";
                }
                return text;
            }
            return null;
        }
        private int ConvertToInt(RJTextBox textBox, Label label = null)
        //Nếu không có lbl Lỗi thì mặc định giá trị là null
        {
            string text = textBox.Texts.Trim();
            int result;

            bool isNumeric = int.TryParse(text, out result);

            if (label != null)
            {
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Vui lòng nhập Giá nhập hàng";
                }
                else
                {
                    label.ForeColor = isNumeric ? Color.Transparent : Color.FromArgb(230, 76, 89);
                    label.Text = isNumeric ? "" : "*Vui lòng nhập 1 số nguyên";
                }
            }

            return isNumeric ? result : 0;
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
                txtTuoiStart.PlaceholderText = "Từ";
                txtTuoiEnd.PlaceholderText = "Đến";
                lblErrTuoiFilter.Visible = false;
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
                tuoiStart = tuoiStartResult;
                if (tuoiStart < 0)
                {
                    lblErrTuoiFilter.Text = "* Không được nhập tuổi là số âm";
                    lblErrTuoiFilter.Visible = true;
                    return;
                }
                else
                {
                    lblErrTuoiFilter.Visible = false;
                    tuoiStart = tuoiStartResult;
                    btnTimKiem_Click(sender, e);
                }
                lblErrTuoiFilter.Visible = false;
            }

            else
            {
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
                tuoiEnd = tuoiEndResult;
                if (tuoiEnd < 0)
                {

                    lblErrTuoiFilter.Text = "* Không được nhập tuổi là số âm";
                    lblErrTuoiFilter.Visible = true;
                    return;
                }
                if (int.Parse(txtTuoiStart.Texts) >= tuoiEnd)
                {

                    lblErrTuoiFilter.Text = "* .Bạn phải tuổi kết thúc lớn hơn tuổi bắt đầu";
                    lblErrTuoiFilter.Visible = true;
                    return;
                }
                else
                {
                    lblErrTuoiFilter.Visible = false;
                    btnTimKiem_Click(sender, e);
                }

            }
            else
            {
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
            txtDiemTLStart.Enabled = isDiemTL;
            txtDiemTLEnd.Enabled = isDiemTL;

            if (!isDiemTL)
            {
                txtDiemTLStart.PlaceholderText = "Từ";
                txtDiemTLEnd.PlaceholderText = "Đến";
                label11.Visible = false;
            }
            if (isTuoi)
            {
                if (int.TryParse(txtDiemTLStart.Texts, out int diemTLStartResult))
                {
                    diemTLStart = diemTLStartResult;
                }
                if (int.TryParse(txtDiemTLEnd.Texts, out int diemTLEndResult))
                {
                    diemTLEnd = diemTLEndResult;

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
            if (int.TryParse(txtDiemTLStart.Texts, out int diemTLStartResult))
            {
                diemTLStart = diemTLStartResult;
                if (diemTLStart < 0)
                {
                    label11.Text = "* Không được nhập điểm là số âm";
                    label11.Visible = true;
                    return;
                }
                else
                {
                    label11.Visible = false;
                    diemTLStart = diemTLStartResult;
                    btnTimKiem_Click(sender, e);
                }
                label11.Visible = false;
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
            if (int.TryParse(txtDiemTLEnd.Texts, out int diemTLEndResult))
            {
                diemTLEnd = diemTLEndResult;
                if (diemTLEnd < 0)
                {

                    label11.Text = "* Không được nhập tuổi là số âm";
                    label11.Visible = true;
                    return;
                }
                if (int.Parse(txtDiemTLStart.Texts) >= diemTLEnd)
                {

                    label11.Text = "* .Bạn phải tuổi kết thúc lớn hơn tuổi bắt đầu";
                    label11.Visible = true;
                    return;
                }
                else
                {
                    label11.Visible = false;
                    btnTimKiem_Click(sender, e);
                }

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


        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKH = CheckAndSetColor(txtMaKH, lblErrMaKH);
            string ho = CheckAndSetColorHo(txtHo, lblErrHo);
            string ten = CheckAndSetColorTen(txtTen, lblErrTen);
            string soDT = CheckAndSetColorSDT(txtSoDT, lblErrSoDT);
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = CheckAndSetColor(txtDiaChi, lblErrDiaChi);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            int diemTichLuy = int.Parse(lblDiemTL.Text);
            string img = fileName;
            if (img == null)
            {
                lblErrIMG.ForeColor = Color.FromArgb(230, 76, 89);
                return;
            }
            else
            {
                lblErrIMG.ForeColor = Color.Transparent;
            }
            string gioiTinh = "";
            if (!(rdbNam.Checked || rdbNu.Checked))
            {
                lblErrGioiTinh.ForeColor = Color.FromArgb(230, 76, 89); // Đổi màu nếu cả hai CheckBox đều không được chọn
                return;
            }
            else if (rdbNam.Checked)
            {
                gioiTinh = Convert.ToString(rdbNam.Text);
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn
            }
            else if (rdbNu.Checked)
            {
                gioiTinh = Convert.ToString(rdbNu.Text);
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn

            }

            if (!(maKH != "" && ho != "" && ten != "" && soDT != "" && diaChi != "" && trangThai != "" && img != null))
            {
                return;
            }
            KhachHangDTO kh = new KhachHangDTO(maKH, ho, ten, ngaySinh, gioiTinh, soDT, diaChi, trangThaiValue, img, diemTichLuy);
            int result = khBLL.insertKhachhang(kh) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Thêm thành công",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            
        }


        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            int i = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Texts = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            txtHo.Texts = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            txtTen.Texts = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse((dgvKhachHang.Rows[i].Cells[3].Value.ToString()));
            string gioiTinh = dgvKhachHang.Rows[i].Cells[4].Value.ToString();
            rdbNam.Checked = (gioiTinh == "Nam");
            rdbNu.Checked = (gioiTinh == "Nữ");
            txtSoDT.Texts = dgvKhachHang.Rows[i].Cells[5].Value.ToString();
            txtDiaChi.Texts = dgvKhachHang.Rows[i].Cells[6].Value.ToString();
            int trangThai = int.Parse(dgvKhachHang.Rows[i].Cells[7].Value.ToString());
            string img = dgvKhachHang.Rows[i].Cells[9].Value.ToString();
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "KhachHang", img);
            if (File.Exists(folderPath))
            {
                pbImage.Image = System.Drawing.Image.FromFile(folderPath);
                pbImage.Tag = dgvKhachHang.Rows[i].Cells[9].Value.ToString();
                fileName = Path.GetFileName(folderPath);
            }
            else
            {
                pbImage.Image = pbImage.InitialImage;

            }
            //if (dgvKhachHang.Rows[i].Cells[9].Value != DBNull.Value)
            //{
            //    byte[] imageBytes = (byte[])dgvKhachHang.Rows[i].Cells[9].Value;
            //    pbImage.Image = convertBinaryStringToImage(imageBytes);
            //}
            //else
            //{
            //    pbImage.Image = pbImage.InitialImage;
            //}
            //byte[] imageBytes = (byte[])dgvKhachHang.Rows[i].Cells[9].Value;
            //pbImage.Image = convertBinaryStringToImage(imageBytes);
            pbImage.Tag = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            cbxTrangThai.SelectedItem = (trangThai == 1) ? "Hoạt động" : "Không hoạt động";

            lblDiemTL.Text = dgvKhachHang.Rows[i].Cells[8].Value.ToString();
        }
        #region validate Dữ liệu
        private void txtHo__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorHo(txtHo, lblErrHo);
        }

        private void txtTen__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorTen(txtTen, lblErrTen);
        }

        private void txtSoDT__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorSDT(txtSoDT, lblErrSoDT);
        }

        private void txtDiaChi__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtDiaChi, lblErrDiaChi);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (!(rdbNam.Checked || rdbNu.Checked))
            {
                lblErrGioiTinh.ForeColor = Color.FromArgb(230, 76, 89); // Đổi màu nếu cả hai CheckBox đều không được chọn
            }
            else
            {
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn
            }
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (!(rdbNam.Checked || rdbNu.Checked))
            {
                lblErrGioiTinh.ForeColor = Color.FromArgb(230, 76, 89); // Đổi màu nếu cả hai CheckBox đều không được chọn
            }
            else
            {
                lblErrGioiTinh.ForeColor = Color.Transparent; // Đổi màu trong suốt nếu có một trong hai CheckBox được chọn
            }
        }

        #endregion

        private void btnUploadIMG_Click(object sender, EventArgs e)
        {
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "KhachHang");
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = folderPath,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = System.Drawing.Image.FromFile(open.FileName);

                this.Text = open.FileName;

                pbImage.Tag = txtMaKH.Texts;
                fileName = open.FileName;
            }
        }

        private void btnDeleteIMG_Click(object sender, EventArgs e)
        {
            pbImage.Image = pbImage.InitialImage;
            pbImage.Tag = "Placeholder";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Texts;
            string ho = txtHo.Texts;
            string ten = txtTen.Texts;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = rdbNam.Checked ? rdbNam.Text : (rdbNu.Checked ? rdbNu.Text : "");
            string soDT = txtSoDT.Texts;
            string diaChi = txtDiaChi.Texts;
            int trangThaiValue = (cbxTrangThai.SelectedItem == "Hoạt động") ? 1 : 0;
            int diemTL = int.Parse(lblDiemTL.Text);
            string img = fileName;
            if(img == null)
            {
                lblErrIMG.ForeColor = Color.FromArgb(230, 76, 89);
                return;
            } else
            {
                lblErrIMG.ForeColor = Color.Transparent;
            }
            KhachHangDTO kh = new KhachHangDTO(maKH, ho, ten, ngaySinh, gioiTinh, soDT, diaChi, trangThaiValue, img, diemTL);
            int result = khBLL.updateKhachHang(kh) ? 1 : 0;
            if (result == 1)
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                reset();
            }
            else
            {
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset(); 
        }
        private void reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            loadMaKH();
            txtHo.Texts = "";
            txtTen.Texts = "";
            txtSoDT.Texts = "";
            txtDiaChi.Texts = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            cbxTrangThai.SelectedIndex = -1;
            cbxTrangThai.Texts = "--Chọn trạng thái--";
            txtTimKiem.Texts = "";
            btnDeleteIMG.PerformClick();
            loadForm();
            unhideError();
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Texts;
            var choice = MessageBox.Show("Xóa khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                if (khBLL.deleteKhachHang(maKH, out isLoiKhoaNgoai))
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    reset();

                }
                else
                {
                    MessageBox.Show("Xóa thất bại",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                }
            }
        }

        private void txtTimKiem__TextChanged(object sender, EventArgs e)
        {

        }
    }
}


