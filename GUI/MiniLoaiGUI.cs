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
    public partial class MiniLoaiGUI : Form
    {
        public string maLoai { get; set; }
        private LoaiBLL loaiBLL;
        private DataTable dt;
        public MiniLoaiGUI()
        {
            InitializeComponent();
            loaiBLL = new LoaiBLL();
            dt = loaiBLL.getListLoaiMini();
        }

        

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            maLoai = txtMaLoai.Texts;
            this.Close();
        }
        private void MiniLoaiGUI_Load(object sender, EventArgs e)
        {
            dgvLoai.DataSource = dt;
            
        }
        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvLoai.ClearSelection();
            dgvLoai.CurrentCell = null;
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void dgvLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvLoai.CurrentRow.Index;
            Console.WriteLine(i);
            txtMaLoai.Texts = dgvLoai.Rows[i].Cells[0].Value.ToString();
            txtTenLoai.Texts = dgvLoai.Rows[i].Cells[1].Value.ToString();
        }
    }
}
