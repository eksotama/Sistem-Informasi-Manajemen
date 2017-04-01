-------------------------------------[ SELECT ]------------------------------------------------

CREATE PROCEDURE SpSelectUkurSasaran (
 
    @periodeawal date,
	@periodeakhir date,
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

DECLARE @perhitungan NUMERIC (18,2), @capaian NUMERIC(18,2)
 
SELECT k.kegiatan,  s.kuantitas AS TargetKuantitas, s.kualitas AS TargetKualitas, s.jumlahwaktu AS TargetWaktu,
s.satuanwaktu AS TargetSatuanWaktu, s.biaya AS TargetBiaya,  r.kuantitas AS RealisasiKuantitas, r.kualitas AS RealisasiKualitas,
r.jumlahwaktu AS RealisasiWaktu, r.satuanwaktu AS RealisasiSatuanWaktu, r.biaya AS RealisasiBiaya, @perhitungan AS perhitungan, @capaian AS capaian,
s.idsasarankerja, r.idrealisasi
FROM Realisasi AS r INNER JOIN Detailkegiatan AS d
ON r.iddetailkegiatan = d.iddetailkegiatan  INNER JOIN Kegiatan AS k
ON d.idkegiatan = k.idkegiatan  INNER JOIN Pegawai AS p
ON p.nip = d.nip JOIN SasaranKerja AS s
ON d.iddetailkegiatan = s.iddetailkegiatan

WHERE r.periodeawal = @periodeawal AND r.periodeakhir = @periodeakhir  
	AND p.jabatan = @jabatan AND s.periodeawal = @periodeawal AND s.periodeakhir = @periodeakhir AND 
s.idsasarankerja NOT IN (SELECT uk.idsasarankerja FROM UkurSasaranKerja AS uk JOIN SasaranKerja AS sk 
							ON uk.idsasarankerja = sk.idsasarankerja WHERE sk.periodeawal = @periodeawal AND sk.periodeakhir = @periodeakhir) AND
r.idrealisasi NOT IN (SELECT  uk.idrealisasi FROM UkurSasaranKerja AS uk JOIN Realisasi AS rl 
							ON UK.idrealisasi = rl.idrealisasi WHERE rl.periodeawal = @periodeawal AND rl.periodeakhir = @periodeakhir)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

----------------------------------------------[ INSERT ]------------------------------------------------

CREATE PROCEDURE SpInsertUkurSasaran (
 
    @idsasaran int,
	@idrealisasi int,
	@perhitungan NUMERIC(18,2),
	@capaian NUMERIC(18,2))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

INSERT INTO UkurSasaranKerja VALUES (@idsasaran, @idrealisasi, @perhitungan, @capaian)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT DATA ]------------------------------------------------

CREATE PROCEDURE SpSelectDataUkurSasaran (
 
    @periodeawal date,
	@periodeakhir date,
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT k.kegiatan,  s.kuantitas AS TargetKuantitas, s.kualitas AS TargetKualitas, s.jumlahwaktu AS TargetWaktu,
s.satuanwaktu AS TargetSatuanWaktu, s.biaya AS TargetBiaya,  r.kuantitas AS RealisasiKuantitas, r.kualitas AS RealisasiKualitas,
r.jumlahwaktu AS RealisasiWaktu, r.satuanwaktu AS RealisasiSatuanWaktu, r.biaya AS RealisasiBiaya, uk.perhitungan, uk.capaian
FROM Realisasi AS r INNER JOIN Detailkegiatan AS d
ON r.iddetailkegiatan = d.iddetailkegiatan  INNER JOIN Kegiatan AS k
ON d.idkegiatan = k.idkegiatan  INNER JOIN Pegawai AS p
ON p.nip = d.nip JOIN SasaranKerja AS s
ON d.iddetailkegiatan = s.iddetailkegiatan JOIN UkurSasaranKerja AS uk
ON uk.idrealisasi = r.idrealisasi JOIN SasaranKerja AS sk
ON sk.idsasarankerja = uk.idsasarankerja

WHERE r.periodeawal = @periodeawal AND r.periodeakhir = @periodeakhir  AND p.jabatan = @jabatan AND s.periodeawal = @periodeawal AND s.periodeakhir = @periodeakhir  AND 
s.idsasarankerja IN (SELECT uk.idsasarankerja FROM UkurSasaranKerja AS uk JOIN SasaranKerja AS sk 
							ON uk.idsasarankerja = sk.idsasarankerja WHERE sk.periodeawal = @periodeawal AND sk.periodeakhir = @periodeakhir) AND
r.idrealisasi IN (SELECT  uk.idrealisasi FROM UkurSasaranKerja AS uk JOIN Realisasi AS rl 
							ON UK.idrealisasi = rl.idrealisasi WHERE rl.periodeawal = @periodeawal AND rl.periodeakhir = @periodeakhir)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO