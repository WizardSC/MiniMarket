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
    public partial class MiniKhachHangGUI : Form
    {
        public string hoTenKH;
        private KhachHangBLL khBLL;
        private DataTable dtKhachHang;
        public int diemTL;
        public MiniKhachHangGUI()
        {
            InitializeComponent();
            khBLL = new KhachHangBLL();
            dtKhachHang = khBLL.getMiniListKhachHang();
            dgvKhachHang.DataSource = dtKhachHang;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            hoTenKH = txtHoTen.Texts;
            this.Close();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhachHang.CurrentRow.Index;
            txtMaKH.Texts = dgvKhachHang.Rows[i].Cells[0].Value.ToString();
            string hoTenPart1 = dgvKhachHang.Rows[i].Cells[1].Value.ToString();
            string hoTenPart2 = dgvKhachHang.Rows[i].Cells[2].Value.ToString();
            string hoTen = hoTenPart1 + " " + hoTenPart2;          
            txtHoTen.Texts = hoTen;
            diemTL = int.Parse(dgvKhachHang.Rows[i].Cells[3].Value.ToString());
        }
    }
}
