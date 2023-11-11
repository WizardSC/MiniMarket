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
        private List<LoaiDTO> listLoai;
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

        public DataTable getListLoaiMini()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select MaLoai, TenLoai from LoaiSP where TrangThai = 1";
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
        public bool insertLoaiSP(LoaiDTO LSP)
        {
            try
                {
                Console.WriteLine("test");
                MSSQLConnect dbConnect = new MSSQLConnect();
                    dbConnect.Connect();
                    // string query = "INSERT INTO KhuyenMai(MaKM,TenKM,NgayBatDau,NgayKetThuc,PhanTramKM,DieuKienKM,TrangThaiKM) VALUES(@MaKM,@TenKM,@NgayBatDau,@NgayKetThuc,@PhanTramKM,@DieuKienKM,@TrangThaiKM)";
                    string query = "INSERT INTO LoaiSP(MaLoai,TenLoai,TrangThai) VALUES(@MaLoai,@TenLoai,@TrangThai)";
                    SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                    cmd.Parameters.AddWithValue("@MaLoai", LSP.MaLoai);
                    cmd.Parameters.AddWithValue("@TenLoai", LSP.TenLoai);
                    cmd.Parameters.AddWithValue("@TrangThai", LSP.TrangThaiLoai);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        //MessageBox.Show("Thêm loại sản phẩm thành công thành công."); // Display a success message
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                catch (Exception e)
                {
                    //MessageBox.Show("Thêm loại sản phẩm thất bại. " + e.Message);
                    return false;
                }
                finally
                {
                    Disconnect();
                }

            }

       public bool update_LoaiSP(LoaiDTO LSP)
        {
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "UPDATE LoaiSP SET TenLoai = @TenLoai,TrangThai = @TrangThai  WHERE MaLoai = @MaLoai";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaLoai", LSP.MaLoai);
                cmd.Parameters.AddWithValue("@TenLoai", LSP.TenLoai);
                cmd.Parameters.AddWithValue("@TrangThai", LSP.TrangThaiLoai);
                cmd.ExecuteNonQuery();

                return true;
            }
            catch (Exception e)
            {
               //MessageBox.Show("Chỉnh sửa loại thất bại. " + e.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }


        }
        public bool delete_LoaiSP(string MaLoai, out bool isLoiKhoaNgoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from loaisp where MaLoai = @MaLoai";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@MaLoai", MaLoai).SqlDbType = SqlDbType.Char;
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

        public bool update_LoaiSP(int trangThai, string MaLoai)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update LoaiSP set TrangThai = @TrangThai where MaLoai = @MaLoai";
                cmd.Connection = conn;
                cmd.Parameters.AddWithValue("@TrangThai", trangThai).SqlDbType = SqlDbType.Int;
                cmd.Parameters.AddWithValue("@MaLoai", MaLoai).SqlDbType = SqlDbType.Char;
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

        public void Export(String file)
        {
           
            List<LoaiDTO> loai = listLoai;

        }
    }
}
