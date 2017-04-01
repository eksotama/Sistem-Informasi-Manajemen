using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntSasaranKerja
    {
        private int idsasarankerja;
        private string iddetailkegiatan;
        private int kuantitas;
        private int kualitas;
        private int jumlahwaktu;
        private string satuanwaktu;
        private double biaya;
        private string idpenilai;
        private string idatasanpenilai;
        private string periodeawal;
        private string periodeakhir;
        private string jabatan;

        public string Iddetailkegiatan
        {
            get
            {
                return iddetailkegiatan;
            }

            set
            {
                iddetailkegiatan = value;
            }
        }

        public int Kuantitas
        {
            get
            {
                return kuantitas;
            }

            set
            {
                kuantitas = value;
            }
        }

        public int Kualitas
        {
            get
            {
                return kualitas;
            }

            set
            {
                kualitas = value;
            }
        }

        public int Jumlahwaktu
        {
            get
            {
                return jumlahwaktu;
            }

            set
            {
                jumlahwaktu = value;
            }
        }

        public string Satuanwaktu
        {
            get
            {
                return satuanwaktu;
            }

            set
            {
                satuanwaktu = value;
            }
        }

        public double Biaya
        {
            get
            {
                return biaya;
            }

            set
            {
                biaya = value;
            }
        }

        public string Idpenilai
        {
            get
            {
                return idpenilai;
            }

            set
            {
                idpenilai = value;
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

        public int Idsasarankerja
        {
            get
            {
                return idsasarankerja;
            }

            set
            {
                idsasarankerja = value;
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
    }
}
