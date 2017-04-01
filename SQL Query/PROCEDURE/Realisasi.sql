-------------------------------------[ HITUNG REALISASI ]-------------------------------------------

CREATE PROCEDURE SpSelectCountRealisasi ( 

	@jabatan varchar(65),
	@periodeawal date,
	@periodeakhir date)

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
	
	DECLARE @kualitas INT, @SatuanWaktu VARCHAR(5), @biaya NUMERIC(18,2);
	SET @kualitas = 80;
	SET @SatuanWaktu = 'Bulan';
	SET @biaya = 0;
 
SELECT k.kegiatan, SUM(t.jumlah) AS kuantitas, @kualitas AS kualitas , CONVERT(INT, DATEDIFF("MM",Min(t.tanggal), max(t.tanggal)) + 1) AS waktu, @SatuanWaktu AS satuanwaktu, @biaya AS biaya,   
		dk.iddetailkegiatan
FROM CapaianKinerjaHarian t JOIN Detailkegiatan AS dk
ON dk.iddetailkegiatan = t.iddetailkegiatan JOIN SasaranKerja AS sk
ON sk.iddetailkegiatan = dk.iddetailkegiatan JOIN Pegawai AS p
ON dk.nip = p.nip JOIN Kegiatan AS k 
ON dk.idkegiatan = k.idkegiatan
WHERE p.jabatan = @jabatan AND sk.periodeawal = @periodeawal AND sk.periodeakhir = @periodeakhir AND dk.iddetailkegiatan NOT IN (SELECT iddetailkegiatan FROM Realisasi WHERE periodeawal = @periodeawal AND periodeakhir = @periodeakhir) AND t.tanggal BETWEEN @periodeawal AND @periodeakhir
GROUP BY k.kegiatan, dk.iddetailkegiatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ INSERT ]-------------------------------------------

CREATE PROCEDURE SpInsertRealisasi(
	
	@iddetailkegiatan char(6),
	@kuantitas int,
	@kualitas int,
	@jumlahwaktu int,
	@satuanwaktu varchar(5),
	@biaya numeric(18,2),
	@perodeawal date,
	@periodeakhir date) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

INSERT INTO Realisasi VALUES (@iddetailkegiatan, @kuantitas, @kualitas, @jumlahwaktu,
									@satuanwaktu, @biaya, @perodeawal, @periodeakhir)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ VALIDASI HITUNG REALISASI ]-------------------------------------------

CREATE PROCEDURE SpSelectPeriodeAwalAkhir (
	
	@jabatan varchar(65),
	@perodeawal date,
	@periodeakhir date) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT s.periodeawal, s.periodeakhir FROM SasaranKerja AS s JOIN Detailkegiatan AS dk
ON s.iddetailkegiatan = dk.iddetailkegiatan JOIN Pegawai AS p
ON dk.nip = p.nip
WHERE s.periodeawal = @perodeawal AND s.periodeakhir = @periodeakhir AND p.jabatan = @jabatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]-------------------------------------------

CREATE PROCEDURE SpSelectRealisasi(
	
	@jabatan varchar(65),
	@perIodeawal date,
	@periodeakhir date) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT k.kegiatan, r.kuantitas, r.kualitas, r.jumlahwaktu, r.satuanwaktu, r.biaya FROM Realisasi AS r JOIN Detailkegiatan AS dk
ON r.iddetailkegiatan = dk.iddetailkegiatan JOIN Kegiatan AS k
ON k.idkegiatan = dk.idkegiatan JOIN Pegawai AS p
ON dk.nip = p.nip 
WHERE p.jabatan = @jabatan AND r.periodeawal = @perIodeawal AND r.periodeakhir = @periodeakhir AND
dk.iddetailkegiatan IN (SELECT iddetailkegiatan FROM Realisasi WHERE periodeawal = @periodeawal AND periodeakhir = @periodeakhir)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO