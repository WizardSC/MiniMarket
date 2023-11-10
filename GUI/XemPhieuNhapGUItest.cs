using BLL;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class XemPhieuNhapGUItest : Form
    {
        private PhieuNhapT_BLL PnBLL;
        private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string cbxItemsMacDinh;
        public XemPhieuNhapGUItest()
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
            Console.WriteLine(123);
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.Handled = true;
            }
        }
    }
}
