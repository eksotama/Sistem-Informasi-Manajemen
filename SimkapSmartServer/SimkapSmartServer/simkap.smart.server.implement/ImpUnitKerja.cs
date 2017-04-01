using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.interfaces;
using System;

namespace SimkapSmartServer.simkap.smart.server.implement
{
    public class ImpUnitKerja : IntUnitKerja
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpUnitKerja()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntUnitKerja et, string dt)
        {
            query = "SpInsertUnitKerja";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@unit", et.Unitkerja),
                new SqlParameter("@alamatunit", et.Alamatunit)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool edit(EntUnitKerja et, string dt)
        {
            query = "SpEditUnitKerja";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idunit", et.Idunit),
                new SqlParameter("@unit", et.Unitkerja),
                new SqlParameter("@alamatunit", et.Alamatunit)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public bool delete(EntUnitKerja et, string dt)
        {
            query = "SpDeleteUnitKerja";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@idunit", et.Idunit)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeLogTrasaction(dt);

            return condition;
        }

        public DataTable selectUnitKerja()
        {
            query = "SpSelectUnitKerja";
            table = "UnitKerja";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public bool validationInsert(EntUnitKerja et)
        {
            query = "SpValidationInsertUnitKerja";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@unit", et.Unitkerja)
            };

            table = "Unitkerja";
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
