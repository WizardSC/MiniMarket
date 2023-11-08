using DTO;
using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CTHoaDonDAL : MSSQLConnect
    {
        public DataTable getListCTHDByMaHD(string maHD)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select MaSP, TenSP, SoLuong, DonGiaBanDau, DonGiaDaGiam, ThanhTien from ChiTietHoaDon where MaHD = @MaHD";
                cmd.Connection = conn;
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = maHD;
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
        public bool insertCTHoaDon(CTHoaDonDTO cthd)
        {
            try
            {
                Connect();
                string sql = "insert into ChiTietHoaDon values (@MaHD, @MaSP, @TenSP, @SoLuong, @DonGiaBanDau, @DonGiaDaGiam, @PhanTramKM, @ThanhTien)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add("@MaHD", SqlDbType.Char).Value = cthd.MaHD;
                cmd.Parameters.Add("@MaSP", SqlDbType.Char).Value = cthd.MaSP;
                cmd.Parameters.Add("@TenSP", SqlDbType.NVarChar).Value = cthd.TenSP;
                cmd.Parameters.Add("@SoLuong", SqlDbType.Int).Value = cthd.SoLuong;
                cmd.Parameters.Add("@DonGiaBanDau", SqlDbType.Int).Value = cthd.DonGiaBanDau;
                cmd.Parameters.Add("@DonGiaDaGiam", SqlDbType.Int).Value = cthd.DonGiaDaGiam;
                cmd.Parameters.Add("@PhanTramKM", SqlDbType.Int).Value = cthd.PhanTramKM;
                cmd.Parameters.Add("@ThanhTien", SqlDbType.Float).Value = cthd.ThanhTien;
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi:" + ex.Message);
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
