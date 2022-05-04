----- SOAL NO.1
CREATE DATABASE Db_KARYAWAN

USE Db_KARYAWAN

Select *
FROM Gaji_Karyawan

----- PROVINSI
insert into Provinsi
(Kode_Provinsi, Nama_Provinsi)

values
('P0001','DKI Jakarta'),
('P0002','Banten'),
('P0003','Jawa Barat')

----- Kota
insert into Kota
(
	Kode_Kota,Kode_Provinsi,Nama_Kota
)

values 
	('K1001','P0001','Jakarta Pusat'),
	('K1002','P0001','Jakarta Barat'),
	('K1003','P0001','Jakarta Selatan'),
	('K1004','P0001','Jakarta Timur'),
	('K1005','P0001','Jakarta Utara'),
	('K2001','P0002','Tangerang Selatan'),
	('K2002','P0002','Tangerang Kota'),
	('K3001','P0003','Bekasi Kota'),
	('K3002','P0003','Bekasi'),	
	('K3003','P0003','Cikarang')

----- Jabatan
insert into Jabatan
(
	Kode_Jabatan, Nama_Jabatan
)

values
	('J001','Staff'),
	('J002','Supervisor'),
	('J003','Manager')

----- Departemen
insert into Departemen
(
	Kode_Departemen,Nama_Departemen
)
values
	('D001','Accounting'),
	('D002','Finance'),
	('D003','Pajak'),
	('D004','HRD'),
	('D005','IT')

----- Karyawan
insert into Karyawan
(
	NIK,Nama_Depan,Nama_Belakang,Kode_Jabatan, Kode_Departemen,ReportTo,Kode_Kota
)
values 
	('17B109','Wati','Kamal','J003','D004',NULL,'K2001'),
	('19F112','Iwan','Lesmana','J002','D003','21C928','K3001'),
	('20G432','Bayu','Ahmady','J001','D003','19F112','K1005'),
	('21C928','Budi','Kurniawan','J003','D003',	NULL,'K1005'),
	('21L002','Bandy','Umar','J001','D003','19F112','K3003')

----- Komponen Gaji
insert into Komponen_Gaji
(
	Kode_KompGaji,Deskripsi,Pajak,[Status]
)

values 
	('I001','Transport','Y','I'),
	('I003','Potongan Lain','T','D'),
	('R001','Gaji Pokok','Y','I'),
	('R002','Makan','Y','I')

----- Gaji Karyawan
insert into Gaji_Karyawan
(
	NIK,Kode_KompGaji,Tahun,Bulan,Nilai
)

values 
	('21C928','R001','2022','3',2500000),
	('17B109','R001','2022','3',2750000),
	('19F112','R001','2022','3',1500000),
	('21L002','R001','2022','3',1000000),
	('20G432','R001','2022','3',1100000),
	('21C928','R002','2022','3',500000),
	('17B109','R002','2022','3',750000),
	('19F112','R002','2022','3',500000),
	('21L002','R002','2022','3',350000),
	('20G432','R002','2022','3',400000),
	('21C928','I001','2022','3',150000),
	('17B109','I001','2022','3',175000),
	('21C928','I003','2022','3',5000),
	('21C928','R001','2022','4',2500000),
	('17B109','R001','2022','4',2750000),
	('19F112','R001','2022','4',1500000),
	('21L002','R001','2022','4',1000000),
	('20G432','R001','2022','4',1100000),
	('21C928','R002','2022','4',500000),
	('17B109','R002','2022','4',750000),
	('19F112','R002','2022','4',500000),
	('21L002','R002','2022','4',350000),
	('20G432','R002','2022','4',400000),
	('21C928','I001','2022','4',150000),
	('17B109','I001','2022','4',175000),
	('21C928','I003','2022','4',5000)

----- SOAL NO.2
select * 
from Karyawan
join Jabatan on
	Karyawan.Kode_Jabatan=Jabatan.Kode_Jabatan
where 
	jabatan.Kode_Jabatan = 'J001'

----- Soal NO.3
select *
from Karyawan

join Departemen on
	Karyawan.Kode_Departemen = Departemen.Kode_Departemen

where 
	departemen.Kode_Departemen = 'D004'

----- Soal NO.4
select *
from Karyawan

select Nama_Jabatan as Jabatan,COUNT(NIK)as Jumlah_Karyawan
from Jabatan
	
join Karyawan on
	Jabatan.Kode_Jabatan = Karyawan.Kode_Jabatan

group by Nama_Jabatan

----- Soal NO.5
select 
	Karyawan.Nama_Depan,NIK AS Bawahan,Karyawan.Nama_Depan, ReportTo as atasan
