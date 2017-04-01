using System;
using System.Data;
using System.Data.SqlClient;
using SimkapSmartLibrary.simkap.smart.library.entitas;
using SimkapSmartServer.simkap.smart.server.connection;
using SimkapSmartLibrary.simkap.smart.library.remote.client;

namespace SimkapSmartServer.simkap.smart.server.remote.client
{
    public class ImpValidationReport : MarshalByRefObject, IntRemoteValidationReport
    {
        private ConnectionDatabase connect;
        private DataTable dt;
        private SqlParameter[] dbParams;
        private string query;
        private string table;
        private bool condition;
        private bool status;

        public ImpValidationReport()
        {
            connect = new ConnectionDatabase();
            connect.getConn();
        }

        public bool validationReportSasaranKerja(EntLaporan et)
        {
            query = "SpLaporanSKPAwal";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
            };

            table = "Sasaran Kerja";
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

        public bool validationReportPenilai(EntLaporan et)
        {
            query = "SpLaporanPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
            };

            table = "Pegawai";
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

        public bool validationReportAtasanPenilai(EntLaporan et)
        {
            query = "SpLaporanAtasanPenilai";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
            };

            table = "Pegawai";
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

        public bool validationReportUkurSasaran(EntLaporan et)
        {
            query = "SpLaporanUkurSasaran";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
            };

            table = "Realisasi";
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

        public bool validationReportPerilaku(EntLaporan et)
        {
            query = "SpLaporanPrilakuKerja";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
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

        public bool validationReportCapaian(EntLaporan et)
        {
            query = "SpLaporanHarianLCKH";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@tanggal", et.Tanggal)
            };

            table = "CapaianKinerjaHarian";
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

        public bool validationReportPeriode(EntLaporan et)
        {
            query = "SpLaporanPeriode";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@periodeawal", et.Periodeawal),
                new SqlParameter("@periodeakhir", et.Periodeakhir)
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

        public bool validationReportUkurSasaranMutasi(EntLaporan et)
        {
            query = "SpLaporanUkurSasaranMutasi";

            dbParams = new SqlParameter[]
            {
                new SqlParameter("@jabatan", et.Jabatan),
                new SqlParameter("@mperiodeawal", et.Periodeawalmutasi),
                new SqlParameter("@mperiodeakhir", et.Periodeakhirmutasi)
            };

            table = "Realisasi";
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
