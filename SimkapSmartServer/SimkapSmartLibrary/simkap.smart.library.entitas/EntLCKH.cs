using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntLCKH
    {
        private string idetailkegiatan;
        private int jumlah;
        private string keterangan;
        private string tanggal;
        private int idcapaian;

        public string Idetailkegiatan
        {
            get
            {
                return idetailkegiatan;
            }

            set
            {
                idetailkegiatan = value;
            }
        }

        public int Jumlah
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

        public int Idcapaian
        {
            get
            {
                return idcapaian;
            }

            set
            {
                idcapaian = value;
            }
        }
    }
}
