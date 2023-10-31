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
