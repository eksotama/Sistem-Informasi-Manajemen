using SimkapSmartLibrary.simkap.smart.library.entitas;
using System.Data;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteReport
    {
        DataTable reportSasaranKerja(EntLaporan et);
        DataTable reportPenilai(EntLaporan et);
        DataTable reportYangDiniali(EntLaporan et);
        DataTable reportAtasanPenilai(EntLaporan et);
        DataTable reportUkurSasaran(EntLaporan et);
        DataTable reportPeriode(EntLaporan et);
        DataTable reportUkurSasaranMutasi(EntLaporan et);
        DataTable reportPerilaku(EntLaporan et);
        DataTable reportCapaian(EntLaporan et);
    }
}
