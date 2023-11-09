using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class XemThongTinHoaDonDAL : MSSQLConnect
    {
        public DataTable getListHoaDon()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT HoaDon.MaHD,HoaDon.NgayLapHD,KhachHang.Ten,HoaDon.DiemSuDung,HoaDon.TongTien,HoaDon.DiemNhanDuoc,NhanVien.Ten\r\n                     FROM HoaDon,KhachHang,NhanVien \r\n                    where HoaDon.MaNV = NhanVien.MaNV AND KhachHang.MaKH = HoaDon.MaKH";
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
