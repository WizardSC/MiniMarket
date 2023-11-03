using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI
{
    public partial class NhaCCGUI : Form
    {

        private string textSearchCondition = "";
        NhaCungCapBLL nccBLL;
        DataTable dt;
        private string currentSearch;
        private bool isFormFilter = false;
        private string trangThaiCondition = "";
        private bool isHoatDong = false;
        private bool isKhongHoatDong = false;
        private bool isTrangThai = false;
        public NhaCCGUI()
        {
            InitializeComponent();
            nccBLL = new NhaCungCapBLL();
            dt = nccBLL.getListNCC();
            loadMaNCC();
            loadCbxTimKiem();

        }
        private void applySearchs(string text)
        {
            currentSearch = text;
            DataView dvNhaCC = nccBLL.getListNCC().DefaultView;
            dvNhaCC.RowFilter = currentSearch;
            dgvNhaCC.DataSource = dvNhaCC.ToTable();
        }
        private  void load_Form()
        {
            dgvNhaCC.DataSource = nccBLL.getListNCC();
        }
        private void NhaCC_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = nccBLL.getListNCC();
        }
        private void loadMaNCC()
        {
            string lastMaNCC = null;
            foreach (DataRow row in dt.Rows)
            {
                lastMaNCC = row["MaNCC"].ToString();
            }
            if (lastMaNCC == "")
            {
                txtMaNCC.Texts = "NCC001";
            }
            int tempNum = int.Parse(lastMaNCC.Substring(3));
            if ((tempNum + 1) >= 10)
            {
                txtMaNCC.Texts = "NCC0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaNCC.Texts = "NCC00" + (tempNum + 1).ToString();
            }
        }
        private void loadCbxTimKiem()
        {
            cbxTimKiem.Items.Add("Mã NCC");
            cbxTimKiem.Items.Add("Tên NCC");
            cbxTimKiem.Items.Add("Địa chỉ");
            cbxTimKiem.Items.Add("Số Fax");
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
                    return returnDieuKien($"MaNCC like '%{searchText}%'");
                case 1:
                    return returnDieuKien($"TenNCC like '%{searchText}%'");
                case 2:
                    return returnDieuKien($"DiaChi like '%{searchText}%'");
                case 3:
                    return returnDieuKien($"SoFax like '%{searchText}%'");
                default:
                    return returnDieuKien($"MaNCC like '%{searchText}%'"); ;
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
        

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, trangThaiCondition);
            applySearchs(combinedCondition);
        }
        private void resetForm()
        {
            loadMaNCC();
            txtTen.Texts = "";
            txtDiaChi.Texts = "";
            txtSoDT.Texts = "";
            txtSoFax.Texts = "";
            cbxTrangThai.SelectedIndex = -1;
            cbxTrangThai.Texts = "--Chọn trạng thái--";
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maNCC = CheckAndSetColor(txtMaNCC, lblErrMaNCC);
            string ten = CheckAndSetColor(txtTen, lblErrTen);
            string diaChi = CheckAndSetColor(txtDiaChi, lblErrDiaChi);
            string soDT = CheckAndSetColor(txtSoDT, lblErrSoDT);
            string soFax = CheckAndSetColor(txtSoFax, lblErrSoFax);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            if (!(maNCC != "" && ten != "" && diaChi != "" && soDT != "" && trangThai != ""))
            {
                return;
            }
            NhaCungCapDTO ncc = new NhaCungCapDTO(maNCC,ten, diaChi, soDT, soFax, trangThaiValue);
            if (nccBLL.insertNhaCungCap(ncc))
            {
                MessageBox.Show("Thêm thành công",
                  "Thông báo",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
                  load_Form();
            }
            else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void lblErrSoFax_Click(object sender, EventArgs e)
        {

        }
        private void txtTenNCC__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtTen, lblErrTen);
        }

        private void txtDiaChi__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtDiaChi, lblErrDiaChi);
        }

        private void txtSoDT__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtSoDT, lblErrSoDT);
        }

        private void txtSoFax__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtSoFax, lblErrSoFax);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Texts;
            string ten = txtTen.Texts;
            string soDT = txtSoDT.Texts;
            string diaChi = txtDiaChi.Texts;
            string soFax = txtSoFax.Texts;
            int trangThaiValue = (cbxTrangThai.SelectedItem == "Hoạt động") ? 1 : 0;

            NhaCungCapDTO ncc = new NhaCungCapDTO(maNCC,ten, diaChi,soDT, soFax, trangThaiValue);
            if (nccBLL.updateNhaCC(ncc))
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    load_Form();

            }
            else
            {
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhaCC.CurrentRow.Index;
            txtMaNCC.Texts = dgvNhaCC.Rows[i].Cells[0].Value.ToString();
            txtTen.Texts = dgvNhaCC.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Texts = dgvNhaCC.Rows[i].Cells[2].Value.ToString();
            txtSoDT.Texts = dgvNhaCC.Rows[i].Cells[3].Value.ToString();
            txtSoFax.Texts = dgvNhaCC.Rows[i].Cells[4].Value.ToString();
            int trangThai = int.Parse(dgvNhaCC.Rows[i].Cells[5].Value.ToString());
            cbxTrangThai.SelectedItem = (trangThai == 1) ? "Hoạt động" : "Không hoạt động";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa nhà cung cấp này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                if (nccBLL.deleteNhaCCC(maNCC, out isLoiKhoaNgoai))
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
                        var result = MessageBox.Show("Không thể xóa nhà cung cấp này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            if (trangThai == 1)
                            {
                                var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của nhà cung cấp này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result1 == DialogResult.OK)
                                {
                                    if (nccBLL.updateTrangThai(trangThai, maNCC))
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            resetForm();
        }

        private void dgvNhaCC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            
            if (e.ColumnIndex == dgvNhaCC.Columns["TrangThai"].Index && e.Value != null)
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
        private bool toggleDieuKien(bool value)
        {
            return !value;
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
    }
}
