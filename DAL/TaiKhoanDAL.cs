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
    public class TaiKhoanDAL : MSSQLConnect
    {
        //public bool insertTaiKhoan(TaiKhoanDTO tk)
        //{
        //    try
        //    {
        //        Connect();
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.CommandType = CommandType.Text;
        //        cmd.CommandText = "insert into nhanvien values (@MaNV, @Ho, @Ten, @NgaySinh, @GioiTinh, @SoDT, @DiaChi, @TrangThai,NULL,@MaTK, @MaCV)";
        //        cmd.Connection = conn;
        //        cmd.Parameters.AddWithValue("@MaNV", nv.MaNV).SqlDbType = SqlDbType.Char;
        //        cmd.Parameters.AddWithValue("@Ho", nv.Ho).SqlDbType = SqlDbType.NVarChar;
        //        cmd.Parameters.AddWithValue("@Ten", nv.Ten).SqlDbType = SqlDbType.NVarChar;
        //        cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh).SqlDbType = SqlDbType.DateTime;
        //        cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh).SqlDbType = SqlDbType.NVarChar;
        //        cmd.Parameters.AddWithValue("@SoDT", nv.SoDT).SqlDbType = SqlDbType.Char;
        //        cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi).SqlDbType = SqlDbType.NVarChar;
        //        cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai).SqlDbType = SqlDbType.Int;
        //        //cmd.Parameters.Add(new SqlParameter("@IMG", SqlDbType.Image) { Value = DBNull.Value });
        //        cmd.Parameters.Add(new SqlParameter("@MaTK", SqlDbType.NVarChar) { Value = DBNull.Value });
        //        //cmd.Parameters.AddWithValue("@IMG", nv.Img).SqlDbType = SqlDbType.Image;
        //        //cmd.Parameters.AddWithValue("@MaTK", nv.MaTK).SqlDbType = SqlDbType.NVarChar;
        //        cmd.Parameters.AddWithValue("@MaCV", nv.MaCV).SqlDbType = SqlDbType.Char;

        //        cmd.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Lỗi:" + ex.Message);
        //        return false;
        //    }
        //    finally
        //    {
        //        Disconnect();
        //    }
        //}
    }
}
