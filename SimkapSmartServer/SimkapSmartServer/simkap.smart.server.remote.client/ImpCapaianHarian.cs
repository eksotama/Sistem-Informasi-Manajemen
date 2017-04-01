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
    public class ImpCapaianHarian : MarshalByRefObject, IntRemoteLCKH, IntRemoteWriteTransactionClient
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

        public ImpCapaianHarian()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntLCKH et, EntRemoteTransactionClient rtc)
        {
            query = "SpInsertLCKH";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@iddetailkegiatan", et.Idetailkegiatan),
                new SqlParameter("@jumlah", et.Jumlah),
                new SqlParameter("@keterangan", et.Keterangan)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public bool edit(EntLCKH et, EntRemoteTransactionClient rtc)
        {
            query = "SpEditLCKHNoSync";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@jumlah", et.Jumlah),
                new SqlParameter("@idcapian", et.Idcapaian)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public bool editSync(EntLCKH et, EntRemoteTransactionClient rtc)
        {
            query = "SpEditLCKHSync";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@jumlah", et.Jumlah),
                new SqlParameter("@iddetailkegiatan", et.Idetailkegiatan),
                new SqlParameter("@tanggal", et.Tanggal)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public bool delete(EntLCKH et, EntRemoteTransactionClient rtc)
        {
            query = "SpDeleteLCKH";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@idcapaian", et.Idcapaian)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public DataTable selectLCKH(EntLoginPegawai et)
        {
            query = "SpSelectLCKH";
            table = "CapaianKinerjaHarian";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@tanggal", et.Tanggal)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectJenisKegiatan()
        {
            query = "SpSelectJenisKegiatanSKP";
            table = "JenisKegiatan";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, true);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }
            return dt;
        }

        public DataTable selectKegiatan(EntLoginPegawai et)
        {
            query = "SpSetKegiatanComboBoxLCKH";
            table = "DetailKegiatan";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@idjenis", et.Idjenis),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@tanggal", et.Tanggal),
                new SqlParameter("@statuskegiatan", et.Statuskegiatan),
                new SqlParameter("@keterangan", et.Keterangan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectKegiatanOthers(EntLoginPegawai et)
        {
            query = "SpSetKegiatanComboBoxLCKHOthers";
            table = "DetailKegiatan";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@tanggal", et.Tanggal),
                new SqlParameter("@statuskegiatan", et.Statuskegiatan),
                new SqlParameter("@keterangan", et.Keterangan)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectDgvSyncI(EntLoginPegawai et)
        {
            query = "SpSelectLCKHSyncI";
            table = "CapaianKinerjaHarian";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@tanggal", et.Tanggal),
                new SqlParameter("@idjenis", et.Idjenis)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectDgvSyncII(EntLoginPegawai et)
        {
            query = "SpSelectLCKHSyncII";
            table = "CapaianKinerjaHarian";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@tanggal", et.Tanggal),
                new SqlParameter("@idjenis", et.Idjenis)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectDgvSyncIII(EntLoginPegawai et)
        {
            query = "SpSelectLCKHSyncIII";
            table = "CapaianKinerjaHarian";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@tanggal", et.Tanggal),
                new SqlParameter("@idjenis", et.Idjenis)
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
