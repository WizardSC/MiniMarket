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
    public class NhanVienBLL
    {
        private NhanVienDAL nvDAL;

        public NhanVienBLL()
        {
            nvDAL = new NhanVienDAL();
        }
        public List<NhanVienDTO> getListNV()
        {
            return nvDAL.getListNV();
        }
        public DataTable getListNhanVien()
        {
            return nvDAL.getListNhanVien();
        }
        public DataTable getListNVNoHasTaiKhoan()
        {
            
            return nvDAL.getListNhanVienNoHasTK();
        }
        public DataTable getListNVHasTaiKhoan()
        {

            return nvDAL.getListNhanVienHasTK();
        }
        public string getMaxMaNhanVien()
        {
            return nvDAL.getMaxMaNhanVien();
        }

        public DataTable getCurrentNVHasTK(string maNV)
        {
            return nvDAL.getCurrentNVHasTK(maNV);
        }
        public bool insertNhanVien(NhanVienDTO nv)
        {
            return nvDAL.insertNhanVien(nv);
        }
        public bool updateNhanVien(NhanVienDTO nv)
        {
            return nvDAL.updateNhanVien(nv);
        }
        public bool deleteNhanVien(string maNV, out bool isLoiKhoaNgoai)
        {
            return nvDAL.deleteNhanVien(maNV, out isLoiKhoaNgoai);
        }
        public bool updateTrangThai(int trangThai, string maNV)
        {
            trangThai = (trangThai == 0) ? 1 : 0;
            return nvDAL.updateTrangThai(trangThai, maNV);
        }
        public bool updateTaiKhoan(string maTK, string maNV)
        {
            return nvDAL.updateTaiKhoan(maTK,maNV);
        }
    }
}
