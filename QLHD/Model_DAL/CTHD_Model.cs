using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model_DAL
{
   public class CTHD_Model
    {
        string [ ] name = { };
        object [ ] value = { };

        Model_Data model = new Model_Data();
        //select
        public DataTable select_CTHD()
        {
            return model.select_sql("Selete_CTHD");
        }
        //selectWhere
        public DataTable selectWhere_CTHD(string SoHD, string MaHH)
        {
            name = new string [ 2 ];
            value = new object [ 2 ];

            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            name [ 1 ] = "@MaHH"; value [ 1 ] = MaHH;
            return model.selectWhere_sql("SeleteWhere_CTHD", name, value, 2);
        }
        public DataTable selectWhereSoHD_CTHD(string SoHD)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            //name [ 1 ] = "@MaHH"; value [ 1 ] = MaHH;
            return model.selectWhere_sql("SeleteWhereSoHD_CTHD", name, value, 1);
        }
        public DataTable selectFind_CTHD(string SoHD)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            return model.selectWhere_sql("SeleteCTHD_whereFind", name, value, 1);
        }
        //insert
        public int Insert_CTHD(string SoHD, string MaHH, int SoLuong)
        {
            name = new string [ 3 ];
            value = new string [ 3 ];
            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            name [ 1 ] = "@MaHH"; value [ 1 ] = MaHH;
            name [ 2 ] = "@SoLuong"; value [ 2 ] = SoLuong.ToString();

            return model.ThucHien_sql("Insert_CTHD",name, value,3);
        }
        //update
        public int update_CTHD(string SoHD, string MaHH,int SoLuong)
        {
            name = new string [ 3 ];
            value = new string [ 3 ];
            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            name [ 1 ] = "@MaHH"; value [ 1 ] = MaHH;
            name [ 2 ] = "@SoLuong"; value [ 2 ] = SoLuong.ToString();
            return model.ThucHien_sql("Update_CTHD", name, value, 3);
        }
       //delete
        public int delete_CTHD(string SoHD)
        {
            name = new string [ 1 ];
            value = new string [ 1 ];
            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
   
            return model.ThucHien_sql("Delete_CTHD", name, value, 1);
        }
    }
}
