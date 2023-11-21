using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.MyCustom
{
    public partial class MyProductItem : UserControl
    {
        public event EventHandler ItemClicked;
        public string maLoai;
        public MyProductItem()
        {
            InitializeComponent();
            pnItem.Click += pnItem_Click;
            lblMaSP.Click += Label_Click;
            lblTenSP.Click += Label_Click;
            lblDonGia.Click += Label_Click;
            pbxIMG.Click += pbxIMG_Click;

        }
        private void Label_Click(object sender, EventArgs e)
        {
            OnItemClicked();
        }

        private void pnItem_Click(object sender, EventArgs e)
        {
            OnItemClicked();
        }
        private void OnItemClicked()
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblMaSP_Click(object sender, EventArgs e)
        {
            OnItemClicked();

        }

        private void lblDonGia_Click(object sender, EventArgs e)
        {
            OnItemClicked();

        }

        private void lblTenSP_Click(object sender, EventArgs e)
        {
            OnItemClicked();

        }

        private void pbxIMG_Click(object sender, EventArgs e)
        {
            OnItemClicked();

        }
    }
}
