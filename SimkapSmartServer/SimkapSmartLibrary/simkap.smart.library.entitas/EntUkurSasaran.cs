using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntUkurSasaran
    {
        private int idsasaran;
        private int idrealisasi;
        private double perhitungan;
        private double capaian;
        private string periodeawal;
        private string periodeakhir;
        private string jabatan;

        public int Idsasaran
        {
            get
            {
                return idsasaran;
            }

            set
            {
                idsasaran = value;
            }
        }

        public int Idrealisasi
        {
            get
            {
                return idrealisasi;
            }

            set
            {
                idrealisasi = value;
            }
        }

        public double Perhitungan
        {
            get
            {
                return perhitungan;
            }

            set
            {
                perhitungan = value;
            }
        }

        public double Capaian
        {
            get
            {
                return capaian;
            }

            set
            {
                capaian = value;
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
    }
}
