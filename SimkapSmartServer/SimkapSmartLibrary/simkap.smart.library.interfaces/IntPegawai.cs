using SimkapSmartLibrary.simkap.smart.library.entitas;
using System.Data;

namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntPegawai : IntGetAll<EntPegawai>, IntGetValidation<EntPegawai>
    {
        DataTable selectPegawai();
        DataTable setCmbPegawai();
    }
}
