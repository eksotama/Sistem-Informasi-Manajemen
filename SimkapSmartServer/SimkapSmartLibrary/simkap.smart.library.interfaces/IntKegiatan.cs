using SimkapSmartLibrary.simkap.smart.library.entitas;
using System.Data;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntKegiatan : IntGetAll<EntKegiatan>, IntGetValidation<EntKegiatan>
    {
        DataTable selectKegiatan();
    }
}
