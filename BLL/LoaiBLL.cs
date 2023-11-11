using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiBLL
    {
        private LoaiDAL loaiDAL;
        public LoaiBLL()
        {
            loaiDAL = new LoaiDAL();
        }
        public DataTable getListLoai()
        {
            return loaiDAL.getListLoai();
        }
        public bool insert_LoaiSP(LoaiDTO LSP)
        {
            return loaiDAL.insertLoaiSP(LSP);
        }
        public bool delete_LoaiSP(string MaNSX, out bool isLoiKhoaNgoai)
        {
            return loaiDAL.delete_LoaiSP(MaNSX, out isLoiKhoaNgoai);
        }
        public bool update_LoaiSP(int Trangthai, string MaLoai)
        {
            Trangthai = (Trangthai == 0) ? 1 : 0;
           return loaiDAL.update_LoaiSP(Trangthai, MaLoai);
        }
        public bool update_LoaiSP(LoaiDTO loaiDTO)
        {
            return loaiDAL.update_LoaiSP(loaiDTO);
        }
    }
}
