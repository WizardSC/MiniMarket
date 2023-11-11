using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
using System.Windows.Forms;

namespace DAL
{
    public class KhuyenMaiDAL : MSSQLConnect
    {
        public DataTable getListKhuyenMai()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from khuyenmai";
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

        //thong tin chi tiet km khi click vao km 
        public DataTable getThongTinKM(string MaKM)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ChiTietKhuyenMai.MaKM,ChiTietKhuyenMai.MaSP," +
                    "SanPham.TenSP,KhuyenMai.NgayBatDau,KhuyenMai.NgayKetThuc," +
                    "ChiTietKhuyenMai.PhanTramKM,ChiTietKhuyenMai.TrangThai" +
                    " from ChiTietKhuyenMai,KhuyenMai,SanPham " +
                    "where KhuyenMai.MaKM = ChiTietKhuyenMai.MaKM AND SanPham.MaSP = ChiTietKhuyenMai.MaSP AND KhuyenMai.MaKM=@MaKM";
                ;
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaKM", MaKM); // Thêm tham số MaKM
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

        // danh sach km ko dieu kien
        public DataTable getMaKmNoDK()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from KhuyenMai where DieuKienKM = '' ";
                ;
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
        // insert khuyen mai
        public bool insert_KhuyenMai(KhuyenMaiDTO KM_DTO)
        {
       
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "INSERT INTO KhuyenMai(MaKM,TenKM,NgayBatDau,NgayKetThuc,PhanTramKM,DieuKienKM,TrangThai) VALUES(@MaKM,@TenKM,@NgayBatDau,@NgayKetThuc,@PhanTramKM,@DieuKienKM,@TrangThai)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaKm", KM_DTO.Makm);
                cmd.Parameters.AddWithValue("@TenKM", KM_DTO.TenKm);
                cmd.Parameters.AddWithValue("@NgayBatDau", KM_DTO.NgayBd);
                cmd.Parameters.AddWithValue("@NgayKetThuc", KM_DTO.NgayKt);
                cmd.Parameters.AddWithValue("@PhanTramKM", KM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@DieuKienKM", KM_DTO.DieuKiemKm);
                cmd.Parameters.AddWithValue("@TrangThai", KM_DTO.TrangThai);
                cmd.ExecuteReader();
                return true;
              


            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool Update_KhuyenMai(KhuyenMaiDTO KM_DTO)
        {
            
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "UPDATE KhuyenMai SET TenKM = @TenKM, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, PhanTramKM = @PhanTramKM, DieuKienKM = @DieuKienKM, TrangThai = @TrangThai WHERE MaKM = @MaKM";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaKm", KM_DTO.Makm);
                cmd.Parameters.AddWithValue("@TenKM", KM_DTO.TenKm);
                cmd.Parameters.AddWithValue("@NgayBatDau", KM_DTO.NgayBd);
                cmd.Parameters.AddWithValue("@NgayKetThuc", KM_DTO.NgayKt);
                cmd.Parameters.AddWithValue("@PhanTramKM", KM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@DieuKienKM", KM_DTO.DieuKiemKm);
                cmd.Parameters.AddWithValue("@TrangThai", KM_DTO.TrangThai);
                cmd.ExecuteReader();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool delete_khuyenMai(string maKM, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from KhuyenMai where MaKM = @MaKM";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaKM", maKM).SqlDbType = SqlDbType.Char;
                cmd.ExecuteReader();
                isLoiKhoaNgoai = false;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Mã lỗi 547 là mã lỗi cho việc tham chiếu đến khóa ngoại
                {
                    Console.WriteLine("Lỗi: Không thể xóa khuyến mãi vì có khóa ngoại tham chiếu.");
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
        public bool update_TrangThai(int trangThai, string maKM)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update KhuyenMai set TrangThai = @TrangThai where MaKM = @MaKM";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaKM", maKM).SqlDbType = SqlDbType.Char;
                cmd.ExecuteReader();
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
