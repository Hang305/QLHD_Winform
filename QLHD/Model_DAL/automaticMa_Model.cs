using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_DAL
{
  public  class automaticMa_Model
    {
        string [ ] name = { };
        object [ ] value = { };
        Model_Data model = new Model_Data();

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
            TienTo = MaCu.Substring(0, 2);
            HauTo = int.Parse(MaCu.Substring(2).ToString());
            HauTo++;
            if ( HauTo < 10 )
            {
                MaMoi = string.Concat(TienTo, "00", HauTo.ToString());
            }
            else
            {
                if ( HauTo<100 )
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
