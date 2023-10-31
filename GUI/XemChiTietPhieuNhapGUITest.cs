using BLL;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
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
    public partial class XemChiTietPhieuNhapGUITest : Form
    {
        private XemPhieuNhapT_BLL ChiTietPN_BLL;
        private string MaPhieuNhap;
        private DateTime NgayTaoPN;
        private string TenNhaCungCap;
        public XemChiTietPhieuNhapGUITest(string MaPhieuNhap, DateTime NgayTaoPN, string TenNhaCungCap)
        {
            InitializeComponent();
            ChiTietPN_BLL = new XemPhieuNhapT_BLL();
            this.MaPhieuNhap = MaPhieuNhap;
            this.NgayTaoPN = NgayTaoPN;
            this.TenNhaCungCap = TenNhaCungCap;
            dgvXemChiTietPN.DataSource = ChiTietPN_BLL.getListDsChiTietPhieuNhap(MaPhieuNhap);
            txtMaPN.Texts = MaPhieuNhap;
            txtTenNCC.Texts = TenNhaCungCap;
            dtpNgayNhap.Value = NgayTaoPN;
        }

        
    }
}
