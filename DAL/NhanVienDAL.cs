using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class NhanVienDAL : MSSQLConnect
    {
        public DataTable getListNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from nhanVien";
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
        public bool insertNhanVien(NhanVienDTO nv)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into nhanvien values (@MaNV, @Ho, @Ten, @NgaySinh, @GioiTinh, @SoDT, @DiaChi, @TrangThai, @MaCV)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@Ho", nv.Ho).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@Ten", nv.Ten).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoDT", nv.SoDT).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai).SqlDbType = SqlDbType.Int;
                //cmd.Parameters.AddWithValue("@IMG", nv.Img).SqlDbType = SqlDbType.Image;
                cmd.Parameters.AddWithValue("@DiemTichLuy", nv.MaCV).SqlDbType = SqlDbType.Char;

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
