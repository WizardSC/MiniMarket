using BLL;
using GUI.MyCustom;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Information;
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
    public partial class HoaDonGUI : Form
    {
        // private XemChiTietHoaDonGUI ChiTietHD;
        private HoaDonBLL HdBLL;
        private string MaHoaDon;     // tạo biến lưu giá trị khi double click
        private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string cbxItemsMacDinh;
        private DateTime NgayTaoHD;

        private int quyenHoaDon;
        private bool isFormFilter = false;
        public HoaDonGUI(int isHoaDon)
        {
            HdBLL = new HoaDonBLL();
            InitializeComponent();
            loadDataToCBX(cbxTimKiem);
            quyenHoaDon = isHoaDon;
            checkQuyen(isHoaDon);
        }
        private void checkQuyen(int quyen)
        {
            if (quyen == 1)
            {
                btnExport.Enabled = false;
            }
        }
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã HD");
            cbx.Items.Add("Tên KH");
            cbx.Items.Add("Tên NV");
            cbxTimKiem.SelectedIndex = 0;
        }
        public void init()
        {
            dgvXemThongTinHoaDon.DataSource = HdBLL.getListXemHoaDon();

        }

        private string returnDieuKien(string text)
        {
            return text;
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã HD":
                    return returnDieuKien($"MaHD like '%{searchText}%'");
                case "Tên KH":
                    return returnDieuKien($"Ten like '%{searchText}%'");
                case "Tên NV":
                    return returnDieuKien($"Ten1  like '%{searchText}%'");

                default:
                    return "";
            }
        }

        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvHoaDon = HdBLL.getListXemHoaDon().DefaultView;
            dvHoaDon.RowFilter = currentSearch;
            dgvXemThongTinHoaDon.DataSource = dvHoaDon.ToTable();
        }
        private string CombineConditions(string condition)
        {
            if (!string.IsNullOrEmpty(condition))
            {
                return $"({condition})";
            }
            else
            {
                return "";
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Tạo một bảng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Dữ liệu");

                // Lấy dữ liệu từ DataTable
                DataTable dataTable = (DataTable)dgvXemThongTinHoaDon.DataSource; // Hãy  lấy dữ liệu thực tế

                // Số hàng và cột
                int rowCount = dataTable.Rows.Count;
                int colCount = dataTable.Columns.Count;

                // Đổ tên cột vào Excel
                for (int j = 1; j <= colCount; j++)
                {
                    // Đặt giá trị của cột hiện tại là tên cột
                    //worksheet.Cells[1, j].Value = dataTable.Columns[j - 1].ColumnName;
                    worksheet.Cells[1, j].Value = dgvXemThongTinHoaDon.Columns[j - 1].HeaderText;
                }

                // Đổ dữ liệu từ DataTable vào Excel
                for (int i = 1; i <= rowCount; i++)
                {
                    for (int j = 1; j <= colCount; j++)
                    {
                        //worksheet.Cells[i + 1, j].Value = dataTable.Rows[i - 1][j - 1];
                        if (dataTable.Columns[j - 1].DataType == typeof(DateTime))
                        {
                            // Nếu cột là kiểu dữ liệu DateTime, định dạng ngày thích hợp trước khi ghi vào Excel
                            worksheet.Cells[i + 1, j].Value = ((DateTime)dataTable.Rows[i - 1][j - 1]).ToString("dd/MM/yyyy"); ;
                        }
                        else
                        {
                            // Các kiểu dữ liệu khác thì ghi trực tiếp
                            worksheet.Cells[i + 1, j].Value = dataTable.Rows[i - 1][j - 1];
                        }
                    }
                }
                // Lưu tệp Excel
                string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string folderPath = Path.Combine(appDirectory, "resources", "fileexcel");

                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    InitialDirectory = folderPath,
                    Filter = "Excel Files|*.xlsx",
                    RestoreDirectory = true
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(file);
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            //string textTimKiem = txtTimKiem.Texts;
            //textSearchCondition = GetTextSearchCondition(textTimKiem);
            //string combinedCondition = CombineConditions(textSearchCondition);
            //applySearchs(combinedCondition);

            //// Kiểm tra xem có chọn ngày hay không
            if (chkNgay.Checked)
            {
                // Gọi hàm tìm kiếm theo ngày
                string dateCondition = GetDateSearchDate();

                // Nếu có lỗi, không tiếp tục tìm kiếm
                if (string.IsNullOrEmpty(dateCondition))
                {
                    return;
                }

                // Thực hiện tìm kiếm với điều kiện ngày
                string textTimKiem = txtTimKiem.Texts;
                string textSearchCondition = GetTextSearchCondition(textTimKiem);
                string combinedCondition = CombineConditions($"{textSearchCondition} AND {dateCondition}");
                applySearchs(combinedCondition);
            }
            else
            {
                // Thực hiện tìm kiếm thông thường nếu không chọn ngày
                string textTimKiem = txtTimKiem.Texts;
                string textSearchCondition = GetTextSearchCondition(textTimKiem);
                string combinedCondition = CombineConditions(textSearchCondition);
                applySearchs(combinedCondition);
            }

            
        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.Handled = true;
            }
        }

        private void dgvXemThongTinHoaDon_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Đặt chữ nằm ở giữa cho tất cả các cột
                dgvXemThongTinHoaDon.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            if (e.ColumnIndex == 1) // Thay yourDateColumnIndex bằng chỉ số cột ngày của bạn.
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng lại ngày thành "ngày/tháng/năm".
                    e.FormattingApplied = true;
                }
            }
        }

        private void HoaDonGUI_Load(object sender, EventArgs e)
        {
            init();
        }

        private void dgvXemThongTinHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvXemThongTinHoaDon.CurrentRow.Index;
            MaHoaDon = dgvXemThongTinHoaDon.Rows[i].Cells[0].Value.ToString();
            NgayTaoHD = DateTime.Parse(dgvXemThongTinHoaDon.Rows[i].Cells[1].Value.ToString());
            ChiTietHoaDonGUI ChiTietHD = new ChiTietHoaDonGUI(MaHoaDon,NgayTaoHD);
            ChiTietHD.ShowDialog();
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


        private string GetDateSearchDate()
        {
            DateTime startDate = dtpNgayStart.Value;
            DateTime endDate = dtpNgayEnd.Value;

            // Tạo điều kiện ngày
            return $"NgayLapHD >= '{startDate.ToString("yyyy-MM-dd")}' AND NgayLapHD <= '{endDate.ToString("yyyy-MM-dd")}'";

        }

        private void chkNgay_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra xem checkbox đã được chọn hay chưa
            if (chkNgay.Checked)
            {
                // Nếu đã chọn, hiển thị DateTimePicker cho ngày bắt đầu và kết thúc
                dtpNgayStart.Enabled = true;
                dtpNgayEnd.Enabled = true;
                btnTimKiem_Click(sender, e);
            }
            else
            {
                // Nếu không chọn, ẩn DateTimePicker
                dtpNgayStart.Enabled = false;
                dtpNgayEnd.Enabled = false;
                // Đặt lại giá trị của ngày để tránh lưu giữ giá trị trước đó
                dtpNgayStart.Value = DateTime.Now;
                dtpNgayEnd.Value = DateTime.Now;
            }
        }

        private void dtpNgayEnd_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpNgayStart.Value;
            DateTime endDate = dtpNgayEnd.Value;
            if(startDate > endDate )
            {
                lblErrTuoiFilter.Visible = true;
                btnTimKiem_Click(sender, e);
            }
            else
            {
                lblErrTuoiFilter.Visible = false;
                lblErrTuoiFilter.Visible = false;
                btnTimKiem_Click(sender, e);
            }
        }

        private void dtpNgayStart_ValueChanged(object sender, EventArgs e)
        {
            DateTime startDate = dtpNgayStart.Value;
            DateTime endDate = dtpNgayEnd.Value;
            if (startDate > endDate)
            {
                lblErrTuoiFilter.Visible = true;
                btnTimKiem_Click(sender, e);
            }
            else
            {
                lblErrTuoiFilter.Visible = false;
                lblErrTuoiFilter.Visible = false;
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
