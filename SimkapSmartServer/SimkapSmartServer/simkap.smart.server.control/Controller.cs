using SimkapSmartServer.simkap.smart.server.implement;
using SimkapSmartServer.simkap.smart.server.log.server;
using SimkapSmartLibrary.simkap.smart.library.interfaces;
using SimkapSmartLibrary.simkap.smart.library.log.server;
using SimkapSmartLibrary.simkap.smart.library.log.client;
using SimkapSmartServer.simkap.smart.server.log.client;

namespace SimkapSmartServer.simkap.smart.server.control
{
    public class Controller
    {
        private static IntLogServer intLog;
        private static IntLoginServer intLs;
        private static IntPegawai intPegawai;
        private static IntKegiatan intKegiatan;
        private static IntAdministrator intAdmin;
        private static IntUnitKerja intUnitKerja;
        private static IntDetailKegiatan intDetail;
        private static IntJenisKegiatan intJenisKegiatan;
        private static IntPejabatPenilai intPejabatPenilai;
        private static IntAtasanPejabatPenilai intAtasanPenilai;
        private static IntLogClient intLogClient;
        private static IntLoginPegawai intLoginPegawai;

        public static IntLoginPegawai getLoginPegawai()
        {
            intLoginPegawai = new ImpLoginPegawai();
            return intLoginPegawai;
        }

        public static IntLogClient getLogClient()
        {
            intLogClient = new ImpLogClient();
            return intLogClient;
        }

        public static IntLogServer getLog()
        {
            intLog = new ImpLogServer();
            return intLog;
        }

        public static IntPegawai getPegawai()
        {
            intPegawai = new ImpPegawai();
            return intPegawai;
        }

        public static IntLoginServer getLogin()
        {
            intLs = new ImpLoginServer();
            return intLs;
        }

        public static IntAdministrator getAdmin()
        {
            intAdmin = new ImpAdministrator();
            return intAdmin;
        }

        public static IntPejabatPenilai getPejabatPenilai()
        {
            intPejabatPenilai = new ImpPejabatPenilai();
            return intPejabatPenilai;
        }

        public static IntDetailKegiatan getDetailKegiatan()
        {
            intDetail = new ImpDetailKegiatan();
            return intDetail;
        }

        public static IntJenisKegiatan getJenisKegiatan()
        {
            intJenisKegiatan = new ImpJenisKegiatan();
            return intJenisKegiatan;
        }

        public static IntKegiatan getKegiatan()
        {
            intKegiatan = new ImpKegiatan();
            return intKegiatan;
        }

        public static IntUnitKerja getUnitKerja()
        {
            intUnitKerja = new ImpUnitKerja();
            return intUnitKerja;
        }

        public static IntAtasanPejabatPenilai getAtasanPejabatPenilai()
        {
            intAtasanPenilai = new ImpAtasanPenilai();
            return intAtasanPenilai;
        }
    }
}
