
-------------------------------------[ INSERT ]-------------------------------------------

CREATE PROCEDURE SpInsertPejabatPenilai (
	
	@nip char(30)) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

		SET NOCOUNT ON;

DECLARE @idpejabatpenilai char(6)
SELECT @idpejabatpenilai = dbo.NoUrutPejabatPenilai()

INSERT INTO PejabatPenilai VALUES (@idpejabatpenilai, @nip)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE PROCEDURE SpDeletePejabatPenilai (

	@idpejabatpenilai char(6)) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

		SET NOCOUNT ON;

DELETE PejabatPenilai WHERE idpejabatpenilai  = @idpejabatpenilai 

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]-------------------------------------------

CREATE PROCEDURE SpSelectPejabatPenilai WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT pn.idpejabatpenilai, pn.nip, p.nama FROM PejabatPenilai AS pn JOIN Pegawai AS p
ON p.nip = pn.nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ VALIDASI INSERT ]--------------------------------------------

CREATE PROCEDURE SpValidationInsertPejabatPenilai (

	@nip char(30))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT nip FROM PejabatPenilai WHERE nip = @nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO