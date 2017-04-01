-------------------------------------[ SELECT DATA ]------------------------------------------------

CREATE PROCEDURE SpLaporanUkurSasaran (  
 
    @periodeawal date,
    @periodeakhir date,
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT k.kegiatan,  s.kuantitas AS TargetKuantitas, s.kualitas AS TargetKualitas, s.jumlahwaktu AS TargetWaktu, s.satuanwaktu AS TargetSatuanWaktu, s.biaya AS TargetBiaya,  
r.kuantitas AS RealisasiKuantitas, r.kualitas AS RealisasiKualitas, r.jumlahwaktu AS RealisasiWaktu, r.satuanwaktu AS RealisasiSatuanWaktu, r.biaya AS RealisasiBiaya, uk.perhitungan, 
uk.capaian, k.satuan,
DAY(s.periodeawal) AS hariawal,
CASE MONTH(s.periodeawal)
	WHEN 1 THEN 'Januari'
	WHEN 2 THEN 'Februari'
	WHEN 3 THEN 'Maret'
	WHEN 4 THEN 'April'
	WHEN 5 THEN 'Mei'
	WHEN 6 THEN 'Juni'
	WHEN 7 THEN 'Juli'
	WHEN 8 THEN 'Agustus'
	WHEN 9 THEN 'September'
	WHEN 10 THEN 'Oktober'
	WHEN 11 THEN 'November'
	WHEN 12 THEN 'Desember'
END AS bulanawal,
DAY(s.periodeakhir) AS hariakhir,
CASE MONTH(s.periodeakhir)
	WHEN 1 THEN 'Januari'
	WHEN 2 THEN 'Februari'
	WHEN 3 THEN 'Maret'
	WHEN 4 THEN 'April'
	WHEN 5 THEN 'Mei'
	WHEN 6 THEN 'Juni'
	WHEN 7 THEN 'Juli'
	WHEN 8 THEN 'Agustus'
	WHEN 9 THEN 'September'
	WHEN 10 THEN 'Oktober'
	WHEN 11 THEN 'November'
	WHEN 12 THEN 'Desember'
END AS bulanakhir,
YEAR(s.periodeakhir) AS tahun

FROM Realisasi AS r INNER JOIN Detailkegiatan AS d
ON r.iddetailkegiatan = d.iddetailkegiatan  INNER JOIN Kegiatan AS k
ON d.idkegiatan = k.idkegiatan  INNER JOIN Pegawai AS p
ON p.nip = d.nip JOIN SasaranKerja AS s
ON d.iddetailkegiatan = s.iddetailkegiatan JOIN UkurSasaranKerja AS uk
ON uk.idrealisasi = r.idrealisasi JOIN SasaranKerja AS sk
ON sk.idsasarankerja = uk.idsasarankerja

WHERE p.jabatan = @jabatan AND 
r.periodeawal = @periodeawal AND r.periodeakhir = @periodeakhir AND 
s.periodeawal = @periodeawal AND s.periodeakhir = @periodeakhir AND
s.idsasarankerja IN (SELECT uk.idsasarankerja FROM UkurSasaranKerja AS uk JOIN SasaranKerja AS sk 
					ON uk.idsasarankerja = sk.idsasarankerja WHERE sk.periodeawal = @periodeawal AND 
																	sk.periodeakhir = @periodeakhir) AND
r.idrealisasi IN (SELECT uk.idrealisasi FROM UkurSasaranKerja AS uk JOIN Realisasi AS rl 
							ON UK.idrealisasi = rl.idrealisasi WHERE rl.periodeawal = @periodeawal AND 
																	rl.periodeakhir = @periodeakhir)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO


--====================================================== MUTASI ===========================================================

-------------------------------------[ SELECT DATA ]------------------------------------------------

CREATE PROCEDURE SpLaporanUkurSasaranMutasi (  
 
    @mperiodeawal date,
    @mperiodeakhir date,
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT k.kegiatan,  s.kuantitas AS TargetKuantitas, s.kualitas AS TargetKualitas, s.jumlahwaktu AS TargetWaktu, s.satuanwaktu AS TargetSatuanWaktu, s.biaya AS TargetBiaya,  
r.kuantitas AS RealisasiKuantitas, r.kualitas AS RealisasiKualitas, r.jumlahwaktu AS RealisasiWaktu, r.satuanwaktu AS RealisasiSatuanWaktu, r.biaya AS RealisasiBiaya, uk.perhitungan, 
uk.capaian, k.satuan,
DAY(s.periodeawal) AS hariawal,
CASE MONTH(s.periodeawal)
	WHEN 1 THEN 'Januari'
	WHEN 2 THEN 'Februari'
	WHEN 3 THEN 'Maret'
	WHEN 4 THEN 'April'
	WHEN 5 THEN 'Mei'
	WHEN 6 THEN 'Juni'
	WHEN 7 THEN 'Juli'
	WHEN 8 THEN 'Agustus'
	WHEN 9 THEN 'September'
	WHEN 10 THEN 'Oktober'
	WHEN 11 THEN 'November'
	WHEN 12 THEN 'Desember'
END AS bulanawal,
DAY(s.periodeakhir) AS hariakhir,
CASE MONTH(s.periodeakhir)
	WHEN 1 THEN 'Januari'
	WHEN 2 THEN 'Februari'
	WHEN 3 THEN 'Maret'
	WHEN 4 THEN 'April'
	WHEN 5 THEN 'Mei'
	WHEN 6 THEN 'Juni'
	WHEN 7 THEN 'Juli'
	WHEN 8 THEN 'Agustus'
	WHEN 9 THEN 'September'
	WHEN 10 THEN 'Oktober'
	WHEN 11 THEN 'November'
	WHEN 12 THEN 'Desember'
END AS bulanakhir,
YEAR(s.periodeakhir) AS tahun

FROM Realisasi AS r INNER JOIN Detailkegiatan AS d
ON r.iddetailkegiatan = d.iddetailkegiatan  INNER JOIN Kegiatan AS k
ON d.idkegiatan = k.idkegiatan  INNER JOIN Pegawai AS p
ON p.nip = d.nip JOIN SasaranKerja AS s
ON d.iddetailkegiatan = s.iddetailkegiatan JOIN UkurSasaranKerja AS uk
ON uk.idrealisasi = r.idrealisasi JOIN SasaranKerja AS sk
ON sk.idsasarankerja = uk.idsasarankerja

WHERE p.jabatan = @jabatan AND 
r.periodeawal = @mperiodeawal AND r.periodeakhir = @mperiodeakhir AND 
s.periodeawal = @mperiodeawal AND s.periodeakhir = @mperiodeakhir AND
s.idsasarankerja IN (SELECT uk.idsasarankerja FROM UkurSasaranKerja AS uk JOIN SasaranKerja AS sk 
					ON uk.idsasarankerja = sk.idsasarankerja WHERE sk.periodeawal = @mperiodeawal AND 
																	sk.periodeakhir = @mperiodeakhir) AND
r.idrealisasi IN (SELECT uk.idrealisasi FROM UkurSasaranKerja AS uk JOIN Realisasi AS rl 
							ON UK.idrealisasi = rl.idrealisasi WHERE rl.periodeawal = @mperiodeawal AND 
																	rl.periodeakhir = @mperiodeakhir)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO