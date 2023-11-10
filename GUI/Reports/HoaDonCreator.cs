using BLL;
using DevExpress.Charts.Native;
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
        private CTHoaDonBLL cthdBLL;
        private string maHD;
        private string ngayLap;
        private string tenNV;
        private string maKH;
        private string tenKH;
        private int diemTLHienTai;
        private int diemTLNhanDuoc;
        private int diemTLSuDung;
        private string maKM;
        private DataTable dtThongTinCTHD;
        private int tongTienTT = 0;
        private float tongTien = 0;
        int tongSoMatHang = 0;
        
        public HoaDonCreator()
        {
            cthdBLL = new CTHoaDonBLL();
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
        public int TongTienTT { get => tongTienTT; set => tongTienTT = value; }
        public float TongTien { get => tongTien; set => tongTien = value; }
        public int DiemTLSuDung { get => diemTLSuDung; set => diemTLSuDung = value; }
        public string ConvertFloatToVND(float amount)
        {
            // Sử dụng định dạng số float của tiền VND, thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N}đ", amount);
            return formattedAmount;
        }
        public string ConvertIntToVND(int amount)
        {
            // Sử dụng định dạng số nguyên của tiền VND và thêm ký hiệu "đ" vào cuối
            string formattedAmount = string.Format("{0:N0}đ", amount);
            return formattedAmount;
        }
        public bool NhapDLVaoDataSet()
        {
            try
            {

                DataTable ttCTPN = cthdBLL.getListCTHDbyMaHD(MaHD);

                foreach (DataRow row in DtThongTinCTHD.Rows)
                {
                    Console.WriteLine(row.Field<int>("DonGiaDaGiam"));
                    string maSP = row["MaSP"].ToString();
                    string tenSP = row["TenSP"].ToString();
                    int soLuong = int.Parse(row["SoLuong"].ToString());
                    int donGiaDaGiam = int.Parse(row["DonGiaDaGiam"].ToString());
                    int thanhTien = int.Parse(row["ThanhTien"].ToString());
                    //hdRP.lblDonGiaBanDau.Text = ConvertIntToVND(donGiaBanDau);
                    tongSoMatHang += 1;
                    hdDS.HoaDon.Rows.Add(new object[]
                    {
                        maSP,tenSP,soLuong,donGiaDaGiam,thanhTien
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
            hdRP.lblTongTienTT.Text = ConvertIntToVND(TongTienTT);
            hdRP.lblDiemTLNhanDuoc.Text = diemTLNhanDuoc.ToString();
            hdRP.lblDiemTLSuDung.Text = diemTLSuDung.ToString();
            hdRP.lblTongTien.Text = ConvertFloatToVND(TongTien);
            ReportPrintTool viewRP = new ReportPrintTool(hdRP);
            viewRP.ShowPreview();

        }
    }
}
