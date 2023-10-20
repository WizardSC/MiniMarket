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
    public partial class ChiTietKhuyenMaiGUI : Form
    {
         DataTable data = new DataTable();
        ChiTietKhuyenMaiBLL CTKhuyenMaiBLL = new ChiTietKhuyenMaiBLL();
        KhuyenMaiBLL KmBLL = new KhuyenMaiBLL();
        SanPhamBLL SpBLL = new SanPhamBLL();

        public ChiTietKhuyenMaiGUI()
        {
            InitializeComponent();
            loadsItemTenKM();
            loadsItemTenSp();
            
           
            
        }

        public void loadsItemTenKM()
        {
            data = KmBLL.getListDsKm();
            cbxTenKM.DataSource = data;
            cbxTenKM.DisplayMember = "TenKM";
            cbxTenKM.SelectedIndex = -1;
           
        }
        public void loadsItemTenSp()
        {
            data = SpBLL.getListSanPham();
            cbxTenSp.DataSource = data;
            cbxTenSp.DisplayMember = "TenSP";
            cbxTenSp.SelectedIndex = -1;

        }


        private void ChiTietKhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            dgvChiTietKM.DataSource = CTKhuyenMaiBLL.getListDsCTKm();
        }

        private void dgvChiTietKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
}
