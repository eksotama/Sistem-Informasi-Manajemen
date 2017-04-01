using SimkapSmartLibrary.simkap.smart.library.entitas;

namespace SimkapSmartLibrary.simkap.smart.library.remote.client
{
    public interface IntRemoteValidationReport
    {
        bool validationReportSasaranKerja(EntLaporan et);
        bool validationReportPenilai(EntLaporan et);
        bool validationReportAtasanPenilai(EntLaporan et);
        bool validationReportUkurSasaran(EntLaporan et);
        bool validationReportUkurSasaranMutasi(EntLaporan et);
        bool validationReportPerilaku(EntLaporan et);
        bool validationReportCapaian(EntLaporan et);
        bool validationReportPeriode(EntLaporan et);
    }
}
