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
    public class ImpSasaranKerja : MarshalByRefObject, IntRemoteSasaranKerja, IntRemoteWriteTransactionClient
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

        public ImpSasaranKerja()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool save(EntSasaranKerja et, EntRemoteTransactionClient rtc)
        {
            query = "SpInsertSasaranKerja";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@idekegiatan", et.Iddetailkegiatan),
                new SqlParameter("@idpenilai", et.Idpenilai),
                new SqlParameter("@idatasanpenilai", et.Idatasanpenilai),
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

        public bool edit(EntSasaranKerja et, EntRemoteTransactionClient rtc)
        {
            query = "SpEditSasaranKerja";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@jabatan", et.Jabatan)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
        }

        public bool delete(EntSasaranKerja et, EntRemoteTransactionClient rtc)
        {
            query = "SpDeleteSasaranKerja";

            dbParams = new SqlParameter[]
             {
                new SqlParameter("@idsasarankerja", et.Idsasarankerja)
             };

            condition = connect.eksekusiQuery(query, dbParams, false);

            ls = new ImpLogServer();
            ls.writeSaveLogTransactionClient(rtc.Text);

            return condition;
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
            query = "SpSetKegiatanComboBoxSKP";
            table = "DetailKegiatan";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@idjenis", et.Idjenis),
                new SqlParameter("@periodeawal", et.Periodeawal),
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
            query = "SpSetKegiatanComboBoxSKPOthers";
            table = "DetailKegiatan";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
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

        public DataTable selectSKP(EntLoginPegawai et)
        {
            query = "SpSelectSKP";
            table = "SasaranKerja";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
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
            query = "SpSelectSKPSyncI";
            table = "SasaranKerja";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@idjenis", et.Idjenis)
            };

            table = "SasaranKerja";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectDgvSyncII(EntLoginPegawai et)
        {
            query = "SpSelectSKPSyncII";
            table = "SasaranKerja";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@idjenis", et.Idjenis)
            };

            table = "SasaranKerja";
            dt = new DataTable();

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable selectDgvSyncIII(EntLoginPegawai et)
        {
            query = "SpSelectSKPSyncIII";
            table = "SasaranKerja";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir),
                new SqlParameter("@idjenis", et.Idjenis)
            };

            table = "SasaranKerja";
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
