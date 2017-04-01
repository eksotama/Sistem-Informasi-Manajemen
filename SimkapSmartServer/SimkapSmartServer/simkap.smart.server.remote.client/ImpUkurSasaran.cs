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
    public class ImpUkurSasaran : MarshalByRefObject, IntRemoteUkurSasaran, IntRemoteWriteTransactionClient
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private TcpClient client;
        private NetworkStream stream;
        private string query;
        private string table;

        private bool condition;

        public ImpUkurSasaran()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntUkurSasaran et, EntRemoteTransactionClient rtc)
        {
            query = "SpInsertUkurSasaran";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@idsasaran", et.Idsasaran),
                new SqlParameter("@idrealisasi", et.Idrealisasi),
                new SqlParameter("@perhitungan", et.Perhitungan),
                new SqlParameter("@capaian", et.Capaian)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public DataTable selectUkurSasaran(EntUkurSasaran et)
        {
            query = "SpSelectUkurSasaran";
            table = "DetailKegiatan";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@jabatan", et.Jabatan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectDataUkurSasaran(EntUkurSasaran et)
        {
            query = "SpSelectDataUkurSasaran";
            table = "UkurSasaranKerja";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@jabatan", et.Jabatan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

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
    }
}
