using BLL;
using DevExpress.Utils.Commands;
using GUI.MyCustom;
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
        private Image convertBinaryStringToImage(byte[] binaryString)
        {
            MemoryStream ms = new MemoryStream(binaryString);
            Image img = Image.FromStream(ms);
            return img;
        }

        private void loadToFlpNhaCungCap()
        {
            this.flpNhaCungCap.Controls.Clear();
            for (int i = 0; i < dtNhaCungCap.Rows.Count; i++)
            {
                MyCustom.MySuppiler item = new MyCustom.MySuppiler();
                item.lblNhaCungCap.Text = dtNhaCungCap.Rows[i]["TenNCC"].ToString();
                byte[] imageBytes = (byte[])dtNhaCungCap.Rows[i]["IMG"];
                item.pbNhaCungCap.Image = convertBinaryStringToImage(imageBytes);
                item.Margin = new Padding(6, 0, 6, 0);
                item.ItemClicked += Item_ItemClicked;
                this.flpNhaCungCap.Controls.Add(item);
            }

        }
        private DataTable searchWithTenNCC(string tenNCC)
        {
            DataTable nhaCungCapTable = dtSanPham.Clone(); // DataTable đã tồn tại
           

            var nhaCungCap = dtSanPham.AsEnumerable()
                .Where(row => row.Field<string>("TenNCC") == tenNCC)
                .ToList();

            if (nhaCungCap.Count == 0)
            {
                return nhaCungCapTable; // Trả về DataTable đã tồn tại nhưng rỗng
            }

            foreach (DataRow row in nhaCungCap)
            {
                nhaCungCapTable.ImportRow(row); // Sao chép các dòng từ danh sách đã lọc vào DataTable đã tồn tại
            }

            return nhaCungCapTable;
        }

        private string searchMaNCCbyTenNCC(string tenNCC)
        {
            string maNCC = dtNhaCungCap.AsEnumerable()
                .Where(row => row.Field<string>("TenNCC") == tenNCC)
                .Select(row => row.Field<string>("MaNCC"))
                .FirstOrDefault();
            return maNCC;
        }
        #region Các hàm thực hiện xử lý sự kiện ở MySupplier
        private void Item_ItemClicked(object sender, EventArgs e)
        {
            MySuppiler item = (MySuppiler)sender;
            string tenNCC = item.lblNhaCungCap.Text;
            var listNCC = searchWithTenNCC(tenNCC);
            dgvSanPham.DataSource = listNCC;

            string maNCC = searchMaNCCbyTenNCC(tenNCC);
            lblNhaCungCap.Text = maNCC.ToString();
            
        }
        #endregion
        private void NhapHangGUI_Load(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dgvSanPham.CurrentCell = null;
            dgvSanPham.ClearSelection();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {

        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }
    }

}
