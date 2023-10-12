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
    public partial class SanPhamGUI : Form
    {
        private SanPhamBLL spBLL;
        public SanPhamGUI()
        {
            spBLL = new SanPhamBLL();
            InitializeComponent();
        }

        private void SanPhamGUI_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = spBLL.getListSanPham();
        }
    }
}
