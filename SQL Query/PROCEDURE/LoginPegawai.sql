
-------------------------------------[ INSERT ]-------------------------------------------


CREATE PROCEDURE SpInsertLogin(
	
	@nip char (30),
	@user char (10),
	@pass char (15)) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DECLARE @idlogin CHAR(6)
SELECT @idlogin =  dbo.NoUrutLogin()

INSERT INTO LoginPegawai VALUES (@idlogin, @nip, @user, @pass)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT ]-------------------------------------------


CREATE PROCEDURE SpEditLogin(
	
	@namapengguna char (30),
	@pass char (15)) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE LoginPegawai SET katasandi = @pass WHERE namapengguna = @namapengguna

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------


CREATE PROCEDURE SpDeleteLogin(
	
	@nip char(30))
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE LoginPegawai WHERE nip = @nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]-------------------------------------------


CREATE PROCEDURE SpSelectLoginPegawai

WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;
 
SELECT nip , namapengguna, dbo.md5(katasandi) AS enkripsipassword FROM LoginPegawai

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ EDIT SELECT KATA SANDI PEGAWAI ]--------------------------------------------

CREATE PROCEDURE SpSelectPasswordLoginPegawai (

	@katasandi char(24))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT  l.katasandi FROM Pegawai AS p JOIN LoginPegawai AS l
		ON p.nip = l.nip
		WHERE l.katasandi COLLATE Latin1_General_CS_AS = @katasandi

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ VALIDASI INSERT ]--------------------------------------------

CREATE PROCEDURE SpValidationInsertLoginPegawai (

	@nip char(30))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT nip FROM LoginPegawai WHERE nip = @nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO