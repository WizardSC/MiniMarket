using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        private ThongKeDAL tkDAL;
        public ThongKeBLL() { 
            tkDAL  = new ThongKeDAL();
        }

        public DataTable getListDoanhThuTheoThang(int nam)
        {
            return tkDAL.getListDoanhThuTheoThang(nam);
        }
        public DataTable getListDoanhThuTheoNgay(int thang)
        {
            return tkDAL.getListDoanhThuTheoNgay(thang);
        }
        
        public DataTable getTopSPBanChayTheoThang(int thang, int soSP)
        {
            return tkDAL.getTopSPBanChayTheoThang(thang, soSP);
        }
        public DataTable getTopSPBanChayTheoNam(int nam, int soSP)
        {
            return tkDAL.getTopSPBanChayTheoNam(nam, soSP);
        }

        public int getTongDoanhThuTheoThang(int thang)
        {
            return tkDAL.getTongDoanhThuTheoThang(thang);
        }
        public int getTongDoanhThuTheoNam(int nam)
        {
            return tkDAL.getTongDoanhThuTheoNam(nam);
        }

        public int getUniqueKhachHang(int thang)
        {
            return tkDAL.getUniqueKhachHang(thang);
        }

        public int getTongDonHangTheoThang(int thang)
        {
            return tkDAL.getTongDonHangThang(thang);
        }

        public int getTongSPBanRaTheoThang(int thang)
        {
            return tkDAL.getTongSPBanRaThang(thang);
        }

        public int getUniqueKhachHangNam(int nam)
        {
            return tkDAL.getUniqueKhachHangNam(nam);
        }

        public int getTongDonHangTheoNam(int nam)
        {
            return tkDAL.getTongDonHangNam(nam);
        }

        public int getTongSPBanRaTheoNam(int nam)
        {
            return tkDAL.getTongSPBanRaNam(nam);
        }

        public DataTable getListDoanhThuThangSoVoiNam(int thang, int nam)
        {
            return tkDAL.getListDoanhThuThangSoVoiNam(thang, nam);
        }

        public int getTongDoanhThuQuy1Nam(int nam)
        {
            return tkDAL.getTongDoanhThuQuy1Nam(nam);
        }

        public int getTongDoanhThuQuy2Nam(int nam)
        {
            return tkDAL.getTongDoanhThuQuy2Nam(nam);
        }

        public int getTongDoanhThuQuy3Nam(int nam)
        {
            return tkDAL.getTongDoanhThuQuy3Nam(nam);
        }

        public int getTongDoanhThuQuy4Nam(int nam)
        {
            return tkDAL.getTongDoanhThuQuy4Nam(nam);
        }

        public DataTable thongKeSoLuotMuaTheoGioiTinh(string maSP)
        {
            return tkDAL.thongKeSoLuotMuaTheoGioiTinh(maSP);
        }
    }
}
