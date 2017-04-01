using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;
using System;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpDetailKegiatan : IntDetailKegiatan
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpDetailKegiatan()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntDetailKegiatan ed, string dt)
        {
            query = "SpInsertDetailKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@nip", ed.Nip ),
                new SqlParameter("@idkegiatan", ed.Idkegiatan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntDetailKegiatan ed, string dt)
        {
            query = "SpDeleteDetailKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@iddetailkegiatan", ed.Iddetailkegiatan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectDetailKegiatan()
        {
            query = "SpSelectDetailKegiatan";
            table = "DetailKegiatan";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntDetailKegiatan et)
        {
            query = "SpValidationInsertDetailKegiatan";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idkegiatan", et.Idkegiatan),
                new SqlParameter("@nip", et.Nip)
            };

            table = "DetailKegiatan";
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

        public DataTable setCmbKegiatan()
        {
            query = "SpCmbKegiatanMenuMaster";
            table = "Kegiatan";
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
