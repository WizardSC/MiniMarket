using BLL;
using DevExpress.XtraRichEdit.Layout.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using Image = System.Drawing.Image;
using bitmap = System.Drawing.Bitmap;
using Excel = Microsoft.Office.Interop.Excel;
using DevExpress.XtraExport.Xls;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using System.Drawing.Imaging;
using DevExpress.XtraReports.UI;
using DTO;
using GUI.MyCustom;
using System.IO;

namespace GUI
{
    public partial class ChucVuGUI : Form
    {
        private string textSearchCondition = "";
        private string currentSearch;
        private ChucVuBLL cvBLL;
        private PhanQuyenBLL pqBLL;
        private DataTable dt;
        private bool isFormFilter = false;
        private bool isGioiTinh = false;
        private bool isNam = false;
        private bool isNu = false;
        private bool isQuanLy = false;
        private bool isBanHang = false;
        private bool isKho = false;
        private bool isAdmin = false;
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

        private string maCV;
        private int quyenChucVu;
        public ChucVuGUI(int isChucVu)
        {
            cvBLL = new ChucVuBLL();
            pqBLL = new PhanQuyenBLL();
            dt = cvBLL.getListChucVu();
            InitializeComponent();
            unhideError();
            loadMaCV();
            loadBtn();
            this.quyenChucVu = isChucVu;
            checkQuyen(isChucVu);
            loadCbxTimKiem();



        }
        private void loadBtn()
        {
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        private void checkQuyen(int quyen)
        {
            if (quyen == 1)
            {

                btnThem.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                cbxTrangThai.Enabled = false;

            }
        }
        private void unhideError()
        {
            lblErrMaCV.ForeColor = Color.Transparent;
            lblErrTen.ForeColor = Color.Transparent;
            lblErrTrangThai.ForeColor = Color.Transparent;
        }

        private void load_Form()
        {
            dgvChucVu.DataSource = cvBLL.getListChucVu();
        }
        private void ChucVuGUI_Load(object sender, EventArgs e)
        {
            dgvChucVu.DataSource = cvBLL.getListChucVu();
        }
        private void loadMaCV()
        {
            cvBLL = new ChucVuBLL();
            maCV = cvBLL.getMaxMaCV();
            string lastMaCV = maCV;
            if (lastMaCV == "")
            {
                txtMaCV11.Texts = "CV001";
            }
            int tempNum = int.Parse(lastMaCV.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaCV11.Texts = "CV0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaCV11.Texts = "CV00" + (tempNum + 1).ToString();
            }
        }
        private void loadCbxTimKiem()
        {
            cbxTimKiem.Items.Add("Mã CV");
            cbxTimKiem.Items.Add("Tên");
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
                    return returnDieuKien($"MaCV like '%{searchText}%'");
                case 1:
                    return returnDieuKien($"TenCV like '%{searchText}%'");
                default:
                    return returnDieuKien($"MaCV like '%{searchText}%'"); ;
            }
        }
        private void applySearchs(string text)
        {
            currentSearch = text;
            DataView dvChucVu = cvBLL.getListChucVu().DefaultView;
            dvChucVu.RowFilter = currentSearch;
            dgvChucVu.DataSource = dvChucVu.ToTable();
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
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maCV = CheckAndSetColor(txtMaCV11, lblErrMaCV);
            string ten = CheckAndSetColorTen(txtTen, lblErrTen);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            if ((string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(trangThai)))
            {
                return;
            }
            ChucVuDTO cv = new ChucVuDTO(maCV, ten, trangThaiValue);
            if (cvBLL.insertCV(cv))
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
            int result = pqBLL.insertPhanQuyen(ten) ? 1 : 0;
            if (result == 1)
            {

                MessageBox.Show("Thêm thành công",
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
        }


        private void btnSua_Click(object sender, EventArgs e)
        {
            string maCV = CheckAndSetColor(txtMaCV11, lblErrMaCV);
            string ten = CheckAndSetColorTen(txtTen, lblErrTen);
            string trangThai = CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            if ((string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(trangThai)))
            {
                return;
            }
            ChucVuDTO cv = new ChucVuDTO(maCV, ten, trangThaiValue);
            if (cvBLL.updateCV(cv))
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maCV = txtMaCV11.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa chức vụ này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                if (cvBLL.deleteCV(maCV, out isLoiKhoaNgoai))
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
                        var result = MessageBox.Show("Không thể xóa chức vụ này vì có dữ liệu liên quan đến nhân viên trong hệ thống. " +
                            "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.OK)
                        {
                            if (trangThai == 1)
                            {
                                var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của chức vụ này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                if (result1 == DialogResult.OK)
                                {
                                    if (cvBLL.updateTrangThai(trangThai, maCV))
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

        private void txtMaCV11__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(txtMaCV11, lblErrMaCV);
        }

        private void txtTen__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorTen(txtTen, lblErrTen);
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, lblErrTrangThai);
        }

        private void reset()
        {
            loadBtn();
            load_Form();
            loadMaCV();
            txtTen.Texts = " ";
            cbxTrangThai.SelectedIndex = -1;
            cbxTrangThai.Texts = "--Chọn trạng thái--";
            txtTimKiem.Texts = "";
            unhideError();
        }

        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            checkQuyen(quyenChucVu);

            int i = dgvChucVu.CurrentRow.Index;
            txtMaCV11.Texts = dgvChucVu.Rows[i].Cells[0].Value.ToString();
            txtTen.Texts = dgvChucVu.Rows[i].Cells[1].Value.ToString();
            int trangThai = int.Parse(dgvChucVu.Rows[i].Cells[2].Value.ToString());
            cbxTrangThai.SelectedItem = (trangThai == 1) ? "Hoạt động" : "Không hoạt động";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            applySearchs(textSearchCondition);
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void dgvChucVu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvChucVu.Columns["TrangThai1"].Index && e.Value != null)
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
    }
}
