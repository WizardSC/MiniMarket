using DAL;
using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class NhaSanXuatDAL : MSSQLConnect
    {
        public DataTable getListNhaSanXuat()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from nhasanxuat";
               // cmd.CommandText = "select * from Khachhang";
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);

            }
            catch (Exception ex)
            {
                return null;
            } finally
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
                string query = "INSERT INTO NhaSanXuat(MaNSX,TenNSX,DiaChi,SoDT, Trangthai) VALUES(@MaNSX,@TenNSX,@DiaChi,@SoDT,@TrangThai)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                cmd.Parameters.AddWithValue("@TenNSX", nsx.TenNSX);
                cmd.Parameters.AddWithValue("@DiaChi", nsx.DiaChi);
                cmd.Parameters.AddWithValue("@SoDT", nsx.SoDT);
                cmd.Parameters.AddWithValue("@TrangThai", nsx.TrangThaiNSX);


                cmd.ExecuteNonQuery();

                return true;

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
        public bool update_nhasanxuat(NhaSanXuatDTO nsx)
        {
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "UPDATE NhaSanXuat SET TenNSX = @TenNSX, DiaChi = @DiaChi, SoDT = @SoDT, TrangThai = @TrangThai WHERE MaNSX = @MaNSX";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                cmd.Parameters.AddWithValue("@TenNSX", nsx.TenNSX);
                cmd.Parameters.AddWithValue("@DiaChi", nsx.DiaChi);
                cmd.Parameters.AddWithValue("@SoDT", nsx.SoDT);
                cmd.Parameters.AddWithValue("@TrangThai", nsx.TrangThaiNSX);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                //MessageBox.Show("Chỉnh sửa nhà sản xuất thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        

        }
        /*public bool delete_nhasanxuat(NhaSanXuatDTO nsx)
        {
            MSSQLConnect dbConnect = new MSSQLConnect();
            dbConnect.Connect();
            try
            {
                
                // string query = "UPDATE NhaSanXuat SET TrangthaiNSX = 0 WHERE MaNSX = @MaNSX";\
                string query = "Delete  From NhaSanXuat where MaNSX = @MaNSX";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                // Execute the SQL command
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa nhà sản xuất thành công."); // Display a success message //Lỗi: Không thể xóa sản phẩm vì có khóa ngoại tham chiếu.
                    return true;
                }
                else
                {
                    return false;
                }
               
               


               }
                catch (Exception e)
                {
                int rowsAffected;
                bool kiemtra;
                DialogResult check =  MessageBox.Show("Lỗi: Không thể xóa sản phẩm vì có khóa ngoại tham chiếu.");
                DialogResult result = MessageBox.Show("Thông báo:Bạn có muốn thay đổi trạng thái không ?");
                if (result == DialogResult.OK)
                {
                    string query = "UPDATE NhaSanXuat SET TrangthaiNSX = 0 WHERE MaNSX = @MaNSX";
                    // string query = "Delete  From NhaSanXuat where MaNSX = @MaNSX";
                    SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                    cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                    // Execute the SQL command
                        rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa nhà sản xuất thành công."); // Display a success message
                        kiemtra = true;
                    }
                    else
                    {
                        kiemtra = false;
                    }
                }
                else
                {
                    MessageBox.Show("Thông báo:Giữ nguyên");
                    kiemtra = false;
                }
                return true;

            }
                            finally
                            {
                                Disconnect();
                            }
                        }
                    }
                }*/

        public bool delete_nhasanxuat(string MaNSX, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from nhasanxuat where MaNSX = @MaNSX";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaNSX", MaNSX).SqlDbType = SqlDbType.Char;
                cmd.ExecuteNonQuery();
                isLoiKhoaNgoai = false;
                return true;
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547) // Mã lỗi 547 là mã lỗi cho việc tham chiếu đến khóa ngoại
                {
                    Console.WriteLine("Lỗi: Không thể xóa nhà sản xuất vì có khóa ngoại tham chiếu.");
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
        public bool update_nhasanxuat(int trangThai, string maSP)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nhasanxuat set TrangThai = @TrangThai where MaNSX = @MaNSX";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaNSX", maSP).SqlDbType = SqlDbType.Char;
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
