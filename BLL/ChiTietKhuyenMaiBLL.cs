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
    public class ChiTietKhuyenMaiBLL
    {
        private ChiTietKhuyenMaiDAL CtKmDAL;
        private List<ChiTietKhuyenMaiDTO> listChiTietKhuyenMai = null;

        public ChiTietKhuyenMaiBLL()
        {
            CtKmDAL = new ChiTietKhuyenMaiDAL();
        }

        public DataTable getListDsCTKm()
        {
            return CtKmDAL.getListChiTietKhuyenMai();
        }

        public bool insertCTKhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {
            return CtKmDAL.insert_CTKhuyenMai(CTKM_DTO);
        }
        public bool UpdateCTKhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {
            return CtKmDAL.Update_CTKhuyenMai(CTKM_DTO);
        }
        public bool deleteCTKhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {
            return CtKmDAL.delete_ChiTietkhuyenMai(CTKM_DTO);
        }
    }
}
