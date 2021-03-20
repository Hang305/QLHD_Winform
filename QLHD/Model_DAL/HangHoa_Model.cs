using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model_DAL
{
  public  class HangHoa_Model
    {
        string [ ] name = { };
        object [ ] value = { };

        Model_Data model = new Model_Data();
        //select
        public DataTable select_HangHoa()
        {
            return model.select_sql("Selete_HangHoa");
        }
        //select MaHH
        public DataTable selectMaHH_HangHoa()
        {
            return model.select_sql("SeleteMaHH_HangHoa");
        }

        //selectWhere
        public DataTable selectWhere_HangHoa(string MaHH)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@MaHH"; value [ 0 ] = MaHH;
            return model.selectWhere_sql("SeleteWhere_HangHoa",name,value,1);
        }

        //insert
        public int Insert_HangHoa(string MaHH, string TenHH, string DVT, float DonGia)
        {
            name = new string [ 4 ];
            value = new string [ 4 ];
            name [ 0 ] = "@MaHH"; value [ 0 ] = MaHH;
            name [ 1 ] = "@TenHH"; value [ 1 ] = TenHH;
            name [ 2 ] = "@DVT"; value [ 2 ] = DVT;
            name [ 3 ] = "@DonGia"; value [ 3 ] = DonGia.ToString();
            return model.ThucHien_sql("Insert_HangHoa", name, value, 4);
        }
        //update
        public int update_HangHoa(string MaHH, string TenHH, string DVT, float DonGia)
        {
            name = new string [ 4 ];
            value = new string [ 4 ];
            name [ 0 ] = "@MaHH"; value [ 0 ] = MaHH;
            name [ 1 ] = "@TenHH"; value [ 1 ] = TenHH;
            name [ 2 ] = "@DVT"; value [ 2 ] = DVT;
            name [ 3 ] = "@DonGia"; value [ 3 ] = DonGia.ToString();
            return model.ThucHien_sql("Update_HangHoa",name, value,4);
        }
        //delete
        public int delete_HangHoa(string MaHH)
        {
            name = new string [ 1 ];
            value = new string [ 1];
            name [ 0 ] = "@MaHH"; value [ 0 ] = MaHH;
            return model.ThucHien_sql("Delete_HangHoa", name, value, 1);
        }
    }
}
