using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model_DAL;

namespace Control_BLL
{
 public   class Control_CongTy
    {
        CongTy_Model CongTy = new CongTy_Model();

        public DataTable select_CongTy()
        {
            return CongTy.select_CongTy();
        }
        public DataTable selectWhere_CTHD(string macty)
        {
            return CongTy.selectWhere_CongTy(macty);
        }

        public int insert_CongTy(string MaCT, string TenCT, string DiaChi, int SDT, int Fax, int MST)
        {
            return CongTy.insert_CongTy( MaCT,  TenCT,  DiaChi,  SDT,  Fax,  MST);
        }
        public int update_CongTy(string MaCT, string TenCT, string DiaChi, int SDT, int Fax, int MST)
        {
            return CongTy.update_CongTy(MaCT, TenCT, DiaChi, SDT, Fax, MST);
        }
        public int delete_CongTy(string MaCT)
        {
            return CongTy.delete_CongTy( MaCT);
        }
    }
}
