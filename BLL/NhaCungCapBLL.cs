using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL nccDAL;
        public NhaCungCapBLL()
        {
            nccDAL = new NhaCungCapDAL();
        }
        public DataTable getListNCC()
        {
            return nccDAL.getListNhaCC();
        }
    }
}
