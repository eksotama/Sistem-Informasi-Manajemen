using SimkapSmartLibrary.simkap.smart.library.entitas;
using System.Data;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
     public interface IntRemotePenilai
    {
        bool selectPeriode(EntValidationPeriode et);
        DataTable selectAtasanPenilaiKepala();
        DataTable selectPenilaiKepala();
        DataTable selectAtasanPenilaiStaff();
        DataTable selectPenilaiStaff();
    }
}
