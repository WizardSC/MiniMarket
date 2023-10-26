using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HoaDonDAL : MSSQLConnect
    {

        public bool insertHoaDon(HoaDonDTO hd)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into hoadon values (@MaHD, @NgayLapHD, @TongTienTT, @DiemSuDung, @TongTien, @DiemNhanDuoc, @MaKM, @MaNV, @MaKH)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaHD", hd.MaHD).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@NgayLapHD", hd.NgayLapHD).SqlDbType = SqlDbType.Date;
                cmd.Parameters.AddWithValue("@TongTienTT", (object)hd.TongTienTT ?? DBNull.Value).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DiemSuDung", (object)hd.DiemSuDung ?? DBNull.Value).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@TongTien", (object)hd.TongTien ?? DBNull.Value).SqlDbType = SqlDbType.Float;
                cmd.Parameters.AddWithValue("@DiemNhanDuoc", (object)hd.DiemNhanDuoc ?? DBNull.Value).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaKM", (object)hd.MaKM ?? DBNull.Value).SqlDbType = SqlDbType.Char; //Cho phép null
                cmd.Parameters.AddWithValue("@MaNV", hd.MaNV).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@MaKH", hd.MaKH).SqlDbType = SqlDbType.Char;


                cmd.ExecuteNonQuery();
                return true; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
