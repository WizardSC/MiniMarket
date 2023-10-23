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
    }
}
