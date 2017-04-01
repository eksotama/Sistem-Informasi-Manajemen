using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteChangePassword
    {
        bool edit(EntLoginPegawai et, EntRemoteTransactionClient rtc);
        bool selectPassword(EntLoginPegawai et);
    }
}
