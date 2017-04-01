using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;


namespace SimkapSmartLibrary.simkap.smart.library.interfaces
{
    public interface IntLoginPegawai :IntGetUD<EntLoginPegawai>, IntGetValidation<EntLoginPegawai>, IntGetComboBox
    {
        DataTable selectLoginPegawai();
    }
}
