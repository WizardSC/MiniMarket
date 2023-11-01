using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class XemThongTinHoaDonDAL : MSSQLConnect
    {
        public DataTable getXemListHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT HoaDon.MaHD,HoaDon.NgayLapHD,KhachHang.Ten," +
                    "HoaDon.DiemSuDung,HoaDon.TongTien,HoaDon.DiemNhanDuoc,NhanVien.Ten " +
                    "FROM NhanVien,KhachHang,HoaDon " +
                    "WHERE NhanVien.MaNV = HoaDon.MaNV AND KhachHang.MaKH = HoaDon.MaKH";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }

            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
    }
}
