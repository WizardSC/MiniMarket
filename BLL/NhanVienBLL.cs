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
    public class NhanVienBLL
    {
        private NhanVienDAL nvDAL;
        private List<NhanVienDTO> listNhanVien = null;

        public NhanVienBLL()
        {
            nvDAL = new NhanVienDAL();
        }

        public DataTable getListNhanVien()
        {
            return nvDAL.getListNhanVien();
        }

        public bool insertNhanVien(NhanVienDTO nv)
        {
            return nvDAL.insertNhanVien(nv);
        }
    }
}
