using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongKeDAL : MSSQLConnect
    {
        public DataTable getListDoanhThu()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from testthongke";
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
        public DataTable getTopSPBanChayTheoThang(int thang, int soSP)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_topSPBanChayTheoThang";
                cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                cmd.Parameters.Add("@SoSP", SqlDbType.Int).Value = soSP;

                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
        public int getUniqueKhachHang(int thang)
        {
            int tongSoKhachHang = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_uniqueKhachHang";
                cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongSoKhachHang = Convert.ToInt32(result);
                }

                Console.WriteLine("Ở đây: " + tongSoKhachHang);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongSoKhachHang;
        }


        public DataTable getTopSPBanChay()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_topSanPhamBanChay";
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
    }
}
