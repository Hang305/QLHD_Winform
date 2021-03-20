using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model_DAL;

namespace Control_BLL
{
    public class Control_HangHoa
    {
        HangHoa_Model HangHoa = new HangHoa_Model();

        public DataTable select_HangHoa()
        {
            return HangHoa.select_HangHoa();
        }
        public DataTable selectMaHH_HangHoa()
        {
            return HangHoa.selectMaHH_HangHoa();
        }
        public DataTable selectWhere_HangHoa(string mahh)
        {
            return HangHoa.selectWhere_HangHoa(mahh);
        }
        public int insert_HangHoa(string mahh,string tenhh, string dvt, float dongia)
        {
            return HangHoa.Insert_HangHoa(mahh, tenhh,  dvt,  dongia);
        }
        public int update_HangHoa(string mahh,string tenhh, string dvt, float dongia)
        {
            return HangHoa.update_HangHoa( mahh,  tenhh,  dvt,  dongia);
        }
        public int delete_HangHoa(string mahh)
        {
            return HangHoa.delete_HangHoa(mahh);
        }
       
    }
}
