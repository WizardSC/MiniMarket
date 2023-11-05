using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTPhieuNhapDAL : MSSQLConnect
    {
        public bool insertCTPhieuNhap(CTPhieuNhapDTO ctPN)
        {
            try
            {
                Connect();
                string sql = "INSERT INTO chiTietPhieuNhap (MaPN, MaSP, TenSP, SoLuong, DonGiaNhap, ThanhTien) " +
                             "VALUES (@MaPN, @MaSP, @TenSP, @SoLuong, @DonGiaNhap, @ThanhTien)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaPN", ctPN.MaPN).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@MaSP", ctPN.MaSP).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@TenSP", ctPN.TenSP).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoLuong", ctPN.SoLuong).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DonGiaNhap", ctPN.DonGiaNhap).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@ThanhTien", ctPN.ThanhTien).SqlDbType = SqlDbType.Int;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
