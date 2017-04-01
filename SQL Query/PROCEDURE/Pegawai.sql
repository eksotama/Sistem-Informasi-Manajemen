
-------------------------------------[ INSERT ]-------------------------------------------

CREATE PROCEDURE SpInsertPegawai (

	@nip char(30),
	@nama varchar (50),
	@pagolru char(25),
	@jabatan char (65),
	@idunit char (6),
	@keterangan varchar(31)) 	

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

INSERT INTO Pegawai VALUES (@nip, @nama, @pagolru, @jabatan, @idunit, @keterangan)



IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ EDIT ]-------------------------------------------

CREATE PROCEDURE SpEditPegawai(

	@nip char(30),
	@nama varchar (50),
	@pagolru char(25),
	@jabatan char (65),
	@idunit char (6),
	@keterangan varchar(31)) 	

	WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

UPDATE Pegawai SET nama = @nama , pagolru = @pagolru, idunit = @idunit, keterangan = @keterangan, nip = @nip
			   WHERE jabatan = @jabatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ DELETE ]-------------------------------------------

CREATE PROCEDURE SpDeletePegawai (
	
	@nip char(30)) WITH ENCRYPTION

AS
BEGIN TRANSACTION

	SET NOCOUNT ON;

DELETE Pegawai WHERE nip = @nip

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]-------------------------------------------

CREATE PROCEDURE SpSelectPegawai 

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;
 
SELECT p.nip, p.nama, p.pagolru, p.jabatan, u.unit, p.keterangan, u.idunit FROM Pegawai AS p JOIN Unitkerja AS u
		ON p.idunit = u.idunit

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SET COMBOBOX ]-------------------------------------------

CREATE PROCEDURE SpSetCmbPegawai

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

SET NOCOUNT ON;
 
SELECT p.nip, p.nama, p.jabatan FROM Pegawai AS p JOIN Unitkerja AS u
		ON p.idunit = u.idunit
		WHERE p.keterangan = 'Pegawai KUA KEC. Klaten Selatan'

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ VALIDASI INSERT ]--------------------------------------------

CREATE PROCEDURE SpValidationInsertPegawai (

	@jabatan char(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT jabatan FROM Pegawai WHERE jabatan = @jabatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-----------------------------[ SET COMBOBOX DATA PENILAIAN ]--------------------------------------------

CREATE PROCEDURE SpCmbPenilaian

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT nip, nama FROM Pegawai

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO