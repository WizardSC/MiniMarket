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
    public class HoaDonBLL
    {
        private HoaDonDAL hdDAL;
        public HoaDonBLL() { 
            hdDAL = new HoaDonDAL();
        }

        public DataTable getListHoaDon()
        {
            return hdDAL.getListHoaDon();
        }
        public bool insertHoaDon(HoaDonDTO hd)
        {
            return hdDAL.insertHoaDon(hd);
        }
    }
}
