using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL : MSSQLConnect
    {
        public PhanQuyenDAL()
        {

        }
        public bool insertPhanQuyen(string tenPQ)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ThemPhanQuyen";
                cmd.Parameters.Add("@TenPQ", SqlDbType.NVarChar, 30).Value = tenPQ;

                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                return true; // Thêm thành công
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu cần
                Console.WriteLine("Lỗi: " + ex.Message);
                return false; // Thêm thất bại
            }
            finally
            {
                Disconnect();
            }
        }
        public PhanQuyenDTO getPhanQuyen(string tenPQ)
        {
            //List<PhanQuyenDTO> listPQ = new List<PhanQuyenDTO>();
            PhanQuyenDTO pq = null;
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand("select * from phanquyen where TenPQ = @TenPQ",conn);
                cmd.Parameters.AddWithValue("@TenPQ", tenPQ);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pq = new PhanQuyenDTO();
                    pq.TenPQ = reader["TenPQ"].ToString();
                    pq.IsBanHang = int.Parse(reader["BanHang"].ToString());
                    pq.IsHoaDon = int.Parse(reader["HoaDon"].ToString());
                    pq.IsNhapHang = int.Parse(reader["NhapHang"].ToString());
                    pq.IsPhieuNhap = int.Parse(reader["PhieuNhap"].ToString());
                    pq.IsKhachHang = int.Parse(reader["KhachHang"].ToString());
                    pq.IsNhanVien = int.Parse(reader["NhanVien"].ToString());
                    pq.IsSanPham = int.Parse(reader["SanPham"].ToString());
                    pq.IsLoai = int.Parse(reader["Loai"].ToString());
                    pq.IsNhaSanXuat = int.Parse(reader["NhaSanXuat"].ToString());
                    pq.IsChucVu = int.Parse(reader["ChucVu"].ToString());
                    pq.IsKhuyenMai = int.Parse(reader["KhuyenMai"].ToString());
                    pq.IsNhaCungCap = int.Parse(reader["NhaCungCap"].ToString());
                    pq.IsThongKe = int.Parse(reader["ThongKe"].ToString());
                    pq.IsTaiKhoan = int.Parse(reader["TaiKhoan"].ToString());
                    pq.IsPhanQuyen = int.Parse(reader["PhanQuyen"].ToString());

                    //listPQ.Add(pq);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex);
                return null;
            }
            finally
            {
                Disconnect();
            }
            return pq;
        }

        public bool updatePhanQuyen(PhanQuyenDTO pq)
        {
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE PhanQuyen SET BanHang = @BanHang, HoaDon = @HoaDon,NhapHang = @NhapHang,PhieuNhap = @PhieuNhap,\r\n    KhachHang = @KhachHang,\r\n    NhanVien = @NhanVien,\r\n    SanPham = @SanPham,\r\n    Loai = @Loai,\r\n    NhaSanXuat = @NhaSanXuat,\r\n    ChucVu = @ChucVu,\r\n    KhuyenMai = @KhuyenMai,\r\n    NhaCungCap = @NhaCungCap,\r\n    ThongKe = @ThongKe,\r\n    TaiKhoan = @TaiKhoan,\r\n    PhanQuyen = @PhanQuyen\r\nWHERE TenPQ = @TenPQ;";
                cmd.Parameters.Add("@BanHang", SqlDbType.TinyInt).Value = pq.IsBanHang;
                cmd.Parameters.Add("@HoaDon", SqlDbType.TinyInt).Value = pq.IsHoaDon;
                cmd.Parameters.Add("@NhapHang", SqlDbType.TinyInt).Value = pq.IsNhapHang;
                cmd.Parameters.Add("@PhieuNhap", SqlDbType.TinyInt).Value = pq.IsPhieuNhap;
                cmd.Parameters.Add("@KhachHang", SqlDbType.TinyInt).Value = pq.IsKhachHang;
                cmd.Parameters.Add("@NhanVien", SqlDbType.TinyInt).Value = pq.IsNhanVien;
                cmd.Parameters.Add("@SanPham", SqlDbType.TinyInt).Value = pq.IsSanPham;
                cmd.Parameters.Add("@Loai", SqlDbType.TinyInt).Value = pq.IsLoai;
                cmd.Parameters.Add("@NhaSanXuat", SqlDbType.TinyInt).Value = pq.IsNhaSanXuat;
                cmd.Parameters.Add("@ChucVu", SqlDbType.TinyInt).Value = pq.IsChucVu;
                cmd.Parameters.Add("@KhuyenMai", SqlDbType.TinyInt).Value = pq.IsKhuyenMai;
                cmd.Parameters.Add("@NhaCungCap", SqlDbType.TinyInt).Value = pq.IsNhaCungCap;
                cmd.Parameters.Add("@ThongKe", SqlDbType.TinyInt).Value = pq.IsThongKe;
                cmd.Parameters.Add("@TaiKhoan", SqlDbType.TinyInt).Value = pq.IsTaiKhoan;
                cmd.Parameters.Add("@PhanQuyen", SqlDbType.TinyInt).Value = pq.IsPhanQuyen;
                cmd.Parameters.Add("@TenPQ", SqlDbType.NVarChar, 30).Value = pq.TenPQ;
                cmd.Connection = conn;
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
