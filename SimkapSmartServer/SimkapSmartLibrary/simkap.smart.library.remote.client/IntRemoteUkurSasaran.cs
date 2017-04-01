using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteUkurSasaran
    {
        bool save(EntUkurSasaran et, EntRemoteTransactionClient rtc);
        DataTable selectUkurSasaran(EntUkurSasaran et);
        DataTable selectDataUkurSasaran(EntUkurSasaran et);
    }
}
