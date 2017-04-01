using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpAdministrator : IntAdministrator
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;

        public ImpAdministrator()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool edit(EntAdministrator et, string dt)
        {
            query = "SpEditAdministrator";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idadmin", et.Idadmin),
                new SqlParameter("@nama", et.Nama),
                new SqlParameter("@jekel", et .Jekel),
                new SqlParameter("@namapengguna", et.Namapengguna),
                new SqlParameter("@pass", et.Passwordpengguna)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectAdministrator()
        {
            query = "SpSelectAdministartor";
            table = "Administrator";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }
    }
}
