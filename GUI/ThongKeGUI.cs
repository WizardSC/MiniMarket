using BLL;
using DevExpress.Utils.Extensions;
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
        private DataTable dtDoanhThu;
        private DataTable dtTopSPBanChay;
        private DataTable dtTopSpBanChayTheoThang;
        private ThongKeBLL tkBLL;
        private int currentMonth;
        private int currentYear;
        private int soSPHienThi = 5;
        public ThongKeGUI()
        {
            InitializeComponent();
            currentMonth = DateTime.Now.Month;
            currentYear = DateTime.Now.Year;

            tkBLL = new ThongKeBLL();
            dtDoanhThu = tkBLL.getListDoanhThu();
            dtTopSPBanChay = tkBLL.getTopSPBanChay();

            loadDataToLineChart();
            loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);
            loadDataToCBXChonThang();
            loadDataToCBXChonNam();
            loadDataToGioiTinhPieChart();
            loadDataToLblKhachHang(currentMonth);

            Console.WriteLine(tkBLL.getUniqueKhachHang(currentMonth).ToString());

            cbxChonThang.SelectedItem = currentMonth;
            cbxChonNam.SelectedItem = currentYear;
        }
        public string ConvertIntToVND(int amount)
        {
            // Sử dụng định dạng số nguyên của tiền VND và thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N0}đ", amount);
            return formattedAmount;
        }
        private void loadDataToCBXChonThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbxChonThang.Items.Add(i);
            }
        }

        private void loadDataToCBXChonNam()
        {
            for (int i = 2021; i <= 2023; i++)
            {
                cbxChonNam.Items.Add(i);
            }
        }
        private void loadDataTopSPBanChayTheoThang(int thang, int soSP)
        {
            dgvTopSPBanChay.DataSource = tkBLL.getTopSPBanChayTheoThang(thang, soSP);
        }
        private void loadDataToGioiTinhPieChart()
        {
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.AddXY("Nam",20);
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.AddXY("Nữ", 80);
            

        }
        private void loadDataToLblKhachHang(int thang)
        {
            lblKhachHang.Text = tkBLL.getUniqueKhachHang(thang).ToString();
            Console.WriteLine(tkBLL.getUniqueKhachHang(thang).ToString());
        }
        private void loadDataToLineChart()
        {
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.MinorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.MinorGrid.Enabled = false;

            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.Title = "Tháng";
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.Title = "Doanh thu";
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.TitleForeColor = Color.FromArgb(1, 140, 137);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.TitleFont = new Font("Cambria", 13, FontStyle.Bold);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.TitleForeColor = Color.FromArgb(1, 140, 137);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.TitleFont = new Font("Cambria", 12, FontStyle.Bold);
            for (int i = 0; i < dtDoanhThu.Rows.Count; i++)
            {
                chartDoanhThu.Series["chartDoanhThu"].Points.AddXY(dtDoanhThu.Rows[i]["Thang"], dtDoanhThu.Rows[i]["DoanhThu"]);

            }

            //chartDoanhThu.Series["chartDoanhThu"].Points.Add(10000000);
            //chartDoanhThu.Series["chartDoanhThu"].Points[0].Label = ConvertIntToVND(10000000);
            //chartDoanhThu.Series["chartDoanhThu"].Points[0].Color = Color.FromArgb(1, 140, 137);
            //chartDoanhThu.Series["chartDoanhThu"].Points[0].AxisLabel = "Tháng 1";

            //chartDoanhThu.Series["chartDoanhThu"].Points.Add(20000000);
            //chartDoanhThu.Series["chartDoanhThu"].Points[1].Label = "20000000";
            //chartDoanhThu.Series["chartDoanhThu"].Points[1].Color = Color.FromArgb(1, 140, 137);
            //chartDoanhThu.Series["chartDoanhThu"].Points[1].AxisLabel = "Tháng 2";

            //chartDoanhThu.Series["chartDoanhThu"].Points.Add(17000000);
            //chartDoanhThu.Series["chartDoanhThu"].Points[2].Label = "17000000";
            //chartDoanhThu.Series["chartDoanhThu"].Points[2].Color = Color.FromArgb(1, 140, 137);
            //chartDoanhThu.Series["chartDoanhThu"].Points[2].AxisLabel = "Tháng 3";
        }

        private void cbxChonThang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            currentMonth = int.Parse(cbxChonThang.SelectedItem.ToString());
            loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);
            loadDataToLblKhachHang(currentMonth);

        }

        private void cbxChonNam_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            currentYear = int.Parse(cbxChonNam.SelectedItem.ToString());

        }

        private void txtHienThi__TextChanged(object sender, EventArgs e)
        {
            string inputText = txtHienThi.Texts;

            if (string.IsNullOrWhiteSpace(inputText))
            {
                soSPHienThi = 5;
            }
            else if (int.TryParse(inputText, out int parsedValue))
            {

                soSPHienThi = parsedValue;
            }
            else
            {

            }

            loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);

        }

        private void txtHienThi_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.Enter)
            //{
            //    // Người dùng đã nhấn Enter
               
            //    if (!int.TryParse(txtHienThi.Texts, out int parsedValue))
            //    {
            //        MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            //        txtHienThi.Text = "";
            //    }
            //    else
            //    {
            //        soSPHienThi = parsedValue;
            //        loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);
            //    }

            //    e.Handled = true;
            //}
        }
    }
}
