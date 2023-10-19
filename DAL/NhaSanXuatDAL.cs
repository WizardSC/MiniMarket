using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
