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
    public class CTHoaDonBLL
    {
        private CTHoaDonDAL cthdDAL;
        public CTHoaDonBLL()
        {
            cthdDAL = new CTHoaDonDAL();    
        }
        public DataTable getListCTHDbyMaHD(string maHD)
        {
            return cthdDAL.getListCTHDByMaHD(maHD);
        }
        public bool insertCTHoaDon(CTHoaDonDTO cthd)
        {
            return cthdDAL.insertCTHoaDon(cthd);
        }
    }
}
