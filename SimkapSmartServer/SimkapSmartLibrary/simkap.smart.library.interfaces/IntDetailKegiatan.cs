using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntDetailKegiatan : IntGetUD<EntDetailKegiatan>, IntGetValidation<EntDetailKegiatan>, IntGetComboBox
    {
        DataTable setCmbKegiatan();
        DataTable selectDetailKegiatan();
    }
}
