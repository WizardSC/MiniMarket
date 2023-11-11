using BLL;
using DevExpress.Utils.Extensions;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class ThongKeGUI : Form
    {
        private DataTable dtDoanhThu;
        private DataTable dtDoanhThuThangSoVoiNam;
        private DataTable dtTopSPBanChay;
        private DataTable dtTopSpBanChayTheoThang;
        private DataTable dtLuotMuaTheoGioiTinh;
        private ThongKeBLL tkBLL;
        private SanPhamBLL spBLL;
        private int currentMonth;
        private int currentYear;
        private int currentDay;
        private int soSPHienThi = 5;
        private List<SanPhamDTO> listSP;
        private bool isThang = true;
        private bool isNam = false;

        public ThongKeGUI()
        {
            InitializeComponent();
            currentMonth = DateTime.Now.Month;
            currentYear = DateTime.Now.Year;
            currentDay = DateTime.Now.Day;
            tkBLL = new ThongKeBLL();
            spBLL = new SanPhamBLL();



            //loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);
            loadDataToCBXChonThang();
            loadDataToCBXChonNam();
            loadDataToGioiTinhPieChart();
            
            cbxChonThang.SelectedItem = currentMonth;
            cbxChonNam.SelectedItem = currentYear;
            rdbTheoThang.Checked = true;
            checkIsThangIsNam(true,false);
        }
        private string searchMaSPbyTenSP(string tenSP)
        {
            listSP = spBLL.getListSP();
            var product = listSP.FirstOrDefault(sp => sp.TenSP == tenSP);
            if(product != null)
            {
                return product.MaSP;
            }
            return null;
        }
        public string ConvertIntToVND(int amount)
        {
            // Sử dụng định dạng số nguyên của tiền VND và thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N0}đ", amount);
            return formattedAmount;
        }
        private void checkIsThangIsNam(bool isThang, bool isNam)
        {
            cbxChonNam.Enabled = isThang ? false : true;
            
            cbxChonThang.Enabled = isNam ? false : true;
            if(isThang && !isNam)
            {
                lblTitleDoanhThu.Text = "doanh thu trong tháng".ToUpper();
                lblTitleDonHang.Text = "đơn hàng trong tháng".ToUpper();
                lblTitleSanPham.Text = "sản phẩm bán ra trong tháng".ToUpper();
                loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);

                loadDataToLblKhachHangThang(currentMonth);
                loadDataToLblDoanhThuThang(currentMonth);
                loadDataToLblDonHangThang(currentMonth);
                loadDataToLblSanPhamBanRaThang(currentMonth);
                loadDoanhThuTheoNgay(currentMonth);
                loadDoanhThuQuy1(currentYear);
                loadDoanhThuQuy2(currentYear);
                loadDoanhThuQuy3(currentYear);
                loadDoanhThuQuy4(currentYear);

                loadDoanhThuThangSoVoiNam(currentMonth, currentYear);
            }
            else if(!isThang && isNam)
            {
                lblTitleDoanhThu.Text = "doanh thu trong năm".ToUpper();
                lblTitleDonHang.Text = "đơn hàng trong năm".ToUpper();
                lblTitleSanPham.Text = "sản phẩm bán ra trong năm".ToUpper();
                loadDataTopSPBanChayTheoNam(currentYear, soSPHienThi);

                loadDoanhThuTheoThang(currentYear);
                loadDataToLblDoanhThuNam(currentYear);
                loadDataToLblDonHangNam(currentYear);
                loadDataToLblKhachHangNam(currentYear);
                loadDataToLblSanPhamBanRaNam(currentYear);
            }

        }
        private void loadDoanhThuQuy3(int nam) {
            int temp = tkBLL.getTongDoanhThuQuy3Nam(nam);
            lblQuy3.Text = ConvertIntToVND(temp);
        }
        private void loadDoanhThuQuy1(int nam)
        {
            int temp = tkBLL.getTongDoanhThuQuy1Nam(nam);
            lblQuy1.Text = ConvertIntToVND(temp);
        }

        private void loadDoanhThuQuy2(int nam)
        {
            int temp = tkBLL.getTongDoanhThuQuy2Nam(nam);
            lblQuy2.Text = ConvertIntToVND(temp);
        }

        private void loadDoanhThuQuy4(int nam)
        {
            int temp = tkBLL.getTongDoanhThuQuy4Nam(nam);
            lblQuy4.Text = ConvertIntToVND(temp);
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
        private void loadDataTopSPBanChayTheoNam(int nam, int soSP)
        {
            dgvTopSPBanChay.DataSource = tkBLL.getTopSPBanChayTheoNam(nam, soSP);
        }
        private void loadDataToGioiTinhPieChart()
        {
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.AddXY("Nam", 20);
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.AddXY("Nữ", 80);


        }
        private void loadLuotMuaTheoGioiTinh(string maSP)
        {
            dtLuotMuaTheoGioiTinh = tkBLL.thongKeSoLuotMuaTheoGioiTinh(maSP);
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.Clear();
            

            for (int i = 0; i < dtLuotMuaTheoGioiTinh.Rows.Count; i++)
            {
                Console.WriteLine(dtLuotMuaTheoGioiTinh.Rows[i]["Số Lượt Mua"]);
                Console.WriteLine(dtLuotMuaTheoGioiTinh.Rows[i]["Giới tính"]);

                chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.AddXY(dtLuotMuaTheoGioiTinh.Rows[i]["Giới Tính"], dtLuotMuaTheoGioiTinh.Rows[i]["Số Lượt Mua"]);

            }
        }
        private void loadDoanhThuThangSoVoiNam(int thang, int nam)
        {
            dtDoanhThuThangSoVoiNam = tkBLL.getListDoanhThuThangSoVoiNam(thang, nam);
            chartDoanhThuThangSoVoiNam.Series["chartDoanhThuThangSoVoiNam"].Points.Clear();

            for (int i = 0; i < dtDoanhThuThangSoVoiNam.Rows.Count; i++)
            {
                // Lấy giá trị DoanhThu từ DataTable
                double doanhThu = Convert.ToDouble(dtDoanhThuThangSoVoiNam.Rows[i]["DoanhThu"]);

                // Tạo điểm (data point) cho biểu đồ
                DataPoint dataPoint = new DataPoint(thang, doanhThu);

                // Đặt LegendText chỉ cho cột thứ 2 (index 1)
                if (i == 1)
                {
                    dataPoint.LegendText = "Các tháng còn lại";
                }

                // Thêm điểm vào Series
                chartDoanhThuThangSoVoiNam.Series["chartDoanhThuThangSoVoiNam"].Points.Add(dataPoint);
            }

        }
        private void loadDataToLblKhachHangThang(int thang)
        {
            lblKhachHang.Text = tkBLL.getUniqueKhachHang(thang).ToString();
            Console.WriteLine(tkBLL.getUniqueKhachHang(thang).ToString());
        }

        private void loadDataToLblDoanhThuThang(int thang)
        {
            lblDoanhThu.Text = tkBLL.getTongDoanhThuTheoThang(thang).ToString();

        }
        private void loadDataToLblDoanhThuNam(int nam)
        {
            lblDoanhThu.Text = tkBLL.getTongDoanhThuTheoNam(nam).ToString();

        }
        private void loadDataToLblDonHangThang(int thang)
        {
            lblDonHang.Text = tkBLL.getTongDonHangTheoThang(thang).ToString();

        }
        private void loadDataToLblSanPhamBanRaThang(int thang)
        {
            lblSanPhamBanRa.Text = tkBLL.getTongSPBanRaTheoThang(thang).ToString();

        }
        private void loadDataToLblKhachHangNam(int nam)
        {
            lblKhachHang.Text = tkBLL.getUniqueKhachHangNam(nam).ToString();
            Console.WriteLine(tkBLL.getUniqueKhachHangNam(nam).ToString());
        }

        private void loadDataToLblDonHangNam(int nam)
        {
            lblDonHang.Text = tkBLL.getTongDonHangTheoNam(nam).ToString();
        }

        private void loadDataToLblSanPhamBanRaNam(int nam)
        {
            lblSanPhamBanRa.Text = tkBLL.getTongSPBanRaTheoNam(nam).ToString();
        }

        private void loadDoanhThuTheoNgay(int thang)
        {

            dtDoanhThu = tkBLL.getListDoanhThuTheoNgay(thang);
            chartDoanhThu.Series["chartDoanhThu"].Points.Clear();
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.MinorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.MinorGrid.Enabled = false;
            chartDoanhThu.Titles["chartDoanhThu"].Text = "DOANH THU THEO NGÀY";
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.Title = "Ngày";
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.Title = "Doanh thu";
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.TitleForeColor = Color.FromArgb(1, 140, 137);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.TitleFont = new Font("Cambria", 13, FontStyle.Bold);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.TitleForeColor = Color.FromArgb(1, 140, 137);
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.TitleFont = new Font("Cambria", 12, FontStyle.Bold);
            for (int i = 0; i < dtDoanhThu.Rows.Count; i++)
            {
                chartDoanhThu.Series["chartDoanhThu"].Points.AddXY(dtDoanhThu.Rows[i]["Ngay"], dtDoanhThu.Rows[i]["DoanhThu"]);

            }

        }
        private void loadDoanhThuTheoThang(int nam)
        {
            dtDoanhThu = tkBLL.getListDoanhThuTheoThang(nam);
            chartDoanhThu.Series["chartDoanhThu"].Points.Clear();
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisX.MinorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.MajorGrid.Enabled = false;
            chartDoanhThu.ChartAreas["chartDoanhThu"].AxisY.MinorGrid.Enabled = false;
            chartDoanhThu.Titles["chartDoanhThu"].Text = "DOANH THU THEO THÁNG";
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

        }
        
        
        private void cbxChonThang_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            currentMonth = int.Parse(cbxChonThang.SelectedItem.ToString());
            loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);
            loadDataToLblKhachHangThang(currentMonth);
            loadDataToLblDoanhThuThang(currentMonth);
            loadDataToLblDonHangThang(currentMonth);
            loadDataToLblSanPhamBanRaThang(currentMonth);
            loadDoanhThuTheoNgay(currentMonth);

            loadDoanhThuThangSoVoiNam(currentMonth, currentYear);
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.Clear();

        }

        private void cbxChonNam_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            currentYear = int.Parse(cbxChonNam.SelectedItem.ToString());
            loadDataTopSPBanChayTheoNam(currentYear, soSPHienThi);
            loadDoanhThuTheoThang(currentYear);
            loadDataToLblDoanhThuNam(currentYear);
            loadDataToLblDonHangNam(currentYear);
            loadDataToLblKhachHangNam(currentYear);
            loadDataToLblSanPhamBanRaNam(currentYear);
            loadDoanhThuThangSoVoiNam(currentMonth, currentYear);
            loadDoanhThuQuy1(currentYear);
            loadDoanhThuQuy2(currentYear);
            loadDoanhThuQuy3(currentYear);
            loadDoanhThuQuy4(currentYear);

            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.Clear();

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
            if(!isNam && isThang)
            {
            loadDataTopSPBanChayTheoThang(currentMonth, soSPHienThi);

            } else if(isNam && !isThang)
            {
                loadDataTopSPBanChayTheoNam(currentYear, soSPHienThi);

            }

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

        private void rdbTheoThang_CheckedChanged(object sender, EventArgs e)
        {
            isThang = true;
            isNam = false;
            checkIsThangIsNam(isThang, isNam);
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.Clear();

        }

        private void rdbTheoNam_CheckedChanged(object sender, EventArgs e)
        {
            isThang = false;
            isNam = true;
            checkIsThangIsNam(isThang, isNam);
            chartSPTheoGioiTinh.Series["chartSPTheoGioiTinh"].Points.Clear();


        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void dgvTopSPBanChay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTopSPBanChay.CurrentRow.Index;
            
            string tenSP = dgvTopSPBanChay.Rows[i].Cells[0].Value.ToString();
            string maSP = searchMaSPbyTenSP(tenSP);
            loadLuotMuaTheoGioiTinh(maSP);
            //Console.WriteLine(searchMaSPbyTenSP(tenSP));
        }
    }
}
