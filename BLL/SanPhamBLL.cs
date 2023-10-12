using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL spDAL;
        private List<SanPhamDTO> listSanPham;
        
        public SanPhamBLL()
        {
            spDAL = new SanPhamDAL();
        }
        public DataTable getListSanPham()
        {
            return spDAL.getListSanPham();
        }
    }
}
