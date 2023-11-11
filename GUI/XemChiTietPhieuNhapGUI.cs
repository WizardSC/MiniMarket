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
    public partial class XemChiTietPhieuNhapGUI : Form
    {
        private CTPhieuNhapBLL ChiTietPN_BLL;
        private string MaPhieuNhap;
        private DateTime NgayTaoPN;
        private string TenNhaCungCap;
        public XemChiTietPhieuNhapGUI(string MaPhieuNhap, DateTime NgayTaoPN, string TenNhaCungCap)
        {
            InitializeComponent();
            ChiTietPN_BLL = new CTPhieuNhapBLL();
            this.MaPhieuNhap = MaPhieuNhap;
            this.NgayTaoPN = NgayTaoPN;
            this.TenNhaCungCap = TenNhaCungCap;
            dgvXemChiTietPN.DataSource = ChiTietPN_BLL.getListChiTietPhieuNhap(MaPhieuNhap);
            txtMaPN.Texts = MaPhieuNhap;
            txtTenNCC.Texts = TenNhaCungCap;
            dtpNgayNhap.Value = NgayTaoPN;
        }
    }
}
