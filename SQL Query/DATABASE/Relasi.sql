
------------------------------------[ LOGIN PEGAWAI ]----------------------------------------------

--RELASI TABEL PEGAWAI DAN TABEL UNIT_KERJA--
alter table LoginPegawai add constraint FK_logpeg foreign key (nip) 
references Pegawai (nip) 
on delete no action 
on update cascade


-------------------------------------[ PEGAWAI ]----------------------------------------------

--RELASI TABEL PEGAWAI DAN TABEL UNIT_KERJA--
alter table Pegawai add constraint FK_unit foreign key (idunit) 
references Unitkerja (idunit) 
on delete no action 
on update cascade

-------------------------------------[ PENILAIAN ]----------------------------------------------

--RELASI TABEL PEJABAT PENILAI DAN TABEL PEGAWAI--
alter table PejabatPenilai add constraint FK_pejabat foreign key (nip) 
references Pegawai (nip) 
on delete no action 
on update cascade

--RELASI TABEL ATASAN PEJABAT PENILAI DAN TABEL PEGAWAI--
alter table AtasanPejabatPenilai add constraint FK_atasan_pejabat foreign key (nip) 
references Pegawai (nip) 
on delete no action 
on update cascade

-------------------------------------[ DETAIL KEGIATAN ]----------------------------------------------

--RELASI TABEL DETAIL KEGITAN DAN TABEL PEGAWAI--
alter table DetailKegiatan add constraint FK_det foreign key (nip) 
references Pegawai (nip) 
on delete no action 
on update cascade

--RELASI TABEL DETAIL KEGIATAN DAN TABEL KEGIATAN--
alter table DetailKegiatan add constraint FK_keg foreign key (idkegiatan) 
references Kegiatan (idkegiatan) 
on delete no action 
on update cascade

-------------------------------------[ LCKH ]----------------------------------------------

--RELASI TABEL CAPAIAN KEGIATAN HARIAN DAN TABEL DETAIL KEGIATAN--
alter table CapaianKinerjaHarian add constraint FK_capaian foreign key (iddetailkegiatan) 
references DetailKegiatan (iddetailkegiatan) 
on delete no action 
on update cascade

-------------------------------------[ TOTAL REASLISASI BIAYA LCKH ]----------------------------------------------

--RELASI TABEL REALISASI DAN TABEL DETAIL KEGIATAN--
alter table Realisasi add constraint FK_detkeg foreign key (iddetailkegiatan) 
references DetailKegiatan (iddetailkegiatan) 
on delete no action 
on update cascade

-------------------------------------[ KEGIATAN ]----------------------------------------------

--RELASI TABEL KEGIATAN DAN TABEL JENIS KEGIATAN--
alter table Kegiatan add constraint FK_jenis foreign key (idjenis) 
references Jeniskegiatan (idjenis) 
on delete no action 
on update cascade

-------------------------------------[ SASARAN KERJA ]----------------------------------------------

--RELASI TABEL SASARAN KERJA DAN TABEL PEJABAT PENILAI--
alter table SasaranKerja add constraint FK_pej foreign key (idpejabatpenilai) 
references PejabatPenilai (idpejabatpenilai) 

--RELASI TABEL SASARAN KERJA DAN TABEL ATASAN PEJABAT PENILAI--
alter table SasaranKerja add constraint FK_atpej foreign key (idatasanpejabatpenilai) 
references AtasanPejabatPenilai (idatasanpejabatpenilai)

--RELASI TABEL SASARAN KERJA DAN TABEL DETAIL KEGIATAN--
alter table SasaranKerja add constraint FK_idsk foreign key (iddetailkegiatan) 
references Detailkegiatan (iddetailkegiatan)

-------------------------------------[ UKUR SASARAN ]----------------------------------------------

--RELASI TABEL UKUR SASARAN KERJA DAN TABEL DETAIL REALISASI--
alter table UkurSasaranKerja add constraint FK_realisasi1 foreign key (idrealisasi) 
references Realisasi (idrealisasi) 
on delete no action 
on update cascade

--RELASI TABEL UKUR SASARAN KERJA DAN TABEL DETAIL SASARAN KERJA--
alter table UkurSasaranKerja add constraint FK_saker foreign key (idsasarankerja) 
references SasaranKerja (idsasarankerja) 

-------------------------------------[ PRILAKU KERJA ]----------------------------------------------

--RELASI TABEL PRILAKU KERJA DAN TABEL PEGAWAI--
alter table PrilakuKerja add constraint FK_prilaku foreign key (nip) 
references Pegawai (nip) 
on delete no action 
on update cascade

--RELASI TABEL PRILAKU KERJA KERJA DAN TABEL PEJABAT PENILAI--
alter table PrilakuKerja add constraint FK_pejb foreign key (idpejabatpenilai) 
references PejabatPenilai (idpejabatpenilai) 

--RELASI TABEL PRILAKU KERJA DAN TABEL ATASAN PEJABAT PENILAI--
alter table PrilakuKerja add constraint FK_atpejb foreign key (idatasanpejabatpenilai) 
references AtasanPejabatPenilai (idatasanpejabatpenilai)
