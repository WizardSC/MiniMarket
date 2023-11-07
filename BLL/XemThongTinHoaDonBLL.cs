using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class XemThongTinHoaDonBLL
    {
        private XemThongTinHoaDonDAL XemThongTinHoaDonDAL;

        public XemThongTinHoaDonBLL()
        {
            XemThongTinHoaDonDAL = new XemThongTinHoaDonDAL();
        }

        public DataTable getXemListDsHoaDon()
        {
            // return HoaDonDAL.getXemListHoaDon();
            return null;
        }
    }
}
