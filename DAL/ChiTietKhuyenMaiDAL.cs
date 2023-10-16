using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietKhuyenMaiDAL : MSSQLConnect
    {
        public DataTable getListChiTietKhuyenMai()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ChiTietKhuyenMai.MaKM,ChiTietKhuyenMai.MaSP,KhuyenMai.TenKM,SanPham.TenSP,ChiTietKhuyenMai.PhanTramKM,ChiTietKhuyenMai.TrangThai from ChiTietKhuyenMai,KhuyenMai,SanPham where KhuyenMai.MaKM = ChiTietKhuyenMai.MaKM AND SanPham.MaSP = ChiTietKhuyenMai.MaSP";
;
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
