using BLL;
using DTO;
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
    public partial class NhaCCGUI : Form
    {

        private NhaCungCapBLL nhaCC;
        public NhaCCGUI()
        {
            InitializeComponent();
            nhaCC = new NhaCungCapBLL();
            LoadForm();
        }

        private void LoadForm()
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
            int trangthai = 1;
            NhaCungCapDTO nhacc = new NhaCungCapDTO();
            nhacc.MaNCC = txtMaNCC.Texts.ToString();
            nhacc.TenNCC = txtTen.Texts.ToString();
            nhacc.DiaChi = txtDiaChi.Texts.ToString();
            nhacc.SoDT = txtSoDT.Texts.ToString();
            nhacc.SoFAX = txtSoFax.Texts.ToString();
            nhacc.TrangThai = trangthai;
            int flag = nhaCC.InsertNhaCC(nhacc) ? 1 : 0;
            if (flag == 1)
            {
                MessageBox.Show("Thêm thành công",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } else
            {
                MessageBox.Show("Thêm thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            LoadForm();
        }
        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
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
            }
            else { 
                cbxTrangThai.Texts = "Không hoạt động";
            }
        }
    }
}
