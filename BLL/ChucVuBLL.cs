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
    public class ChucVuBLL
    {
        private ChucVuDAL cvDAL;
        public ChucVuBLL()
        {
            cvDAL = new ChucVuDAL();
        }

        public DataTable getListChucVu()
        {
            return cvDAL.getListChucVu();
        }
        public bool insertCV(ChucVuDTO nv)
        {
            return cvDAL.insertChucVu(nv);
        }
        public bool updateCV(ChucVuDTO nv)
        {
            return cvDAL.updateChucVu(nv);
        }
        public bool deleteCV(string maNV, out bool isLoiKhoaNgoai)
        {
            return cvDAL.deleteChucVu(maNV, out isLoiKhoaNgoai);
        }
        public string getMaxMaCV()
        {
            return cvDAL.getMaxMaChucVu();
        }
        public bool updateTrangThai(int trangThai, string macv)
        {
            trangThai = (trangThai == 0) ? 1 : 0;
            return cvDAL.updateTrangThai(trangThai, macv);
        }
    }
}
