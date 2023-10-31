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
    public class XemPhieuNhapT_BLL
    {
        private XemPhieuNhap_DAL PnDAL;

        public XemPhieuNhapT_BLL()
        {
            PnDAL = new XemPhieuNhap_DAL();
        }

        public DataTable getListDsPhieuNhap()
        {
            return PnDAL.getListPhieuNhap();
        }
        public DataTable getListDsChiTietPhieuNhap(string MaPN)
        {
            return PnDAL.getListChiTietPhieuNhap(MaPN);
        }
    }
}
