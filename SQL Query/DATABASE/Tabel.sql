CREATE TABLE Unitkerja( 
idunit CHAR (6) PRIMARY KEY NOT NULL,
unit varchar (35),
alamatunit varchar(250))

CREATE TABLE Pegawai( 
nip CHAR (30) PRIMARY KEY NOT NULL,
nama varchar (50),
pagolru varchar (25),
jabatan varchar (65),
idunit CHAR(6) NOT NULL,
keterangan varchar (35))

CREATE TABLE AtasanPejabatPenilai( 
idatasanpejabatpenilai CHAR (6) PRIMARY KEY NOT NULL,
nip char (30) NOT NULL)

CREATE TABLE PejabatPenilai( 
idpejabatpenilai CHAR (6) PRIMARY KEY NOT NULL,
nip char (30) NOT NULL)

CREATE TABLE CapaianKinerjaHarian( 
idcapaian INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
iddetailkegiatan char (6) NOT NULL,
tanggal DATE,
jumlah INT,
keterangan VARCHAR (50))

CREATE TABLE Detailkegiatan( 
iddetailkegiatan CHAR (6) PRIMARY KEY NOT NULL,
nip char (30) NOT NULL,
idkegiatan CHAR (6) NOT NULL)

CREATE TABLE Kegiatan( 
idkegiatan CHAR (6) PRIMARY KEY NOT NULL,
kegiatan varchar (150),
idjenis CHAR(6) NOT NULL,
outputkegiatan CHAR (30),
satuan VARCHAR (10),
statuskegiatan varchar(20),
keterangan varchar(20))

CREATE TABLE Realisasi( 
idrealisasi INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
iddetailkegiatan char (6) NOT NULL,
kuantitas INT,
kualitas INT,
jumlahwaktu INT,
satuanwaktu VARCHAR (5),
biaya numeric(18,2),
periodeawal DATE,
periodeakhir DATE)

CREATE TABLE SasaranKerja(
idsasarankerja INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
iddetailkegiatan CHAR (6) NOT NULL,
idatasanpejabatpenilai CHAR(6) NOT NULL,
idpejabatpenilai CHAR(6) NOT NULL,
kuantitas INT,
kualitas INT,
jumlahwaktu INT,
satuanwaktu VARCHAR(5),
biaya numeric(18,2),
periodeawal DATE,
periodeakhir DATE,)

CREATE TABLE JenisKegiatan(
idjenis CHAR (6) PRIMARY KEY NOT NULL,
jenis VARCHAR (50))

CREATE TABLE UkurSasaranKerja(
idukursasaran INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
idsasarankerja INT NOT NULL,
idrealisasi INT NOT NULL,
perhitungan numeric(18,2),
capaian numeric(18,2))

CREATE TABLE PrilakuKerja(
idprilaku INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
nip char(30) NOT NULL,
idatasanpejabatpenilai char(6) NOT NULL,
idpejabatpenilai char(6) NOT NULL,
orientasi NUMERIC(18,2),
integritas NUMERIC(18,2),
disiplin NUMERIC(18,2),
komitemen NUMERIC(18,2),
kerjasama NUMERIC(18,2),
jumlah NUMERIC(18,2),
ratarata NUMERIC(18,2),
periodeawal date,
periodeakhir date,)

CREATE TABLE Administrator(
idadmin CHAR(6) PRIMARY KEY NOT NULL,
nama VARCHAR(50),
jekel CHAR (1),
namapengguna VARCHAR(10),
passwordpengguna CHAR(15))

CREATE TABLE LoginPegawai(
idlogin CHAR(6) PRIMARY KEY NOT NULL,
nip CHAR(30) NOT NULL,
namapengguna VARCHAR(10),
katasandi CHAR(15))

ALTER TABLE PrilakuKerja Add 
kepemimpinan NUMERIC (18,2) 

ALTER TABLE PrilakuKerja drop column
komitemen

ALTER TABLE PrilakuKerja Add 
komitmen NUMERIC (18,2) 

 



























 

 


 

 
 
