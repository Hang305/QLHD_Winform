using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Model_DAL
{
  public  class TaiKhoan_Model
    {
        string [ ] name = { };
        object [ ] value = { };

        Model_Data model = new Model_Data();
       
        public DataTable login(string tentk, string matkhau)
        {
            name = new string [ 2 ];
            value = new object [ 2];

            name [ 0 ] = "@TenTK"; value [ 0 ] = tentk;
            name [ 1 ] = "@MatKhau"; value [ 1] = matkhau;
           
            return model.selectWhere_sql("login", name, value, 2);
        }
    }
}
