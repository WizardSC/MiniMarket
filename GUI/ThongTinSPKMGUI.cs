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
    public partial class ThongTinSPKMGUI : Form
    {
        private string TenKM;
        private KhuyenMaiBLL kmBLL;
        private KhuyenMaiGUI KmGUI;
        public ThongTinSPKMGUI(KhuyenMaiGUI KmGUI,string MaKM,string TenKM)
        {
            InitializeComponent();
            kmBLL = new KhuyenMaiBLL();
            this.KmGUI = KmGUI;
            this.TenKM = TenKM;
            dgvThongTinSPKM.DataSource = kmBLL.getThongTinSPKM(MaKM);

            // Đặt tiêu đề của form bằng tên khuyến mãi
            this.Text = "Thông tin khuyến mãi: " + TenKM;
        }

        private void dgvThongTinSPKM_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6) // Thay 4 bằng chỉ số cột thứ 5 (chú ý: chỉ số cột bắt đầu từ 0).
            {
                if (e.Value != null && e.Value is int)
                {
                    int value = (int)e.Value;
                    if (value == 1)
                    {
                        e.Value = "Hoạt động";
                    }
                    else if (value == 0)
                    {
                        e.Value = "Không hoạt động";
                    }
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == 3) // Thay yourDateColumnIndex bằng chỉ số cột ngày của bạn.
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng lại ngày thành "ngày/tháng/năm".
                    e.FormattingApplied = true;
                }
            }
            if (e.ColumnIndex == 4) // Thay yourDateColumnIndex bằng chỉ số cột ngày của bạn.
            {
                if (e.Value != null && e.Value is DateTime)
                {
                    DateTime dateValue = (DateTime)e.Value;
                    e.Value = dateValue.ToString("dd/MM/yyyy"); // Định dạng lại ngày thành "ngày/tháng/năm".
                    e.FormattingApplied = true;
                }
            }
            if (e.Value != null)
            {
                // Đặt chữ nằm ở giữa cho tất cả các cột
                dgvThongTinSPKM.Columns[e.ColumnIndex].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }
    }
}
