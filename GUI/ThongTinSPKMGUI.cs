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
    public partial class ThongTinSPKMGUI : Form
    {
        private KhuyenMaiBLL kmBLL;
        public ThongTinSPKMGUI()
        {
            InitializeComponent();
            kmBLL = new KhuyenMaiBLL();
        }
        private void ThongTinSPKMGUI_Load(object sender, EventArgs e)
        {
            dgvThongTinSPKM.DataSource = kmBLL.getThongTinSPKM();

        }
    }
}
