﻿using DAL;
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
        public string getMaxMaNhaSX()
        {
            return nsxDAL.getMaxMaNhaSX();
        }
        public DataTable getListNSXMini()
        {
            return nsxDAL.getListNhaSanXuatMini();
        }
        public bool insertNhaSanXuat(NhaSanXuatDTO nsx)
        {
            return nsxDAL.insertNhaSanXuat(nsx);
        }

        public bool update_nhasanxuat(NhaSanXuatDTO nsx)
        {
            return nsxDAL.update_nhasanxuat(nsx);
        }
        //public bool delete_nhasanxuat(NhaSanXuatDTO nsx)maSP, out isLoiKhoaNgoai //string maSP, out bool isLoiKhoaNgoai
        public bool delete_nhasanxuat(string MaNSX, out bool isLoiKhoaNgoai)
        {
            return nsxDAL.delete_nhasanxuat(MaNSX, out isLoiKhoaNgoai);
        }
        public bool update_nhasanxuat(int Trangthai, string MaNSX)
        {
            Trangthai = (Trangthai == 0) ? 1 : 0;
            return nsxDAL.update_nhasanxuat(Trangthai, MaNSX);
        }
    }
}
