using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model_DAL
{
    public class Model_Data
    {
        SqlConnection getConnect;
        DataTable dt;
        SqlDataAdapter data;
        SqlCommand cmd;
        //getConnect SQL
        private void getConnectData()
        {
            getConnect = new SqlConnection("Data Source=SUNSHINE;Initial Catalog=QLHD;Integrated Security=True");
            getConnect.Open();

        }
        //closeConnect SQL
        private void closeConnectData()
        {
            getConnect.Close();
            getConnect.Dispose();
        }
        public DataTable select_sql (string sql)
        {
            getConnectData();
            //thực thi lấy dữ liệu từ CSDL
            cmd = new SqlCommand(sql, getConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            data = new SqlDataAdapter(cmd);
            dt = new DataTable();
            data.Fill(dt);

            closeConnectData();
            return dt;
        }
        //Insert, Update, Delete
        public int ThucHien_sql(string sql, string [] name, object[] value, int Npara)
        {
            getConnectData();
            //thực thi lấy dữ liệu từ CSDL
            cmd = new SqlCommand(sql, getConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            for ( int i = 0 ; i < Npara ; i++ )
            {
                cmd.Parameters.AddWithValue(name [ i ], value [ i ]);
            }
            return cmd.ExecuteNonQuery();
        }
        //selectWhere
        public DataTable selectWhere_sql(string sql, string [ ] name, object [ ] value, int Npara)
        {
            getConnectData();
            //thực thi lấy dữ liệu từ CSDL
            cmd = new SqlCommand(sql, getConnect);
            cmd.CommandType = CommandType.StoredProcedure;
            for ( int i = 0 ; i < Npara ; i++ )
            {
                cmd.Parameters.AddWithValue(name [ i ], value [ i ]);
            }
            data = new SqlDataAdapter(cmd);
            dt = new DataTable();
            data.Fill(dt);

            closeConnectData();
            return dt;
        }

    }


}
