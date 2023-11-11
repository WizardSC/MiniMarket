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
        public DataTable getListPhieuNhapbyMaPN(string maPN)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select MaSP, TenSP, SoLuong, DonGiaNhap, ThanhTien from ChiTietPhieuNhap where MaPN = @MaPN";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
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


        //thai
        public DataTable getListChiTietPhieuNhap(string MaPN)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("Select * from ChiTietPhieuNhap where MaPN = @MaPN", conn);
                cmd.Parameters.AddWithValue("@MaPN", MaPN).SqlDbType = SqlDbType.Char;

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
