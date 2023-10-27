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
        public bool InsertNhaCC(NhaCungCapDTO nhacc)
        {
            return nccDAL.InsertNhaCC(nhacc);
        }
        public bool deleteNhaCC(string maNCC, out bool isLoiKhoaNgoai)
        {
            return nccDAL.deleteNhaCC(maNCC, out isLoiKhoaNgoai);
        }
        public bool updateTrangThai(String maNCC, int trangthai)
        {
            return nccDAL.updateTrangThai(trangthai, maNCC);
        }
        public bool updateNhaCC(NhaCungCapDTO nhacc)
        {
            return nccDAL.updateNhaCC(nhacc);
        }
    }   

}
