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
    public class NhaSanXuatBLL
    {
        private NhaSanXuatDAL nsxDAL;
        private List<NhaSanXuatDTO> listNhaSanXuat = null;
        public NhaSanXuatBLL()
        {
            nsxDAL = new NhaSanXuatDAL();
        }
        public DataTable getListNSX()
        {
            return nsxDAL.getListNhaSanXuat();
        }
        public bool insertNhaSanXuat(NhaSanXuatDTO nsx)
        {
            return nsxDAL.insertNhaSanXuat(nsx);
        }

        public bool update_nhasanxuat(NhaSanXuatDTO nsx)
        {
            return nsxDAL.update_nhasanxuat(nsx);
        }
        public bool delete_nhasanxuat(NhaSanXuatDTO nsx)
        {
            return nsxDAL.delete_nhasanxuat(nsx);
        }
    }
}
