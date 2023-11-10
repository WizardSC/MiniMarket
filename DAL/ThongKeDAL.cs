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
        public DataTable getListDoanhThuTheoThang(int nam)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DoanhThuTheoThang";
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

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

        public DataTable getListDoanhThuTheoNgay(int thang)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_DoanhThuTheoNgay";
                cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;

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
        public DataTable getTopSPBanChayTheoNam(int nam, int soSP)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_topSPBanChayTheoNam";
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;
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


        
        public int getTongDoanhThuTheoThang(int thang)
        {
            int tongSoKhachHang = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongDoanhThuTheoThang";
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
        public int getTongDoanhThuTheoNam(int nam)
        {
            int tongDoanhThu = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongDoanhThuTheoNam";
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongDoanhThu = Convert.ToInt32(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongDoanhThu;
        }
        public int getTongDonHangThang (int thang)
        {
            int tongSoKhachHang = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongDonHangTheoThang";
                cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongSoKhachHang = Convert.ToInt32(result);
                }

              
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

        public int getTongSPBanRaThang(int thang)
        {
            int tongSPBanRa = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongSPBanRaTheoThang";
                cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongSPBanRa = Convert.ToInt32(result);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongSPBanRa;
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
        public int getTongDonHangNam(int nam)
        {
            int tongSoDonHang = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_tongDonHangTheoNam";
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongSoDonHang = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongSoDonHang;
        }

        public int getTongSPBanRaNam(int nam)
        {
            int tongSPBanRa = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongSPBanRaTheoNam";
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongSPBanRa = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongSPBanRa;
        }

        public int getUniqueKhachHangNam(int nam)
        {
            int tongSoKhachHang = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_uniqueKhachHangTheoNam";
                cmd.Parameters.Add("@nam", SqlDbType.Int).Value = nam;

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

        public DataTable getListDoanhThuThangSoVoiNam(int thang, int nam)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_doanhThuThangSoVoiNam";
                cmd.Parameters.Add("@Thang", SqlDbType.Int).Value = thang;
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;


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

        public int getTongDoanhThuQuy3Nam(int nam)
        {
            int tongDoanhThuQuy3 = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongDoanhThuQuy3";
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongDoanhThuQuy3 = Convert.ToInt32(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongDoanhThuQuy3;
        }
        public int getTongDoanhThuQuy1Nam(int nam)
        {
            int tongDoanhThuQuy1 = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongDoanhThuQuy1";
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongDoanhThuQuy1 = Convert.ToInt32(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongDoanhThuQuy1;
        }

        public int getTongDoanhThuQuy2Nam(int nam)
        {
            int tongDoanhThuQuy2 = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongDoanhThuQuy2";
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongDoanhThuQuy2 = Convert.ToInt32(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongDoanhThuQuy2;
        }

        public int getTongDoanhThuQuy4Nam(int nam)
        {
            int tongDoanhThuQuy4 = 0;

            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_TongDoanhThuQuy4";
                cmd.Parameters.Add("@Nam", SqlDbType.Int).Value = nam;

                cmd.Connection = conn;

                // Sử dụng ExecuteScalar để lấy giá trị trả về từ stored procedure
                object result = cmd.ExecuteScalar();

                // Kiểm tra giá trị null và kiểm tra xem có thể chuyển đổi sang kiểu int không
                if (result != null && result != DBNull.Value)
                {
                    tongDoanhThuQuy4 = Convert.ToInt32(result);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return tongDoanhThuQuy4;
        }

    }
}
