using DAL;
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
    public class SanPhamDAL : MSSQLConnect
    {
        //Không lấy cột hình ảnh để tiết kiệm dung lượng
        public List<SanPhamDTO> getListSP()
        {
            List<SanPhamDTO> listSP = new List<SanPhamDTO>();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MaSP, TenSP, SoLuong, DonGiaNhap, DonGiaBan, DonViTinh, TrangThai, MaLoai, MaNSX, MaNCC FROM sanpham";

                cmd.Connection = conn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    SanPhamDTO sp = new SanPhamDTO(
                        reader["MaSP"].ToString(),
                        reader["TenSP"].ToString(),
                        reader.GetInt32(reader.GetOrdinal("SoLuong")),
                        reader.GetInt32(reader.GetOrdinal("DonGiaNhap")),
                        reader.GetInt32(reader.GetOrdinal("DonGiaBan")),
                        reader["DonViTinh"].ToString(),
                        reader.GetInt32(reader.GetOrdinal("TrangThai")),
                        reader["MaLoai"].ToString(),
                        reader["MaNSX"].ToString(),
                        reader["MaNCC"].ToString()
                        
                    );
                    listSP.Add(sp);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                Disconnect();
            }
            return listSP;
        }
        public DataTable getListSanPham()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from sanpham";
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

        public bool insertSanPham(SanPhamDTO sp)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into sanpham values (@MaSP, @TenSP, @SoLuong, @DonGiaNhap, @DonGiaBan, @DonViTinh, @TrangThai, @MaLoai, @MaNSX, @MaNCC, @IMG)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DonGiaNhap", sp.DonGiaNhap).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DonGiaBan", sp.DonGiaBan).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThaiSP).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@MaNSX", sp.MaNSX).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@MaNCC", sp.MaNCC).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@IMG", sp.Img).SqlDbType = SqlDbType.Image;
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
        public bool updateSanPham(SanPhamDTO sp)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update sanpham set TenSP = @TenSP, SoLuong = @SoLuong, DonGiaNhap = @DonGiaNhap, DonGiaBan = @DonGiaBan, DonViTinh = @DonViTinh, TrangThai = @TrangThai, MaLoai = @MaLoai, MaNSX = @MaNSX, MaNCC = @MaNCC, IMG = @IMG where MaSP = @MaSP";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaSP", sp.MaSP).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@TenSP", sp.TenSP).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoLuong", sp.SoLuong).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DonGiaNhap", sp.DonGiaNhap).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DonGiaBan", sp.DonGiaBan).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DonViTinh", sp.DonViTinh).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", sp.TrangThaiSP).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaLoai", sp.MaLoai).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@MaNSX", sp.MaNSX).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@MaNCC", sp.MaNCC).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@IMG", sp.Img).SqlDbType = SqlDbType.Image;
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

        public bool deleteSanPham(string maSP, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from sanpham where MaSP = @MaSP";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaSP", maSP).SqlDbType = SqlDbType.Char;
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
        public bool updateTrangThai(int trangThai, string maSP)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update sanpham set TrangThai = @TrangThai where MaSP = @MaSP";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaSP", maSP).SqlDbType = SqlDbType.Char;
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
