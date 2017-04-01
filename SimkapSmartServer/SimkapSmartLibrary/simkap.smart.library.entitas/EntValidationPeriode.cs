using System;

namespace SimkapSmartLibrary.simkap.smart.library.entitas
{
    [Serializable]
    public class EntValidationPeriode
    {
        private string jabatan;
        private string periodeawal;
        private string periodeakhir;

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
