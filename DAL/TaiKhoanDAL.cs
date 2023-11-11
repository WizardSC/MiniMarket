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
        public DataTable getListTaiKhoan()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from taikhoan";
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
        public string getLastMaTK()
        {
            try
            {
                Connect();
                string sql = "Select top 1 MaTK from taikhoan order by MaTK DESC";
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
        public bool insertTaiKhoan(TaiKhoanDTO tk)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into taikhoan values (@MaTK, @MaNV, @TenDangNhap, @MatKhau, @Quyen, @TrangThai, @NgayLap)";
                cmd.Connection = conn;
                // Bổ sung các tham số
                cmd.Parameters.AddWithValue("@MaTK", tk.MaTK).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@MaNV", tk.MaNV).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@TenDangNhap", tk.TenDangNhap).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@MatKhau", tk.MatKhau).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@Quyen", tk.Quyen).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", tk.TrangThai).SqlDbType = SqlDbType.TinyInt;
                cmd.Parameters.AddWithValue("@NgayLap", tk.NgayLap).SqlDbType = SqlDbType.Date;


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
