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
    public class ImpPrilakuKerja : MarshalByRefObject, IntRemotePrilakuKerja, IntRemoteWriteTransactionClient
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

        public ImpPrilakuKerja()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntPrilakukerja et, EntRemoteTransactionClient rtc)
        {
            query = "SpInsertPrilakuKerja";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@nip", et.Nip),
                new SqlParameter("@orientasi", et.Orientasi),
                new SqlParameter("@integritas", et.Integritas),
                new SqlParameter("@disiplin", et.Disiplin),
                new SqlParameter("@kerjasama", et.Kerjasama),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@idatasanpenilai", et.Idatasanpenilai),
                new SqlParameter("@idpejabatpenilai", et.Idpejabatpenilai),
                new SqlParameter("@kepemimpinan", et.Kepemimpinam),
                new SqlParameter("@komitmen", et.Komitmen),
                new SqlParameter("@jumlah", et.Jumlah),
                new SqlParameter("@ratarata", et.Ratarata)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public bool edit(EntPrilakukerja et, EntRemoteTransactionClient rtc)
        {
            query = "SpEditPrilakuKerja";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@idprilaku", et.Idprilaku),
                new SqlParameter("@orientasi", et.Orientasi),
                new SqlParameter("@integritas", et.Integritas),
                new SqlParameter("@disiplin", et.Disiplin),
                new SqlParameter("@kerjasama", et.Kerjasama),
                new SqlParameter("@kepemimpinan", et.Kepemimpinam),
                new SqlParameter("@komitmen", et.Komitmen),
                new SqlParameter("@jumlah", et.Jumlah),
                new SqlParameter("@ratarata", et.Ratarata)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public DataTable selectPrilakuKerja(EntPrilakukerja et)
        {
            query = "SpSelectPrilakuKerja";
            table = "PrilakuKerja";
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

        public DataTable setCmbNIP(EntPrilakukerja et)
        {
            query = "SpSetCmbNip";
            table = "Pegawai";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public bool validationInsert(EntPrilakukerja et)
        {
            query = "SpValidationInsertPrilakuKerja";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@jabatan", et.Jabatan)
            };

            table = "PrilakuKerja";
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
