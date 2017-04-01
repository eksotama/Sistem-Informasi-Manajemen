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
    public class ImpLoginClient : MarshalByRefObject, IntRemoteLoginClient, IntRemoteWriteTransactionClient
    {
        private ConnectionDatabase connect;
        private ImpLogServer ls;
        private DataTable dtb;
        private SqlParameter[] dbParams;
        private TcpClient client;
        private NetworkStream stream;
        private DataTable dt;
        private string table;
        private string query;
        private bool status;
        private bool condition;

        public ImpLoginClient()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool loginClient(EntLoginPegawai et, EntRemoteTransactionClient rtc)
        {
            query = "SpLoginPegawai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@namapengguna", et.Namapengguna),
				new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@katasandi", et.Katasandi)
            };

            table = "Pegawai";
            dtb = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dtb);

                if (dtb.Rows.Count > 0)
                {
                    status = true;

                    ls = new ImpLogServer();
                    ls.writeSaveLogTransactionClient(rtc.Text);
                }
                else
                {
                    status = false;
                }
            }

            return status;
        }

        public DataTable setCmbPegawai()
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
