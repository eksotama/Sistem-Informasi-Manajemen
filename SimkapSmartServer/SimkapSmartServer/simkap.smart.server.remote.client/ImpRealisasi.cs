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
    public class ImpRealisasi : MarshalByRefObject, IntRemoteRealisasi, IntRemoteWriteTransactionClient
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
        private bool status;

        public ImpRealisasi()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntRealisasi et, EntRemoteTransactionClient rtc)
        {
            query = "SpInsertRealisasi";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@iddetailkegiatan", et.Iddetailkegiatan),
                new SqlParameter("@kuantitas", et.Kuantitas),
                new SqlParameter("@kualitas", et.Kualitas),
                new SqlParameter("@jumlahwaktu", et.Jumlahwaktu),
                new SqlParameter("@satuanwaktu", et.Satuanwaktu),
                new SqlParameter("@biaya", et.Biaya),
                new SqlParameter("@perodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public DataTable selectRealisasi(EntRealisasi et)
        {
            query = "SpSelectCountRealisasi";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
            };

            table = "CapaianKinerjaHarian";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectDataRealisasi(EntRealisasi et)
        {
            query = "SpSelectRealisasi";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@perIodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
            };

            table = "CapaianKinerjaHarian";
            dt = new DataTable();

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
