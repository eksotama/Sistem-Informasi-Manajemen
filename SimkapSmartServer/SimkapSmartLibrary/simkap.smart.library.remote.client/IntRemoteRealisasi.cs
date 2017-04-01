 using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteRealisasi
    {
        bool save(EntRealisasi et, EntRemoteTransactionClient rtc);
        DataTable selectRealisasi(EntRealisasi et);
        DataTable selectDataRealisasi(EntRealisasi et);
    }
}
