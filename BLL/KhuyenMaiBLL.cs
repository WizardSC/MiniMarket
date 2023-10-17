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
    public class KhuyenMaiBLL
    {
        
            private KhuyenMaiDAL kmDAL;
            private List<KhuyenMaiDTO> listKhuyenMai = null;

            public KhuyenMaiBLL()
            {
                kmDAL = new KhuyenMaiDAL();
            }

            public DataTable getListDsKm()
            {
                return kmDAL.getListKhuyenMai();
            }

            public DataTable getThongTinSPKM()
            {
                return kmDAL.getThongTinKM();
            }

    }
}
