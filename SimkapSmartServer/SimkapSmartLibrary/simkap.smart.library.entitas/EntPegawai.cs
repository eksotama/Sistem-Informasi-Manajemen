
using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntPegawai
    {
        private string nip;
        private string nama;
        private string pagolru;
        private string jabatan;
        private string idunit;
        private string keterangan;

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

        public string Nama
        {
            get
            {
                return nama;
            }

            set
            {
                nama = value;
            }
        }

        public string Pagolru
        {
            get
            {
                return pagolru;
            }

            set
            {
                pagolru = value;
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

        public string Idunit
        {
            get
            {
                return idunit;
            }

            set
            {
                idunit = value;
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
    }
}
