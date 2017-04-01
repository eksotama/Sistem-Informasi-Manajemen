using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteSasaranKerja : IntRemoteGetAl<EntSasaranKerja, EntRemoteTransactionClient>, IntRemoteViewDgvSync, IntRemoteListKegiatan
    {
        DataTable selectSKP(EntLoginPegawai et);
    }
}
