using BLL;
using DevExpress.XtraEditors.Filtering.Templates;
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
    public partial class ChiTietHoaDonGUI : Form
    {
        private CTHoaDonBLL CTHoaDonBLL;
        private string MaHoaDon;
        private DateTime NgayTaoHD;
        public ChiTietHoaDonGUI(string MaHoaDon,DateTime NgayTaoHD)
        {
            InitializeComponent();
            CTHoaDonBLL = new CTHoaDonBLL();
            this.MaHoaDon = MaHoaDon;
            this.NgayTaoHD = NgayTaoHD;
            dgvXemChiTietHD.DataSource = CTHoaDonBLL.getListCTHDbyMaHD(MaHoaDon);
            labelMaHD.Text = MaHoaDon;
            dtpNgayNhap.Value = NgayTaoHD;
        }
    }
}
