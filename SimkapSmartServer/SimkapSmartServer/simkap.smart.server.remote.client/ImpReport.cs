using System;
using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartServer.simkap.smart.server.remote.client
{
    public class ImpReport : MarshalByRefObject, IntRemoteReport
    {
        private ConnectionDatabase connect;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;

        public ImpReport()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public DataTable reportPenilai(EntLaporan et)
        {
            query = "SpLaporanPenilai";
            table = "Pegawai";
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

        public DataTable reportSasaranKerja(EntLaporan et)
        {
            query = "SpLaporanSKPAwal";
            table = "Sasaran Kerja";
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

        public DataTable reportYangDiniali(EntLaporan et)
        {
            query = "SpLaporanYangDinilai";
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

        public DataTable reportAtasanPenilai(EntLaporan et)
        {
            query = "SpLaporanAtasanPenilai";
            table = "Pegawai";
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

        public DataTable reportUkurSasaran(EntLaporan et)
        {
            query = "SpLaporanUkurSasaran";
            table = "Realisasi";
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

        public DataTable reportPeriode(EntLaporan et)
        {
            query = "SpLaporanPeriode";
            table = "SasaranKerja";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
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

        public DataTable reportUkurSasaranMutasi(EntLaporan et)
        {
            query = "SpLaporanUkurSasaranMutasi";
            table = "Realisasi";
            dt = new DataTable();

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@mperiodeawal", et.Periodeawalmutasi),
                new SqlParameter("@mperiodeakhir", et.Periodeakhirmutasi)
            };

            condition = connect.eksekusiQuery(query, dbParams, false);

            if (condition)
            {
                connect.viewTable(table).Fill(dt);
            }

            return dt;
        }

        public DataTable reportPerilaku(EntLaporan et)
        {
            query = "SpLaporanPrilakuKerja";
            table = "PrilakuKerja";
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

        public DataTable reportCapaian(EntLaporan et)
        {
            query = "SpLaporanHarianLCKH";
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
    }
}