from
	Karyawan



----- Soal NO.7
-- buat view database (gak usah gapapa tapi biar sedikit aja nantinya)
CREATE VIEW Vw_SUMGAJIBERSIH
AS
SELECT Kota.Kode_Kota,Kota.Nama_Kota, Gaji.Tahun, 
	SUM(CASE WHEN [Status] = 'I' THEN
		Nilai
	Else
		Nilai * -1
	END) Nilai
FROM Karyawan as Kry
JOIN Kota ON
	Kry.Kode_Kota = Kota.Kode_Kota
JOIN Gaji_Karyawan as Gaji ON
Kry.NIK = Gaji.NIK
JOIN Komponen_Gaji as Komp ON
Gaji.Kode_KompGaji = Komp.Kode_KompGaji

GROUP BY Kota.Kode_Kota,Kota.Nama_Kota, Gaji.Tahun

-- pemunculan nilai max dari view database
select *
from Vw_SUMGAJIBERSIH
Where Nilai = (Select MAX(Nilai) FROM Vw_SUMGAJIBERSIH)

----- Soal NO.8
CREATE VIEW Vw_SUMGAJI
AS
Select Kry.NIK, Kry.Nama_Depan, Gaji.Tahun, Gaji.Bulan,
	SUM(CASE WHEN Status = 'I' THEN
		Gaji.Nilai
	Else
		Gaji.Nilai * -1
	END) as Nilai
FROM Karyawan as Kry
JOIN Gaji_Karyawan as Gaji ON
	Kry.NIK = Gaji.NIK
JOIN Komponen_Gaji as Komp ON
Gaji.Kode_KompGaji = Komp.Kode_KompGaji
GROUP BY Kry.NIK, Kry.Nama_Depan, Gaji.Tahun, Gaji.Bulan

Select *
FROM Vw_SUMGAJI as Vw1
JOIN
(Select Tahun, Bulan, Avg(Nilai) as AvgNilai
FROM Vw_SUMGAJI
GROUP BY Tahun, Bulan) as Vw2 ON
	Vw1.Tahun = Vw2.Tahun AND Vw1.Bulan = Vw2.Bulan

Where Vw1.Nilai < AvgNilai
ORDER BY Vw1.Tahun, Vw1.Bulan

----- Soal No.9
Select Kry.NIK, Kry.Nama_Depan, Gaji.Tahun, Gaji.Bulan,
SUM(CASE WHEN [status] = 'I' THEN 
		Gaji.Nilai
	Else
		Gaji.Nilai * -1
	END) as Nilai

FROM Karyawan as Kry

JOIN Gaji_Karyawan as Gaji ON
	Kry.NIK = Gaji.NIK
JOIN Komponen_Gaji as Komp ON
	Gaji.Kode_KompGaji = Komp.Kode_KompGaji

Where Komp.Pajak = 'Y'
GROUP BY Kry.NIK, Kry.Nama_Depan, Gaji.Tahun, Gaji.Bulan
ORDER BY Kry.NIK


---- kalau ada umr
Select Kry.NIK, Kry.Nama_Depan, Gaji.Tahun, Gaji.Bulan,
SUM(CASE WHEN [status] = 'I' THEN 
		Gaji.Nilai
	Else
		Gaji.Nilai * -1
	END) as Nilai

FROM Karyawan as Kry

JOIN Gaji_Karyawan as Gaji ON
	Kry.NIK = Gaji.NIK
JOIN Komponen_Gaji as Komp ON
	Gaji.Kode_KompGaji = Komp.Kode_KompGaji

Where Komp.Pajak = 'Y'
GROUP BY Kry.NIK, Kry.Nama_Depan, Gaji.Tahun, Gaji.Bulan
--- Having SUM itu untuk 
HAVING SUM(CASE WHEN [status] = 'I' THEN Gaji.Nilai Else Gaji.Nilai * -1 END) > 1750000
ORDER BY Kry.NIK

----- Soal No.10
Select 
	Kry.NIK, 
	Kry.Nama_Depan, 
	SUM(CASE WHEN [status] = 'I' THEN Gaji.Nilai END) as Income,
	SUM(CASE WHEN [status] = 'D' THEN Gaji.Nilai END) as Outcome

FROM Karyawan as Kry
JOIN Gaji_Karyawan as Gaji ON
	Kry.NIK = Gaji.NIK
JOIN Komponen_Gaji as Komp ON
	Gaji.Kode_KompGaji = Komp.Kode_KompGaji

GROUP BY Kry.NIK, Kry.Nama_Depan

 

