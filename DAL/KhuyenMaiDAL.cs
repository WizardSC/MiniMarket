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
                 cmd.ExecuteNonQuery(); // Use ExecuteNonQuery() here
                    return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        //public void update_nhanvien_DAL(model_nv model_nv)
        //{
        //    ConnectToMySQL conn = new ConnectToMySQL();
        //    try
        //    {
        //        conn.getConnection().Open();
        //        string query = "UPDATE nhanvien SET tennhanvien = @tennv, diachi = @diachi, idchucvu = @idchucvu WHERE idnhanvien = @idnhanvien";

        //        MySqlCommand cmd = new MySqlCommand(query, conn.getConnection());
        //        cmd.Parameters.AddWithValue("@tennv", model_nv.Tennv);
        //        cmd.Parameters.AddWithValue("@diachi", model_nv.Diachi);
        //        cmd.Parameters.AddWithValue("@idnhanvien", model_nv.IdNhanvien); // Assuming you have an "id" field in your model_nv class
        //        cmd.Parameters.AddWithValue("@idchucvu", model_nv.IdChucvu);
        //        int rowsAffected = cmd.ExecuteNonQuery(); // Use ExecuteNonQuery() here
        //        if (rowsAffected > 0)
        //        {
        //            MessageBox.Show("Cập nhật nhân viên thành công");
        //        }
        //        cmd.Dispose();
        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show("loi" + e);
        //    }
        //    finally
        //    {
        //        conn.getConnection().Close();
        //    }
        //}
    }
}
