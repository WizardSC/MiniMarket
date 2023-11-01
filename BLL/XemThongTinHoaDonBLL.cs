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
        private XemThongTinHoaDonDAL HoaDonDAL;

        public XemThongTinHoaDonBLL()
        {
            HoaDonDAL = new XemThongTinHoaDonDAL();
        }

        public DataTable getXemListDsHoaDon()
        {
            return HoaDonDAL.getXemListHoaDon();
        }
    }
}
