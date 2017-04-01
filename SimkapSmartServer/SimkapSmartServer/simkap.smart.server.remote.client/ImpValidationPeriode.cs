using System;
using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartServer.simkap.smart.server.remote.client
{
    public class ImpValidationPeriode : MarshalByRefObject, IntRemoteValidationPeriode
    {
        private DataTable dt;
        private SqlParameter[] dbParams;
        private ConnectionDatabase connect;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpValidationPeriode()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool selectPeriode(EntValidationPeriode et)
        {
            query = "SpSelectPeriodeAwalAkhir";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@perodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@jabatan", et.Jabatan)
            };

            table = "SasaranKerja";
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
