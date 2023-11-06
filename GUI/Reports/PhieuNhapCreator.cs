using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
using System.Globalization;
using DevExpress.XtraReports.UI;

namespace GUI.Reports
{
    public class PhieuNhapCreator : MSSQLConnect
    {
        public PhieuNhapDataSet pnDS;
        public PhieuNhapRP pnRP;
        public NhapHangBLL nhBLL;
        private string maPN;
        private string ngayLap;
        private string tenNCC;
        private string diaChi;
        private string soDT;
        private string soFAX;
        private DataTable dtThongTinCTPN;
        int tongTienTT = 0;
        int tongTien = 0;
        public PhieuNhapCreator()
        {

            pnDS = new PhieuNhapDataSet();
            pnRP = new PhieuNhapRP();
            nhBLL = new NhapHangBLL();
        }

        public string MaPN { get => maPN; set => maPN = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string SoFAX { get => soFAX; set => soFAX = value; }
        public DataTable DtThongTinCTPN { get => dtThongTinCTPN; set => dtThongTinCTPN = value; }

        public bool NhapDLVaoDataSet()
        {
            try
            {

                //DataTable ttCTPN = nhBLL.getThongTinCTPhieuNhap(maPN);

                foreach (DataRow row in dtThongTinCTPN.Rows)
                {
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    int soLuong = int.Parse(row["SoLuong"].ToString());
                    int donGiaNhap = int.Parse(row["DonGiaNhap"].ToString());
                    int thanhTien = int.Parse(row["ThanhTien"].ToString());

                    tongTienTT += thanhTien;
                    tongTien += thanhTien;

                    pnDS.PhieuNhap.Rows.Add(new object[]
                    {
                maSP, tenSP, soLuong, donGiaNhap, thanhTien
                    });
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }

        public void showPhieuNhapRP()
        {

            pnRP.DataSource = pnDS;
            pnRP.DataMember = pnDS.PhieuNhap.TableName;

            NhapDLVaoDataSet();

            pnRP.lblMaPN.Text = maPN;
            pnRP.lblNgayLap.Text = ngayLap.ToString();
            pnRP.lblDiaChi.Text = diaChi;
            pnRP.lblNhaCungCap.Text = tenNCC;
            pnRP.lblSoDT.Text = soDT;
            pnRP.lblSoFAX.Text = soFAX;
            pnRP.lblTongTienTT.Text = tongTienTT.ToString();
            pnRP.lblTongTien.Text = tongTien.ToString();
            ReportPrintTool viewRP = new ReportPrintTool(pnRP);
            viewRP.ShowPreview();

        }


    }
}
