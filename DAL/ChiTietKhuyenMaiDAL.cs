using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Collections;

namespace DAL
{
    public class ChiTietKhuyenMaiDAL : MSSQLConnect
    {
        public DataTable getListChiTietKhuyenMai()
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ChiTietKhuyenMai.MaKM,ChiTietKhuyenMai.MaSP,KhuyenMai.TenKM," +
                    "SanPham.TenSP,ChiTietKhuyenMai.PhanTramKM,ChiTietKhuyenMai.TrangThai" +
                    " from ChiTietKhuyenMai,KhuyenMai,SanPham" +
                    " where KhuyenMai.MaKM = ChiTietKhuyenMai.MaKM AND SanPham.MaSP = ChiTietKhuyenMai.MaSP";
;
                cmd.Connection = conn;
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                adt.Fill(dt);
            }

            catch (Exception ex)
            {
                
                return null;
            }
            finally
            {
                Disconnect();
            }
            return dt;
        }

       
        public bool insert_CTKhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {

            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query = "INSERT INTO ChiTietKhuyenMai(MaKM,MaSP,PhanTramKM,TrangThai) VALUES(@MaKM,@MaSP,@PhanTramKM,@TrangThai)";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);

                cmd.Parameters.AddWithValue("@MaKm", CTKM_DTO.Makm);
                cmd.Parameters.AddWithValue("@MaSP", CTKM_DTO.Masp);
                cmd.Parameters.AddWithValue("@PhanTramKM", CTKM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@TrangThai", CTKM_DTO.TrangThai);
                cmd.ExecuteReader();
                return true;


            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool Update_CTKhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {
            MSSQLConnect dbConnect = new MSSQLConnect();
            try
            {
                dbConnect.Connect();
                string query = "UPDATE ChiTietKhuyenMai SET MaSP = @MaSP, PhanTramKM = @PhanTramKM, TrangThai = @TrangThai WHERE MaKM = @MaKM";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaKM", CTKM_DTO.Makm);
                cmd.Parameters.AddWithValue("@MaSP", CTKM_DTO.Masp);
                cmd.Parameters.AddWithValue("@PhanTramKM", CTKM_DTO.PhanTramKm);
                cmd.Parameters.AddWithValue("@TrangThai", CTKM_DTO.TrangThai);
                cmd.ExecuteReader();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
        public bool delete_ChiTietkhuyenMai(ChiTietKhuyenMaiDTO CTKM_DTO)
        {
            try
            {
                MSSQLConnect dbConnect = new MSSQLConnect();
                dbConnect.Connect();
                string query= "delete from ChiTietKhuyenMai where MaKM = @MaKM and MaSP = @MaSP";
                SqlCommand cmd = new SqlCommand(query, dbConnect.conn);
                cmd.Parameters.AddWithValue("@MaKM", CTKM_DTO.Makm);
                cmd.Parameters.AddWithValue("@MaSP", CTKM_DTO.Masp);
                cmd.ExecuteReader();
                return true;
            }
            catch (SqlException ex)
            {
                
               
                return false;
            }
            finally
            {
                Disconnect();
            }
        }
       
    }
}
