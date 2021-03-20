using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Model_DAL
{
    public class KhachHang_Model
    {
        string [ ] name = { };
        object [ ] value = { };


        Model_Data model = new Model_Data();
        //select
        public DataTable select_KhachHang()
        {
            return model.select_sql("Selete_KhachHang");
        }
        //selectWhere
        public DataTable selectWhere_KhachHang(string MaKH)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@MaKH"; value [ 0 ] = MaKH;
            return model.selectWhere_sql("SeleteWhere_KhachHang",name, value,1);
        }
        //insert
        public int insert_KhachHang(string MaKH, string Hoten, string TenCT, string MST, string DiaChi)
        {
            name = new string [ 5 ];
            value = new string [ 5 ];

            name [ 0 ] = "@MaKH"; value [ 0 ] = MaKH;
            name [ 1 ] = "@HoTenKH"; value [ 1 ] = Hoten;
            name [ 2 ] = "@TenCtyKH"; value [ 2 ] = TenCT;
            name [ 3 ] = "@MSTCty"; value [ 3 ] = MST;
            name [ 4 ] = "@DiaChi"; value [ 4 ] = DiaChi;
            return model.ThucHien_sql("Update_KhachHang", name, value, 5);
        }
        //update
        public int update_KhachHang(string MaKH, string Hoten, string TenCT, string MST, string DiaChi)
        {
            name = new string [ 5 ];
            value = new string [ 5 ];

            name [ 0 ] = "@MaKH"; value [ 0 ] = MaKH;
            name [ 1 ] = "@HoTenKH"; value [ 1 ] = Hoten;
            name [ 2 ] = "@TenCtyKH"; value [ 2 ] = TenCT;
            name [ 3 ] = "@MSTCty"; value [ 3 ] = MST;
            name [ 4 ] = "@DiaChi"; value [ 4 ] = DiaChi;
            return model.ThucHien_sql("Update_KhachHang", name, value, 5);

        }
        //delete
        public int delete_KhachHang(string MaKH)
        {
            name = new string [ 1 ];
            value = new string [ 1 ];

            name [ 0 ] = "@MaKH"; value [ 0 ] = MaKH;
            return model.ThucHien_sql("Delete_KhachHang", name, value, 1);
        }
    }
}
