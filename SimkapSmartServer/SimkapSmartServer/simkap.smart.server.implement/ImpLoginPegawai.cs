using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;
using System;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpLoginPegawai : IntLoginPegawai
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpLoginPegawai()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntLoginPegawai et, string dt)
        {
            query = "SpInsertLogin";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@nip", et.Nip),
                new SqlParameter("@user", et.Namapengguna),
                new SqlParameter("@pass", et.Katasandi)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntLoginPegawai et, string dt)
        {
            query = "SpDeleteLogin";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Nip),
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectLoginPegawai()
        {
            query = "SpSelectLoginPegawai";
            table = "LoginPegawai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntLoginPegawai et)
        {
            query = "SpValidationInsertLoginPegawai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Nip)
            };

            table = "LoginPegawai";
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

        public DataTable setComboBox()
        {
            query = "SpSetCmbPegawai";
            table = "Pegawai";
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
