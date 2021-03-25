using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model_DAL;

namespace Control_BLL
{
   public class Control_HoaDon
    {
        HoaDon_Model HoaDon = new HoaDon_Model();
      
        public DataTable select_HoaDon()
        {
            return HoaDon.select_HoaDon();
        }
        public DataTable selectWhere_HoaDon(string sohd)
        {
            return HoaDon.selectWhere_HoaDon(sohd);
        }
        public DataTable selectFind_HoaDon()
        {
            return HoaDon.selectFind_HoaDon();
        }
        public string automatic_MaMax(string Bang,string Ma)
        {
            return HoaDon.Actomatic_Ma(Bang, Ma);
        }

        public int insert_HoaDon( string Sohd,DateTime ngaylap,string hinhthuctt, string makh, string manv, string mact)
        {
            return HoaDon.insert_HoaDon(Sohd, ngaylap, hinhthuctt, makh,  manv,  mact);
        }
        public int update_HoaDon(string sohd,DateTime ngaylap, string hinhthuctt, string makh, string manv, string mact)
        {
            return HoaDon.update_HoaDon( sohd,  ngaylap,  hinhthuctt, makh,  manv,  mact);
        }
        public int delete_HoaDon(string sohd)
        {
            return HoaDon.delete_HoaDon(sohd);
        }

        public int selectFind_HoaDon(string Sohd, DateTime ngaylap, string hinhthuctt, string makh, string manv, string mact)
        {
            return HoaDon.insert_HoaDon(Sohd, ngaylap, hinhthuctt, makh, manv, mact);
        }

    }
}
