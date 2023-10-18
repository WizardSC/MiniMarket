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
        private KhuyenMaiGUI KmGUI;
        public ThongTinSPKMGUI(KhuyenMaiGUI KmGUI,string MaKM)
        {
            InitializeComponent();
            kmBLL = new KhuyenMaiBLL();
            this.KmGUI = KmGUI;
            dgvThongTinSPKM.DataSource = kmBLL.getThongTinSPKM(MaKM);
        }
    }
}
