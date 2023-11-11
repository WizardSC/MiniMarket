using BLL;
using GUI.MyCustom;
using OfficeOpenXml;
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
    public partial class XemPhieuNhapGUI : Form
    {
        private PhieuNhapT_BLL PnBLL;
        private XemChiTietPhieuNhapGUI ChiTietPN;
        private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string cbxItemsMacDinh;
        private string MaPhieuNhap;     // tạo biến lưu giá trị khi double click
        private string TenNhaCungCap;
        private DateTime NgayTaoPN;
        public XemPhieuNhapGUI()
        {
            InitializeComponent();
            PnBLL = new PhieuNhapT_BLL();
            loadDataToCBX(cbxTimKiem);
        }

        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã PN");
            cbx.Items.Add("Tên NV");
            cbx.Items.Add("Tên NCC");
            cbxTimKiem.SelectedIndex = 0;
        }
        //load form DataTable
        public void init()
        {
            dgvThongTinPhieuNhap.DataSource = PnBLL.getListDsPhieuNhap();

        }

        //timkiem 
        private string returnDieuKien(string text)
        {
            return text;
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã PN":
                    return returnDieuKien($"MaPN like '%{searchText}%'");
                case "Tên NV":
                    return returnDieuKien($"Ten like '%{searchText}%'");
                case "Tên NCC":
                    return returnDieuKien($"TenNCC  like '%{searchText}%'");

                default:
                    return "";
            }
        }

        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvPhieuNhap = PnBLL.getListDsPhieuNhap().DefaultView;
            dvPhieuNhap.RowFilter = currentSearch;
            dgvThongTinPhieuNhap.DataSource = dvPhieuNhap.ToTable();
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
        private void XemPhieuNhapGUI_Load(object sender, EventArgs e)
        {
            init();
            // Gán sự kiện CellFormatting
           // dgvThongTinPhieuNhap.CellFormatting += dgvThongTinPhieuNhap_CellFormatting;
        }

        private void dgvThongTinPhieuNhap_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value != null)
            {
                // Đặt chữ nằm ở giữa cho tất cả các cột
                dgvThongTinPhieuNhap.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition);
            applySearchs(combinedCondition);
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

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Tạo một bảng ExcelPackage
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                // Tạo một worksheet mới
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Dữ liệu");

                // Lấy dữ liệu từ DataTable
                DataTable dataTable = (DataTable)dgvThongTinPhieuNhap.DataSource; // Hãy  lấy dữ liệu thực tế
                

                // Số hàng và cột
                int rowCount = dataTable.Rows.Count;
                int colCount = dataTable.Columns.Count;

                // Đổ tên cột vào Excel
                for (int j = 1; j <= colCount; j++)
                {
                    // Đặt giá trị của cột hiện tại là tên cột
                    worksheet.Cells[1, j].Value = dataTable.Columns[j - 1].ColumnName;
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
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Lưu tệp Excel";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(saveFileDialog.FileName);
                    excelPackage.SaveAs(file);
                    MessageBox.Show("Xuất Excel thành công!");
                }
            }
        }

        private void dgvThongTinPhieuNhap_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvThongTinPhieuNhap.CurrentRow.Index;
            MaPhieuNhap = dgvThongTinPhieuNhap.Rows[i].Cells[0].Value.ToString();
            NgayTaoPN = DateTime.Parse(dgvThongTinPhieuNhap.Rows[i].Cells[1].Value.ToString());
            TenNhaCungCap = dgvThongTinPhieuNhap.Rows[i].Cells[4].Value.ToString();
            XemChiTietPhieuNhapGUI ChiTietPN = new XemChiTietPhieuNhapGUI(MaPhieuNhap, NgayTaoPN, TenNhaCungCap);
            ChiTietPN.ShowDialog();
        }
    }
}
