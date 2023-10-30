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

            public DataTable getThongTinSPKM(string MaKM)
            {
                return kmDAL.getThongTinKM(MaKM);
            }
        public DataTable getListMaKmNoDK()
        {
            return kmDAL.getMaKmNoDK();
        }
        public bool insertKhuyenMai(KhuyenMaiDTO KM_DTO)
            {
                return kmDAL.insert_KhuyenMai(KM_DTO);
            }
            public bool UpdateKhuyenMai(KhuyenMaiDTO KM_DTO)
            {
                return kmDAL.Update_KhuyenMai(KM_DTO);
            }
            public bool deleteKhuyenMai(string maKM, out bool isLoiKhoaNgoai)
            {
                return kmDAL.delete_khuyenMai(maKM, out isLoiKhoaNgoai);
            }
            public bool updateTrangThai(int trangThai, string maKM)
            {
                trangThai = (trangThai == 0) ? 1 : 0;
                return kmDAL.update_TrangThai(trangThai, maKM);
            }
    }
}
