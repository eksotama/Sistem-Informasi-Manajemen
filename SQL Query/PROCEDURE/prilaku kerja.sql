-------------------------------------[ INSERT ]------------------------------------------------

ALTER PROCEDURE SpInsertPrilakuKerja (
 
    @nip char (30),
	@orientasi NUMERIC(18,2),
	@integritas NUMERIC(18,2),
	@disiplin NUMERIC(18,2),
	@kerjasama NUMERIC(18,2),
	@periodeawal date,
	@periodeakhir date,
	@idatasanpenilai char(6),
	@idpejabatpenilai char(6),
	@kepemimpinan NUMERIC(18,2),
	@komitmen NUMERIC(18,2),
	@jumlah numeric (18,2),
	@ratarata numeric (18,2))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
INSERT INTO PrilakuKerja VALUES (@nip, @idatasanpenilai, @idpejabatpenilai, 
									@orientasi, @integritas, @disiplin, @kerjasama, 
									@jumlah, @ratarata, @periodeawal, @periodeakhir, @kepemimpinan , @komitmen)

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO



-------------------------------------[ EDIT ]------------------------------------------------

CREATE PROCEDURE SpEditPrilakuKerja (
 
	@idprilaku int,
	@nip char (30),
	@orientasi NUMERIC(18,2),
	@integritas NUMERIC(18,2),
	@disiplin NUMERIC(18,2),
	@kerjasama NUMERIC(18,2),
	@periodeawal date,
	@periodeakhir date,
	@idatasanpenilai char(6),
	@idpejabatpenilai char(6),
	@kepemimpinan NUMERIC(18,2),
	@komitmen NUMERIC(18,2),
	@jumlah numeric (18,2),
	@ratarata numeric (18,2))


	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
UPDATE PrilakuKerja SET idatasanpejabatpenilai = @idatasanpenilai, idpejabatpenilai = @idpejabatpenilai, 
						orientasi = @orientasi, integritas = @integritas, disiplin = @disiplin, komitmen = @komitmen, kerjasama = @kerjasama, 
						jumlah = @jumlah, ratarata = @ratarata, periodeawal = @periodeawal, periodeakhir = @periodeakhir, kepemimpinan = @kepemimpinan
						WHERE idprilaku = @idprilaku
IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT ]------------------------------------------------

ALTER PROCEDURE SpSelectPrilakuKerja ( 
 
	@periodeawal date,
	@periodeakhir date,
	@jabatan varchar (65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT pk.orientasi, pk.integritas, pk.disiplin, pk.komitmen, pk.kerjasama, pk.kepemimpinan, pk.jumlah, pk.ratarata , pk.idprilaku FROM PrilakuKerja AS pk JOIN Pegawai AS p
on pk.nip = p.nip
WHERE p.jabatan = @jabatan AND pk.periodeawal = @periodeawal AND pk.periodeakhir = @periodeakhir

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ VALIDASI INSERT ]------------------------------------------------

CREATE PROCEDURE SpValidationInsertPrilakuKerja (
 
	@periodeawal date,
	@periodeakhir date,
	@jabatan varchar (65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT pk.periodeawal, pk.periodeakhir FROM PrilakuKerja AS pk JOIN Pegawai AS P
ON pk.nip = p.nip
WHERE pk.periodeawal = @periodeawal AND pk.periodeakhir = @periodeakhir AND p.jabatan = @jabatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

-------------------------------------[ SELECT NIP ]------------------------------------------------

CREATE PROCEDURE SpSetCmbNip (
 
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;
 
SELECT nip FROM Pegawai WHERE jabatan = @jabatan

IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO
