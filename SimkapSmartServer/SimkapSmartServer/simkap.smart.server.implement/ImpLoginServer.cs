using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpLoginServer : IntLoginServer
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dtb;
        private SqlParameter[] dbParams;
        private string table;
        private string query;
        private bool status;
        private bool condition;

        public ImpLoginServer()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool loginUser(EntAdministrator et, string dt)
        {
            query = "SpLoginAdministrator";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@user", et.Namapengguna),
                new SqlParameter("@pass", et.Passwordpengguna)
            };

            table = "Administrator";
            dtb = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    status = true;

                    ls = new ImpLogServer();
                    ls.writeLogTrasaction(dt);
                }
                else
                {
                    status = false;
                }
            }

            return status;
        }
    }
}
