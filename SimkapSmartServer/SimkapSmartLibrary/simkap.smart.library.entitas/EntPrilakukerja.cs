using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntPrilakukerja
    {
        private string nip;
        private double orientasi;
        private double disiplin;
        private double kerjasama;
        private double integritas;
        private string periodeawal;
        private string periodeakhir;
        private string idatasanpenilai;
        private string idpejabatpenilai;
        private double kepemimpinam;
        private double komitmen;
        private double jumlah;
        private double ratarata;
        private string jabatan;
        private int idprilaku;

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

        public double Orientasi
        {
            get
            {
                return orientasi;
            }

            set
            {
                orientasi = value;
            }
        }

        public double Disiplin
        {
            get
            {
                return disiplin;
            }

            set
            {
                disiplin = value;
            }
        }

        public double Kerjasama
        {
            get
            {
                return kerjasama;
            }

            set
            {
                kerjasama = value;
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

        public string Idatasanpenilai
        {
            get
            {
                return idatasanpenilai;
            }

            set
            {
                idatasanpenilai = value;
            }
        }

        public string Idpejabatpenilai
        {
            get
            {
                return idpejabatpenilai;
            }

            set
            {
                idpejabatpenilai = value;
            }
        }

        public double Kepemimpinam
        {
            get
            {
                return kepemimpinam;
            }

            set
            {
                kepemimpinam = value;
            }
        }

        public double Komitmen
        {
            get
            {
                return komitmen;
            }

            set
            {
                komitmen = value;
            }
        }

        public double Jumlah
        {
            get
            {
                return jumlah;
            }

            set
            {
                jumlah = value;
            }
        }

        public double Ratarata
        {
            get
            {
                return ratarata;
            }

            set
            {
                ratarata = value;
            }
        }

        public double Integritas
        {
            get
            {
                return integritas;
            }

            set
            {
                integritas = value;
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

        public int Idprilaku
        {
            get
            {
                return idprilaku;
            }

            set
            {
                idprilaku = value;
            }
        }
    }
}
