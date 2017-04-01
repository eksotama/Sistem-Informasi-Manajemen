-------------------------------------[ INSERT ]-------------------------------------------

ALTER PROCEDURE SpInsertSasaranKerja(
	
	@idekegiatan char(6),
	@idpenilai char(6),
	@idatasanpenilai char(6),
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

INSERT INTO SasaranKerja VALUES (@idekegiatan, @idatasanpenilai, @idpenilai, @kuantitas, @kualitas, @jumlahwaktu,
									@satuanwaktu, @biaya, @perodeawal, @periodeakhir)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT ]-------------------------------------------

CREATE PROCEDURE SpEditSasaranKerja (
	
	@periodeawal date,
	@periodeakhir date,
	@jabatan varchar (65))
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE s SET s.periodeakhir = @periodeakhir FROM SasaranKerja As s JOIN Detailkegiatan AS dk
ON s.iddetailkegiatan = dk.iddetailkegiatan JOIN Pegawai AS p
ON dk.nip = p.nip
WHERE p.jabatan = @jabatan and s.periodeawal = @periodeawal

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE PROCEDURE SpDeleteSasaranKerja(
	
	@idsasarankerja int)
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE SasaranKerja WHERE idsasarankerja = @idsasarankerja

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT SKP ]-------------------------------------------

CREATE PROCEDURE SpSelectSKP ( 
		
		@jabatan char(65),
		@periodeawal date,
		@periodeakhir date)
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT k.kegiatan, skp.kuantitas, skp.kualitas, skp.jumlahwaktu, skp.satuanwaktu, skp.biaya, skp.idsasarankerja FROM Kegiatan AS k JOIN Detailkegiatan dk
			ON k.idkegiatan = dk.idkegiatan JOIN SasaranKerja AS skp
			ON dk.iddetailkegiatan = skp.iddetailkegiatan JOIN Pegawai AS p
			ON dk.nip = p.nip
			WHERE p.jabatan = @jabatan and skp.periodeawal = @periodeawal and skp.periodeakhir = @periodeakhir

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET CMB ATASAN PENILAI KEPALA  ]-------------------------------------------

ALTER PROCEDURE SpSetCmbAtasanPenilaiKepala WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT ap.idatasanpejabatpenilai, p.nama FROM AtasanPejabatPenilai AS ap JOIN Pegawai AS p
		ON p.nip = ap.nip
		WHERE p.jabatan = 'Kepala Kanwil Kemenag Prov. Jateng'

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET CMB ATASAN PENILAI STAFF  ]-------------------------------------------

ALTER PROCEDURE SpSetCmbAtasanPenilaiStaff WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT ap.idatasanpejabatpenilai, p.nama FROM AtasanPejabatPenilai AS ap JOIN Pegawai AS p
		ON p.nip = ap.nip
		WHERE p.jabatan = 'Plt. Kepala Kantor Kemenag Kab. Klaten'

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET CMB PENILAI STAFF  ]-------------------------------------------

CREATE PROCEDURE SpSetCmbPenilaiStaff WITH ENCRYPTION exec SpSetCmbPenilaiStaff 

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT pp.idpejabatpenilai, p.nama FROM PejabatPenilai AS pp JOIN Pegawai AS p
		ON p.nip = pp.nip
		WHERE p.jabatan = 'Kepala KUA Kec. Klaten Selatan'

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET CMB PENILAI KEPALA  ]-------------------------------------------

ALTER PROCEDURE SpSetCmbPenilaiKepala WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT pp.idpejabatpenilai, p.nama FROM PejabatPenilai AS pp JOIN Pegawai AS p
		ON p.nip = pp.nip
		WHERE p.jabatan = 'Plt. Kepala Kantor Kemenag Kab. Klaten'

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET CMB KEGIATAN SKP ]-------------------------------------------

CREATE PROCEDURE SpSetKegiatanComboBoxSKP ( 

	@jabatan varchar(65),
	@idjenis char(6),
	@periodeawal date,
	@statuskegiatan varchar (20),
	@keterangan varchar(20))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT DISTINCT dk.iddetailkegiatan, k.kegiatan FROM Detailkegiatan AS dk JOIN Kegiatan AS K
       ON dk.idkegiatan = k.idkegiatan JOIN Pegawai AS p
	   ON dk.nip = p.nip JOIN JenisKegiatan AS jk
	   ON k.idjenis = jk.idjenis LEFT JOIN SasaranKerja AS skp
	   ON dk.iddetailkegiatan = skp.iddetailkegiatan
	   WHERE p.jabatan = @jabatan and jk.idjenis = @idjenis AND k.statuskegiatan = @statuskegiatan AND k.keterangan = @keterangan
	   AND dk.iddetailkegiatan NOT IN (SELECT iddetailkegiatan FROM SasaranKerja WHERE periodeawal = @periodeawal)


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

