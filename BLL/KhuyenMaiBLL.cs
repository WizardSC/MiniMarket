using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DTO.KhuyenMaiDTO;

namespace BUS
{
    public class KhuyenMaiBLL
    {
        
            private KhuyenMaiDAL kmDAL;
            private List<KhuyenMai_DTO> listKhuyenMai = null;

            public KhuyenMaiBLL()
            {
                kmDAL = new KhuyenMaiDAL();
            }

            public DataTable getListDsKm()
            {
                return kmDAL.getListKhuyenMai();
            }
        
    }
}
