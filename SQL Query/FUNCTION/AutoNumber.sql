

---------------------------------[ ENKRIPSI PASSWORD ]------------------------------------

CREATE FUNCTION dbo.md5(@data varchar (15))
RETURNS char (32)
BEGIN
RETURN substring(sys.fn_sqlvarbasetostr(HASHBYTES('MD5',@data)),3,32)
END

-------------------------------[ LOGIN ]------------------------------------------------

CREATE function NoUrutLogin() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
SELECT @dataakhir = max(isnull(right(idlogin,4),0)) FROM LoginPegawai

SET @kodebaru='IL' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'IL0001'

RETURN @kodebaru
END

-------------------------------[ ADMINISTRATOR ]------------------------------------------------

CREATE function NoUrutAdministrator() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
SELECT @dataakhir = max(isnull(right(idadmin,4),0)) FROM Administrator

SET @kodebaru='AT' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'AT0001'

RETURN @kodebaru
END

-----------------------------------------[ JENIS KEGIATAN ]--------------------------------------------------------

CREATE function NoUrutJenis() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
 
SELECT @dataakhir = max(isnull(right(idjenis,4),0)) FROM JenisKegiatan

SET @kodebaru='JK' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'JK0001'

RETURN @kodebaru
END

-----------------------------------------[ ATASAN PEJABAT PENILAI ]--------------------------------------------------

CREATE function NoUrutAtasanPenilai() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
 
SELECT @dataakhir = max(isnull(right(idatasanpejabatpenilai,4),0)) FROM AtasanPejabatPenilai

SET @kodebaru='AP' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'AP0001'

RETURN @kodebaru
END

--------------------------------------[ KEGIATAN ]--------------------------------------------------------

CREATE function NoUrutKegiatan() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
 
SELECT @dataakhir = max(isnull(right(idkegiatan,4),0)) FROM Kegiatan

SET @kodebaru='KG' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'AP0001'

RETURN @kodebaru
END

--------------------------------------[ DETAIL KEGIATAN ]---------------------------------------------------------

CREATE function NoUrutDetailKegiatan() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
 
SELECT @dataakhir = max(isnull(right(iddetailkegiatan,4),0)) FROM Detailkegiatan

SET @kodebaru='DK' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'DK0001'

RETURN @kodebaru
END

-------------------------------------------[ PEJABAT PENILAI ]-----------------------------------------------------

CREATE function NoUrutPejabatPenilai() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
 
SELECT @dataakhir = max(isnull(right(idpejabatpenilai,4),0)) FROM PejabatPenilai

SET @kodebaru='PP' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'PP0001'

RETURN @kodebaru
END

-----------------------------------------[ UNIT KERJA ]------------------------------------------------

CREATE function NoUrutUnitKerja() 
RETURNS CHAR (6) WITH ENCRYPTION
AS
BEGIN 

DECLARE @kodebaru CHAR(6),@dataakhir INT
 
SELECT @dataakhir = max(isnull(right(idunit,4),0)) FROM Unitkerja

SET @kodebaru='UK' + right('000'+ cast(@dataakhir + 1 AS VARCHAR(4)),4)

IF @kodebaru is null SET @kodebaru = 'UK0001'

RETURN @kodebaru
END