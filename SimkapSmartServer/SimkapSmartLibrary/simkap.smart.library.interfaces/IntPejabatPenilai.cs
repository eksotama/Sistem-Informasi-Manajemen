
using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntPejabatPenilai : IntGetUD<EntPejabatPenilai>, IntGetValidation<EntPejabatPenilai>
    {
        DataTable selectPejabatPenilai();
    }
}
