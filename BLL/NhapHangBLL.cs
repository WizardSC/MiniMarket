using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhapHangBLL
    {
        public NhapHangDAL nhDAL;
        public NhapHangBLL()
        {
            nhDAL = new NhapHangDAL();
        }

        public DataTable getListNhapHang()
        {
            return nhDAL.getListSPToNhapHang();
        }

        public DataTable getThongTinCTPhieuNhap(string maPN)
        {
            return nhDAL.getThongTinCTPhieuNhap(maPN);
        }
    }
}
