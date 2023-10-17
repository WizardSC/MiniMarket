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
        private ThongTinSPKMGUI ThongTinSPKM;
        private DataTable dt;

        public KhuyenMaiGUI()
        {
            InitializeComponent();
            kmBLL = new KhuyenMaiBLL();
            CTKhuyenMai = new ChiTietKhuyenMaiGUI();
            ThongTinSPKM = new ThongTinSPKMGUI();
            dt = kmBLL.getListDsKm();
            loadMaKM();
        }

        private void loadMaKM()
        {
            string lastMaKM = null;
            foreach (DataRow row in dt.Rows)
            {
                lastMaKM = row["MaKM"].ToString();
            }
            if (lastMaKM == "")
            {
                txtMaKM.Texts = "KM001";
            }
            int tempNum = int.Parse(lastMaKM.Substring(2));
            if ((tempNum + 1) >= 10)
            {
                txtMaKM.Texts = "KM0" + (tempNum + 1).ToString();
            }
            else if (tempNum >= 1 && tempNum < 9)
            {
                txtMaKM.Texts = "KM00" + (tempNum + 1).ToString();
            }
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
            txtPhanTramKM.Texts = dgvKhuyenMai.Rows[i].Cells[4].Value.ToString();
            txtDkKM.Texts = dgvKhuyenMai.Rows[i].Cells[5].Value.ToString();
            int TrangThai = int.Parse(dgvKhuyenMai.Rows[i].Cells[6].Value.ToString());
            if(TrangThai == 1)
            {
                cbxTrangThai.SelectedIndex = 0;
            }
            else
            {
                cbxTrangThai.SelectedIndex = 1;
            }

            if(txtDkKM.Texts == "")
            {
                btnThongTinKM.Visible = true;
            }
            else
            {
                btnThongTinKM.Visible = false;
            }
  
        }

        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            dgvKhuyenMai.DataSource = kmBLL.getListDsKm();
            cbxTrangThai.SelectedIndex = 0;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            CTKhuyenMai.ShowDialog();
            
        }

        private void cbxTrangThai_OnSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            loadMaKM();
            txtTenKm.Texts = "";
            txtDkKM.Texts = "";
            DateTime currentDate = DateTime.Now;
            dtpNgayBD.Value = currentDate;
            dtpNgayKT.Value = currentDate;
            txtPhanTramKM.Texts = "";
            cbxTrangThai.SelectedIndex = 0;
            btnThongTinKM.Visible = false;
        }

        private void btnThongTinKM_Click(object sender, EventArgs e)
        {
            ThongTinSPKM.ShowDialog();
        }
    }
}
