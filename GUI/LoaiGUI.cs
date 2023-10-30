using BLL;
using DTO;
using GUI.MyCustom;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{

    public partial class LoaiGUI : Form
    {
        private string cbxItemsMacDinh;
        private string statusCondition = "";
        private string textSearchCondition = ""; // Biến để lưu trữ điều kiện từ textbox tìm kiếm
        private string genderCondition = ""; // Biến để lưu trữ điều kiện từ checkbox "Giới Tính"
        private string currentSearch;
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
        private void loadMaLoai()
        {
            string lastMaLoai = null;
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
            }
        }
        public void clearForm()
        {
            loadMaLoai();
            txtTenLoai.Texts = "";
            cbxTrangThai.Text = "--Chọn trạng thái--";
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
            String MaLoai = CheckAndSetColor(txtMaLoai,label13);
            String TenLoai = CheckAndSetColor(txtTenLoai,label15);
            string trangThai = CheckAndSetColor(cbxTrangThai,label3);
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            if (!(MaLoai != "" && TenLoai != "" && trangThai != "" ))
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
                case "Mã Loại":
                    return returnDieuKien($"MaLoai like '%{searchText}%'");
                case "Tên Loại":
                    return returnDieuKien($"TenLoai like '%{searchText}%'");
                default:
                    return "";
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
             

             string textTimKiem = txtTimKiem.Texts;
             textSearchCondition = GetTextSearchCondition(textTimKiem);
             string combinedCondition = CombineConditions(textSearchCondition, genderCondition);
             applySearchs(combinedCondition);
        }

        private void txtTimKiem_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //btnTimKiem.PerformClick();
                btnTimKiem_Click(sender, e);
                e.Handled = true;
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
        private string CombineConditions(string condition1)
        {
            if (!string.IsNullOrEmpty(condition1))
            {
                return $"({condition1})";
            }
            else if (!string.IsNullOrEmpty(condition1))
            {
                return condition1;
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
        /* private void cbxTimKiem_OnSelectedIndexChanged(object sender, EventArgs e)
{
    cbxItemsMacDinh = cbxTimKiem.SelectedItem.ToString();
}

private string GetTextSearchCondition(string searchText)
{
    string columnName = "";

    switch (cbxItemsMacDinh)
    {
        case "Mã Loại":
            columnName = "MALOAI";
            break;
        case "Tên Loại":
            columnName = "TENLOAI";
            break;
        default:
            return "";
    }

    return $"{columnName} like '%{searchText}%'";
}

private void btnTimKiem_Click(object sender, EventArgs e)
{
    string textTimKiem = txtTimKiem.Texts;
    textSearchCondition = GetTextSearchCondition(textTimKiem);
    applySearchs(textSearchCondition);
}

private void txtTimKiem_KeyPress_1(object sender, KeyPressEventArgs e)
{
    if (e.KeyChar == (char)Keys.Enter)
    {
        btnTimKiem_Click(sender, e);
        e.Handled = true;
    }
}

private void applySearchs(string text)
{
    currentSearch = text;
    Console.WriteLine(currentSearch);
    DataView dvLoai = loaibill.getListLoai().DefaultView;
    dvLoai.RowFilter = currentSearch;
    dgvLoai.DataSource = dvLoai.ToTable();
}*/



    }

}
