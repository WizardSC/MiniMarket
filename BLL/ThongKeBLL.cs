using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ThongKeBLL
    {
        private ThongKeDAL tkDAL;
        public ThongKeBLL() { 
            tkDAL  = new ThongKeDAL();
        }

        public DataTable getListDoanhThu()
        {
            return tkDAL.getListDoanhThu();
        }

        public DataTable getTopSPBanChay()
        {
            return tkDAL.getTopSPBanChay();
        }

        public DataTable getTopSPBanChayTheoThang(int thang, int soSP)
        {
            return tkDAL.getTopSPBanChayTheoThang(thang, soSP);
        }
    }
}
