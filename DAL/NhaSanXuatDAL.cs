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
                string query = "INSERT INTO NhaSanXuat(MaNSX,TenNSX,DiaChi,SoDT, TrangthaiNSX) VALUES(@MaNSX,@TenNSX,@DiaChi,@SoDT,1)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                cmd.Parameters.AddWithValue("@TenNSX", nsx.TenNSX);
                cmd.Parameters.AddWithValue("@DiaChi", nsx.DiaChi);
                cmd.Parameters.AddWithValue("@SoDT", nsx.SoDT);
                
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
                string query = "UPDATE NhaSanXuat SET TenNSX = @TenNSX, DiaChi = @DiaChi, SoDT = @SoDT WHERE MaNSX = @MaNSX";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                cmd.Parameters.AddWithValue("@TenNSX", nsx.TenNSX);
                cmd.Parameters.AddWithValue("@DiaChi", nsx.DiaChi);
                cmd.Parameters.AddWithValue("@SoDT", nsx.SoDT);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Chỉnh sửa nhà sản xuất thành công."); // Display a success message
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Chỉnh sửa nhà sản xuất thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        

        }
        public bool delete_nhasanxuat(NhaSanXuatDTO nsx)
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
                    MessageBox.Show("Xóa nhà sản xuất thành công."); // Display a success message
                    return true;
                }
                else
                {
                    return false;
                }
               
               


               }
                catch (Exception e)
                            {
                string query = "UPDATE NhaSanXuat SET TrangthaiNSX = 0 WHERE MaNSX = @MaNSX";
               // string query = "Delete  From NhaSanXuat where MaNSX = @MaNSX";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaNSX", nsx.MaNSX);
                // Execute the SQL command
                cmd.ExecuteNonQuery();
                return true;
                
                            }
                            finally
                            {
                                Disconnect();
                            }
                        }
                    }
                }
