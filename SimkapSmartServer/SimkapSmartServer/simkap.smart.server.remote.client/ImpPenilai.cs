using System;
using System.Net;
using System.Text;
using System.Data;
using System.Net.Sockets;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.remote.client;
 
namespace SimkapSmartServer.simkap.smart.server.remote.client
{
    public class ImpPenilai : MarshalByRefObject, IntRemotePenilai, IntRemoteWriteTransactionClient
    {
        private DataTable dt;
        private SqlParameter[] dbParams;
        private TcpClient client;
        private NetworkStream stream;
        private ConnectionDatabase connect;
        private string query;
        private string table;
        private bool status;
        private bool condition;

        public ImpPenilai()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public DataTable selectAtasanPenilaiKepala()
        {
            query = "SpSetCmbAtasanPenilaiKepala";
            table = "AtasanPejabatPenilai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public DataTable selectPenilaiKepala()
        {
            query = "SpSetCmbPenilaiKepala";
            table = "PejabatPenilai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public DataTable selectAtasanPenilaiStaff()
        {
            query = "SpSetCmbAtasanPenilaiStaff";
            table = "AtasanPejabatPenilai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public DataTable selectPenilaiStaff()
        {
            query = "SpSetCmbPenilaiStaff";
            table = "PejabatPenilai";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public void writeLogTransactionClient(string dt, string ip, int port)
        {
            try
            {
                client = new TcpClient();
                client.Connect(IPAddress.Parse(ip), port);

                stream = client.GetStream();

                byte[] message = Encoding.ASCII.GetBytes(dt);
                stream.Write(message, 0, message.Length);

            }
            catch { }
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
