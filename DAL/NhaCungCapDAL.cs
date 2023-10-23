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
    public class NhaCungCapDAL : MSSQLConnect
    {
       
        public DataTable getListNhaCC()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from nhacungcap";
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
        public bool InsertNhaCC(NhaCungCapDTO nhacc)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into nhacungcap values (@MaNCC, @TenNCC, @DiaChi, @SoDT, @SoFax, @TrangThai)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaNCC", nhacc.MaNCC).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@TenNCC", nhacc.TenNCC).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DiaChi", nhacc.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoDT", nhacc.SoDT).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@SoFax", nhacc.SoFAX).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", nhacc.TrangThai).SqlDbType = SqlDbType.Int;
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
        public bool deleteNhaCC(string maNCC, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from nhacungcap where MaNCC = @MaNCC";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaNCC", maNCC).SqlDbType = SqlDbType.Char;
                cmd.ExecuteNonQuery();
                isLoiKhoaNgoai = false;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Mã lỗi 547 là mã lỗi cho việc tham chiếu đến khóa ngoại
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
    }
}
