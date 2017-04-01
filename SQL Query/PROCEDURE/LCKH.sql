-------------------------------------[ INSERT ]-----------------------------------------------

CREATE PROCEDURE SpInsertLCKH(

	@iddetailkegiatan char(6),
	@jumlah int,
	@keterangan varchar(50))

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

INSERT INTO CapaianKinerjaHarian VALUES (@iddetailkegiatan, GETDATE(), @jumlah, @keterangan)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT SYNC ]-----------------------------------------------

CREATE PROCEDURE SpEditLCKHSync ( 

	@jumlah int,
	@iddetailkegiatan char(6),
	@tanggal date)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE lc SET lc.jumlah = @jumlah FROM CapaianKinerjaHarian AS lc JOIN Detailkegiatan AS dk
ON dk.iddetailkegiatan = lc.iddetailkegiatan JOIN Kegiatan AS k
ON k.idkegiatan = dk.idkegiatan JOIN JenisKegiatan AS jk
ON k.idjenis = k.idjenis JOIN Pegawai AS p
ON p.nip = dk.nip
WHERE lc.tanggal = @tanggal
	   AND
	   k.statuskegiatan in (SELECT k.statuskegiatan FROM JenisKegiatan AS j join Kegiatan AS k
	   ON j.idjenis = k.idjenis JOIN Detailkegiatan AS dk
	   ON dk.idkegiatan = k.idkegiatan JOIN CapaianKinerjaHarian AS c
	   ON dk.iddetailkegiatan = c.iddetailkegiatan WHERE c.iddetailkegiatan = @iddetailkegiatan)
	   AND 
	   k.keterangan in (SELECT K.keterangan FROM JenisKegiatan AS j join Kegiatan AS k
	   ON j.idjenis = k.idjenis JOIN Detailkegiatan AS dk
	   ON dk.idkegiatan = k.idkegiatan JOIN CapaianKinerjaHarian AS c
	   ON dk.iddetailkegiatan = c.iddetailkegiatan WHERE c.iddetailkegiatan = @iddetailkegiatan)
	   AND
	   jk.idjenis in (SELECT j.idjenis FROM JenisKegiatan AS j join Kegiatan AS k
	   ON j.idjenis = k.idjenis JOIN Detailkegiatan AS dk
	   ON dk.idkegiatan = k.idkegiatan JOIN CapaianKinerjaHarian AS c
	   ON dk.iddetailkegiatan = c.iddetailkegiatan WHERE c.iddetailkegiatan = @iddetailkegiatan)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT NO SYNC ]-----------------------------------------------

CREATE PROCEDURE SpEditLCKHNoSync ( 

	@jumlah int,
	@idcapian int)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE CapaianKinerjaHarian SET jumlah = @jumlah WHERE idcapaian = @idcapian

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE]-----------------------------------------------

CREATE PROCEDURE SpDeleteLCKH(

	@idcapaian int)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE CapaianKinerjaHarian WHERE idcapaian = @idcapaian

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]------------------------------------------------

CREATE PROCEDURE SpSelectLCKH (
 
    @tanggal date,
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT k.kegiatan, k.outputkegiatan, lc.jumlah, k.satuan, lc.keterangan, lc.iddetailkegiatan, lc.idcapaian, k.statuskegiatan FROM Detailkegiatan AS dk JOIN Kegiatan AS K
       ON dk.idkegiatan = k.idkegiatan JOIN Pegawai AS p
	   ON dk.nip = p.nip JOIN JenisKegiatan AS jk
	   ON k.idjenis = jk.idjenis RIGHT JOIN CapaianKinerjaHarian AS lc
	   ON dk.iddetailkegiatan = lc.iddetailkegiatan
	   WHERE p.jabatan = @jabatan AND lc.tanggal = @tanggal


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET CMB KEGIATAN LCKH ]-------------------------------------------

