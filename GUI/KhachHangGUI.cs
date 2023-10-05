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

    public partial class KhachHangGUI : Form
    {
        private bool isFormFilter = false;

        public KhachHangGUI()
        {
            InitializeComponent();
        }


        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            isFormFilter = !isFormFilter;
            if (isFormFilter)
            {
                flpFilter.Visible = true;
            } else
            {
                flpFilter.Visible = false;
            }

        }
    }
}
