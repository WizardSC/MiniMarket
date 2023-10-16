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
        private ChiTietKhuyenMaiBLL CTKhuyenMaiBLL;
        public ChiTietKhuyenMaiGUI()
        {
            InitializeComponent();
            CTKhuyenMaiBLL = new ChiTietKhuyenMaiBLL();
        }

        private void dgvChiTietKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChiTietKhuyenMaiGUI_Load(object sender, EventArgs e)
        {
            dgvChiTietKM.DataSource = CTKhuyenMaiBLL.getListDsCTKm();
        }
    }
    
}
