using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpKegiatan : IntKegiatan
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpKegiatan()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntKegiatan et, string dt)
        {
            query = "SpInsertKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@kegiatan", et.Kegiatan),
                new SqlParameter("@idjenis", et.Idjenis),
                new SqlParameter("@outputkegiatan", et.Outputkegiatan),
                new SqlParameter("@satuan", et.Satuan),
                new SqlParameter("@statuskegiatan", et.Status),
                new SqlParameter("@keterangan", et.Keterangan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool edit(EntKegiatan et, string dt)
        {
            query = "SpEditKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idkegiatan", et.Idkegiatan),
                new SqlParameter("@outputkegiatan", et.Outputkegiatan),
                new SqlParameter("@satuan", et.Satuan),
                new SqlParameter("@idjenis", et.Idjenis),
                new SqlParameter("@statuskegiatan", et.Status),
                new SqlParameter("@keterangan", et.Keterangan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntKegiatan et, string dt)
        {
            query = "SpDeleteKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idkegiatan", et.Idkegiatan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectKegiatan()
        {
            query = "SpSelectKegiatan";
            table = "Kegiatan";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams ,true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntKegiatan et)
        {
            query = "SpValidationInsertKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@kegiatan", et.Kegiatan)
            };

            table = "Kegiatan";
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
