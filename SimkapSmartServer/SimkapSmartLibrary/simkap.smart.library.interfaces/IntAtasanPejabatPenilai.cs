
using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntAtasanPejabatPenilai : IntGetUD<EntAtasanPejabatPenilai>, IntGetValidation<EntAtasanPejabatPenilai>
    {
        DataTable selectAtasanPejabatPenilai();
    }
}
