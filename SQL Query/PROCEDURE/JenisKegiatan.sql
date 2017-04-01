
-------------------------------------[ INSERT ]-------------------------------------------

CREATE PROCEDURE SpInsertJenisKegiatan ( 

	@jenis varchar(50)) 
	
	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DECLARE @idjenis char (6)
SELECT @idjenis = dbo.NoUrutJenis()

INSERT INTO JenisKegiatan VALUES (@idjenis, @jenis)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT ]-------------------------------------------

create PROCEDURE SpEditJenisKegiatan ( 
	
	@idjenis CHAR (6) ,
	@jenis varchar (50)) 
	
	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE JenisKegiatan SET jenis = @jenis WHERE idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE PROCEDURE SpDeleteJenisKegiatan ( 
	
	@idjenis CHAR (6)) 

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE JenisKegiatan WHERE idjenis = @idjenis

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]-------------------------------------------

CREATE PROCEDURE SpSelectJenisKegiatan 	

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