--+++++++++++++++++++++++++++++++++++++++++++++++++

CREATE PROCEDURE SpSetKegiatanComboBoxSKPOthers ( 

	@jabatan varchar(65),
	@periodeawal date,
	@statuskegiatan varchar (20),
	@keterangan varchar(20))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT DISTINCT dk.iddetailkegiatan, k.kegiatan FROM Detailkegiatan AS dk JOIN Kegiatan AS K
       ON dk.idkegiatan = k.idkegiatan JOIN Pegawai AS p
	   ON dk.nip = p.nip JOIN JenisKegiatan AS jk
	   ON k.idjenis = jk.idjenis LEFT JOIN SasaranKerja AS skp
	   ON dk.iddetailkegiatan = skp.iddetailkegiatan
	   WHERE p.jabatan = @jabatan AND k.statuskegiatan = @statuskegiatan AND k.keterangan = @keterangan
	   AND dk.iddetailkegiatan NOT IN (SELECT iddetailkegiatan FROM SasaranKerja WHERE periodeawal = @periodeawal)


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO


-------------------------------------[ SET CMB JENIS KEGIATAN SKP ]-------------------------------------------

CREATE PROCEDURE SpSelectJenisKegiatanSKP	

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT * FROM JenisKegiatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT INFORMATION SKP ]-------------------------------------------

CREATE PROCEDURE SpSelectInformationSKP ( 

	@jabatan varchar(65),
	@periodeawal date)

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT k.kegiatan, jk.jenis FROM Kegiatan AS k JOIN JenisKegiatan AS jk
	   ON k.idjenis = jk.idjenis JOIN Detailkegiatan AS dk
       ON dk.idkegiatan = k.idkegiatan JOIN Pegawai AS p
	   ON dk.nip = p.nip FULL JOIN SasaranKerja AS skp
	   ON dk.iddetailkegiatan = skp.iddetailkegiatan
	   WHERE p.jabatan = @jabatan AND dk.iddetailkegiatan NOT IN (SELECT iddetailkegiatan FROM SasaranKerja WHERE periodeawal = @periodeawal)


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET DGV SYNC I LCKH ]-------------------------------------------

CREATE PROCEDURE SpSelectSKPSyncI (
	
	@idjenis char(6),
	@periodeawal date,
	@periodeakhir date)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT skp.kuantitas, skp.jumlahwaktu, skp.satuanwaktu FROM Kegiatan AS k JOIN Detailkegiatan dk
ON k.idkegiatan = dk.idkegiatan JOIN SasaranKerja AS skp
ON dk.iddetailkegiatan = skp.iddetailkegiatan JOIN JenisKegiatan AS jk
ON k.idjenis = jk.idjenis
WHERE skp.periodeawal = @periodeawal AND skp.periodeakhir = @periodeakhir AND k.statuskegiatan = 'Sinkron' AND k.keterangan = 'Sinkron I' AND jk.idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET DGV SYNC II LCKH ]-------------------------------------------

CREATE PROCEDURE SpSelectSKPSyncII (
	
	@idjenis char(6),
	@periodeawal date,
	@periodeakhir date)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT skp.kuantitas, skp.jumlahwaktu, skp.satuanwaktu FROM Kegiatan AS k JOIN Detailkegiatan dk
ON k.idkegiatan = dk.idkegiatan JOIN SasaranKerja AS skp
ON dk.iddetailkegiatan = skp.iddetailkegiatan JOIN JenisKegiatan AS jk
ON k.idjenis = jk.idjenis
WHERE skp.periodeawal = @periodeawal AND skp.periodeakhir = @periodeakhir AND k.statuskegiatan = 'Sinkron' AND k.keterangan = 'Sinkron II' AND jk.idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET DGV SYNC III LCKH ]-------------------------------------------

CREATE PROCEDURE SpSelectSKPSyncIII (
	
	@idjenis char(6),
	@periodeawal date,
	@periodeakhir date)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT skp.kuantitas, skp.jumlahwaktu, skp.satuanwaktu FROM Kegiatan AS k JOIN Detailkegiatan dk
ON k.idkegiatan = dk.idkegiatan JOIN SasaranKerja AS skp
ON dk.iddetailkegiatan = skp.iddetailkegiatan JOIN JenisKegiatan AS jk
ON k.idjenis = jk.idjenis
WHERE skp.periodeawal = @periodeawal AND skp.periodeakhir = @periodeakhir AND k.statuskegiatan = 'Sinkron' AND k.keterangan = 'Sinkron III' AND jk.idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO