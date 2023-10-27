using BLL;
using DTO;
using OfficeOpenXml.FormulaParsing.ExpressionGraph.FunctionCompilers;
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
    public partial class NhaCCGUI : Form
    {

        private NhaCungCapBLL nhaCC;
        public NhaCCGUI()
        {
            InitializeComponent();
            nhaCC = new NhaCungCapBLL();
            cbxTrangThai.Items.Add("Hoạt động");
            cbxTrangThai.Items.Add("Không hoạt động");
            LoadForm();
        }
        private void loadMaNCC()
        {
            DataTable dsNhaCC = nhaCC.getListNCC();
            string lastMaNCC = null;
            foreach (DataRow row in dsNhaCC.Rows)
            {
                lastMaNCC = row["MaNCC"].ToString();
            }
            if (lastMaNCC == "")
            {
                txtMaNCC.Texts = "NCC001";
            }
            int tempNum = int.Parse(lastMaNCC.Substring(3));
            if ((tempNum + 1) >= 10)
            {
                txtMaNCC.Texts = "NCC0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaNCC.Texts = "NCC00" + (tempNum + 1).ToString();
            }
        }
        private void LoadForm()
        {
            DataTable dsNhaCC = nhaCC.getListNCC();
            loadMaNCC();
            dgvNhaCC.DataSource = dsNhaCC;

        }
        private void dgvNhaCC_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == dgvNhaCC.Columns["TrangThai"].Index && e.Value != null)
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
        private void NhaCC_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int FullTxt = 0;
            if (cbxTrangThai.SelectedIndex == -1)
            {
                lbltrangThai.Visible = true;
                FullTxt += 1;
            }
            else
            {
                FullTxt -= 1;
                lbltrangThai.Visible = false;
            }
            if (string.IsNullOrWhiteSpace(txtTen.Texts))
            {
                lblten.Visible = true;
                FullTxt += 1;
            }
            else
            {
                FullTxt -= 1;
                lblten.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(txtDiaChi.Texts))
            {
                lbldiaChi.Visible = true;
                FullTxt += 1;
            }
            else
            {
                FullTxt -= 1;
                lbldiaChi.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDT.Texts))
            {
                lblsoDT.Visible = true;
                FullTxt += 1;
            }
            else
            {
                FullTxt -= 1;
                lblsoDT.Visible = false;
            }

            if (string.IsNullOrWhiteSpace(txtSoFax.Texts))
            {
                lblsoFax.Visible = true;
                FullTxt += 1;
            }
            else
            {
                FullTxt -= 1;
                lblsoFax.Visible = false;
            }

            
            NhaCungCapDTO nhacc = new NhaCungCapDTO();
            if (FullTxt <=  0)
            {
                string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
                int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
                nhacc.MaNCC = txtMaNCC.Texts.ToString();
                nhacc.TenNCC = txtTen.Texts.ToString();
                nhacc.DiaChi = txtDiaChi.Texts.ToString();
                nhacc.SoDT = txtSoDT.Texts.ToString();
                nhacc.SoFAX = txtSoFax.Texts.ToString();
                nhacc.TrangThai = trangThai;
               
                if (nhaCC.InsertNhaCC(nhacc))
                {
                    MessageBox.Show("Thêm thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        loadMaNCC();
                        reset();
                        LoadForm();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại",
                        "Lỗi",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

            }
            
        }
        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            reset();
            int i = dgvNhaCC.CurrentRow.Index;
            txtMaNCC.Texts = dgvNhaCC.Rows[i].Cells[0].Value.ToString();
            txtTen.Texts = dgvNhaCC.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Texts = dgvNhaCC.Rows[i].Cells[2].Value.ToString();
            txtSoDT.Texts = dgvNhaCC.Rows[i].Cells[3].Value.ToString();
            txtSoFax.Texts = dgvNhaCC.Rows[i].Cells[4].Value.ToString();
            String trangthai = dgvNhaCC.Rows[i].Cells[5].Value.ToString();
            int intTrangThai = int.Parse(trangthai);
            Console.WriteLine(intTrangThai);
            if (intTrangThai == 1)
            {
                cbxTrangThai.Texts = "Hoạt động";
                cbxTrangThai.SelectedIndex = 0;
            }
            else { 
                cbxTrangThai.Texts = "Không hoạt động";
                cbxTrangThai.SelectedIndex = 1;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Texts.ToString();
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;
            var choice = MessageBox.Show("Xóa nhà cung cấp này? "+ trangThai, "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (choice == DialogResult.Yes)
            {
                bool isLoiKhoaNgoai;
                bool kq = nhaCC.deleteNhaCC(ma, out isLoiKhoaNgoai);
                if (kq)
                {
                    MessageBox.Show("Xóa thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Information);
                      reset();
                      LoadForm();
                        
                }
                else
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    var result = MessageBox.Show("Không thể xóa nhà cung cấp này vì có dữ liệu liên quan đến nhà cung cấp trong hệ thống. " +
                        "Vui lòng xóa các dữ liệu liên quan trước khi tiếp tục", "Lỗi", buttons, MessageBoxIcon.Error);
                    if (result == DialogResult.OK)
                    {
                        if (trangThai == 1)
                        {
                            var result1 = MessageBox.Show("Bạn có muốn thay đổi trạng thái của nhà cung cấp này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (result1 == DialogResult.OK)
                            {
                                if (nhaCC.updateTrangThai(ma, 0))
                                {
                                    MessageBox.Show("Thay đổi trạng thái thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    LoadForm();
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMaNCC.Texts.ToString();
            string ten = txtTen.Texts.ToString();
            string diachi = txtDiaChi.Texts.ToString();
            string sdt = txtSoDT.Texts.ToString();
            string fax = txtSoFax.Texts.ToString();
            string stringTrangThai = cbxTrangThai.SelectedItem.ToString();
            int trangThai = (stringTrangThai == "Hoạt động") ? 1 : 0;

            NhaCungCapDTO nhacc = new NhaCungCapDTO(ma,ten,diachi,sdt,fax,trangThai);
            if (nhaCC.updateNhaCC(nhacc))
            {
                MessageBox.Show("Sửa thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    LoadForm();
            }
            else
            {
                MessageBox.Show("Sửa thất bại",
                   "Lỗi",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
            }
            
        }
        private void reset()
        {
            loadMaNCC();
            txtTen.Texts = "";
            txtDiaChi.Texts = "";
            txtSoDT.Texts = "";
            txtSoFax.Texts = "";
            cbxTrangThai.SelectedIndex = -1;
            string trangthaibandau = "-- Chọn trạng thái --";
            cbxTrangThai.SelectedItem = trangthaibandau;

            lblten.Visible = false;
            lbldiaChi.Visible = false;
            lblsoDT.Visible = false;
            lblsoFax.Visible = false;
            lbltrangThai.Visible = false;
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
