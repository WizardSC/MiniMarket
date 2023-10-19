using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaSanXuatBLL
    {
        private NhaSanXuatDAL nsxDAL;
        public NhaSanXuatBLL()
        {
            nsxDAL = new NhaSanXuatDAL();
        }

        public DataTable getListNSX()
        {
            return nsxDAL.getListNhaSanXuat();
        }
    }
}
