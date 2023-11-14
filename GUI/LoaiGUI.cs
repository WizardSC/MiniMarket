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

            string newMaLoai;
            string lastMaLoai = null;

            foreach (DataRow row in dt.Rows)
            {
                lastMaLoai = row["MaLoai"].ToString();
            }

            int nextNumber = 1;

            if (!string.IsNullOrEmpty(lastMaLoai))
            {
                // Nếu có dữ liệu, tìm giá trị lớn nhất và tăng lên 1
                int tempNum = int.Parse(lastMaLoai.Substring(1)) + 1;
                nextNumber = tempNum;
            }

            // Kiểm tra xem mã mới đã tồn tại hay chưa
            while (dt.AsEnumerable().Any(row => row["MaLoai"].ToString() == "L" + nextNumber.ToString("D3")))
            {
                nextNumber++;
            }

            newMaLoai = "L" + nextNumber.ToString("D3");
            txtMaLoai.Texts = newMaLoai;

            /*string lastMaLoai = null;
            foreach (DataRow row in dt.Rows)
            {
                lastMaLoai = row["MaLoai"].ToString();
            }
            if (lastMaLoai == "")
            {
                txtMaLoai.Texts = "L001";
            }
            int tempNum = int.Parse(lastMaLoai.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaLoai.Texts = "L0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaLoai.Texts = "L00" + (tempNum + 1).ToString();
            }*/
        }

        private void loadMaLoai12()
        {

            string lastMaLoai = txtMaLoai.Texts;

            // Kiểm tra xem lastMaLoai đã tồn tại trong danh sách hay chưa
            if (dt.AsEnumerable().Any(row => row["MaLoai"].ToString() == lastMaLoai))
            {
                int nextNumber = 1;

                // Nếu có dữ liệu, tìm giá trị lớn nhất và tăng lên 1
                if (dt.Rows.Count > 0)
                {
                    int tempNum = int.Parse(dt.AsEnumerable().Max(row => row["MaLoai"].ToString()).Substring(1)) + 1;
                    nextNumber = tempNum;
                }

                // Kiểm tra xem mã mới đã tồn tại hay chưa
                while (dt.AsEnumerable().Any(row => row["MaLoai"].ToString() == "L" + nextNumber.ToString("D3")))
                {
                    nextNumber++;
                }

                string newMaLoai = "L" + nextNumber.ToString("D3");
                txtMaLoai.Texts = newMaLoai;
            }
        }
            public void clearForm()
        {
            loadMaLoai12();
            init();
            txtTenLoai.Texts = "";
            cbxTrangThai.Text = "Hoạt Động";
        }

        private void LoaiGUI_Load(object sender, EventArgs e)
        {
            loadDataToCBX(cbxTimKiem);
            init();
        }
        public void init()
        {
            dgvLoai.DataSource = loaibill.getListLoai();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String MaLoai = CheckAndSetColor(txtMaLoai, label13);
            String TenLoai = CheckAndSetColor(txtTenLoai, label15);
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

                MessageBox.Show("Thêm loại thành công thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loadMaLoai12();
                dgvLoai.DataSource = loaibill.getListLoai();
                clearForm();

            }
            else
            {
                MessageBox.Show("Thêm loại thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
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
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                init();


            }
            else
            {
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
                var choice1 = MessageBox.Show("Đã chuyển về không hoạt động", "Thông báo");
                clearForm();

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
                        init();
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
            clearForm();
        }
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("MÃ LOẠI");
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
                case "MÃ LOẠI":
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
            /*DataObject copydata = dgvLoai.GetClipboardContent();
            if (copydata != null) Clipboard.SetDataObject(copydata);
            Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
            xlapp.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook xlWbook;
            Microsoft.Office.Interop.Excel.Workbook xlsheet;
            object miseddata = System.Reflection.Missing.Value;
            xlWbook = xlapp.Workbooks.Add(miseddata);

            xlsheet = (Microsoft.Office.Interop.Excel.Worksheet)xlWbook.Worksheets.get_Item(1);
            Microsoft.Office.Interop.Excel.Range xlr = (Microsoft.Office.Interop.Excel.Range)xlsheet.Cells[1, 1];
            xlr.Select();
            xlsheet.PasteSpecial(xlr, Type.Missing, , true);*/


            /* Excel.Application excelApp = new Excel.Application();
             Excel.Workbook excelWB = excelApp.Workbooks.Add("");
             Excel._Worksheet excelWS = excelWB.ActiveSheet;
             excelWS.Cells[1, 1] = "First Name";
             excelWS.Cells[1, 2] = "Last Name";
             excelWS.Cells[2, 1] = "Azhar";
             excelWS.Cells[2, 2] = "Jamal";
             excelWB.SaveCopyAs(@"C:\Users\Admin\Documents\GitHub\MiniMarket\GUI\resources\fileexcel\writeDataFile.xlsx");
             excelWB.Close();
             excelApp.Quit();*/
            //  using Excel = Microsoft.Office.Interop.Excel;

            // Khởi tạo danh sách loại (thay thế dòng này bằng danh sách thực tế của bạn)

            /* List<LoaiDTO> loai = listLoai;
             dt = loaibill.getListLoai();
             // Khởi tạo ứng dụng Excel
             Excel.Application excelApp = new Excel.Application();
             Excel.Workbook excelWB = excelApp.Workbooks.Add("");
             Excel._Worksheet excelWS = excelWB.ActiveSheet;

             // Định dạng tiêu đề (nếu cần)
             excelWS.Cells[1, 1] = "Mã Loại";
             excelWS.Cells[1, 2] = "Tên Loại";
             excelWS.Cells[1, 3] = "Trạng Thái";

             // Bắt đầu từ hàng 2 để điền dữ liệu trong vòng lặp

             // Vòng lặp để thêm dữ liệu
             int currentRow = 2; // Bắt đầu từ hàng 2 để điền dữ liệu trong vòng lặp

             foreach (DataRow row in dt.Rows)
             {
                 excelWS.Cells[currentRow, 1] = row["MaLoai"];
                 excelWS.Cells[currentRow, 2] = row["TenLoai"];

                 // Kiểm tra giá trị của cột "TrangThai" và hiển thị tương ứng
                 if (row["TrangThai"].ToString() == "1")
                 {
                     excelWS.Cells[currentRow, 3] = "Hoạt Động";
                 }
                 else
                 {
                     excelWS.Cells[currentRow, 3] = "Không Hoạt Động";
                 }

                 // Tăng chỉ số hàng
                 currentRow++;
             }




            // string filePath = @"C:\Users\Admin\Documents\GitHub\MiniMarket\GUI\resources\fileexcel\writeDataFile.xlsx";

             // Lưu tệp Excel và đóng ứng dụng Excel
             excelWB.SaveAs(filePath);
             excelWB.Close();
             excelApp.Quit();

             // Giải phóng tài nguyên
             System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
             System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWB);
             System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWS);

             // Thông báo hoàn thành
             MessageBox.Show("Dữ liệu đã được xuất ra tệp Excel.", "Hoàn thành", MessageBoxButtons.OK, MessageBoxIcon.Information);


             */


            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            // folderBrowserDialog.Description = "Chọn thư mục đầu ra";
            //folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;


            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                // Lấy tên tệp Excel từ textbox hoặc từ bất kỳ nguồn dữ liệu nào khác
                string namefile = rjtFile.Texts; // Kiểm tra tên tệp từ textbox của bạn

                // Kết hợp đường dẫn và tên tệp để tạo đường dẫn đầy đủ
                string filePath = Path.Combine(selectedFolderPath, namefile + ".xlsx");

                // Bắt đầu tạo tệp Excel
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWB = excelApp.Workbooks.Add("");
                Excel._Worksheet excelWS = excelWB.ActiveSheet;

                // Định dạng tiêu đề
                excelWS.Cells[1, 1] = "Mã Loại";
                excelWS.Cells[1, 2] = "Tên Loại";
                excelWS.Cells[1, 3] = "Trạng Thái";

                // Bắt đầu từ hàng 2 để điền dữ liệu trong vòng lặp
                int currentRow = 2;

                // Export dữ liệu từ DataTable vào Excel
                foreach (DataRow row in dt.Rows)
                {
                    excelWS.Cells[currentRow, 1] = row["MaLoai"];
                    excelWS.Cells[currentRow, 2] = row["TenLoai"];
                    excelWS.Cells[currentRow, 3] = row["TrangThai"];

                    // Kiểm tra giá trị của cột "TrangThai" và hiển thị tương ứng
                    /*  if (row["TrangThai"].ToString() == "1")
                      {
                          excelWS.Cells[currentRow, 3] = "Hoạt Động";
                      }
                      else
                      {
                          excelWS.Cells[currentRow, 3] = "Không Hoạt Động";
                      }*/

                    // Tăng chỉ số hàng
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
            else
            {
                Console.WriteLine("Không có thư mục nào được chọn.");
            }
            /*System.Configuration.ConfigurationManager.AppSettings["ExcelPackage.LicenseContext"] = "NonCommercial";


            try
            {
                List<LoaiDTO> loai = listLoai;

                using (var package = new ExcelPackage())
                {
                    var worksheet = package.Workbook.Worksheets.Add("Loai");

                    worksheet.Cells["A1"].Value = "Mã Loại";
                    worksheet.Cells["B1"].Value = "Tên Loại";
                    worksheet.Cells["C1"].Value = "Trạng Thái";

                    int row = 2; // Bắt đầu từ hàng 2 để điền dữ liệu
                    foreach (var docloai in loai)
                    {
                        worksheet.Cells["A" + row].Value = docloai.MaLoai;
                        worksheet.Cells["B" + row].Value = docloai.TenLoai;
                        worksheet.Cells["C" + row].Value = docloai.TrangThaiLoai;
                        row++;
                    }

                    var filePath = @"C:\Users\Admin\Documents\GitHub\MiniMarket\GUI\resources\fileexcel\Loai.xlsx";
                    package.SaveAs(filePath);

                    MessageBox.Show("Xuất file than", "Thông báo");


                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ:
                Console.WriteLine("Đã xảy ra lỗi: " + ex.Message);
            }*/
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            folderBrowserDialog.Description = "Chọn một thư mục";
            folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Thư mục gốc
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Thư mục mặc định

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn đến thư mục được chọn
                string selectedFolderPath = folderBrowserDialog.SelectedPath;

                string namefile = rjtFile.Text; // Lấy tên file từ TextBox

                // Tạo đường dẫn đến tệp trong thư mục được chọn
                string filePath = Path.Combine(selectedFolderPath, namefile);

                Console.WriteLine("Đường dẫn đến tệp đã chọn: " + filePath);
            }
            else
            {
                Console.WriteLine("Không có thư mục nào được chọn.");
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWB = excelApp.Workbooks.Open(filePath);
                Excel.Worksheet excelWS = excelWB.ActiveSheet;

                // Xóa tất cả các hàng
                /* dgvLoai.Rows.Clear();

                 // Xóa tất cả các cột
                 while (dgvLoai.Columns.Count > 0)
                 {
                     dgvLoai.Columns.RemoveAt(0);
                 }*/
                dgvLoai.Rows.Clear();

                // Xóa tất cả các cột hiện có trong DataGridView
                dgvLoai.Columns.Clear();

                // Tạo một DataTable để chứa dữ liệu từ Excel
                DataTable dt = new DataTable();

                // Đọc tiêu đề từ Excel và thêm các cột vào DataGridView
                /*   for (int col = 1; col <= excelWS.UsedRange.Columns.Count; col++)
                   {
                       string header = excelWS.Cells[1, col].Value;
                       dgvLoai.Columns.Add(header, header);
                   }

                   // Đọc dữ liệu từ Excel và đổ vào DataGridView
                   for (int row = 2; row <= excelWS.UsedRange.Rows.Count; row++)
                   {
                       dgvLoai.Rows.Add();
                       for (int col = 1; col <= dgvLoai.Columns.Count; col++)
                       {
                           dgvLoai.Rows[row - 2].Cells[col - 1].Value = excelWS.Cells[row, col].Value;
                       }
                   }*/
                for (int col = 1; col <= excelWS.UsedRange.Columns.Count; col++)
                {
                    string header = excelWS.Cells[1, col].Value;
                    dt.Columns.Add(header, typeof(string));
                }

                // Đọc dữ liệu từ Excel và thêm vào DataTable
                for (int row = 2; row <= excelWS.UsedRange.Rows.Count; row++)
                {
                    DataRow newRow = dt.NewRow();
                    for (int col = 1; col <= dt.Columns.Count; col++)
                    {
                        newRow[col - 1] = excelWS.Cells[row, col].Value;
                    }
                    dt.Rows.Add(newRow);
                }

                // Đóng tệp Excel
                excelWB.Close(false);
                excelApp.Quit();
            }

            /*  OpenFileDialog openFileDialog = new OpenFileDialog();
              openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";

              if (openFileDialog.ShowDialog() == DialogResult.OK)
              {
                  string filePath = openFileDialog.FileName;

                  Excel.Application excelApp = new Excel.Application();
                  Excel.Workbook excelWB = excelApp.Workbooks.Open(filePath);
                  Excel.Worksheet excelWS = excelWB.ActiveSheet;

                  int currentRow = dgvLoai.Rows.Count;

                  // Đọc tiêu đề từ Excel và thêm các cột vào DataGridView nếu cột đó chưa tồn tại
                  for (int col = 1; col <= excelWS.UsedRange.Columns.Count; col++)
                  {
                      string header = excelWS.Cells[1, col].Value;
                      if (!dgvLoai.Columns.Cast<DataGridViewColumn>().Any(x => x.HeaderText == header))
                      {
                          dgvLoai.Columns.Add(header, header);
                      }
                  }

                  // Đọc dữ liệu từ Excel và thêm vào DataGridView
                  for (int row = 2; row <= excelWS.UsedRange.Rows.Count; row++)
                  {
                      dgvLoai.Rows.Add();
                      for (int col = 1; col <= dgvLoai.Columns.Count; col++)
                      {
                          dgvLoai.Rows[currentRow].Cells[col - 1].Value = excelWS.Cells[row, col].Value;
                      }
                      currentRow++;
                  }

                  // Đóng tệp Excel
                  excelWB.Close(false);
                  excelApp.Quit();

                  // Giải phóng tài nguyên
                  System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                  System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWB);
                  System.Runtime.InteropServices.Marshal.ReleaseComObject(excelWS);
              }*/
        }
        private void cbxTrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckAndSetColor(cbxTrangThai, label3);
        }
    }

}





















