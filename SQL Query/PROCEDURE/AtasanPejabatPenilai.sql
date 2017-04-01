
-------------------------------------[ INSERT ]-------------------------------------------
CREATE PROCEDURE SpInsertAtasanPejabatPenilai (
	
	@nip char(30))

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

		SET NOCOUNT ON;

DECLARE @idatasanpenilai char(6)
SELECT @idatasanpenilai = dbo.NoUrutAtasanPenilai()

INSERT INTO AtasanPejabatPenilai VALUES (@idatasanpenilai, @nip)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE PROCEDURE SpDeleteAtasanPejabatPenilai (

	@idatasanpejabatpenilai char(6)) WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE AtasanPejabatPenilai WHERE idatasanpejabatpenilai = @idatasanpejabatpenilai

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]-------------------------------------------

CREATE PROCEDURE SpSelectAtasanPejabatPenilai WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT ap.nip, p.nama, ap.idatasanpejabatpenilai FROM AtasanPejabatPenilai AS ap JOIN Pegawai AS p
		ON p.nip = ap.nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ VALIDASI INSERT ]--------------------------------------------

CREATE PROCEDURE SpValidationInsertAtasanPenilai (

	@nip char(30))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT nip FROM AtasanPejabatPenilai WHERE nip = @nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO