using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MSSQLConnect
    {
        public SqlConnection conn = null;
        //Thái
        //string strconn = @"Data Source=DESKTOP-G0C5JTO\LEHONGTHAI;Initial Catalog = MiniMarket; Integrated Security = True";

        //Toàn đẹp try wizard
        // string strconn = @"Data Source=LAPTOP-AEI9M0MI\WIZARDSC;Initial Catalog = MiniMarket; Integrated Security = True";


        //string strconn = @"Data Source=LAPTOP-AEI9M0MI\WIZARDSC;Initial Catalog = MiniMarket; Integrated Security = True";


        //Minh Toàn/
        //TheVinh
        string strconn = @"Data Source=MSI\MSSQLSERVER_1;Initial Catalog = MiniMarket; Integrated Security = True";
        //TheVinh
        //string strconn = @"Data Source=MSI;Initial Catalog = MiniMarket3110; Integrated Security = True";

        public void Connect()
        {
            if (conn == null)
            {
                conn = new SqlConnection(strconn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void Disconnect()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
