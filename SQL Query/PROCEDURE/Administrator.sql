-------------------------------------------[ EDIT ]----------------------------------------------------------------------

CREATE PROCEDURE SpEditAdministrator (

	@idadmin Char(6),
	@nama varchar (50),
	@jekel char(6),
	@namapengguna char (10),
	@pass char (15)) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE Administrator SET nama = @nama, jekel = @jekel, namapengguna = @namapengguna, passwordpengguna = @pass 
                     WHERE idadmin = @idadmin

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

---------------------------------[ SELECT ]--------------------------------------

CREATE PROCEDURE SpSelectAdministartor 

WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;
 
SELECT idadmin, nama , jekel, namapengguna, dbo.md5(passwordpengguna) AS enkripsipassword , passwordpengguna FROM Administrator

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO