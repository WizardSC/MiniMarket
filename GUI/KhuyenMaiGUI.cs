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
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            btnThongTinKM.Visible = false;
            kmBLL = new KhuyenMaiBLL();
            CTKhuyenMai = new ChiTietKhuyenMaiGUI();
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

        public void clearForm()
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
       
        private void dgvKhuyenMai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvKhuyenMai.CurrentRow.Index;
            txtMaKM.Texts = dgvKhuyenMai.Rows[i].Cells[0].Value.ToString();
            DateTime NgayBd = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[2].Value.ToString());
            DateTime NgayKt = DateTime.Parse(dgvKhuyenMai.Rows[i].Cells[3].Value.ToString());
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
        //load form DataTable
        public void init()
        {
            dgvKhuyenMai.DataSource = kmBLL.getListDsKm();

            cbxTrangThai.SelectedIndex = 0;
        }
        private void KhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            init();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
           CTKhuyenMai.ShowDialog();
            
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void btnThongTinKM_Click(object sender, EventArgs e)
        {
            string MaKM = txtMaKM.Texts;
            //// Truyền MaKM sang Form ThongTinSPKMGUI và mở Form đó
            //ThongTinSPKMGUI ThongTin = new ThongTinSPKMGUI(this, MaKM);
            //ThongTin.Show();
            DataTable dataTable = kmBLL.getThongTinSPKM(MaKM);
            if (dataTable != null && dataTable.Rows.Count > 0)
            {
                ThongTinSPKMGUI ThongTin = new ThongTinSPKMGUI(this, MaKM);
                ThongTin.Show();
            }
            else
            {
                MessageBox.Show("Khuyến mãi này chưa áp dụng cho sản phẩm nào.");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;
            KhuyenMaiDTO KM_DTO = new KhuyenMaiDTO();
            KM_DTO.Makm = txtMaKM.Texts;
            KM_DTO.TenKm = txtTenKm.Texts; ;
            KM_DTO.NgayBd = dtpNgayBD.Value;
            KM_DTO.NgayKt = dtpNgayKT.Value;
            KM_DTO.PhanTramKm= int.Parse(txtPhanTramKM.Texts);
            KM_DTO.DieuKiemKm = txtDkKM.Texts;
            KM_DTO.TrangThai = trangthai;
            kmBLL.insertKhuyenMai(KM_DTO);
            loadMaKM();
            init();
            clearForm();
        }

            private void btnSua_Click(object sender, EventArgs e)
            {
            string CheckTrangThai = cbxTrangThai.Texts.ToString();
            int trangthai = (CheckTrangThai == "Hoạt động") ? 1 : 0;
            KhuyenMaiDTO KM_DTO = new KhuyenMaiDTO();

            KM_DTO.TenKm = txtTenKm.Texts; ;
            KM_DTO.NgayBd = dtpNgayBD.Value;
            KM_DTO.NgayKt = dtpNgayKT.Value;
            KM_DTO.PhanTramKm = int.Parse(txtPhanTramKM.Texts);
            KM_DTO.DieuKiemKm = txtDkKM.Texts;
            KM_DTO.TrangThai = trangthai;
            KM_DTO.Makm = txtMaKM.Texts;
            kmBLL.UpdateKhuyenMai(KM_DTO);
            loadMaKM();
            init();
            clearForm();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            KhuyenMaiDTO KM_DTO = new KhuyenMaiDTO();
            KM_DTO.Makm = txtMaKM.Texts;
            kmBLL.DeleteKhuyenMai(KM_DTO);
            loadMaKM();
            init();
            clearForm();
        }
    }
}
