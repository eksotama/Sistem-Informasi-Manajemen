using SimkapSmartLibrary.simkap.smart.library.entitas;
using System.Data;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteLoginClient
    {
        bool loginClient(EntLoginPegawai et, EntRemoteTransactionClient rtc);
        DataTable setCmbPegawai();
    }
}
