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

        public List<NhanVienDTO> getListNV()
        {
            List<NhanVienDTO> listNV = new List<NhanVienDTO>();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("select MaNV, Ho, Ten from nhanvien", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    NhanVienDTO nv = new NhanVienDTO();
                    nv.MaNV = reader["MaNV"].ToString();
                    nv.Ho = reader["Ho"].ToString();
                    nv.Ten = reader["Ten"].ToString();
                    listNV.Add(nv);
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
            return listNV;
        }
        public DataTable getListNhanVien()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * from nhanvien";
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

        public DataTable getListNhanVienHasTK()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MaNV, Ho, Ten, MaTK, MaCV from nhanvien where TrangThai = 1";
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
                cmd.CommandText = "insert into nhanvien values (@MaNV, @Ho, @Ten, @NgaySinh, @GioiTinh, @SoDT, @DiaChi, @TrangThai,NULL,@MaTK, @MaCV)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@Ho", nv.Ho).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@Ten", nv.Ten).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoDT", nv.SoDT).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai).SqlDbType = SqlDbType.Int;
                //cmd.Parameters.Add(new SqlParameter("@IMG", SqlDbType.Image) { Value = DBNull.Value });
                cmd.Parameters.Add(new SqlParameter("@MaTK", SqlDbType.NVarChar) { Value = DBNull.Value });
                //cmd.Parameters.AddWithValue("@IMG", nv.Img).SqlDbType = SqlDbType.Image;
                //cmd.Parameters.AddWithValue("@MaTK", nv.MaTK).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@MaCV", nv.MaCV).SqlDbType = SqlDbType.Char;

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

        public bool updateNhanVien(NhanVienDTO nv)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nhanvien set Ho = @Ho, Ten = @Ten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SoDT = @SoDT, DiaChi = @DiaChi, TrangThai = @TrangThai, MaCV = @MaCV, IMG = NULL, MaTK = NULL where MaNV = @MaNV";
                cmd.Parameters.AddWithValue("@Ho", nv.Ho).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@Ten", nv.Ten).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@NgaySinh", nv.NgaySinh).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@GioiTinh", nv.GioiTinh).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoDT", nv.SoDT).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DiaChi", nv.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", nv.TrangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaCV", nv.MaCV).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@MaNV", nv.MaNV).SqlDbType = SqlDbType.Char;

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
        public bool deleteNhanVien(string maNV, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from nhanvien where MaNV = @MaNV";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaNV", maNV).SqlDbType = SqlDbType.Char;
                cmd.ExecuteNonQuery();
                isLoiKhoaNgoai = false;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                {
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
        public bool updateTrangThai(int trangThai, string maNV)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nhanvien set TrangThai = @TrangThai where MaNV = @MaNV";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaNV", maNV).SqlDbType = SqlDbType.Char;
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
