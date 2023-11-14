using DTO;
using System;
using System.Collections.Generic;
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
    }
}
