using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class ChiTietKhuyenMaiGUI : Form
    {
         DataTable data = new DataTable();
        ChiTietKhuyenMaiBLL CTKhuyenMaiBLL = new ChiTietKhuyenMaiBLL();
        KhuyenMaiBLL KmBLL = new KhuyenMaiBLL();
        SanPhamBLL SpBLL = new SanPhamBLL();
        private string cbxItemsMacDinh;
        private string currentSearch;
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm

        public ChiTietKhuyenMaiGUI()
        {
            InitializeComponent();
            loadsItemTenKM();
            loadsItemTenSp();
            loadDataToCBX(cbxTimKiem);



        }
        //load tenkm
        public void loadsItemTenKM()
        {
            data = KmBLL.getListMaKmNoDK();
            cbxTenKM.DataSource = data;
            cbxTenKM.DisplayMember = "TenKM";
            cbxTenKM.Texts = "--Chọn tên km--";

        }
        //load tensp
        public void loadsItemTenSp()
        {
            data = SpBLL.getListSanPham();
            cbxTenSp.DataSource = data;
            cbxTenSp.DisplayMember = "TenSP";
            cbxTenSp.Texts = "--Chọn tên sp--";

        }
        //load combobox timkiem
        private void loadDataToCBX(RJComboBox cbx)
        {
            cbx.Items.Add("Mã KM");
            cbx.Items.Add("Mã SP");
            cbx.Items.Add("Tên KM");
            cbx.Items.Add("Tên SP");
            cbx.Items.Add("Phần Trăm KM");
            cbxTimKiem.SelectedIndex = 0;
        }

        private string returnDieuKien(string text)
        {
            return text;
        }
        private string GetTextSearchCondition(string searchText)
        {
            switch (cbxItemsMacDinh)
            {
                case "Mã KM":
                    return returnDieuKien($"MaKM like '%{searchText}%'");
                case "Mã SP":
                    return returnDieuKien($"MaSP like '%{searchText}%'");
                case "Tên KM":
                    return returnDieuKien($"TenKM like '%{searchText}%'");
                case "Tên SP":
                    return returnDieuKien($"TenSP like '%{searchText}%'");
                case "Phần Trăm KM":
                    int phanTramKM;
                    if (int.TryParse(searchText, out phanTramKM))
                    {
                        return returnDieuKien($"PhanTramKM = {phanTramKM}");
                    }
                    else
                    {
                        return "";
                    }
                default:
                    return "";
            }
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

        private void applySearchs(string text)
        {
            currentSearch = text;
            Console.WriteLine(currentSearch);
            DataView dvCTKhuyenMai = CTKhuyenMaiBLL.getListDsCTKm().DefaultView;
            dvCTKhuyenMai.RowFilter = currentSearch;
            dgvChiTietKM.DataSource = dvCTKhuyenMai.ToTable();
        }

        
        public void init()
        {
            dgvChiTietKM.DataSource = CTKhuyenMaiBLL.getListDsCTKm();

            cbxTrangThai.SelectedIndex=0;
            // Gán sự kiện CellFormatting
            dgvChiTietKM.CellFormatting += dgvChiTietKM_CellFormatting;
        }

        public void clearForm()
        {
            txtPhanTramKM.Texts = " ";
        }

        private void ChiTietKhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            init();
        }

        private void dgvChiTietKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string textTimKiem = txtTimKiem.Texts;
            textSearchCondition = GetTextSearchCondition(textTimKiem);
            string combinedCondition = CombineConditions(textSearchCondition);
            applySearchs(combinedCondition);
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnTimKiem.PerformClick();
                e.Handled = true;
            }
        }

        private void btnThemCTKM_Click(object sender, EventArgs e)
        {
            string tenKM = cbxTenKM.Texts;
            
            string tenSp = cbxTenSp.Texts;
            // Lấy ID khuyen mai từ tên khuyenmai
            string idKm = "KM000"; // Giá trị mặc định nếu không tìm thấy
           
            data = KmBLL.getListDsKm();
            foreach (DataRow row in data.Rows)
            {
                if (row["TenKM"].ToString() == tenKM)
                {
                    idKm = row["MaKM"].ToString();
                    break; // Thoát vòng lặp khi tìm thấy ID
                }
            }
            string idSp = "SP000";
            data = SpBLL.getListSanPham();
            foreach (DataRow row in data.Rows)
            {
                if (row["TenSP"].ToString() == tenSp)
                {
                    idSp = row["MaSP"].ToString();
                    break; // Thoát vòng lặp khi tìm thấy ID
                }
            }


            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;
            ChiTietKhuyenMaiDTO CTKM_DTO = new ChiTietKhuyenMaiDTO();
            CTKM_DTO.Makm = idKm;
            CTKM_DTO.Masp = idSp;
            CTKM_DTO.PhanTramKm = int.Parse(txtPhanTramKM.Texts);
            CTKM_DTO.TrangThai = trangthai;

            try
            {
                CTKhuyenMaiBLL.insertCTKhuyenMai(CTKM_DTO);
                MessageBox.Show("Thêm khuyến mãi cho sản phẩm thành công!");
                init();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }


        }

        private void btnUpdateKM_Click(object sender, EventArgs e)
        {
            string tenKM = cbxTenKM.Texts;

            string tenSp = cbxTenSp.Texts;
            // Lấy ID khuyen mai từ tên khuyenmai
            string idKm = ""; // Giá trị mặc định nếu không tìm thấy

            DataTable data1 = KmBLL.getListMaKmNoDK();
            foreach (DataRow row in data1.Rows)
            {
                if (row["TenKM"].ToString() == tenKM)
                {
                    idKm = row["MaKM"].ToString();
                    break; // Thoát vòng lặp khi tìm thấy ID
                }
            }
            string idSp = "";
            data = SpBLL.getListSanPham();
            foreach (DataRow row in data.Rows)
            {
                if (row["TenSP"].ToString() == tenSp)
                {
                    idSp = row["MaSP"].ToString();
                    break; // Thoát vòng lặp khi tìm thấy ID
                }
            }
            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;

            ChiTietKhuyenMaiDTO CTKM_DTO = new ChiTietKhuyenMaiDTO();
            CTKM_DTO.Makm = idKm;
            CTKM_DTO.Masp = idSp;
            CTKM_DTO.PhanTramKm = int.Parse(txtPhanTramKM.Texts);
            CTKM_DTO.TrangThai = trangthai;
            
            try
            {
                CTKhuyenMaiBLL.UpdateCTKhuyenMai(CTKM_DTO);
                MessageBox.Show("Cập nhật khuyến mãi cho sản phẩm thành công!");
                init();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void btnXoaKM_Click(object sender, EventArgs e)
        {

            string tenKM = cbxTenKM.Texts;

            string tenSp = cbxTenSp.Texts;
            // Lấy ID khuyen mai từ tên khuyenmai
            string idKm = ""; // Giá trị mặc định nếu không tìm thấy

            DataTable data1 = KmBLL.getListMaKmNoDK();
            foreach (DataRow row in data1.Rows)
            {
                if (row["TenKM"].ToString() == tenKM)
                {
                    idKm = row["MaKM"].ToString();
                    break; // Thoát vòng lặp khi tìm thấy ID
                }
            }
            string idSp = "";
            data = SpBLL.getListSanPham();
            foreach (DataRow row in data.Rows)
            {
                if (row["TenSP"].ToString() == tenSp)
                {
                    idSp = row["MaSP"].ToString();
                    break; // Thoát vòng lặp khi tìm thấy ID
                }
            }
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();

            ChiTietKhuyenMaiDTO CTKM_DTO = new ChiTietKhuyenMaiDTO();

            CTKM_DTO.Makm = idKm;
            CTKM_DTO.Masp = idSp;
            try
            {
                CTKhuyenMaiBLL.deleteCTKhuyenMai(CTKM_DTO);
                MessageBox.Show("Xoa khuyến mãi cho sản phẩm thành công!");
                init();
                clearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }

        }

        private void btnRS_Click(object sender, EventArgs e)
        {

        }

        private void dgvChiTietKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvChiTietKM.CurrentRow.Index;
            txtPhanTramKM.Texts = dgvChiTietKM.Rows[i].Cells[4].Value.ToString();
            int TrangThai = int.Parse(dgvChiTietKM.Rows[i].Cells[5].Value.ToString());
            if (TrangThai == 1)
            {
                cbxTrangThai.SelectedIndex = 0;
            }
            else
            {
                cbxTrangThai.SelectedIndex = 1;
            }

            // tenkm
            string tenkm = dgvChiTietKM.Rows[i].Cells[2].Value.ToString();
            int IndexKM = -1;

            foreach (DataRowView item in cbxTenKM.Items)
            {
                string itemText = item.Row["TenKM"].ToString();

                if (tenkm == itemText)
                {
                    IndexKM = cbxTenKM.Items.IndexOf(item);
                    break;
                }
            }

            if (IndexKM != -1)
            {
                cbxTenKM.SelectedIndex = IndexKM;
            }

            // tensp
            string tensp = dgvChiTietKM.Rows[i].Cells[3].Value.ToString();
            int IndexSP = -1;

            foreach (DataRowView item in cbxTenSp.Items)
            {
                string itemSp = item.Row["TenSP"].ToString();

                if (tensp == itemSp)
                {
                    IndexSP = cbxTenSp.Items.IndexOf(item);
                    break;
                }
            }

            if (IndexSP != -1)
            {
                cbxTenSp.SelectedIndex = IndexSP;
            }
            MessageBox.Show(IndexSP.ToString());
        }

        private void dgvChiTietKM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5) // Thay 4 bằng chỉ số cột thứ 5 (chú ý: chỉ số cột bắt đầu từ 0).
            {
                if (e.Value != null && e.Value is int)
                {
                    int value = (int)e.Value;
                    if (value == 1)
                    {
                        e.Value = "Hoạt động";
                    }
                    else if (value == 0)
                    {
                        e.Value = "Không hoạt động";
                    }
                    e.FormattingApplied = true;
                }
            }
            if (e.Value != null)
            {
                // Đặt chữ nằm ở giữa cho tất cả các cột
                dgvChiTietKM.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
    
}
