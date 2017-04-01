using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;
using System;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpJenisKegiatan : IntJenisKegiatan
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpJenisKegiatan()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntJenisKegiatan et, string dt)
        {
            query = "SpInsertJenisKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jenis", et.Jenis)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool edit(EntJenisKegiatan et, string dt)
        {
            query = "SpEditJenisKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idjenis", et.Idjenis),
                new SqlParameter("@jenis", et.Jenis)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntJenisKegiatan et, string dt)
        {
            query = "SpDeleteJenisKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idjenis", et.Idjenis)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectJenisKegiatan()
        {
            query = "SpSelectJenisKegiatan";
            table = "JenisKegiatan";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntJenisKegiatan et)
        {
            query = "SpValidationInsertJenisKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jenis", et.Jenis)
            };

            table = "JenisKegiatan";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    status = true;
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
