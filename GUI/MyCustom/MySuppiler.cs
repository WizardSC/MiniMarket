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
    public partial class MySuppiler : UserControl
    {
        public event EventHandler ItemClicked;
        private void OnItemClicked()
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
            
        }
        public MySuppiler()
        {
            InitializeComponent();
            pnItem.Click += Panel_Click;
            lblNhaCungCap.Click += Label_Click;
        }

        public void Panel_Click(object sender, EventArgs e)
        {
            OnItemClicked();
        }
        private void Label_Click(object sender, EventArgs e)
        {
            OnItemClicked();
        }
    }
}
