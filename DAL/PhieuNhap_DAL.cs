using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhap_DAL : MSSQLConnect
    {
        public DataTable getListPhieuNhap()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT PhieuNhap.MaPN,PhieuNhap.NgayLap,PhieuNhap.TongTien,NhanVien.Ten,NhaCungCap.TenNCC" +
                    " FROM PhieuNhap,NhanVien,NhaCungCap " +
                    "where PhieuNhap.MaNV = NhanVien.MaNV AND PhieuNhap.MaNCC = NhaCungCap.MaNCC";
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
