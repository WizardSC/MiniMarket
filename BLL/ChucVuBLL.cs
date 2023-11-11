using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChucVuBLL
    {
        private ChucVuDAL cvDAL;
        public ChucVuBLL()
        {
            cvDAL = new ChucVuDAL();
        }

        public DataTable getListChucVu()
        {
            return cvDAL.getListChucVu();
        }
    }
}
