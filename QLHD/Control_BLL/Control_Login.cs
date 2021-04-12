using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model_DAL;

namespace Control_BLL
{
   public class Control_Login
    {
        TaiKhoan_Model TaiKhoan = new TaiKhoan_Model();

        public DataTable login(string tentk, string matkhau)
        {
            return TaiKhoan.login( tentk,  matkhau);
        }
    }
}
