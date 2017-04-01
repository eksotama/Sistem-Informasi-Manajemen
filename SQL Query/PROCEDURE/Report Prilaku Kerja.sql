-------------------------------------[ NILAI PRILAKU ]------------------------------------------------ 

ALTER PROCEDURE SpLaporanPrilakuKerja (
 
    @periodeawal date,
	@periodeakhir date,
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT DISTINCT pk.orientasi, pk.integritas, pk.komitmen, pk.disiplin, pk.kerjasama, pk.kepemimpinan, pk.jumlah, pk.ratarata FROM PrilakuKerja AS pk JOIN Pegawai AS p
ON pk.nip = p.nip
WHERE p.jabatan = @jabatan AND pk.periodeawal = @periodeawal AND pk.periodeakhir = @periodeakhir


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO
