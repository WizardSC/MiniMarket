using DAL;
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
    public class ChiTietKhuyenMaiDAL : MSSQLConnect
    {
        public DataTable getListChiTietKhuyenMai()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ChiTietKhuyenMai.MaKM,ChiTietKhuyenMai.MaSP,KhuyenMai.TenKM," +
                    "SanPham.TenSP,ChiTietKhuyenMai.PhanTramKM,ChiTietKhuyenMai.TrangThai" +
                    " from ChiTietKhuyenMai,KhuyenMai,SanPham" +
                    " where KhuyenMai.MaKM = ChiTietKhuyenMai.MaKM AND SanPham.MaSP = ChiTietKhuyenMai.MaSP";
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


        public bool insert_CTKhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {

            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "INSERT INTO ChiTietKhuyenMai(MaKM,MaSP,PhanTramKM,TrangThai) VALUES(@MaKM,@MaSP,@PhanTramKM,@TrangThai)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaKm", CTKM_DTO.Makm);
                cmd.Parameters.AddWithValue("@TenKM", CTKM_DTO.Masp);
                cmd.Parameters.AddWithValue("@PhanTramKM", CTKM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@TrangThai", CTKM_DTO.TrangThai);
                cmd.ExecuteNonQuery();
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
        public bool Update_CTKhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {

            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "UPDATE ChiTietKhuyenMai SET MaSP = @MaSP, PhanTramKM = @PhanTramKM, TrangThai = @TrangThai WHERE MaKM = @MaKM";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaKm", CTKM_DTO.Makm);
                cmd.Parameters.AddWithValue("@MaSP", CTKM_DTO.Masp);
                cmd.Parameters.AddWithValue("@PhanTramKM", CTKM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@TrangThai", CTKM_DTO.TrangThai);
                // Execute the SQL command
                cmd.ExecuteNonQuery();
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
        public bool delete_ChiTietkhuyenMai(string maKM, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from ChiTietkhuyenmai where MaKM = @MaKM";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaKM", maKM).SqlDbType = SqlDbType.Char;
                cmd.ExecuteNonQuery();
                isLoiKhoaNgoai = false;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Mã lỗi 547 là mã lỗi cho việc tham chiếu đến khóa ngoại
                {
                    Console.WriteLine("Lỗi: Không thể xóa chi tiết khuyến mãi vì có khóa ngoại tham chiếu.");
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
                cmd.CommandText = "update ChiTietKhuyenMai set TrangThai = @TrangThai where MaKM = @MaKM";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaKM", maKM).SqlDbType = SqlDbType.Char;
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
