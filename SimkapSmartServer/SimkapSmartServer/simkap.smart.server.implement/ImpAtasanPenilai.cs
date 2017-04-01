using System;
using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpAtasanPenilai : IntAtasanPejabatPenilai
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpAtasanPenilai()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntAtasanPejabatPenilai et, string dt)
        {
            query = "SpInsertAtasanPejabatPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Idpegawai),
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntAtasanPejabatPenilai et, string dt)
        {
            query = "SpDeleteAtasanPejabatPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idatasanpejabatpenilai", et.Idatasanpenilai)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectAtasanPejabatPenilai()
        {
            query = "SpSelectAtasanPejabatPenilai";
            table = "AtasanPejabatPenilai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntAtasanPejabatPenilai et)
        {
            query = "SpValidationInsertAtasanPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Idpegawai)
            };

            table = "AtasanPejabatPenilai";
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
