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
    public partial class MiniNCCGUI : Form
    {
        private NhaCungCapBLL nccBLL;
        private DataTable dt;
        public string maNCC { get; set; }

        public MiniNCCGUI()
        {
            InitializeComponent();
            nccBLL = new NhaCungCapBLL();
            dt = nccBLL.getListNCCMini();
            dgvNhaCungCap.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            maNCC = txtMaNCC.Texts;
            this.Close();
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvNhaCungCap.CurrentRow.Index;
            txtMaNCC.Texts = dgvNhaCungCap.Rows[i].Cells[0].Value.ToString();
            txtTenNCC.Texts = dgvNhaCungCap.Rows[i].Cells[1].Value.ToString();

        }
    }
}
