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
    public class ChucVuDAL : MSSQLConnect
    {
        public DataTable getListChucVu()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ChucVu";
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
        public bool insertChucVu(ChucVuDTO cv)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into chucvu values (@MaCV, @TenCV, @TrangThai)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaCV", cv.MaCV).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@TenCV", cv.TenCV).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", cv.TrangThai).SqlDbType = SqlDbType.Int;  
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
        public bool updateChucVu(ChucVuDTO cv)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update chucvu set TenCV = @TenCV ,TrangThai = @TrangThai where MaCV = @MaCV";
                
                cmd.Parameters.AddWithValue("@TenCV", cv.TenCV).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", cv.TrangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaCV", cv.MaCV).SqlDbType = SqlDbType.Char;
                cmd.Connection = conn;

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
        public bool deleteChucVu(string maCV, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from chucvu where MaCV = @MaCV";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaCV", maCV).SqlDbType = SqlDbType.Char;
                cmd.ExecuteNonQuery();
                isLoiKhoaNgoai = false;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
                    Console.WriteLine("Lỗi: Không thể xóa sản phẩm vì có khóa ngoại tham chiếu.");
                    isLoiKhoaNgoai = true;
                }
                else
                {
                    Console.WriteLine("Lỗi: " + ex.Message);
                    isLoiKhoaNgoai = false;

                }
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public string getMaxMaChucVu()
        {
            string result = "";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MAX(MaCV) FROM ChucVu";
                cmd.Connection = conn;
                result = cmd.ExecuteScalar()?.ToString();
            }
            catch (Exception ex)
            {
                return ""; // hoặc có thể xử lý exception theo nhu cầu của bạn
            }
            finally
            {
                Disconnect();
            }
            return result;


        }
        public bool updateTrangThai(int trangThai, string maCV)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update chucvu set TrangThai = @TrangThai where MaCV = @MaCV";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaCV", maCV).SqlDbType = SqlDbType.Char;
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (SqlException ex)
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
