using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class KhachHangDAL : MSSQLConnect
    {
        public DataTable getListKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from khachhang";
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
        //Chỉ lấy các khách hàng có trạng thái = 1 để load lên miniform
        public DataTable getMiniListKhachHang()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select makh, ho, ten, diemtichluy from khachhang where TrangThai = 1";
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
        public bool insertKhachHang(KhachHangDTO kh)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into khachhang values (@MaKH, @Ho, @Ten, @NgaySinh, @GioiTinh, @SoDT, @DiaChi, @TrangThai, @DiemTichLuy, @IMG)";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH).SqlDbType = SqlDbType.Char;
                cmd.Parameters.AddWithValue("@Ho", kh.Ho).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@Ten", kh.Ten).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoDT", kh.SoDT).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", kh.TrangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@IMG", kh.Img).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy).SqlDbType = SqlDbType.Int;

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
        public bool updateDiemTichLuy(string maKH, int diemTL)
        {
            try
            {
                Connect();
                string sql = "update khachhang set DiemTichLuy = DiemTichLuy + @DiemTL where MaKH = @MaKH";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@DiemTL", SqlDbType.Int).Value = diemTL;
                cmd.Parameters.Add("@MaKH", SqlDbType.Char).Value = maKH;
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
        public bool updateKhachHang(KhachHangDTO kh)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update khachhang set Ho = @Ho, Ten = @Ten, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, SoDT = @SoDT, DiaChi = @DiaChi, TrangThai = @TrangThai, DiemTichLuy = @DiemTichLuy, IMG = @IMG where MaKH = @MaKH";
                cmd.Parameters.AddWithValue("@Ho", kh.Ho).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@Ten", kh.Ten).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@NgaySinh", kh.NgaySinh).SqlDbType = SqlDbType.DateTime;
                cmd.Parameters.AddWithValue("@GioiTinh", kh.GioiTinh).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@SoDT", kh.SoDT).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@DiaChi", kh.DiaChi).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@TrangThai", kh.TrangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@DiemTichLuy", kh.DiemTichLuy).SqlDbType = SqlDbType.Int;

                cmd.Parameters.AddWithValue("@IMG", kh.Img).SqlDbType = SqlDbType.NVarChar;
                cmd.Parameters.AddWithValue("@MaKH", kh.MaKH).SqlDbType = SqlDbType.Char;

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

        public bool deleteKhachHang(string maKH, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from khachhang where MaKH = @MaKH";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaKH", maKH).SqlDbType = SqlDbType.Char;
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
        public string getMaxMaKhachHang()
        {
            string result = "";
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT MAX(MaKH) FROM khachhang";
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

    } 
}
