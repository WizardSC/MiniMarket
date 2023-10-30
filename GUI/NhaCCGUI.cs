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
    public partial class NhaCCGUI : Form
    {
        NhaCungCapBLL nccBLL;
        DataTable dt;
        public NhaCCGUI()
        {
            nccBLL = new NhaCungCapBLL();
            dt = nccBLL.getListNCC();
            InitializeComponent();
        }

        private void NhaCC_Load(object sender, EventArgs e)
        {
            dgvNhaCC.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
