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
        public string getLastMaPN()
        {
            try
            {
                Connect();
                string sql = "Select top 1 MaPN from phieunhap order by MaPN DESC";
                SqlCommand cmd = new SqlCommand(sql, conn);
                string lastMaPN = cmd.ExecuteScalar() as string;
                return lastMaPN;
            }

            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return null;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool insertPhieuNhap(PhieuNhapDTO pn)
        {
            try
            {
                Connect();
                string sql = "insert into phieunhap values (@MaPN, @NgayLap, @TongTien, @MaNV, @MaNCC)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@MaPN", pn.MaPN).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@NgayLap", pn.NgayLap).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@TongTien", pn.TongTien).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaNV", pn.MaNV).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@MaNCC", pn.MaNCC).SqlDbType = SqlDbType.Char;

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