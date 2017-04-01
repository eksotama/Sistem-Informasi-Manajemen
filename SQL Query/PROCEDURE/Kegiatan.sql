
-------------------------------------[ INSERT ]-------------------------------------------

create PROCEDURE SpInsertKegiatan(

	@kegiatan  varchar(150),
	@outputkegiatan varchar(30),
	@satuan varchar(10),
	@idjenis char(6),
	@statuskegiatan varchar(20),
	@keterangan varchar(20))

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DECLARE @idkegiatan char(6)
SELECT @idkegiatan = dbo.NoUrutKegiatan()

INSERT INTO Kegiatan VALUES (@idkegiatan, @kegiatan, @idjenis, @outputkegiatan, @satuan, @statuskegiatan, @keterangan)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT ]-------------------------------------------

CREATE PROCEDURE SpEditKegiatan (

	@idkegiatan char(6),
	@outputkegiatan varchar(30),
	@satuan varchar(10),
	@idjenis char(6),
	@statuskegiatan varchar(20),
	@keterangan varchar(20))
	
	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE Kegiatan SET idjenis = @idjenis, outputkegiatan = @outputkegiatan, satuan = @satuan, statuskegiatan = @statuskegiatan, keterangan = @keterangan
				where idkegiatan = @idkegiatan

if @@error = 0 
commit transaction 
else 
rollback transaction
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE PROCEDURE SpDeleteKegiatan (

	@idkegiatan char(6))

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE Kegiatan WHERE idkegiatan  = @idkegiatan  

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[SELECT ]-------------------------------------------

CREATE PROCEDURE SpSelectKegiatan 

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT k.idkegiatan, k.kegiatan, jk.jenis, k.outputkegiatan, k.satuan, k.statuskegiatan, k.keterangan, jk.idjenis FROM Kegiatan AS k JOIN JenisKegiatan AS jk
ON k.idjenis = jk.idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ VALIDASI INSERT ]--------------------------------------------

CREATE PROCEDURE SpValidationInsertKegiatan (

	@kegiatan varchar(150))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT kegiatan FROM Kegiatan WHERE kegiatan = @kegiatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO