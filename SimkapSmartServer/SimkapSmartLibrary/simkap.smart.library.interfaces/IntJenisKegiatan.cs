using SimkapSmartLibrary.simkap.smart.library.entitas;
using System.Data;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntJenisKegiatan : IntGetAll<EntJenisKegiatan>, IntGetValidation<EntJenisKegiatan>
    {
        DataTable selectJenisKegiatan();
    }
}
