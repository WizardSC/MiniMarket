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
        public bool insertNhaCC(NhaCungCapDTO ncc)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into nhacungcap values (@MaNCC, @TenNCC,@DiaChi,@SoDT, @SoFax,@TrangThai,@IMG)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoDT", ncc.SoDT).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@SoFax", ncc.SoFAX).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", ncc.TrangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IMG", ncc.Img).SqlDbType = SqlDbType.VarBinary;
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
        public bool updateNhaCC(NhaCungCapDTO ncc)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nhacungcap set TenNCC = @TenNCC,SoDT = @SoDT, DiaChi = @DiaChi,SoFax = @SoFax, TrangThai = @TrangThai, IMG = @IMG where MaNCC = @MaNCC";
                cmd.Parameters.AddWithValue("@TenNCC", ncc.TenNCC).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@SoDT", ncc.SoDT).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@DiaChi", ncc.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoFax", ncc.SoFAX).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", ncc.TrangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IMG", ncc.Img).SqlDbType = SqlDbType.VarBinary;
                cmd.Parameters.AddWithValue("@MaNCC", ncc.MaNCC).SqlDbType = SqlDbType.Char;
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
        public bool updateTrangThai(int trangThai, string maNCC)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nhacungcap set TrangThai = @TrangThai where MaNCC = @MaNCC";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaNCC", maNCC).SqlDbType = SqlDbType.Char;
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
