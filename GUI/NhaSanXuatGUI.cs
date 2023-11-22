using BLL;
using ClosedXML.Excel;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace GUI
{
    public partial class NhaSanXuatGUI : Form
    {
        private bool isFormFilter = false;
        private string cbxItemsMacDinh;
        private string statusCondition = "";
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string genderCondition = ""; // Biến để lưu trữ điều kiện từ checkbox "Giới Tính"
        private string currentSearch;
        private bool isTrangThai = false;
        private bool isHoatDong = false;
        private bool isKoHD = false;

        private bool isGioiTinh = false;
        private bool isTuoi = false;

        private NhaSanXuatBLL nsxBLL;
        private DataTable dt;
        public NhaSanXuatGUI()
        {
            InitializeComponent();
            nsxBLL = new NhaSanXuatBLL();
            dt = nsxBLL.getListNSX();
            loadMaNSX();
            unhideError();

        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //  string MaNSX = txtMaNSX.Texts;
            string MaNSX = CheckAndSetColor(txtMaNSX, label13);
            string TenNSX = CheckAndSetColor(txtTenNSX, label14);
            string DiaChi = CheckAndSetColor(txtDiaChi, label15);
            string SoDT = CheckAndSetColor(txtSoDT, label18);
            string trangThai = CheckAndSetColor(cbxTrangThai, label6);
           // string trangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;

            if (!(MaNSX != "" && TenNSX != "" && DiaChi != "" && SoDT != "" && trangThai != ""))
            {
                return;
            }
            NhaSanXuatDTO nsx = new NhaSanXuatDTO(MaNSX, TenNSX, DiaChi, SoDT, trangThaiValue);
            int flag = nsxBLL.insertNhaSanXuat(nsx) ? 1 : 0;
            if (flag == 1)
            {
                
                MessageBox.Show("Thêm nhà sản xuất thành công thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loadMaNSX();
                init();
                clearForm();

            }
            else
            {
                MessageBox.Show("Thêm nhà sản xuất thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }
        // ẩn lỗi
        private void unhideError()
        {
            label13.ForeColor = Color.Transparent;
            label14.ForeColor = Color.Transparent;
            label15.ForeColor = Color.Transparent;
            label18.ForeColor = Color.Transparent;
            label6.ForeColor = Color.Transparent;
        }
        private string CheckAndSetColor(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                label.ForeColor = string.IsNullOrWhiteSpace(text) ? Color.FromArgb(230, 76, 89) : Color.Transparent;
                return text;
            }
            else if (control is ComboBox comboBox)
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
        private void loadMaNSX()
        {
            string mansx;
            nsxBLL = new NhaSanXuatBLL();
            mansx = nsxBLL.getMaxMaNhaSX();
            if (mansx == "")
            {
                txtMaNSX.Texts = "NSX001";
            }
            int tempNum = int.Parse(mansx.Substring(3));
            if ((tempNum + 1) >= 10)
            {
                txtMaNSX.Texts = "NSX0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaNSX.Texts = "NSX00" + (tempNum + 1).ToString();
            }
        }

        public void clearForm()
        {
            loadMaNSX();
            txtTenNSX.Texts = "";
            txtDiaChi.Texts = "";
            txtSoDT.Texts = "";
            cbxTrangThai.Text = "Hoạt động";

            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label18.Text = "";
        }

        private void NhaSanXuatGUI_Load(object sender, EventArgs e)
        {
            // dgvNSX.DataSource = nsxBLL.getListNSX();
            loadDataToCBX(cbxTimKiem);
            init();
        }
        private bool ContainsNumber(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            string MaNSX = CheckAndSetColor(txtMaNSX, label13);
            string TenNSX = CheckAndSetColor(txtTenNSX, label14);
            string DiaChi = CheckAndSetColor(txtDiaChi, label15);
            string SoDT = CheckAndSetColor(txtSoDT, label18);



            string trangThai = CheckAndSetColor(cbxTrangThai, label6);
            int trangThaiValue = (trangThai == "Hoạt động" ? 1 : 0);
            if (ContainsNumber(TenNSX))
            {
                MessageBox.Show("Tên NSX không được chứa số!",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            if ((string.IsNullOrWhiteSpace(MaNSX) || string.IsNullOrWhiteSpace(TenNSX) || string.IsNullOrWhiteSpace(SoDT) || string.IsNullOrWhiteSpace(DiaChi) || string.IsNullOrWhiteSpace(trangThai)))
            {
                return;
            }

            NhaSanXuatDTO nsx = new NhaSanXuatDTO(MaNSX, TenNSX, DiaChi, SoDT, trangThaiValue);
            if (nsxBLL.update_nhasanxuat(nsx))
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loadMaNSX();
                init();

            }
            else
            {
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }

           




        }

        private void dgvNSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNSX.CurrentRow.Index;
            txtMaNSX.Texts = dgvNSX.Rows[i].Cells[0].Value.ToString();
            txtTenNSX.Texts = dgvNSX.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Texts = dgvNSX.Rows[i].Cells[2].Value.ToString();
            txtSoDT.Texts = dgvNSX.Rows[i].Cells[3].Value.ToString();
            int trangThaiValue = Convert.ToInt32(dgvNSX.Rows[i].Cells[4].Value);
            cbxTrangThai.SelectedItem = (trangThaiValue == 0) ? "Không hoạt động" : "Hoạt động";
        }

        public void init()
        {
            
            dgvNSX.DataSource = nsxBLL.getListNSX();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnThem.BackgroundColor = Color.White;
            btnThem.BackColor = Color.White;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;

           
            init();
            loadMaNSX();
            clearForm();
        }

        /*private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaSanXuatDTO nsx = new NhaSanXuatDTO();
            nsx.MaNSX = txtMaNSX.Texts;
            nsxBLL.delete_nhasanxuat(nsx);
            loadMaNSX();
            init();
            clearForm();
        }*/

        private void dgvNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {



            btnSua.Enabled = true;
            

            btnXoa.Enabled = true;
            

            btnThem.Enabled = false;
            

            int i = dgvNSX.CurrentRow.Index;
            txtMaNSX.Texts = dgvNSX.Rows[i].Cells[0].Value.ToString();
            txtTenNSX.Texts = dgvNSX.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Texts = dgvNSX.Rows[i].Cells[2].Value.ToString();
            txtSoDT.Texts = dgvNSX.Rows[i].Cells[3].Value.ToString();
            int trangThaiValue = Convert.ToInt32(dgvNSX.Rows[i].Cells[4].Value);
            cbxTrangThai.SelectedItem = (trangThaiValue == 0) ? "Không hoạt động" : "Hoạt động";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaNSX = txtMaNSX.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            if (trangThai == 0)
            {
                bool isLoiKhoaNgoai;
                var choice2 = MessageBox.Show("Xóa loại này này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice2 == DialogResult.Yes)
                {
                    if (nsxBLL.delete_nhasanxuat(MaNSX, out isLoiKhoaNgoai))
                    {
                        MessageBox.Show("Xóa thành công",
                          "Thông báo",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                        btnThem.Enabled = true;
                        btnThem.BackgroundColor = Color.White;
                        btnThem.BackColor = Color.White;

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                       
                        init();
                        loadMaNSX();
                        clearForm();




                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà sản xuất này vì có tồn tại khóa ngoại",
                          "Thông báo",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);

                        init();
                      
                    }
                }



            }
            else
            {
                var choice = MessageBox.Show("Xóa nhà sản xuât này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    bool isLoiKhoaNgoai;
                    bool kq = nsxBLL.delete_nhasanxuat(MaNSX, out isLoiKhoaNgoai);
                    if (kq)
                    {
                        MessageBox.Show("Xóa thành công",
                          "Thông báo",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                        btnThem.Enabled = true;
                        btnThem.BackgroundColor = Color.White;
                        btnThem.BackColor = Color.White;

                        btnSua.Enabled = false;
                        btnXoa.Enabled = false;
                        
                        init();
                        loadMaNSX();
                        clearForm();

                    }
                    else
                    {
                        if (isLoiKhoaNgoai)
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            var result = MessageBox.Show("Không thể xóa nhà sản xuất này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                                "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                            if (result == DialogResult.OK)
                            {
                                if (trangThai == 1)
                                {
                                    var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của nhà sản xuất này này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (result1 == DialogResult.OK)
                                    {
                                        int flag = nsxBLL.update_nhasanxuat(trangThai, MaNSX) ? 1 : 0;
                                        if (flag == 1)
                                        {
                                            MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            init() ;
                                            
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
           
        }

        private void dgvNSX_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvNSX.Columns["TrangThai"].Index && e.Value != null)
            {
                int trangThaiValue = Convert.ToInt32(e.Value);
                if (trangThaiValue == 0)
                {
                    e.Value = "Không hoạt động";
                }
                else if (trangThaiValue == 1)
                {
                    e.Value = "Hoạt động";
                }
            }
        }
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã NSX");
            cbx.Items.Add("Tên NSX");
            cbx.Items.Add("Địa chỉ");
            cbx.Items.Add("Số ĐT");
            cbxItemsMacDinh = cbx.Items[0].ToString();
        }
        private string returnDieuKien(string text)
        {
            return text;
        }
        private bool toggleDieuKien(bool value)
        {
            return !value;
        }

        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã NSX":
                    return returnDieuKien($"MaNSX like '%{searchText}%'");
                case "Tên NSX":
                    return returnDieuKien($"TenNSX like '%{searchText}%'");
                case "Địa chỉ":
                    return returnDieuKien($"DiaChi like '%{searchText}%'");
                case "Số ĐT":
                    return returnDieuKien($"SoDT like '%{searchText}%'");
                default:
                    return "";
            }
        }

        private void applySearchs(string text)
        {
            // dtSanPham = loaibill.getListLoai();
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvNSX = nsxBLL.getListNSX().DefaultView;
            dvNSX.RowFilter = currentSearch;
            dgvNSX.DataSource = dvNSX.ToTable();
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

        private void btnTimKiem_Click_1(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, genderCondition);
            combinedCondition = CombineConditions(combinedCondition, statusCondition);
            applySearchs(combinedCondition);
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    //btnTimKiem.PerformClick();
                    btnTimKiem_Click_1(sender, e);
                    e.Handled = true;
                }
            
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
           
                cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
            
        }

        private void dgvNSX_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvNSX.ClearSelection();
            dgvNSX.CurrentCell = null;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
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

        private void chkHoatDong_CheckedChanged(object sender, EventArgs e)
        {
            isHoatDong = toggleDieuKien(isHoatDong);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
        }


        private void flpFilter_Paint(object sender, PaintEventArgs e)
        {

        }



       

        private void chkKoHD_CheckedChanged(object sender, EventArgs e)
        {
            isKoHD = toggleDieuKien(isKoHD);
            UpdateStatusCondition();
            btnTimKiem.PerformClick();
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

       

        private void rjComboBox1_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, label6);
        }

        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSoDT__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorSDT(txtSoDT,label18);
           // CheckAndSetColorSDT1(txtSoDT, label18);
        }
      
        private string CheckAndSetColorSDT(RJTextBox textBox, Label label)
        {
            string text = textBox.Texts.Trim();

            if (string.IsNullOrWhiteSpace(text))
            {
                SetValidationMessage(label, "* Bạn phải nhập số ĐT");
                return null;
            }

            if (!IsValidPhoneNumber(text))
            {
                SetValidationMessage(label, "* Số điện thoại bẳng 10 hoặc 12 số");
                return null;
            }
            if (!text.StartsWith("0"))
            {
                SetValidationMessage(label, "* Số điện thoại phải có số 0 ở đầu");
                return null;
            }

            ClearValidationMessage(label);
            return text;
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length < 10 || phoneNumber.Length > 12 || !phoneNumber.All(char.IsDigit))
            {
                return false;
            }

            return true;
        }

        private void SetValidationMessage(Label label, string message)
        {
            label.ForeColor = Color.FromArgb(230, 76, 89);
            label.Text = message;
        }

        private void ClearValidationMessage(Label label)
        {
            label.ForeColor = Color.Transparent;
            label.Text = "";
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

        private string CheckAndSetColorDC(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Bạn phải nhập địa chỉ";
                    return null;
                }
                else if (int.TryParse(text, out int result))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Địa chỉ không thể chứa chữ số";
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
        private void txtDiaChi__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorDC(txtDiaChi, label15);
        }

        private void txtTenNSX__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorTen(txtTenNSX, label14);
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
                else if (text.Any(char.IsDigit))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*tên không thể chứa chữ số";
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


        private void InitializeDataGridView()
        {
            dt = new DataTable();
            dgvNSX.DataSource = dt;

            // Add columns to the DataGridView
            // Set the header text (display name) and DataPropertyName for each column
            dgvNSX.Columns.Add("Mã NSX", "Mã NSX");
            dgvNSX.Columns["Mã NSX"].DataPropertyName = "MaNSX"; // Map to DataTable column

            dgvNSX.Columns.Add("Tên NSX", "Tên NSX");
            dgvNSX.Columns["Tên NSX"].DataPropertyName = "TenNSX"; // Map to DataTable column

            dgvNSX.Columns.Add("Số điện thoại", "Số điện thoại");
            dgvNSX.Columns["Số điện thoại"].DataPropertyName = "SoDT"; // Map to DataTable column

            dgvNSX.Columns.Add("Địa Chỉ", "Địa Chỉ");
            dgvNSX.Columns["Địa Chỉ"].DataPropertyName = "DiaChi"; // Map to DataTable column

            dgvNSX.Columns.Add("Trạng Thái", "Trạng Thái");
            dgvNSX.Columns["Trạng Thái"].DataPropertyName = "TrangThai"; // Map to DataTable column

            // Set additional properties for each column
            dgvNSX.Columns["Mã NSX"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNSX.Columns["Tên NSX"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNSX.Columns["Địa Chỉ"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNSX.Columns["Số điện thoại"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNSX.Columns["Trạng Thái"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            dt.Clear();
            bool importError = false;

            OpenFileDialog open = new OpenFileDialog
            {
                Filter = "Excel Files|*.xlsx;*.xls",
                RestoreDirectory = true
            };

            if (open.ShowDialog() == DialogResult.OK)
            {
                // Get the selected Excel file path
                string filePath = open.FileName;

                // Read data from the Excel file and add it to the DataTable
                importError = ImportDataFromExcel(filePath);

                // Update the DataGridView's DataSource
                dgvNSX.DataSource = null;
                dgvNSX.DataSource = dt;

                // Set HeaderText for the existing column "Mã LOẠI"
                dgvNSX.Columns["MaNSX"].HeaderText = "Mã NSX";
                dgvNSX.Columns["TenNSX"].HeaderText = "Tên NSX";
                dgvNSX.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                dgvNSX.Columns["SoDT"].HeaderText = "Số điện thoại";
                dgvNSX.Columns["TrangThai"].HeaderText = "Trạng Thái";
            }

            // Reset AutoSizeMode for each column after importing data
            dgvNSX.Columns["MaNSX"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNSX.Columns["TenNSX"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvNSX.Columns["DiaChi"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvNSX.Columns["SoDT"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvNSX.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

           

            // Reset AutoSizeMode for each column after importing data

            if (importError)
            {
                MessageBox.Show("Dữ liệu nhập từ tệp Excel có lỗi. Vui lòng kiểm tra và thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                MessageBox.Show("Dữ liệu đã được nhập vào từ tệp Excel.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SaveDataToDatabase();
                init();
                loadMaNSX();
            }
        }

        private bool IsMaNSXExists(string maNSX)
        {
            // Lặp qua các dòng trong DataTable để kiểm tra xem mã đã tồn tại hay chưa
            foreach (DataRow row in dt.Rows)
            {
                if (row["MaNSX"].ToString() == maNSX)
                {
                    return true; // Mã đã tồn tại
                }
            }
            return false; // Mã không tồn tại
        }

        private bool ImportDataFromExcel(string filePath)
        {
            // Open the Excel file using ClosedXML
            bool importError = false;

            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheets.Worksheet(1);

                    // Read data from the Excel file and add it to the DataTable
                    for (int row = 2; row <= worksheet.RowsUsed().Count(); row++)
                    {
                        DataRow dataRow = dt.NewRow();

                        // Kiểm tra xem có trường trống không trong dòng
                        bool hasEmptyField = false;

                        for (int col = 1; col <= worksheet.ColumnsUsed().Count(); col++)
                        {
                            string cellValue = worksheet.Cell(row, col).Value.ToString().Trim();

                            if (string.IsNullOrWhiteSpace(cellValue))
                            {
                                // Thông báo hoặc xử lý theo ý muốn của bạn nếu có trường trống
                                MessageBox.Show($"Dòng {row} trong tệp Excel có trường trống ở cột {col}.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                hasEmptyField = true;
                                break;  // Dừng quá trình nhập liệu nếu có lỗi
                            }

                            // Kiểm tra xem cột "MaNSX" có chuỗi "NSX" ở đầu không
                            if (col == 1)
                            {
                                string maNSX = cellValue;

                                if (!maNSX.StartsWith("NSX"))
                                {
                                    // Thông báo hoặc xử lý theo ý muốn của bạn nếu điều kiện không được đáp ứng
                                    MessageBox.Show($"Dòng {row} trong tệp Excel không có chuỗi 'NSX' ở đầu trong cột 'MaNSX'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    hasEmptyField = true;
                                    break;  // Dừng quá trình nhập liệu nếu có lỗi
                                }
                            }

                            if (col == 2) // Check 'TenNSX'
                            {
                                string tenNSX = cellValue;

                                if (ContainsNumber(tenNSX))
                                {
                                    MessageBox.Show($"Dòng {row} trong tệp Excel có 'Tên NSX' chứa số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    hasEmptyField = true;
                                    break;
                                }
                            }

                            // Kiểm tra số điện thoại có từ 10-12 số và có số 0 ở đầu không
                            if (col == 4)
                            {
                                string soDT = cellValue;

                                if (!IsValidPhoneNumber(soDT))
                                {
                                    // Thông báo hoặc xử lý theo ý muốn của bạn nếu điều kiện không được đáp ứng
                                    MessageBox.Show($"Dòng {row} trong tệp Excel có số điện thoại không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    hasEmptyField = true;
                                    break;  // Dừng quá trình nhập liệu nếu có lỗi
                                }
                            }

                           if (col == 5) // Check 'TrangThai'
                            {
                                string trangThai = cellValue;

                                if (trangThai != "0" && trangThai != "1")
                                {
                                    MessageBox.Show($"Dòng {row} trong tệp Excel 'Trạng Thái' không hợp lệ (chỉ chấp nhận giá trị 0 hoặc 1).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    hasEmptyField = true;
                                    break;
                                }
                            }

                            dataRow[dt.Columns[col - 1].ColumnName] = cellValue;
                        }

                        if (!hasEmptyField)
                        {
                            dt.Rows.Add(dataRow);
                        }
                        else
                        {
                            importError = true;
                            break;  // Dừng quá trình nhập liệu nếu có lỗi
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi khi mở tệp Excel
                MessageBox.Show($"Đã xảy ra lỗi khi mở tệp Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                importError = true;
            }

            return importError;
        }

        private void SaveDataToDatabase()
        {
            string strconn = @"Data Source=MSI;Initial Catalog=MiniMarket1511;Integrated Security=True";
             // string strconn = @"Data Source=LAPTOP-AEI9M0MI\WIZARDSC;Initial Catalog = MiniMarket; Integrated Security = True";
            try
            {
                using (SqlConnection connection = new SqlConnection(strconn))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                        {
                            bulkCopy.DestinationTableName = "NhaSanXuat"; // Đặt tên bảng cần lưu dữ liệu

                            // Ánh xạ cột DataTable với cột trong Database
                            foreach (DataColumn column in dt.Columns)
                            {
                                bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                            }

                            // Lấy danh sách mã loại hiện tại trong cơ sở dữ liệu
                            List<string> existingMaLoaiList = GetExistingMaNSXList(connection, transaction);

                            // Chỉ lưu dữ liệu có mã loại chưa tồn tại trong cơ sở dữ liệu
                            DataTable newData = dt.AsEnumerable()
                                .Where(row => !existingMaLoaiList.Contains(row.Field<string>("MaNSX")))
                                .CopyToDataTable();

                            if (newData.Rows.Count > 0)
                            {
                                bulkCopy.WriteToServer(newData);
                            }
                        }

                        // Hoàn thành và commit giao dịch
                        transaction.Commit();
                    }
                }

                MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu dữ liệu vào cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<string> GetExistingMaNSXList(SqlConnection connection, SqlTransaction transaction)
        {
            List<string> existingMaLoaiList = new List<string>();

            using (SqlCommand command = new SqlCommand("SELECT MaNSX FROM NhaSanXuat", connection, transaction))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        existingMaLoaiList.Add(reader["MaNSX"].ToString());
                    }
                }
            }

            return existingMaLoaiList;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }

        private void ExportToExcel()
        {
            // Đường dẫn thư mục mặc định cho tệp Excel
            // Đường dẫn thư mục mặc định cho tệp Excel
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "excel");

            // Hiển thị hộp thoại chọn hoặc nhập tên tệp Excel mới
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = folderPath,
                Filter = "Excel Files|*.xlsx",
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Đường dẫn tệp Excel mới được chọn hoặc nhập
                string filePath = saveFileDialog.FileName;

                // Khởi tạo ứng dụng Excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWB = excelApp.Workbooks.Add("");
                Excel._Worksheet excelWS = excelWB.ActiveSheet;

                // Lấy dữ liệu từ DataTable (dtSanPham là DataTable của bạn)
                DataTable dt = GetData(); // Hàm GetData() là hàm lấy dữ liệu của bạn

                // Định dạng tiêu đề
                excelWS.Cells[1, 1] = "MaNSX";
                excelWS.Cells[1, 2] = "TenNSX";
                excelWS.Cells[1, 3] = "DiaChi";
                excelWS.Cells[1, 4] = "SoDT";
                excelWS.Cells[1, 5] = "TrangThai";

                // Bắt đầu từ hàng 2 để điền dữ liệu trong vòng lặp
                int currentRow = 2;

                // Export dữ liệu từ DataTable vào Excel
                foreach (DataRow row in dt.Rows)
                {
                    excelWS.Cells[currentRow, 1] = row["MaNSX"];
                    excelWS.Cells[currentRow, 2] = row["TenNSX"];
                    excelWS.Cells[currentRow, 3] = row["DiaChi"];
                    excelWS.Cells[currentRow, 4].NumberFormat = "@";
                    excelWS.Cells[currentRow, 4] = row["SoDT"].ToString();
                    excelWS.Cells[currentRow, 5] = row["TrangThai"];

                    currentRow++;
                }

                // Lưu tệp Excel với đường dẫn mới
                excelWB.SaveAs(filePath);

                // Đóng tệp Excel
                excelWB.Close(false);
                excelApp.Quit();

                // Giải phóng tài nguyên
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWB);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWS);

                // Thông báo hoàn thành
                MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }
        }
        private DataTable GetData()
        {
            // Code để lấy dữ liệu từ nguồn nào đó và trả về DataTable
            // Ví dụ: 
            dt = nsxBLL.getListNSX();
            // ... (code để điền dữ liệu vào DataTable)
            return dt;
        }
    }






}
