using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model_DAL;

namespace Control_BLL
{
   public class Control_CTHD
    {
        CTHD_Model CTHD = new CTHD_Model();

        public DataTable select_CTHD()
        {
            return CTHD.select_CTHD();
        }
        public DataTable selectWhere_CTHD(string sohd,string mahh)
        {
            return CTHD.selectWhere_CTHD(sohd,mahh);
        }
        public DataTable selectWhereSoHD_CTHD(string sohd)
        {
            return CTHD.selectWhereSoHD_CTHD(sohd);
        }
        public DataTable selectFind_CTHD(string sohd)
        {
            return CTHD.selectFind_CTHD(sohd);
        }
        public int insert_CTHD(string sohd, string mahh, int soluong)
        {
            return CTHD.Insert_CTHD(sohd, mahh, soluong);
        }
        public int update_CTHD(string sohd,  string mahh, int soluong)
        {
            return CTHD.update_CTHD(sohd,mahh, soluong );
        }
        public int delete_CTHD(string sohd)
        {
            return CTHD.delete_CTHD(sohd);
        }
    }
}
