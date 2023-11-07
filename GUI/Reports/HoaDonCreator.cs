using BLL;
using DevExpress.XtraExport.Xls;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.Reports
{
    public class HoaDonCreator
    {
        public HoaDonDataSet hdDS;
        public HoaDonRP hdRP;
        private string maHD;
        private string ngayLap;
        private string tenNV;
        private string maKH;
        private string tenKH;
        private int diemTLHienTai;
        private int diemTLNhanDuoc;
        private string maKM;
        private DataTable dtThongTinCTHD;
        int tongTienTT = 0;
        int tongTien = 0;
        int tongSoMatHang = 0;
        
        public HoaDonCreator()
        {
            hdDS = new HoaDonDataSet();
            hdRP = new HoaDonRP();
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string NgayLap { get => ngayLap; set => ngayLap = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string MaKH { get => maKH; set => maKH = value; }
        public string TenKH { get => tenKH; set => tenKH = value; }
        public int DiemTLHienTai { get => diemTLHienTai; set => diemTLHienTai = value; }
        public string MaKM { get => maKM; set => maKM = value; }
        public DataTable DtThongTinCTHD { get => dtThongTinCTHD; set => dtThongTinCTHD = value; }
        public int DiemTLNhanDuoc { get => diemTLNhanDuoc; set => diemTLNhanDuoc = value; }

        public bool NhapDLVaoDataSet()
        {
            try
            {

                //DataTable ttCTPN = nhBLL.getThongTinCTPhieuNhap(maPN);

                foreach (DataRow row in DtThongTinCTHD.Rows)
                {
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    int soLuong = int.Parse(row["SoLuong"].ToString());
                    int donGiaDaGiam = int.Parse(row["DonGiaDaGiam"].ToString());
                    int thanhTien = int.Parse(row["ThanhTien"].ToString());
                    int donGiaBanDau = int.Parse(row["DonGiaBanDau"].ToString());
                    tongTienTT += donGiaBanDau*soLuong;
                    tongTien += thanhTien;
                    tongSoMatHang += 1;
                    hdDS.HoaDon.Rows.Add(new object[]
                    {
                        maSP, tenSP, soLuong, donGiaDaGiam, thanhTien
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
        public void showHoaDonRP()
        {
            hdRP.DataSource = hdDS;
            hdRP.DataMember = hdDS.HoaDon.TableName;
            NhapDLVaoDataSet();
            hdRP.lblMaHD.Text = maHD;
            hdRP.lblNgayLap.Text = ngayLap;
            hdRP.lblNhanVien.Text = tenNV;
            hdRP.lblMaKH.Text = maKH;
            hdRP.lblTenKH.Text = tenKH;
            hdRP.lblDiemTLHienTai.Text = diemTLHienTai.ToString();
            hdRP.lblMaKM.Text = maKM;
            hdRP.lblTongSoMH.Text = tongSoMatHang.ToString();
            hdRP.lblTongTienTT.Text = tongTienTT.ToString();
            hdRP.lblDiemTLNhanDuoc.Text = diemTLNhanDuoc.ToString();
            hdRP.lblTongTien.Text = tongTien.ToString();
            ReportPrintTool viewRP = new ReportPrintTool(hdRP);
            viewRP.ShowPreview();

        }
    }
}
