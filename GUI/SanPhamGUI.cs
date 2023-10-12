using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSanPham.ClearSelection();
            dgvSanPham.CurrentCell = null;
        }

        private void btnUploadAnh_Click(object sender, EventArgs e)
        {
            string appDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string folderPath = Path.Combine(appDirectory, "resources", "image", "SanPham");
            OpenFileDialog open = new OpenFileDialog
            {
                InitialDirectory = folderPath,
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                RestoreDirectory = true
            };
            if (open.ShowDialog() == DialogResult.OK)
            {
                pbImage.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;

                pbImage.Tag = txtMaKH.Texts;
                Console.WriteLine(pbImage.Tag);

            }
        }
    }
}
