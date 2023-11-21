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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using ClosedXML.Excel;
using System.Data.SqlClient;

namespace GUI
{

    public partial class LoaiGUI : Form
    {
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

        private bool isFormFilter = false;

        private LoaiBLL loaibill;
        private DataTable dt;
        private List<LoaiDTO> listLoai;
        //private LoaiDTO loaidto;
        public LoaiGUI()
        {
            InitializeComponent();
            loaibill = new LoaiBLL();
            dt = loaibill.getListLoai();
            loadMaLoai();
            clearForm();
            unhideError();
        }
        private void unhideError()
        {
            label13.ForeColor = Color.Transparent;
            label15.ForeColor = Color.Transparent;
            label3.ForeColor = Color.Transparent;
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
     
        private void loadMaLoai()
        {
            string maLoai;

            loaibill = new LoaiBLL();
            maLoai = loaibill.getMaxMaLoai();
            if (maLoai == "")
            {
                txtMaLoai.Texts = "L001";
            }
            int tempNum = int.Parse(maLoai.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaLoai.Texts = "L0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaLoai.Texts = "L00" + (tempNum + 1).ToString();
            }
        }

        public void clearForm()
        {

            loadMaLoai();
            init();
            txtTenLoai.Texts = "";
            cbxTrangThai.Text = "Hoạt Động";
        }

        private void LoaiGUI_Load(object sender, EventArgs e)
        {
            loadDataToCBX(cbxTimKiem);
            loadMaLoai();
            init();
            
        }
        public void init()
        {
            
            dgvLoai.DataSource = loaibill.getListLoai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string MaLoai = CheckAndSetColor(txtMaLoai, label13);
            string TenLoai = CheckAndSetColor(txtTenLoai, label15);
            string trangThai = CheckAndSetColor(cbxTrangThai, label3);
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            if (!(MaLoai != "" && TenLoai != "" && trangThai != ""))
            {
                return;
            }
            LoaiDTO LSP = new LoaiDTO(MaLoai, TenLoai, trangThaiValue);
            int flag = loaibill.insert_LoaiSP(LSP) ? 1 : 0;
            if (flag == 1)
            {

                MessageBox.Show("Thêm loại thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loadMaLoai();
                init();
                clearForm();

            }
            else
            {
                MessageBox.Show("Thêm loại thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                init();
            }

        }

        private void dgvLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLoai.CurrentRow.Index;
            txtMaLoai.Texts = dgvLoai.Rows[i].Cells[0].Value.ToString();
            txtTenLoai.Texts = dgvLoai.Rows[i].Cells[1].Value.ToString();
            int trangThaiValue = Convert.ToInt32(dgvLoai.Rows[i].Cells[2].Value);
            cbxTrangThai.SelectedItem = (trangThaiValue == 0) ? "Không hoạt động" : "Hoạt động";
        }

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            btnSua.Enabled = true;
            btnSua.BackgroundColor = Color.White;
            btnSua.BackColor = Color.White;
            
            btnXoa.Enabled = true;
            btnXoa.BackgroundColor = Color.White;
            btnXoa.BackColor = Color.White;

            btnThem.Enabled = false;
            btnThem.BackgroundColor = Color.DimGray;
            btnThem.BackColor = Color.DimGray;

            int i = dgvLoai.CurrentRow.Index;
            txtMaLoai.Texts = dgvLoai.Rows[i].Cells[0].Value.ToString();
            txtTenLoai.Texts = dgvLoai.Rows[i].Cells[1].Value.ToString();
            int trangThaiValue = Convert.ToInt32(dgvLoai.Rows[i].Cells[2].Value);
            cbxTrangThai.SelectedItem = (trangThaiValue == 0) ? "Không hoạt động" : "Hoạt động";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiDTO LSP = new LoaiDTO();
            LSP.TenLoai = txtTenLoai.Texts;
            LSP.MaLoai = txtMaLoai.Texts;
            string trangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            LSP.TrangThaiLoai = trangThaiValue;

            int kq = loaibill.update_LoaiSP(LSP) ? 1 : 0;
            if (kq == 1)
            {
                init();
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
               


            }
            else
            {
                init();
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            //nsx.Trangthai = cbxTrangThai.Texts;



        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {

            string MaLoai = txtMaLoai.Texts;
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
       
                if (trangThai == 0)
                {
                var choice2 = MessageBox.Show("Xóa loại này này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice2 == DialogResult.Yes)
                {
                    bool isLoiKhoaNgoai;
                    if (loaibill.delete_LoaiSP(MaLoai, out isLoiKhoaNgoai))
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
                        btnSua.BackgroundColor = Color.DimGray;
                        btnSua.BackColor = Color.DimGray;

                        btnXoa.BackgroundColor = Color.DimGray;
                        btnXoa.BackColor = Color.DimGray;
                        init();
                        loadMaLoai();
                        clearForm();




                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa loại sản phẩm này vì có tồn tại khóa ngoại",
                          "Thông báo",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
                     
                        init();
                        clearForm();
                    }
                }
                    


                }
                else
            {
                var choice = MessageBox.Show("Xóa loại này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (choice == DialogResult.Yes)
                {
                    bool isLoiKhoaNgoai;
                    bool kq = loaibill.delete_LoaiSP(MaLoai, out isLoiKhoaNgoai);
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
                        btnSua.BackgroundColor = Color.DimGray;
                        btnSua.BackColor = Color.DimGray;

                        btnXoa.BackgroundColor = Color.DimGray;
                        btnXoa.BackColor = Color.DimGray;
                        init();
                        loadMaLoai();
                        clearForm();

                    }
                    else
                    {
                        if (isLoiKhoaNgoai)
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            var result = MessageBox.Show("Không thể xóa loại sản phẩm này vì có dữ liệu liên quan đến sản phẩm trong hệ thống. " +
                                "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                            if (result == DialogResult.OK)
                            {
                                if (trangThai == 1)
                                {
                                    var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của loại sản phẩm này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                                    if (result1 == DialogResult.OK)
                                    {
                                        int flag = loaibill.update_LoaiSP(trangThai, MaLoai) ? 1 : 0;
                                        if (flag == 1)
                                        {
                                            MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                           
                                            init();
                                           
                                        }
                                        else
                                        {
                                            MessageBox.Show("Thay đổi trạng thái thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            init();
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

        private void dgvLoai_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgvLoai.Columns["TrangThai"].Index && e.Value != null)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnThem.BackgroundColor = Color.White;
            btnThem.BackColor = Color.White;

            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.BackgroundColor = Color.DimGray;
            btnSua.BackColor = Color.DimGray;

            btnXoa.BackgroundColor = Color.DimGray;
            btnXoa.BackColor = Color.DimGray;
            loadMaLoai();
            clearForm();
        }
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã LOẠI");
            cbx.Items.Add("TÊN LOẠI");
            cbxItemsMacDinh = cbx.Items[0].ToString();
        }
        private string returnDieuKien(string text)
        {
            return text;
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã LOẠI":
                    return returnDieuKien($"MaLoai like '%{searchText}%'");
                case "TÊN LOẠI":
                    return returnDieuKien($"TenLoai like '%{searchText}%'");
                default:
                    return "";
            }
        }




        private void applySearchs(string text)
        {
            // dt = loaibill.getListLoai();
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvLoai = loaibill.getListLoai().DefaultView;
            dvLoai.RowFilter = currentSearch;
            dgvLoai.DataSource = dvLoai.ToTable();
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
        /* private string CombineConditions(string condition1)
         {
             if (!string.IsNullOrEmpty(condition1))
             {
                 return $"({condition1})";
             }
             return "";
         }*/


        private void dgvLoai_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLoai.ClearSelection();
            dgvLoai.CurrentCell = null;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition, genderCondition);
            combinedCondition = CombineConditions(combinedCondition, statusCondition);
            applySearchs(combinedCondition);
        }
        private void txtTimKiem_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                btnTimKiem_Click(sender, e);
                e.Handled = true;
            }
        }

        private bool toggleDieuKien(bool value)
        {
            return !value;
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

                // Lấy dữ liệu từ DataTable (dt là DataTable của bạn)
                DataTable dt = GetData(); // Hàm GetData() là hàm lấy dữ liệu của bạn

                // Định dạng tiêu đề
                excelWS.Cells[1, 1] = "MaLoai";
                excelWS.Cells[1, 2] = "TenLoai";
                excelWS.Cells[1, 3] = "TrangThai";

                // Bắt đầu từ hàng 2 để điền dữ liệu trong vòng lặp
                int currentRow = 2;

                // Export dữ liệu từ DataTable vào Excel
                foreach (DataRow row in dt.Rows)
                {
                    excelWS.Cells[currentRow, 1] = row["MaLoai"];
                    excelWS.Cells[currentRow, 2] = row["TenLoai"];
                    excelWS.Cells[currentRow, 3] = row["TrangThai"];

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
            dt = loaibill.getListLoai();
            // ... (code để điền dữ liệu vào DataTable)
            return dt;
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            
        }
        private void InitializeDataGridView()
        {
            dt = new DataTable();
            dgvLoai.DataSource = dt;

            // Add columns to the DataGridView
            // Set the header text (display name) and DataPropertyName for each column
            dgvLoai.Columns.Add("Mã LOẠI", "Mã LOẠI");
            dgvLoai.Columns["Mã LOẠI"].DataPropertyName = "MaLoai"; // Map to DataTable column

            dgvLoai.Columns.Add("TÊN LOẠI", "TÊN LOẠI");
            dgvLoai.Columns["TÊN LOẠI"].DataPropertyName = "TenLoai"; // Map to DataTable column

            dgvLoai.Columns.Add("Trạng Thái", "Trạng Thái");
            dgvLoai.Columns["Trạng Thái"].DataPropertyName = "TrangThai"; // Map to DataTable column

            // Set additional properties for each column
            dgvLoai.Columns["Mã LOẠI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dgvLoai.Columns["TÊN LOẠI"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvLoai.Columns["Trạng Thái"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            dt.Clear();

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
                bool importError = ImportDataFromExcel(filePath);

                // Update the DataGridView's DataSource only if there is no import error
                if (!importError)
                {
                    dgvLoai.DataSource = null;
                    dgvLoai.DataSource = dt;

                    // Set HeaderText for the existing column "Mã LOẠI"
                    dgvLoai.Columns["MaLoai"].HeaderText = "Mã LOẠI";
                    dgvLoai.Columns["TenLoai"].HeaderText = "TÊN LOẠI";
                    dgvLoai.Columns["TrangThai"].HeaderText = "Trạng Thái";

                    // Reset AutoSizeMode for each column after importing data
                    dgvLoai.Columns["MaLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvLoai.Columns["TenLoai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvLoai.Columns["TrangThai"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                    MessageBox.Show("Dữ liệu đã được nhập vào từ tệp Excel.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Save data to the database
                    SaveDataToDatabase();
                }
            }
        }

        private bool ImportDataFromExcel(string filePath)
        {
            bool importError = false;

            try
            {
                // Open the Excel file using ClosedXML
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheets.Worksheet(1);

                    // Read data from the Excel file and add it to the DataTable
                    for (int row = 2; row <= worksheet.RowsUsed().Count(); row++)
                    {
                        DataRow dataRow = dt.NewRow();
                        dataRow["MaLoai"] = worksheet.Cell(row, 1).Value.ToString();
                        dataRow["TenLoai"] = worksheet.Cell(row, 2).Value.ToString();
                        dataRow["TrangThai"] = worksheet.Cell(row, 3).Value.ToString();

                        // Check if MaLoai already exists in the DataTable
                        string maLoai = dataRow["MaLoai"].ToString();
                        if (IsMaLoaiExists(maLoai))
                        {
                            MessageBox.Show($"Dòng {row} trong tệp Excel có 'MaLoai' đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            importError = true;
                            break;  // Stop the import process if there is an error
                        }

                        dt.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the error when opening the Excel file
                MessageBox.Show($"Đã xảy ra lỗi khi mở tệp Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                importError = true;
            }

            return importError;
        }

        private bool IsMaLoaiExists(string maLoai)
        {
            // Check if MaLoai already exists in the DataTable
            foreach (DataRow row in dt.Rows)
            {
                if (row["MaLoai"].ToString() == maLoai)
                {
                    return true;
                }
            }

            return false;
        }
        private void SaveDataToDatabase()
        {
            string strconn = @"Data Source=MSI;Initial Catalog=MiniMarket1511;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(strconn))
                {
                    connection.Open();

                    using (SqlTransaction transaction = connection.BeginTransaction())
                    {
                        using (SqlBulkCopy bulkCopy = new SqlBulkCopy(connection, SqlBulkCopyOptions.Default, transaction))
                        {
                            bulkCopy.DestinationTableName = "LoaiSP"; // Đặt tên bảng cần lưu dữ liệu

                            // Ánh xạ cột DataTable với cột trong Database
                            foreach (DataColumn column in dt.Columns)
                            {
                                bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                            }

                            // Lấy danh sách mã loại hiện tại trong cơ sở dữ liệu
                            List<string> existingMaLoaiList = GetExistingMaLoaiList(connection, transaction);

                            // Chỉ lưu dữ liệu có mã loại chưa tồn tại trong cơ sở dữ liệu
                            DataTable newData = dt.AsEnumerable()
                                .Where(row => !existingMaLoaiList.Contains(row.Field<string>("MaLoai")))
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

        private List<string> GetExistingMaLoaiList(SqlConnection connection, SqlTransaction transaction)
        {
            List<string> existingMaLoaiList = new List<string>();

            using (SqlCommand command = new SqlCommand("SELECT MaLoai FROM LoaiSP", connection, transaction))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        existingMaLoaiList.Add(reader["MaLoai"].ToString());
                    }
                }
            }

            return existingMaLoaiList;
        }
        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, label3);
        }

        private void txtTenLoai__TextChanged(object sender, EventArgs e)
        {
            CheckAndSetColorTen(txtTenLoai, label15);
        }

        private string CheckAndSetColorTen(object control, Label label)
        {
            if (control is RJTextBox textBox)
            {
                string text = textBox.Texts.Trim();
                if (string.IsNullOrWhiteSpace(text))
                {
                    label.ForeColor = Color.FromArgb(230, 76, 89);
                    label.Text = "*Bạn phải nhập loại";
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
    }

}





















