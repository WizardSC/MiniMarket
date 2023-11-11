using BLL;
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
    public partial class MiniNSXGUI : Form
    {
        public string maNSX { get; set; }
        private LoaiBLL loaiBLL;
        private NhaSanXuatBLL nsxBLL;
        private DataTable dt;
        public MiniNSXGUI()
        {
            InitializeComponent();
            nsxBLL = new NhaSanXuatBLL();
            dt = nsxBLL.getListNSX();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            maNSX = txtMaNSX.Texts;
            this.Close();
        }

        private void MiniNSXGUI_Load(object sender, EventArgs e)
        {
            dgvNhaSanXuat.DataSource = dt;

        }

        private void dgvNhaSanXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhaSanXuat.CurrentRow.Index;
            txtMaNSX.Texts = dgvNhaSanXuat.Rows[i].Cells[0].Value.ToString();
            txtTenNSX.Texts = dgvNhaSanXuat.Rows[i].Cells[1].Value.ToString();
           // txtDiaChi.Texts = dgvNhaSanXuat.Rows[i].Cells[2].Value.ToString();

        }

        private void dgvNhaSanXuat_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvNhaSanXuat.ClearSelection();
            dgvNhaSanXuat.CurrentCell = null;
        }
    }
}
