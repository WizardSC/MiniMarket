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
    public class NhaCungCapBLL
    {
        private NhaCungCapDAL nccDAL;
        public NhaCungCapBLL()
        {
            nccDAL = new NhaCungCapDAL();
        }
        public DataTable getListNCC()
        {
            return nccDAL.getListNhaCC();
        }
        public bool insertNhaCungCap(NhaCungCapDTO ncc)
        {
            return nccDAL.insertNhaCC(ncc);
        }
        public bool updateNhaCC(NhaCungCapDTO ncc)
        {
            return nccDAL.updateNhaCC(ncc);
        }
        public bool deleteNhaCCC(string maNCC, out bool isLoiKhoaNgoai)
        {
            return nccDAL.deleteNhaCC(maNCC, out isLoiKhoaNgoai);
        }
        public bool updateTrangThai(int trangThai, string maNCC)
        {
            trangThai = (trangThai == 0) ? 1 : 0;
            return nccDAL.updateTrangThai(trangThai, maNCC);
        }
    }
}
