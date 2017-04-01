using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace SimkapSmartServer.simkap.smart.server.connection
{
    public class ConnectionDatabase
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        private DataTable dt;
        private int affect = 0;

        public SqlConnection getConn()
        {
            string strconn = ConfigurationManager.ConnectionStrings["ConnectionSimkap"].ToString();
            conn = new SqlConnection(strconn);
            return conn;
        }

        public bool eksekusiQuery(string query, SqlParameter[] p, bool condition)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                if (condition)
                {
                    //.......
                }
                else
                {
                    int count = p.GetUpperBound(0) + 1;

                    for (int i = 0; i < count; i++)

                    cmd.Parameters.AddWithValue(p[i].ParameterName, p[i].Value);

                    affect = cmd.ExecuteNonQuery();
                }
             
                return true;
            }
            catch
            { 
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        public SqlDataAdapter viewTable(string table)
        {
            dt = new DataTable(table);
            da.Fill(dt);
            return da;
        }
    }
}
