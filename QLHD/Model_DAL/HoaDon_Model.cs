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

        //selectFind
        public DataTable selectFind_HoaDon()
        {
            return model.select_sql("SeleteHoaDon_whereFind");
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
        private string selectMaMax(string Bang, string Ma)
        {
            name = new string [ 2 ];
            value = new object [ 2 ];

            name [ 0 ] = "@Bang"; value [ 0 ] = Bang;
            name [ 1 ] = "@Ma"; value [ 1 ] = Ma;
            return model.selectMaMax_sql("LayMaLonNhat", name, value, 2);
        }
        public string Actomatic_Ma(string Bang, string Ma)
        {
            string MaCu, MaMoi;
            MaCu = selectMaMax(Bang, Ma);
            string TienTo;
            int HauTo;
            TienTo = MaCu.Substring(0, 3);
            HauTo = int.Parse(MaCu.Substring(3).ToString());
            HauTo++;
            if ( HauTo < 10 )
            {
                MaMoi = string.Concat(TienTo, "00", HauTo.ToString());
            }
            else
            {
                if ( HauTo < 100 )
                {
                    MaMoi = string.Concat(TienTo, "0", HauTo.ToString());

                }
                else
                {
                    MaMoi = string.Concat(TienTo, HauTo.ToString());
                }
            }
            return MaMoi;
        }

    }
}
