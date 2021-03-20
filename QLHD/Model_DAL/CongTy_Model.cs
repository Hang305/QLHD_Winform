using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Model_DAL
{
    public class CongTy_Model
    {
        string [ ] name = { };
        object [ ] value = { };

        Model_Data model = new Model_Data();

        public DataTable select_CongTy()
        {
            return model.select_sql("Selete_CongTy");
        }
        public DataTable selectWhere_CongTy(string MaCty)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@MaCty"; value [ 0 ] = MaCty;
            return model.selectWhere_sql("SeleteWhere_CongTy",name,value,1);
        }
        public int insert_CongTy(string MaCT, string TenCT, string DiaChi, int SDT, int Fax, int MST)
        {
            name = new string [ 6 ];
            value = new string [ 6 ];

            name [ 0 ] = "@MaCty"; value [ 0 ] = MaCT;
            name [ 1 ] = "@TenCty"; value [ 1 ] = TenCT;
            name [ 2 ] = "@DiaChi"; value [ 2 ] = DiaChi;
            name [ 3 ] = "@SDT"; value [ 3 ] = SDT.ToString();
            name [ 4 ] = "@Fax"; value [ 4 ] = Fax.ToString();
            name [ 5 ] = "@MSTCty"; value [ 5 ] = MST.ToString();
            return model.ThucHien_sql("Update_CongTy",name, value,6);
        }
        public int update_CongTy(string MaCT,string TenCT, string DiaChi, int SDT, int Fax, int MST)
        {
            name = new string [ 6 ];
            value = new string [ 6 ];

            name [ 0 ] = "@MaCty"; value [ 0 ] = MaCT;
            name [ 1 ] = "@TenCty"; value [ 1 ] = TenCT;
            name [ 2 ] = "@DiaChi"; value [ 2 ] = DiaChi;
            name [ 3 ] = "@SDT"; value [ 3 ] = SDT.ToString();
            name [ 4 ] = "@Fax"; value [ 4 ] = Fax.ToString();
            name [ 5 ] = "@MSTCty"; value [ 5 ] = MST.ToString();
            return model.ThucHien_sql("Insert_CongTy", name, value, 6);
        }
        public int delete_CongTy(string MaCT)
        {
            name = new string [ 6 ];
            value = new string [ 6 ];

            name [ 0 ] = "@MaCty"; value [ 0 ] = MaCT;
            return model.ThucHien_sql("Delete_CongTy", name, value, 1);
        }
    }
}
