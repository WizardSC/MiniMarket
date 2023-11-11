using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhapHangDAL : MSSQLConnect
    {
        public DataTable getListSPToNhapHang()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                string sql = "select MaSP, TenSP, SoLuong, DonGiaNhap, TenLoai, TenNCC, SanPham.TrangThai from SanPham join LoaiSP on LoaiSP.MaLoai = SanPham.MaLoai join NhaCungCap on NhaCungCap.MaNCC = SanPham.MaNCC where SanPham.TrangThai = 1";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }
        public DataTable getThongTinCTPhieuNhap(string maPN)
        {

            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select MaSP,TenSP,SoLuong,DonGiaNhap,ThanhTien from ChiTietPhieuNhap where MaPN = @MaPN";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaPN", SqlDbType.Char).Value = maPN;
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
