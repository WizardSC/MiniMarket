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
    public class CTPhieuNhapBLL
    {
        private CTPhieuNhapDAL ctpnDAL;
        public CTPhieuNhapBLL()
        {
            ctpnDAL = new CTPhieuNhapDAL();
        }
        public bool insertCTPN(CTPhieuNhapDTO ctpn)
        {
            return ctpnDAL.insertCTPhieuNhap(ctpn);
        }

        public DataTable getListPhieuNhapbyMaPN(string maPN)
        {
            return ctpnDAL.getListPhieuNhapbyMaPN(maPN);
        }
    }
}
