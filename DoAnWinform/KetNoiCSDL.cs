using System;
using System.Data;
using System.Data.SqlClient;

namespace DoAnWinform
{
    class KetNoiCSDL
    {
        public static String ChuoiKetNoi = "Data Source=.;Initial Catalog=QLNhaSach;User ID=sa;Password=1234";

        private SqlConnection conn;
        internal ConnectionState State;
        public KetNoiCSDL()
        {
            conn = new SqlConnection(KetNoiCSDL.ChuoiKetNoi);
        }
        public void Open()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        public DataTable TaoBang(String sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            return dt;
        }


        public SqlConnection GetConnection()
        {
            return conn;
        }

    }
}
