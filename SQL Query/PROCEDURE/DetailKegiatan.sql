
-------------------------------------[ INSERT ]-------------------------------------------

CREATE PROCEDURE SpInsertDetailKegiatan(
	
	@nip char(30),
	@idkegiatan char(6)) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DECLARE @iddetailkegiatan char(6)
SELECT @iddetailkegiatan = dbo.NoUrutDetailKegiatan()

insert into Detailkegiatan values (@iddetailkegiatan, @nip, @idkegiatan)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]-------------------------------------------

CREATE PROCEDURE SpSelectDetailKegiatan 

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT dk.iddetailkegiatan, dk.nip, p.nama, k.kegiatan FROM Detailkegiatan AS dk JOIN Kegiatan AS K
       ON dk.idkegiatan = k.idkegiatan JOIN Pegawai AS p
	   ON dk.nip = p.nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO


-------------------------------------[ EDIT ]-------------------------------------------

CREATE PROCEDURE SpEditDetailKegiatan(
	
	@nip char(30),
	@idkegiatan char(6)) 

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE DetailKegiatan SET idkegiatan = @idkegiatan WHERE nip = @nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------------------------------------------------------

CREATE PROCEDURE SpDeleteDetailKegiatan (

	@iddetailkegiatan char(6))

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE detailkegiatan WHERE iddetailkegiatan = @iddetailkegiatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ VALIDASI INSERT ]--------------------------------------------

CREATE PROCEDURE SpValidationInsertDetailKegiatan (

	@idkegiatan char(6),
	@nip char(30))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT idkegiatan FROM DetailKegiatan WHERE idkegiatan = @idkegiatan and nip = @nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ SET COMBOBOX KEGIATAN PEGAWAI ]--------------------------------------------

CREATE PROCEDURE SpCmbKegiatanMenuMaster

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT idkegiatan, kegiatan FROM Kegiatan
WHERE idkegiatan NOT IN (SELECT idkegiatan FROM Detailkegiatan)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO
