using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteLCKH : IntRemoteGetAl<EntLCKH, EntRemoteTransactionClient>, IntRemoteListKegiatan, IntRemoteViewDgvSync
    {
        bool editSync(EntLCKH et, EntRemoteTransactionClient rtc);
        DataTable selectLCKH(EntLoginPegawai et);
    }
}
