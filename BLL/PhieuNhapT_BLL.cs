using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapT_BLL
    {
        private PhieuNhap_DAL PnDAL;

        public PhieuNhapT_BLL()
        {
            PnDAL = new PhieuNhap_DAL();
        }

        public DataTable getListDsPhieuNhap()
        {
            return PnDAL.getListPhieuNhap();
        }

    }
}
