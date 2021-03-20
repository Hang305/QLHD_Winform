using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Model_DAL
{
    public class HoaDon_Model
    {
        string [ ] name = { };
        object [ ] value = { };

        Model_Data model = new Model_Data();
        //select
        public DataTable select_HoaDon()
        {
            return model.select_sql("Selete_HoaDon");
        }
        //selectWhere
        public DataTable selectWhere_HoaDon(string SoHD)
        {
            name = new string [ 1 ];
            value = new object [ 1 ];

            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            return model.selectWhere_sql("SeleteWhere_HoaDon",name,value,1);
        }
        public DataTable selectFind_HoaDon()
        {
            return model.select_sql("SeleteHoaDon_whereFind");
            //name = new string [ 2 ];
            //value = new string [ 2 ];

            //name [ 0 ] = "@HoTenKH"; value [ 0 ] = HoTenKH;
            //name [ 1 ] = "@SoHD"; value [ 1 ] = SoHD;
            //name [ 2 ] = "@NgayLapHD"; value [ 2 ] = NgayLapHD.ToString();
            //name [ 3 ] = "@TenNV"; value [ 3 ] = TenNV;


            //return model.selectWhere_sql("SeleteHoaDon_whereFind", name, value, 4);
        }
        //insert
        public int insert_HoaDon(string SoHD, DateTime NgayLap, string HinhThucTT, string MaKH, string MaNV, string MaCT)
        {
            name = new string [ 6 ];
            value = new string [ 6 ];

            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            name [ 1 ] = "@NgayLapHD"; value [ 1 ] = NgayLap.ToString();
            name [ 2 ] = "@HinhThucTT"; value [ 2 ] = HinhThucTT;
            name [ 3 ] = "@MaKh"; value [ 3 ] = MaKH;
            name [ 4 ] = "@MaNV"; value [ 4 ] = MaNV;
            name [ 5 ] = "@MaCty"; value [ 5 ] = MaCT;
            return model.ThucHien_sql("Insert_HoaDon", name, value, 6);
        }
        //update
        public int update_HoaDon(string SoHD,DateTime NgayLap, string HinhThucTT, string MaKH, string MaNV, string MaCT)
        {
            name = new string [ 6 ];
            value = new string [ 6 ];

            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            name [ 1 ] = "@NgayLapHD"; value [ 1 ] = NgayLap.ToString();
            name [ 2 ] = "@HinhThucTT"; value [ 2 ] = HinhThucTT;
            name [ 3 ] = "@MaKh"; value [ 3 ] = MaKH;
            name [ 4 ] = "@MaNV"; value [ 4 ] = MaNV;
            name [ 5 ] = "@MaCty"; value [ 5 ] = MaCT;

            return model.ThucHien_sql("Update_HoaDon", name, value, 6);
        }
        //delete
       public int delete_HoaDon(string SoHD)
        {
            name = new string [ 1 ];
            value = new string [ 1 ];

            name [ 0 ] = "@SoHD"; value [ 0 ] = SoHD;
            return model.ThucHien_sql("Delete_HoaDon", name, value, 1);
        }
       

    }
}
