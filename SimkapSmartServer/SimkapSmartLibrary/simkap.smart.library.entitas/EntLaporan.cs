using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntLaporan
    {
        private string periodeawal;
        private string periodeakhir;
        private string periodeawalmutasi;
        private string periodeakhirmutasi;
        private string jabatan;
        private string tanggal;

        public string Periodeawal
        {
            get
            {
                return periodeawal;
            }

            set
            {
                periodeawal = value;
            }
        }

        public string Periodeakhir
        {
            get
            {
                return periodeakhir;
            }

            set
            {
                periodeakhir = value;
            }
        }

        public string Jabatan
        {
            get
            {
                return jabatan;
            }

            set
            {
                jabatan = value;
            }
        }

        public string Tanggal
        {
            get
            {
                return tanggal;
            }

            set
            {
                tanggal = value;
            }
        }

        public string Periodeawalmutasi
        {
            get
            {
                return periodeawalmutasi;
            }

            set
            {
                periodeawalmutasi = value;
            }
        }

        public string Periodeakhirmutasi
        {
            get
            {
                return periodeakhirmutasi;
            }

            set
            {
                periodeakhirmutasi = value;
            }
        }
    }
}
