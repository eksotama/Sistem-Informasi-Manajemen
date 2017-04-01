using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteViewDgvSync
    {
        DataTable selectDgvSyncI(EntLoginPegawai et);
        DataTable selectDgvSyncII(EntLoginPegawai et);
        DataTable selectDgvSyncIII(EntLoginPegawai et);
    }
}
