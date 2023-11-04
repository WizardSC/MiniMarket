using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhapHangDAL : MSSQLConnect
    {
        public DataTable getListSPToNhapHang()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                string sql = "select MaSP, TenSP, SoLuong, DonGiaNhap, TenLoai from SanPham join LoaiSP on LoaiSP.MaLoai = SanPham.MaLoai";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
    }
}
