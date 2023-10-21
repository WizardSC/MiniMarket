using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO
{
    public class LoaiDAL : MSSQLConnect
    {
        public DataTable getListLoai()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from LoaiSP";
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
        public bool insertNhaSanXuat(NhaSanXuatDTO nsx)
        {
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                // string query = "INSERT INTO KhuyenMai(MaKM,TenKM,NgayBatDau,NgayKetThuc,PhanTramKM,DieuKienKM,TrangThaiKM) VALUES(@MaKM,@TenKM,@NgayBatDau,@NgayKetThuc,@PhanTramKM,@DieuKienKM,@TrangThaiKM)";
                string query = "INSERT INTO LoaiSP(MaNSX,TenNSX,DiaChi,SoDT) VALUES(@MaNSX,@TenNSX,@DiaChi,@SoDT)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                cmd.Parameters.AddWithValue("@TenNSX", nsx.TenNSX);
                cmd.Parameters.AddWithValue("@DiaChi", nsx.DiaChi);
                cmd.Parameters.AddWithValue("@SoDT", nsx.SoDT);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    //MessageBox.Show("Thêm nhà sản xuất thành công thành công."); // Display a success message
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Thêm nhà sản xuất thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }

        }
    }
}
