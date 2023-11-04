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
    public partial class NhapHangGUI : Form
    {
        private int currentScrollPosition = 0;
        private NhapHangBLL nhBLL;
        private NhaCungCapBLL nccBLL;
        private DataTable dtSanPham;
        private DataTable dtNhaCungCap;
        public NhapHangGUI()
        {
            InitializeComponent();
            nhBLL = new NhapHangBLL();
            nccBLL = new NhaCungCapBLL();
            dtSanPham = nhBLL.getListNhapHang();
            dtNhaCungCap = nccBLL.getListNCC();
            dgvSanPham.DataSource = dtSanPham;
            loadToFlpNhaCungCap();
        }

        private void loadToFlpNhaCungCap()
        {
            this.flpNhaCungCap.Controls.Clear();
            for (int i = 0; i < dtNhaCungCap.Rows.Count; i++)
            {
                MyCustom.MySuppiler item = new MyCustom.MySuppiler();
                item.lblNhaCungCap.Text = dtNhaCungCap.Rows[i]["TenNCC"].ToString();

                item.Margin = new Padding(6, 0, 6, 0);
                this.flpNhaCungCap.Controls.Add(item);
            }

        }
        private void NhapHangGUI_Load(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSanPham.CurrentCell = null;
            dgvSanPham.ClearSelection();
        }

        int currentPosition = 0;
        int step = 80;

        private void rjButton1_Click(object sender, EventArgs e)
        {
            currentPosition += step;

            // Kiểm tra xem đã đạt đến cuối cùng chưa.
            int maxPosition = flpNhaCungCap.Controls.Cast<Control>().Sum(c => c.Width) - flpNhaCungCap.ClientSize.Width;

            // Kiểm tra giới hạn tối đa của thanh cuộn ngang.
            int maxScrollValue = flpNhaCungCap.HorizontalScroll.Maximum;

            if (currentPosition > maxPosition)
            {
                currentPosition = maxPosition;
            }

            if (currentPosition > maxScrollValue)
            {
                currentPosition = maxScrollValue;
            }

            // Cuộn nội dung của FlowLayoutPanel.
            flpNhaCungCap.HorizontalScroll.Value = currentPosition;
        }
    }

}