CREATE PROCEDURE SpSetKegiatanComboBoxLCKH ( 

	@jabatan varchar(65),
	@idjenis char(6),
	@periodeawal date,
	@periodeakhir date,
	@tanggal date,
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
	   ON dk.iddetailkegiatan = skp.iddetailkegiatan LEFT JOIN CapaianKinerjaHarian AS lc
	   ON dk.iddetailkegiatan = lc.iddetailkegiatan
	   WHERE p.jabatan = @jabatan and jk.idjenis = @idjenis AND k.statuskegiatan = @statuskegiatan AND k.keterangan = @keterangan
	   AND dk.iddetailkegiatan IN (SELECT iddetailkegiatan FROM SasaranKerja WHERE periodeawal = @periodeawal and periodeakhir = @periodeakhir) AND dk.iddetailkegiatan NOT IN (SELECT iddetailkegiatan FROM CapaianKinerjaHarian WHERE tanggal = @tanggal)


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

--++++++++++++++++++++++++++++++++++++++

CREATE PROCEDURE SpSetKegiatanComboBoxLCKHOthers ( 

	@jabatan varchar(65),
	@periodeawal date,
	@periodeakhir date,
	@tanggal date,
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
	   ON dk.iddetailkegiatan = skp.iddetailkegiatan LEFT JOIN CapaianKinerjaHarian AS lc
	   ON dk.iddetailkegiatan = lc.iddetailkegiatan
	   WHERE p.jabatan = @jabatan AND k.statuskegiatan = @statuskegiatan AND k.keterangan = @keterangan
	   AND dk.iddetailkegiatan IN (SELECT iddetailkegiatan FROM SasaranKerja WHERE periodeawal = @periodeawal AND periodeakhir = @periodeakhir) AND dk.iddetailkegiatan NOT IN (SELECT iddetailkegiatan FROM CapaianKinerjaHarian WHERE tanggal = @tanggal)


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET DGV SYNC I LCKH ]-------------------------------------------

CREATE PROCEDURE SpSelectLCKHSyncI (
	
	@idjenis char(6),
	@tanggal date)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT lc.jumlah FROM Kegiatan AS k JOIN Detailkegiatan dk
ON k.idkegiatan = dk.idkegiatan JOIN CapaianKinerjaHarian AS lc
ON dk.iddetailkegiatan = lc.iddetailkegiatan JOIN JenisKegiatan AS jk
ON k.idjenis = jk.idjenis JOIN Pegawai  AS p
ON dk.nip = p.nip
WHERE lc.tanggal = @tanggal AND k.statuskegiatan = 'Sinkron' AND k.keterangan = 'Sinkron I' AND jk.idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET DGV SYNC II LCKH ]-------------------------------------------

CREATE PROCEDURE SpSelectLCKHSyncII (
	
	@idjenis char(6),
	@tanggal date)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT lc.jumlah FROM Kegiatan AS k JOIN Detailkegiatan dk
ON k.idkegiatan = dk.idkegiatan JOIN CapaianKinerjaHarian AS lc
ON dk.iddetailkegiatan = lc.iddetailkegiatan JOIN JenisKegiatan AS jk
ON k.idjenis = jk.idjenis JOIN Pegawai  AS p
ON dk.nip = p.nip
WHERE lc.tanggal = @tanggal AND k.statuskegiatan = 'Sinkron' AND k.keterangan = 'Sinkron II' AND jk.idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET DGV SYNC III LCKH ]-------------------------------------------

CREATE PROCEDURE SpSelectLCKHSyncIII (
	
	@idjenis char(6),
	@tanggal date)

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT lc.jumlah FROM Kegiatan AS k JOIN Detailkegiatan dk
ON k.idkegiatan = dk.idkegiatan JOIN CapaianKinerjaHarian AS lc
ON dk.iddetailkegiatan = lc.iddetailkegiatan JOIN JenisKegiatan AS jk
ON k.idjenis = jk.idjenis
WHERE lc.tanggal = @tanggal AND k.statuskegiatan = 'Sinkron' AND k.keterangan = 'Sinkron III' AND jk.idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO