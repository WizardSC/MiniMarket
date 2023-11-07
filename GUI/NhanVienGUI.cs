using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NhanVienGUI : Form
    {

        private string textSearchCondition = "";
        private string currentSearch;
        private NhanVienBLL nvBLL;
        private DataTable dt;
        private bool isFormFilter = false;
        private bool isGioiTinh = false;
        private bool isNam = false;
        private bool isNu = false;
        private bool isQuanLy = false;
        private bool isBanHang = false;
        private bool isHoatDong = false;
        private bool isKhongHoatDong = false;
        private string genderCondition = "";
        private string chucVuCondition = "";
        private string trangThaiCondition = "";

        private int tuoiStart = 0;
        private int tuoiEnd = 0;
        private bool isTuoi = false;
        private bool isChucVu = false;
        private bool isTrangThai = false;
        public NhanVienGUI()
        {
            InitializeComponent();
            nvBLL = new NhanVienBLL();
            dt = nvBLL.getListNhanVien();
            unhideError();
            loadMaNV();
            loadCbxTimKiem();
        }
        private void load_Form()
        {
            dgvNhanVien.DataSource = nvBLL.getListNhanVien();
        }
        private void NhanViennGUI_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = nvBLL.getListNhanVien();
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
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
        private void loadMaNV()
        {
            string lastMaNV = dt.AsEnumerable()
                .Select(row => row.Field<string>("MaNV"))
                .LastOrDefault();

            int nextNum = 1;
            if (!string.IsNullOrEmpty(lastMaNV) && lastMaNV.Length >= 5)
            {
                int.TryParse(lastMaNV.Substring(2), out nextNum);
                nextNum++;
            }
            txtMaNV.Texts = "NV" + nextNum.ToString("D3");
        }
        private void loadCbxTimKiem()
        {
            cbxTimKiem.Items.Add("Mã NV");
            cbxTimKiem.Items.Add("Họ");
            cbxTimKiem.Items.Add("Tên");
            cbxTimKiem.Items.Add("Địa chỉ");
            cbxTimKiem.SelectedItem = 0;
        }
        private string returnDieuKien(string text)
        {
            return text;
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxTimKiem.SelectedIndex)
            {
                case 0:
                    return returnDieuKien($"MaNV like '%{searchText}%'");
                case 1:
                    return returnDieuKien($"Ho like '%{searchText}%'");
                case 2:
                    return returnDieuKien($"Ten like '%{searchText}%'");
                case 3:
                    return returnDieuKien($"DiaChi like '%{searchText}%'");
                default:
                    return returnDieuKien($"MaNV like '%{searchText}%'"); ;
            }
        }
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
        private void applySearchs(string text)
        {
            currentSearch = text;
            DataView dvNhanVien = nvBLL.getListNhanVien().DefaultView;
            dvNhanVien.RowFilter = currentSearch;
            dgvNhanVien.DataSource = dvNhanVien.ToTable();
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
       
        private void unhideError()
        {
            lblErrMaNV.ForeColor = Color.Transparent;
            lblErrHo.ForeColor = Color.Transparent;
            lblErrTen.ForeColor = Color.Transparent;
            lblErrGioiTinh.ForeColor = Color.Transparent;
            lblErrSoDT.ForeColor = Color.Transparent;
            lblErrDiaChi.ForeColor = Color.Transparent;
            lblErrTrangThai.ForeColor = Color.Transparent;
            lblErrChucVu.ForeColor = Color.Transparent;
            lblErrIMG.ForeColor = Color.Transparent;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNV = CheckAndSetColor(txtMaNV, lblErrMaNV);
            string ho = CheckAndSetColor(txtHo, lblErrHo);
            string ten = CheckAndSetColor(txtTen, lblErrTen);
            string soDT = CheckAndSetColor(txtSoDT, lblErrSoDT);
            DateTime ngaySinh = dtpNgaySinh.Value;
            string diaChi = CheckAndSetColor(txtDiaChi, lblErrDiaChi);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            string chucVu = CheckAndSetColor(cbxChucVu, lblErrChucVu);
            string valueChucVu = (chucVu == "Nhân viên bán hàng" ? "CV001" : "CV002");
            //byte[] img = convertImageToBinaryString(pbImage.Image, pbImage.Tag.ToString());
            //string maTK = null;
            byte[] img = null;
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

            if (!(maNV != "" && ho != "" && ten != "" && soDT != "" && diaChi != "" && trangThai != ""))
            {
                return;
            }
            NhanVienDTO nv = new NhanVienDTO(maNV, ho, ten, ngaySinh, gioiTinh, soDT, diaChi, trangThaiValue, valueChucVu);
            if (nvBLL.insertNhanVien(nv))
            {
                MessageBox.Show("Thêm thành công",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                load_Form();
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
        private void txtHo__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtHo, lblErrHo);
        }

        private void txtTen__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtTen, lblErrTen);
        }

        private void txtSoDT__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtSoDT, lblErrSoDT);
        }

        private void txtDiaChi__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtDiaChi, lblErrDiaChi);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }
        private void cbxChucVu_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxChucVu, lblErrChucVu);
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


        private void btnUploadIMG_Click(object sender, EventArgs e)
        {
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "NhanVien");
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

                pbImage.Tag = txtMaNV.Texts;
                Console.WriteLine(pbImage.Tag);

            }
        }

        private void btnDeleteIMG_Click(object sender, EventArgs e)
        {
            pbImage.Image = pbImage.InitialImage;
            pbImage.Tag = "Placeholder";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhanVien.CurrentRow.Index;
            txtMaNV.Texts = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            txtHo.Texts = dgvNhanVien.Rows[i].Cells[1].Value.ToString();
            txtTen.Texts = dgvNhanVien.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinh.Value = DateTime.Parse((dgvNhanVien.Rows[i].Cells[3].Value.ToString()));
            string gioiTinh = dgvNhanVien.Rows[i].Cells[4].Value.ToString();
            rdbNam.Checked = (gioiTinh == "Nam");
            rdbNu.Checked = (gioiTinh == "Nữ");
            txtSoDT.Texts = dgvNhanVien.Rows[i].Cells[5].Value.ToString();
            txtDiaChi.Texts = dgvNhanVien.Rows[i].Cells[6].Value.ToString();
            int trangThai = int.Parse(dgvNhanVien.Rows[i].Cells[7].Value.ToString());
            string chucVu = dgvNhanVien.Rows[i].Cells[9].Value.ToString();
            //byte[] imageBytes = (byte[])dgvNhanVien.Rows[i].Cells[9].Value;
            //pbImage.Image = convertBinaryStringToImage(imageBytes);
            //pbImage.Tag = dgvNhanVien.Rows[i].Cells[0].Value.ToString();
            cbxTrangThai.SelectedItem = (trangThai == 1) ? "Hoạt động" : "Không hoạt động";

            cbxChucVu.SelectedItem = (chucVu == "CV001") ? "Nhân viên bán hàng" : "Nhân viên quản lý";
        }
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
        private void reset()
        {
            loadMaNV();
            txtHo.Texts = "";
            txtTen.Texts = "";
            txtSoDT.Texts = "";
            txtDiaChi.Texts = "";
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            cbxChucVu.SelectedIndex = -1;
            cbxChucVu.Texts = "--Chọn chức vụ--";
            cbxTrangThai.SelectedIndex = -1;
            cbxTrangThai.Texts = "--Chọn trạng thái--";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Texts;
            string ho = txtHo.Texts;
            string ten = txtTen.Texts;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = rdbNam.Checked ? rdbNam.Text : (rdbNu.Checked ? rdbNu.Text : "");
            string soDT = txtSoDT.Texts;
            string diaChi = txtDiaChi.Texts;
            int trangThaiValue = (cbxTrangThai.SelectedItem == "Hoạt động") ? 1 : 0;
            string valueChucVu = (cbxChucVu.SelectedItem == "Nhân viên bán hàng") ? "CV001" : "CV002";
            byte[] img = convertImageToBinaryString(pbImage.Image, pbImage.Tag.ToString());

            NhanVienDTO nv = new NhanVienDTO(maNV, ho, ten, ngaySinh, gioiTinh, soDT, diaChi, trangThaiValue, valueChucVu);
            if (nvBLL.updateNhanVien(nv))
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                load_Form();
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

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                if (nvBLL.deleteNhanVien(maNV, out isLoiKhoaNgoai))
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                    load_Form();

                }
                else
                {
                    if (isLoiKhoaNgoai)
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        var result = MessageBox.Show("Không thể xóa nhân viên này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            if (trangThai == 1)
                            {
                                var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của nhân viên này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result1 == DialogResult.OK)
                                {
                                    if (nvBLL.updateTrangThai(trangThai, maNV))
                                    {
                                        MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        load_Form();
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

        private void dgvNhanVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == dgvNhanVien.Columns["NgaySinh"].Index && e.Value != null)
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == dgvNhanVien.Columns["TrangThai"].Index && e.Value != null)
            {
                int intValue;
                if (int.TryParse(e.Value.ToString(), out intValue))
                {
                    if (intValue == 1)
                    {
                        e.Value = "Hoạt động";
                    }
                    else
                    {
                        e.Value = "Không hoạt động";
                    }
                    e.FormattingApplied = true;
                }
            }
        }

        private void dtpNgaySinh_ValueChanged(object sender, EventArgs e)
        {

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
        private bool toggleDieuKien(bool value)
        {
            return !value;
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
        private void UpdateChucVuCondition()
        {
            List<string> chucVuConditions = new List<string>();

            if (isBanHang)
            {
                chucVuConditions.Add("MaCV = 'CV001'");
            }

            if (isQuanLy)
            {
                chucVuConditions.Add("MaCV = 'CV002'");
            }

            chucVuCondition = string.Join(" OR ", chucVuConditions);
        }
        private void UpdateTrangThaiCondition()
        {
            List<string> trangThaiConditions = new List<string>();

            if (isHoatDong)
            {
                trangThaiConditions.Add("TrangThai = 1");
            }

            if (isKhongHoatDong)
            {
                trangThaiConditions.Add("TrangThai = 0");
            }

            trangThaiCondition = string.Join(" OR ", trangThaiConditions);
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
        private void chkDiemTL_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void chkChucVu_CheckedChanged(object sender, EventArgs e)
        {
            isChucVu = toggleDieuKien(isChucVu);

            // Bật hoặc tắt chkNam và chkNu dựa trên trạng thái của chkGioiTinh
            chkNam.Enabled = isChucVu;
            chkNu.Enabled = isChucVu;
            if (isChucVu)
            {

                if (isBanHang)
                {

                    chkBanHang_CheckedChanged(sender, e);
                }

                if (isQuanLy)
                {

                    chkQuanLy_CheckedChanged(sender, e);
                }
            }
            else
            {
                chkBanHang.Checked = false;
                chkQuanLy.Checked = false;
                chkBanHang.Enabled = isChucVu;
                chkQuanLy.Enabled = isChucVu;
            }
        }
        private void chkBanHang_CheckedChanged(object sender, EventArgs e)
        {
            isBanHang = toggleDieuKien(isBanHang);
            UpdateChucVuCondition();
            btnTimKiem.PerformClick();
        }

        private void chkQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            isQuanLy = toggleDieuKien(isQuanLy);
            UpdateChucVuCondition();
            btnTimKiem.PerformClick();
        }



        private void chkTrangThai_CheckedChanged(object sender, EventArgs e)
        {
            isTrangThai = toggleDieuKien(isTrangThai);

            // Bật hoặc tắt chkNam và chkNu dựa trên trạng thái của chkGioiTinh
            chkHoatDong.Enabled = isTrangThai;
            chkKoHD.Enabled = isTrangThai;
            if (isTrangThai)
            {

                if (isHoatDong)
                {

                    chkHoatDong_CheckedChanged(sender, e);
                }

                if (isKhongHoatDong)
                {

                    chkKoHD_CheckedChanged(sender, e);
                }
            }
            else
            {
                chkHoatDong.Checked = false;
                chkKoHD.Checked = false;
                chkHoatDong.Enabled = isTrangThai;
                chkKoHD.Enabled = isTrangThai;
            }
        }
        private void chkHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            isHoatDong = toggleDieuKien(isHoatDong);
            UpdateTrangThaiCondition();
            btnTimKiem.PerformClick();
        }
        private void chkKoHD_CheckedChanged(object sender, EventArgs e)
        {
            isKhongHoatDong = toggleDieuKien(isKhongHoatDong);
            UpdateTrangThaiCondition();
            btnTimKiem.PerformClick();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, genderCondition);        
            combinedCondition = CombineConditions(combinedCondition, trangThaiCondition);
            combinedCondition = CombineConditions(combinedCondition, chucVuCondition);
            combinedCondition = ApplyOrRemoveTuoiCondition(combinedCondition, isTuoi);
            applySearchs(combinedCondition);
        }
    }
}
