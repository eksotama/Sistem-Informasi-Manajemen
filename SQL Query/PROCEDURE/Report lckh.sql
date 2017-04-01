
-------------------------------------[ HARIAN ]------------------------------------------------ 

CREATE PROCEDURE SpLaporanHarianLCKH (
 
    @tanggal date,
	@jabatan varchar(65))

	WITH ENCRYPTION

AS 
BEGIN TRANSACTION

	SET NOCOUNT ON;

SELECT k.kegiatan, k.outputkegiatan, lc.jumlah, k.satuan, lc.keterangan FROM Detailkegiatan AS dk JOIN Kegiatan AS K
       ON dk.idkegiatan = k.idkegiatan JOIN Pegawai AS p
	   ON dk.nip = p.nip JOIN JenisKegiatan AS jk
	   ON k.idjenis = jk.idjenis RIGHT JOIN CapaianKinerjaHarian AS lc
	   ON dk.iddetailkegiatan = lc.iddetailkegiatan
	   WHERE p.jabatan = @jabatan AND lc.tanggal = @tanggal


IF @@error = 0 
	COMMIT TRANSACTION
ELSE
	ROLLBACK TRANSACTION
GO

