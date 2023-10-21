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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace GUI
{
    public partial class NhaSanXuatGUI : Form
    {

        private NhaSanXuatBLL nsxBLL;
        private DataTable dt;
        public NhaSanXuatGUI()
        {
            InitializeComponent();
            nsxBLL = new NhaSanXuatBLL();
            dt = nsxBLL.getListNSX();
            loadMaNSX();

        }
        

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String MaNSX = txtMaNSX.Texts;
            String TenNSX = txtTenNSX.Texts;
            String DiaChi = txtDiaChi.Texts;
            String SoDT = txtSoDT.Texts;
            NhaSanXuatDTO nsx = new NhaSanXuatDTO(MaNSX, TenNSX, DiaChi, SoDT);
            int flag = nsxBLL.insertNhaSanXuat(nsx) ? 1 : 0;
            if (flag == 1)
            {
                dgvNSX.DataSource = nsxBLL.getListNSX();
                MessageBox.Show("Thêm nhà sản xuất thành công thành công.",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

              
            }
            else
            {
                MessageBox.Show("Thêm nhà sản xuất thất bại",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

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
        }

        private void NhaSanXuatGUI_Load(object sender, EventArgs e)
        {
            // dgvNSX.DataSource = nsxBLL.getListNSX();
            init();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhaSanXuatDTO nsx = new NhaSanXuatDTO();
            nsx.TenNSX = txtTenNSX.Texts;
            nsx.DiaChi = txtDiaChi.Texts;
            nsx.SoDT = txtSoDT.Texts;
            nsx.MaNSX = txtMaNSX.Texts;
            nsxBLL.update_nhasanxuat(nsx);
            loadMaNSX();
            init();
            clearForm();
            
           


        }

        private void dgvNSX_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNSX.CurrentRow.Index;
            txtMaNSX.Texts = dgvNSX.Rows[i].Cells[0].Value.ToString();
            txtTenNSX.Texts = dgvNSX.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Texts = dgvNSX.Rows[i].Cells[2].Value.ToString();
            txtSoDT.Texts = dgvNSX.Rows[i].Cells[3].Value.ToString();
        }

        public void init()
        {
            dgvNSX.DataSource = nsxBLL.getListNSX();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhaSanXuatDTO nsx = new NhaSanXuatDTO();
            nsx.MaNSX = txtMaNSX.Texts;
            nsxBLL.delete_nhasanxuat(nsx);
            loadMaNSX();
            init();
            clearForm();
        }

        private void dgvNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNSX.CurrentRow.Index;
            txtMaNSX.Texts = dgvNSX.Rows[i].Cells[0].Value.ToString();
            txtTenNSX.Texts = dgvNSX.Rows[i].Cells[1].Value.ToString();
            txtDiaChi.Texts = dgvNSX.Rows[i].Cells[2].Value.ToString();
            txtSoDT.Texts = dgvNSX.Rows[i].Cells[3].Value.ToString();
        }
    }
}
