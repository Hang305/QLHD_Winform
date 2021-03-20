using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model_DAL;

namespace Control_BLL
{
   public class Control_NhanVien
    {

        NhanVien_Model NhanVien = new NhanVien_Model();

        public DataTable select_NhanVien()
        {
            return NhanVien.select_NhanVien();
        }
        public DataTable select_NhanVien(string manv)
        {
            return NhanVien.selectWhere_NhanVien(manv);
        }

        public int insert_NhanVien(string MaNV, string TenNV)
        {
            return NhanVien.insert_NhanVien( MaNV,  TenNV);
        }
        public int update_NhanVien(string MaNV, string TenNV)
        {
            return NhanVien.update_NhanVien( MaNV,  TenNV);
        }
        public int delete_NhanVien(string MaNV)
        {
            return NhanVien.delete_NhanVien(MaNV);
        }
    }
}
