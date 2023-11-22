using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BanHangBLL
    {
        private BanHangDAL bhDAL;
        public BanHangBLL()
        {
            bhDAL = new BanHangDAL();
        }

        public DataTable getListSanPhamActive()
        {
            return bhDAL.getListSanPhamActive();
        }
    }
}
