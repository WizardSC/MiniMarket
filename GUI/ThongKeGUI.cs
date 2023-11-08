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
    public partial class ThongKeGUI : Form
    {
        public ThongKeGUI()
        {
            InitializeComponent();
            loadDataToLineChart();
        }
        public string ConvertIntToVND(int amount)
        {
            // Sử dụng định dạng số nguyên của tiền VND và thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N0}đ", amount);
            return formattedAmount;
        }
        private void loadDataToLineChart()
        {
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.Title = "Doanh thu";
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.TitleForeColor = Color.FromArgb(1, 140, 137);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.TitleFont = new Font("Cambria", 13, FontStyle.Bold);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.TitleForeColor = Color.FromArgb(1, 140, 137);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.TitleFont = new Font("Cambria", 12, FontStyle.Bold);

            chartDoanhThu.Series["chartDoanhThu"].Points.Add(10000000);
            chartDoanhThu.Series["chartDoanhThu"].Points[0].Label = ConvertIntToVND(10000000);
            chartDoanhThu.Series["chartDoanhThu"].Points[0].Color = Color.FromArgb(1, 140, 137);
            chartDoanhThu.Series["chartDoanhThu"].Points[0].AxisLabel = "Tháng 1";

            chartDoanhThu.Series["chartDoanhThu"].Points.Add(20000000);
            chartDoanhThu.Series["chartDoanhThu"].Points[1].Label = "20000000";
            chartDoanhThu.Series["chartDoanhThu"].Points[1].Color = Color.FromArgb(1, 140, 137);
            chartDoanhThu.Series["chartDoanhThu"].Points[1].AxisLabel = "Tháng 2";

            chartDoanhThu.Series["chartDoanhThu"].Points.Add(17000000);
            chartDoanhThu.Series["chartDoanhThu"].Points[2].Label = "17000000";
            chartDoanhThu.Series["chartDoanhThu"].Points[2].Color = Color.FromArgb(1, 140, 137);
            chartDoanhThu.Series["chartDoanhThu"].Points[2].AxisLabel = "Tháng 3";
        }
    }
}
