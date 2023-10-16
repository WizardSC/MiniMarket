using BLL;
using GUI.MyCustom;
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
    public partial class KhuyenMaiGUI : Form
    {
        private KhuyenMaiBLL kmBLL;
        private ChiTietKhuyenMaiGUI CTKhuyenMai;
        
        public KhuyenMaiGUI()
        {
            InitializeComponent();
            kmBLL = new KhuyenMaiBLL();
            CTKhuyenMai = new ChiTietKhuyenMaiGUI();
        }

        private void dgvKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhuyenMai.CurrentRow.Index;
            DateTime NgayBd = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[2].Value.ToString());
            DateTime NgayKt = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[3].Value.ToString());

            txtMaKM.Texts = dgvKhuyenMai.Rows[i].Cells[0].Value.ToString();
            txtTenKm.Texts = dgvKhuyenMai.Rows[i].Cells[1].Value.ToString();
            dtpNgayBD.Value = NgayBd;
            dtpNgayKT.Value = NgayKt;
            txtDkKM.Texts = dgvKhuyenMai.Rows[i].Cells[4].Value.ToString();
            txtPhanTramKM.Texts = dgvKhuyenMai.Rows[i].Cells[5].Value.ToString();
            int TrangThai = int.Parse(dgvKhuyenMai.Rows[i].Cells[6].Value.ToString());
  
        }

        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            dgvKhuyenMai.DataSource = kmBLL.getListDsKm();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            CTKhuyenMai.ShowDialog();
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
