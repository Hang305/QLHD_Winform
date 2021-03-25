using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model_DAL;

namespace Control_BLL
{
   public class Control_KhachHang
    {
        KhachHang_Model KhachHang = new KhachHang_Model();
        automaticMa_Model automaticMa = new automaticMa_Model();

        public DataTable select_KhachHang()
        {
            return KhachHang.select_KhachHang();
        }
        public DataTable selectWhere_KhachHang(string makh)
        {
            return KhachHang.selectWhere_KhachHang(makh);
        }
        public string automatic_MaMax(string Bang, string Ma)
        {
            return automaticMa.Actomatic_Ma(Bang, Ma);
        }

        public int insert_KhachHang(string MaKH, string Hoten, string TenCT, string MST, string DiaChi)
        {
            return KhachHang.insert_KhachHang( MaKH,  Hoten,  TenCT,  MST,  DiaChi);
        }
        public int update_KhachHang(string MaKH, string Hoten, string TenCT, string MST, string DiaChi)
        {
            return KhachHang.update_KhachHang(MaKH, Hoten, TenCT, MST, DiaChi);
        }
        public int delete_KhachHang(string MaKH)
        {
            return KhachHang.delete_KhachHang(MaKH);
        }
    }
}
