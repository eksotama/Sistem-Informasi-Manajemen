using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;
using System;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpPegawai : IntPegawai
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpPegawai()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntPegawai et, string dt)
        {
            query = "SpInsertPegawai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Nip),
                new SqlParameter("@nama", et.Nama),
                new SqlParameter("@pagolru", et.Pagolru),
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@idunit", et.Idunit),
                new SqlParameter("@keterangan", et.Keterangan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool edit(EntPegawai et, string dt)
        {
            query = "SpEditPegawai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Nip),
                new SqlParameter("@nama", et.Nama),
                new SqlParameter("@pagolru", et.Pagolru),
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@idunit", et.Idunit),
                new SqlParameter("@keterangan", et.Keterangan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntPegawai et, string dt)
        {
            query = "SpDeletePegawai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", et.Nip)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectPegawai()
        {
            query = "SpSelectPegawai";
            table = "Pegawai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public DataTable setCmbPegawai()
        {
            query = "SpCmbPenilaian";
            table = "Pegawai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntPegawai et)
        {
            query = "SpValidationInsertPegawai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan)
            };

            table = "Pegawai";
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
