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
        public List<SanPhamDTO> getListSP()
        {
            return spDAL.getListSP();
        }
        public bool insertSanPham(SanPhamDTO sp)
        {
            return spDAL.insertSanPham(sp);
        }
        public bool updateSanPham(SanPhamDTO sp)
        {
            return spDAL.updateSanPham(sp);
        }
        public bool deleteSanPham(string maSP, out bool isLoiKhoaNgoai)
        {
            return spDAL.deleteSanPham(maSP, out isLoiKhoaNgoai);
        }
        public bool updateTrangThai(int trangThai, string maSP)
        {
            trangThai = (trangThai == 0) ? 1 : 0;
            return spDAL.updateTrangThai(trangThai, maSP);
        }

        public bool updateTonKho(string maSP,int soLuong)
        {
            return spDAL.updateTonKho(maSP, soLuong);
        }
    }
}
