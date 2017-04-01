using SimkapSmartLibrary.simkap.smart.library.entitas;
using System.Data;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntUnitKerja : IntGetAll<EntUnitKerja>, IntGetValidation<EntUnitKerja>
    {
        DataTable selectUnitKerja();
    }
}
