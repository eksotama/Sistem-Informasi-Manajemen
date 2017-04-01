
-------------------------------------[ INSERT ]-------------------------------------------

CREATE PROCEDURE SpInsertUnitKerja(
	
	@unit varchar(50),
	@alamatunit varchar(250)) 

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DECLARE @idunit char(6)
SELECT @idunit = dbo.NoUrutUnitKerja()


INSERT INTO Unitkerja VALUES (@idunit, @unit, @alamatunit)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT ]-------------------------------------------

CREATE PROCEDURE SpEditUnitKerja (
 
	@idunit char(6),
	@unit varchar(35), 
	@alamatunit varchar(250)) 
	
	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE Unitkerja SET  unit = @unit, alamatunit = @alamatunit WHERE idunit = @idunit

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE procedure SpDeleteUnitKerja (

	@idunit char(6)) 
	
	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE Unitkerja WHERE idunit  = @idunit 

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE PROCEDURE SpSelectUnitKerja

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT * FROM Unitkerja

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO
insert into Administrator
values ('il0001','am1','l','sa','kua')