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
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Net.Mime.MediaTypeNames;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using bitmap = System.Drawing.Bitmap;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraExport.Xls;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System.Drawing.Imaging;
using DevExpress.XtraReports.UI;

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
        private string fileName;
        private string ma;

        public NhaCCGUI(int isNCC)
        {
            InitializeComponent();
            nccBLL = new NhaCungCapBLL();
            dt = nccBLL.getListNCC();
            load_Form();
            loadCbxTimKiem();
            unhideError();
            checkQuyen(isNCC);
            loadMaNCC();

        }
        private void checkQuyen(int quyen)
        {
            if (quyen == 1)
            {
                btnDeleteIMG.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                cbxTrangThai.Enabled = false;
                btnImport.Enabled = false;
                btnFolder.Enabled = false;
                btnUploadIMG.Enabled = false;
                btnDeleteIMG.Enabled = false;
            }
        }
        private void unhideError()
        {
            lblErrMaNCC.ForeColor = Color.Transparent;
            lblErrTen.ForeColor = Color.Transparent;
            lblErrDiaChi.ForeColor = Color.Transparent;
            lblErrSoDT.ForeColor = Color.Transparent;
            lblErrSoFax.ForeColor = Color.Transparent;
            lblErrTrangThai.ForeColor = Color.Transparent;
            lblErrIMG.ForeColor = Color.Transparent;
        }
        private void applySearchs(string text)
        {
            currentSearch = text;
            DataView dvNhaCC = nccBLL.getListNCC().DefaultView;
            dvNhaCC.RowFilter = currentSearch;
            dgvNhaCC.DataSource = dvNhaCC.ToTable();
        }
        private void load_Form()
        {
            dgvNhaCC.DataSource = nccBLL.getListNCC();
        }
        private void NhaCC_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = nccBLL.getListNCC();
        }

        private void loadMaNCC()
        {
            nccBLL = new NhaCungCapBLL();
            ma = nccBLL.getMaxMaNhaCC();

            if (ma == "")
            {
                txtMaNCC.Texts = "NCC001";
            }
            int tempNum = int.Parse(ma.Substring(3));
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
        private string CheckAndSetColorSoFax(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Bạn phải nhập so Fax";
                    return null;
                }
                else if (ContainsLetter(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "    *Số Fax không thể chứa chữ";
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
                else if (text.ToString().Length > 10 )
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "    *Số DT không quá 10 số";
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
                }
                else if (int.TryParse(text, out int result))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "    *Tên không thể chứa chữ số";
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
            string ten = CheckAndSetColorTen(txtTen, lblErrTen);
            string diaChi = CheckAndSetColor(txtDiaChi, lblErrDiaChi);
            string soDT = CheckAndSetColorSDT(txtSoDT, lblErrSoDT);
            string soFax = CheckAndSetColorSoFax(txtSoFax, lblErrSoFax);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            string img = fileName;
            if ((string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(soDT) || string.IsNullOrWhiteSpace(trangThai) || img == null))
            {
                return;
            }
            else
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO(maNCC, ten, diaChi, soDT, soFax, trangThaiValue, img);
                if (nccBLL.insertNhaCungCap(ncc))
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

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maNCC = CheckAndSetColor(txtMaNCC, lblErrMaNCC);
            string ten = CheckAndSetColorTen(txtTen, lblErrTen);
            string diaChi = CheckAndSetColor(txtDiaChi, lblErrDiaChi);
            string soDT = CheckAndSetColorSDT(txtSoDT, lblErrSoDT);
            string soFax = CheckAndSetColorSoFax(txtSoFax, lblErrSoFax);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            string img = fileName;
            if ((string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(diaChi) || string.IsNullOrWhiteSpace(soDT) || string.IsNullOrWhiteSpace(trangThai) || img == null))
            {
                return;
            }
            else
            {
                NhaCungCapDTO ncc = new NhaCungCapDTO(maNCC, ten, diaChi, soDT, soFax, trangThaiValue, img);
                if (nccBLL.updateNhaCC(ncc))
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

        }
        private void txtTenNCC__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorTen(txtTen, lblErrTen);
        }

        private void txtDiaChi__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtDiaChi, lblErrDiaChi);
        }

        private void txtSoDT__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorSDT(txtSoDT, lblErrSoDT);
        }

        private void txtSoFax__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorSoFax(txtSoFax, lblErrSoFax);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }
        private byte[] convertImageToBinaryString(Image img, string tag)
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
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
        }


        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            int i = dgvNhaCC.CurrentRow.Index;
            txtMaNCC.Texts = dgvNhaCC.Rows[i].Cells[0].Value.ToString();
            txtTen.Texts = dgvNhaCC.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Texts = dgvNhaCC.Rows[i].Cells[2].Value.ToString();
            txtSoDT.Texts = dgvNhaCC.Rows[i].Cells[3].Value.ToString();
            txtSoFax.Texts = dgvNhaCC.Rows[i].Cells[4].Value.ToString();
            int trangThai = int.Parse(dgvNhaCC.Rows[i].Cells[5].Value.ToString());
            cbxTrangThai.SelectedItem = (trangThai == 1) ? "Hoạt động" : "Không hoạt động";
            string img = dgvNhaCC.Rows[i].Cells[6].Value.ToString();
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "NhaCungCap", img);
            if (File.Exists(folderPath))
            {
                pbImage.Image = Image.FromFile(folderPath);
                pbImage.Tag = dgvNhaCC.Rows[i].Cells[0].Value.ToString();

            } else
            {
                pbImage.Image = pbImage.InitialImage;

            }
            
            //pbImage.Image = convertBinaryStringToImage(imageBytes);

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

                    reset();

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

                                        reset();
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
            reset();
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

        private void btnUploadIMG_Click(object sender, EventArgs e)
        {
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "NhaCungCap");
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = folderPath,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;

                pbImage.Tag = txtMaNCC.Texts;
                fileName = Path.GetFileName(open.FileName);

            }
        }
        private void btnDeleteIMG_Click(object sender, EventArgs e)
        {
            pbImage.Image = pbImage.InitialImage;
            pbImage.Tag = "Placeholder";
        }
        private void reset()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            loadMaNCC();
            txtTimKiem.Texts = "";
            txtTen.Texts = "";
            txtDiaChi.Texts = "";
            txtSoDT.Texts = "";
            txtSoFax.Texts = "";
            cbxTrangThai.SelectedIndex = -1;
            cbxTrangThai.Texts = "--Chọn trạng thái--";
            btnDeleteIMG.PerformClick();
            unhideError();
            load_Form();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
                e.Handled = true;
            }
        }
    }
}
