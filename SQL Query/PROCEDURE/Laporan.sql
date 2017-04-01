
--===================================================== SKP AWAL =============================
CREATE PROCEDURE SpLaporanSKPAwal (

		@jabatan varchar(65),
		@periodeawal date)

WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;

SELECT dbo.Kegiatan.kegiatan, dbo.SasaranKerja.kuantitas, dbo.Kegiatan.satuan, dbo.SasaranKerja.kualitas, 
	   dbo.SasaranKerja.jumlahwaktu, dbo.SasaranKerja.satuanwaktu, dbo.SasaranKerja.biaya, 
       dbo.SasaranKerja.periodeawal
FROM  dbo.Detailkegiatan INNER JOIN dbo.Kegiatan ON dbo.Detailkegiatan.idkegiatan = dbo.Kegiatan.idkegiatan INNER JOIN
      dbo.SasaranKerja ON dbo.Detailkegiatan.iddetailkegiatan = dbo.SasaranKerja.iddetailkegiatan INNER JOIN
      dbo.Pegawai ON dbo.Detailkegiatan.nip = dbo.Pegawai.nip
WHERE dbo.Pegawai.jabatan = @jabatan and dbo.SasaranKerja.periodeawal = @periodeawal

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

--============================================================= ATASAN PENILAI ===================================

CREATE PROCEDURE SpLaporanAtasanPenilai ( 

		@jabatan varchar(65),
		@periodeawal date)

WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;

-- ATASAN PENILAI 
SELECT DISTINCT dbo.Pegawai.nip, dbo.Pegawai.nama, dbo.Pegawai.pagolru, dbo.Pegawai.jabatan, dbo.Unitkerja.unit
FROM  dbo.AtasanPejabatPenilai INNER JOIN dbo.Pegawai ON dbo.AtasanPejabatPenilai.nip = dbo.Pegawai.nip INNER JOIN
      dbo.SasaranKerja ON dbo.AtasanPejabatPenilai.idatasanpejabatpenilai = dbo.SasaranKerja.idatasanpejabatpenilai INNER JOIN
      dbo.Unitkerja ON dbo.Pegawai.idunit = dbo.Unitkerja.idunit
WHERE dbo.SasaranKerja.iddetailkegiatan IN (SELECT dk.iddetailkegiatan FROM dbo.SasaranKerja AS sk INNER JOIN
                                             dbo.Detailkegiatan AS dk ON dk.iddetailkegiatan = sk.iddetailkegiatan INNER JOIN
                                              dbo.Pegawai AS p ON dk.nip = p.nip
												WHERE p.jabatan = @jabatan AND dbo.SasaranKerja.periodeawal = @periodeawal)
IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

--============================================================= PENILAI ===================================

CREATE PROCEDURE SpLaporanPenilai ( 

		@jabatan varchar(65),
		@periodeawal date)

WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;

SELECT DISTINCT dbo.Pegawai.nip, dbo.Pegawai.nama, dbo.Pegawai.pagolru, dbo.Pegawai.jabatan, dbo.Unitkerja.unit
FROM dbo.Pegawai INNER JOIN dbo.PejabatPenilai ON dbo.Pegawai.nip = dbo.PejabatPenilai.nip INNER JOIN
     dbo.SasaranKerja ON dbo.PejabatPenilai.idpejabatpenilai = dbo.SasaranKerja.idpejabatpenilai INNER JOIN
     dbo.Unitkerja ON dbo.Pegawai.idunit = dbo.Unitkerja.idunit
WHERE dbo.SasaranKerja.iddetailkegiatan IN (SELECT dk.iddetailkegiatan FROM dbo.SasaranKerja AS sk INNER JOIN
                                             dbo.Detailkegiatan AS dk ON dk.iddetailkegiatan = sk.iddetailkegiatan INNER JOIN
                                              dbo.Pegawai AS p ON dk.nip = p.nip
												WHERE p.jabatan = @jabatan AND dbo.SasaranKerja.periodeawal = @periodeawal)
IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

--============================================================= YANG DINILAI ===================================

CREATE PROCEDURE SpLaporanYangDinilai ( 

		@jabatan varchar(65))

WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;

SELECT DISTINCT dbo.Pegawai.nip, dbo.Pegawai.nama, dbo.Pegawai.pagolru, dbo.Pegawai.jabatan, dbo.Unitkerja.unit
FROM  dbo.Detailkegiatan INNER JOIN dbo.Pegawai ON dbo.Detailkegiatan.nip = dbo.Pegawai.nip INNER JOIN
      dbo.SasaranKerja ON dbo.Detailkegiatan.iddetailkegiatan = dbo.SasaranKerja.iddetailkegiatan INNER JOIN
      dbo.Unitkerja ON dbo.Pegawai.idunit = dbo.Unitkerja.idunit
WHERE dbo.Pegawai.jabatan = @jabatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

--============================================================= PERIODE ===================================

CREATE PROCEDURE SpLaporanPeriode ( 

		@periode date)

WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;

SELECT periodeawal, periodeakhir FROM SasaranKerja WHERE periodeawal = @periode

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO
