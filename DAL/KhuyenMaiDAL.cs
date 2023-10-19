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

        //thong tin chi tiet km 
        public DataTable getThongTinKM(string MaKM)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ChiTietKhuyenMai.MaKM,ChiTietKhuyenMai.MaSP," +
                    "KhuyenMai.TenKM,SanPham.TenSP,KhuyenMai.NgayBatDau,KhuyenMai.NgayKetThuc," +
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

        // insert khuyen mai
        public bool insert_KhuyenMai(KhuyenMaiDTO KM_DTO)
        {
       
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "INSERT INTO KhuyenMai(MaKM,TenKM,NgayBatDau,NgayKetThuc,PhanTramKM,DieuKienKM,TrangThaiKM) VALUES(@MaKM,@TenKM,@NgayBatDau,@NgayKetThuc,@PhanTramKM,@DieuKienKM,@TrangThaiKM)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaKm", KM_DTO.Makm);
                cmd.Parameters.AddWithValue("@TenKM", KM_DTO.TenKm);
                cmd.Parameters.AddWithValue("@NgayBatDau", KM_DTO.NgayBd);
                cmd.Parameters.AddWithValue("@NgayKetThuc", KM_DTO.NgayKt);
                cmd.Parameters.AddWithValue("@PhanTramKM", KM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@DieuKienKM", KM_DTO.DieuKiemKm);
                cmd.Parameters.AddWithValue("@TrangThaiKM", KM_DTO.TrangThai);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Thêm khuyến mãi thành công."); // Display a success message
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm khuyến mãi thất bại. " + e.Message);
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
                string query = "UPDATE KhuyenMai SET TenKM = @TenKM, NgayBatDau = @NgayBatDau, NgayKetThuc = @NgayKetThuc, PhanTramKM = @PhanTramKM, DieuKienKM = @DieuKienKM, TrangThaiKM = @TrangThaiKM WHERE MaKM = @MaKM";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaKm", KM_DTO.Makm);
                cmd.Parameters.AddWithValue("@TenKM", KM_DTO.TenKm);
                cmd.Parameters.AddWithValue("@NgayBatDau", KM_DTO.NgayBd);
                cmd.Parameters.AddWithValue("@NgayKetThuc", KM_DTO.NgayKt);
                cmd.Parameters.AddWithValue("@PhanTramKM", KM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@DieuKienKM", KM_DTO.DieuKiemKm);
                cmd.Parameters.AddWithValue("@TrangThaiKM", KM_DTO.TrangThai);
                // Execute the SQL command
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Chỉnh sửa khuyến mãi thành công."); // Display a success message
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Chỉnh sửa khuyến mãi thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool Delete_KhuyenMai(KhuyenMaiDTO KM_DTO)
        {

            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "UPDATE KhuyenMai SET TrangThaiKM =0 WHERE MaKM = @MaKM";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaKm", KM_DTO.Makm);
                // Execute the SQL command
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa khuyến mãi thành công."); // Display a success message
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Xóa khuyến mãi thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
