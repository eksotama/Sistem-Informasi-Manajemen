-----------------------------[ LOGIN CLIENT ]--------------------------------------------

CREATE PROCEDURE SpLoginPegawai (

	@namapengguna varchar(10),
	@jabatan varchar(65),
	@katasandi char(24))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT l.namapengguna, l.katasandi, p.jabatan FROM Pegawai AS p JOIN LoginPegawai AS l
		ON p.nip = l.nip
		WHERE l.namapengguna COLLATE Latin1_General_CS_AS = @namapengguna and p.jabatan = @jabatan and
				l.katasandi COLLATE Latin1_General_CS_AS = @katasandi

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO
------------------------------[ LOGIN SERVER ]--------------------------------------------

create PROCEDURE SpLoginAdministrator (

	@user varchar(10),
	@pass char(15))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT namapengguna , passwordpengguna FROM Administrator 
		WHERE namapengguna COLLATE Latin1_General_CS_AS = @user and 
				passwordpengguna COLLATE Latin1_General_CS_AS = @pass

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

------------------------------[ LOAD DATA ComboBox ]--------------------------------------------

CREATE PROCEDURE SpGetCmbPenilai with encryption

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT nip, nama FROM Pegawai 
		WHERE jabatan LIKE 'Kepala%'

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO
