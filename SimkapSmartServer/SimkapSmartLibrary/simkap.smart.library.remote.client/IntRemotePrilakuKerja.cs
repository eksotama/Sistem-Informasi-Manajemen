using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemotePrilakuKerja 
    {
        bool save(EntPrilakukerja et, EntRemoteTransactionClient rtc);
        bool edit(EntPrilakukerja et, EntRemoteTransactionClient rtc);
        bool validationInsert(EntPrilakukerja et);
        DataTable selectPrilakuKerja(EntPrilakukerja et);
        DataTable setCmbNIP(EntPrilakukerja et);
    }
}
