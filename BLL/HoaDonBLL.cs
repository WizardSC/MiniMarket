using DAL;
using DTO;
using System;
using System.Collections.Generic;
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

        public bool insertHoaDon(HoaDonDTO hd)
        {
            return hdDAL.insertHoaDon(hd);
        }
    }
}
