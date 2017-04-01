using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;
using System;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpPejabatPenilai : IntPejabatPenilai
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpPejabatPenilai()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntPejabatPenilai et, string dt)
        {
            query = "SpInsertPejabatPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Idpegawai),
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntPejabatPenilai et, string dt)
        {
            query = "SpDeletePejabatPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idpejabatpenilai", et.Idpejabatpenilai)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable setCmbPenilai()
        {
            query = "SpGetCmbPenilai";
            table = "Pegawai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public DataTable selectPejabatPenilai()
        {
            query = "SpSelectPejabatPenilai";
            table = "PejabatPenilai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntPejabatPenilai et)
        {
            query = "SpValidationInsertPejabatPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Idpegawai)
            };

            table = "PejabatPenilai";
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
