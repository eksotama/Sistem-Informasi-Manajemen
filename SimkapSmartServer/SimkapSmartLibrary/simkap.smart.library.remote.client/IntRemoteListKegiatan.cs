using System.Data;
using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteListKegiatan
    {
        DataTable selectJenisKegiatan();
        DataTable selectKegiatan(EntLoginPegawai et);
        DataTable selectKegiatanOthers(EntLoginPegawai et);
    }
}
