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
