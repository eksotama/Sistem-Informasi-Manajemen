using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntLoginPegawai
    {
        private string namapengguna;
        private string katasandi;
        private string jabatan;
        private string nip;
        private string periodeawal;
        private string idjenis;
        private string tanggal;
        private string statuskegiatan;
        private string keterangan;
        private string periodeakhir;

        public string Namapengguna
        {
            get
            {
                return namapengguna;
            }

            set
            {
                namapengguna = value;
            }
        }

        public string Katasandi
        {
            get
            {
                return katasandi;
            }

            set
            {
                katasandi = value;
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

        public string Nip
        {
            get
            {
                return nip;
            }

            set
            {
                nip = value;
            }
        }

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

        public string Idjenis
        {
            get
            {
                return idjenis;
            }

            set
            {
                idjenis = value;
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

        public string Statuskegiatan
        {
            get
            {
                return statuskegiatan;
            }

            set
            {
                statuskegiatan = value;
            }
        }

        public string Keterangan
        {
            get
            {
                return keterangan;
            }

            set
            {
                keterangan = value;
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
    }
}
