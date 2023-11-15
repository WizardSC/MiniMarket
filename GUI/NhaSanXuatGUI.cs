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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

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

            //  String MaNSX = txtMaNSX.Texts;
            String MaNSX = CheckAndSetColor(txtMaNSX, label13);
            String TenNSX = CheckAndSetColor(txtTenNSX, label14);
            String DiaChi = CheckAndSetColor(txtDiaChi, label15);
            String SoDT = CheckAndSetColor(txtSoDT, label18);
            String trangThai = CheckAndSetColor(cbxTrangThai, label6);
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
                    dgvNSX.DataSource = nsxBLL.getListNSX();

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
            string lastMaNSX = null;
            foreach (DataRow row in dt.Rows)
            {
                lastMaNSX = row["MaNSX"].ToString();
            }
            if (lastMaNSX == "")
            {
                txtMaNSX.Texts = "NSX001";
            }
            int tempNum = int.Parse(lastMaNSX.Substring(3));
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
        }

        private void NhaSanXuatGUI_Load(object sender, EventArgs e)
        {
            // dgvNSX.DataSource = nsxBLL.getListNSX();
            loadDataToCBX(cbxTimKiem);
            init();
        }

       private void btnSua_Click(object sender, EventArgs e)
        {
            NhaSanXuatDTO nsx = new NhaSanXuatDTO();
            nsx.TenNSX = txtTenNSX.Texts;
            nsx.DiaChi = txtDiaChi.Texts;
            nsx.SoDT = txtSoDT.Texts;
            nsx.MaNSX = txtMaNSX.Texts;
            string trangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThaiValue = (trangThai == "Hoạt động") ? 1 : 0;
            nsx.TrangThaiNSX = trangThaiValue;

            //nsx.Trangthai = cbxTrangThai.Texts;
            int kq = nsxBLL.update_nhasanxuat(nsx) ? 1 : 0;
            if (kq == 1)
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                loadMaNSX();
                init();
                clearForm();

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
                        init();
                        clearForm();




                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhà sản xuất này vì có tồn tại khóa ngoại",
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
                        init();
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
            // dt = loaibill.getListLoai();
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
    }





}
