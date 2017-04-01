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
    public class ImpChangePassword : MarshalByRefObject, IntRemoteChangePassword, IntRemoteWriteTransactionClient
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private SqlParameter[] dbParams;
        private TcpClient client;
        private NetworkStream stream;
        private string query;
        private bool condition;

        public ImpChangePassword()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool edit(EntLoginPegawai et, EntRemoteTransactionClient rtc)
        {
            query = "SpEditLogin";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@namapengguna", et.Namapengguna),
                new SqlParameter("@pass", et.Katasandi)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public bool selectPassword(EntLoginPegawai et)
        {
            query = "SpSelectPasswordLoginPegawai";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@katasandi", et.Katasandi)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            return condition;
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
