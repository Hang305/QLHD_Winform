using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model_DAL
{
    public class NhanVien_Model
    {
        string[] name= { };
        object [ ] value= { };

        Model_Data model = new Model_Data();
        //select
        public DataTable select_NhanVien()
        {
            return model.select_sql("Selete_NhanVien");
        }
        //selectWhere
        public DataTable selectWhere_NhanVien(string MaNV)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@MaNV"; value [ 0 ] = MaNV;
            return model.selectWhere_sql("SeleteWhere_NhanVien",name, value,1);
        }
        //insert
        public int insert_NhanVien(string MaNV, string TenNV)
        {
            name = new string [ 2 ];
            value = new string [ 2 ];

            name [ 0 ] = "@MaNV"; value [ 0 ] = MaNV;
            name [ 1 ] = "@TenNV"; value [ 1 ] = TenNV;
            return model.ThucHien_sql("Insert_NhanVien", name, value, 2);

        }
        //update
        public int update_NhanVien(string MaNV, string TenNV)
        {
            name = new string [ 2 ];
            value = new string [ 2 ];

            name [ 0 ] = "@MaNV"; value [ 0 ] = MaNV;
            name [ 1 ] = "@TenNV"; value [ 1 ] = TenNV;
            return model.ThucHien_sql("Update_NhanVien",name,value,2);
        }
        //delete
         public int delete_NhanVien(string MaNV)
        {
            name = new string [ 1 ];
            value = new string [ 1 ];

            name [ 0 ] = "@MaNV"; value [ 0 ] = MaNV;
            return model.ThucHien_sql("Delete_NhanVien", name, value, 1);
        }
    }
}
