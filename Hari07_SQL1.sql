SELECT
	Kode_Mahasiswa, Nama_Mahasiswa, Mahasiswa.Kode_Jurusan, Nama_Jurusan, Deskripsi, Mahasiswa.Kode_Agama
FROM
	Mahasiswa
JOIN Jurusan ON
	Mahasiswa.Kode_Jurusan = Jurusan.Kode_Jurusan

JOIN Agama ON
	Mahasiswa.Kode_Agama = Agama.Kode_Agama;

-- LEFT & RIGHT JOIN EXAMPLE
-- RIGHT JOIN (YANG DITAMPILKAN ITU SEBANYAK KANAN/ Mengikuti yang kanan dari lambang "=")
Select *
from Agama Right join Mahasiswa on
Agama.Kode_Agama = Mahasiswa.Kode_Agama

-- Left Join (YANG DITAMPILKAN ITU SEBANYAK KIRI/ Mengikuti yang kiri dari lambang "=")
Select *
from Agama Left Join Mahasiswa on
Agama.Kode_Agama = Mahasiswa.Kode_Agama



-- Buat alias dipakai "AS" dalam 1 RUN
--- [Nama Table](spasi)[alias] = option pertama untuk membuat alias, NOTE: alias pada select itu tidak bisa dipakai dalam "FROM"
Select
	Kode_Mahasiswa Kd_Mhs, Nama_Mahasiswa
--- 
From
	Mahasiswa
Join Agama as Agm ON
	Mahasiswa.Kode_Agama = Agm.Kode_Agama;

-- Insert Value Example
Select * from Mahasiswa
Select * from Agama

Insert Into Agama
	(Kode_Agama, Deskripsi)
Values
	('A007', 'Agama Baru');


--------------------- PRACTICE ---------------------

--- PRACTICE NO.3
Select 
	Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, Deskripsi
From Mahasiswa
LEFT JOIN Jurusan ON
	Mahasiswa.Kode_Jurusan = Jurusan.Kode_Jurusan
LEFT JOIN Agama ON
	Mahasiswa.Kode_Agama = Agama.Kode_Agama
Where Kode_Mahasiswa = 'M001';

--- PRACTICE NO.4
Select *
FROM Mahasiswa AS Mhs
JOIN Jurusan AS Jur ON
Mhs.Kode_Jurusan = Jur.Kode_Jurusan
Where Status_Jurusan = 'Non Aktif';

--- PRACTICE NO.5
Select *
From Mahasiswa Mhs
JOIN Nilai ON
	Mhs.Kode_Mahasiswa = Nilai.Kode_Mahasiswa
JOIN Ujian ON
	Nilai.Kode_Ujian = Ujian.Kode_Ujian
Where Nilai > '80' AND Status_Ujian = 'Aktif';

--- PRACTICE N0.6
Select *
From Jurusan
WHERE Nama_Jurusan LIKE '%Sistem%';

--- PRACTICE NO.7
-- untuk COUNT 
Select Mahasiswa.Nama_Mahasiswa, COUNT(Ujian.ID) Jumlah --polanya adalah coun(data yang ingin dihitung)(spasi) Nama
From Mahasiswa
	LEFT JOIN Nilai ON
		Mahasiswa.Kode_Mahasiswa = Nilai.Kode_Mahasiswa
	LEFT JOIN Ujian ON
		Nilai.Kode_Ujian = Ujian.Kode_Ujian
GROUP BY Mahasiswa.Kode_Mahasiswa, Mahasiswa.Nama_Mahasiswa
HAVING COUNT(Ujian.ID) > 1

--- PRACTICE NO.8
Select 
	Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, Agama.Deskripsi, Nama_Dosen, Status_Jurusan, Type_Dosen.Deskripsi
From Mahasiswa
LEFT JOIN Jurusan ON
	Mahasiswa.Kode_Jurusan = Jurusan.Kode_Jurusan
LEFT JOIN Agama ON
	Mahasiswa.Kode_Agama = Agama.Kode_Agama
LEFT JOIN Dosen ON
	Jurusan.Kode_Jurusan = Dosen.Kode_Jurusan
LEFT JOIN Type_Dosen ON
	Dosen.Kode_Type_Dosen = Type_Dosen.Kode_Type_Dosen
where Kode_Mahasiswa = 'M001';

--- PRACTICE NO.9
--- View ini bisa di update/ganti lhooo, Commandnya ALTER VIEW
CREATE VIEW View_Practice_Soal09
AS
Select 
	Kode_Mahasiswa, Nama_Mahasiswa, Nama_Jurusan, Agama.Deskripsi Agama, Nama_Dosen, Status_Jurusan, Type_Dosen.Deskripsi Deskripsi
From Mahasiswa
LEFT JOIN Jurusan ON
	Mahasiswa.Kode_Jurusan = Jurusan.Kode_Jurusan
LEFT JOIN Agama ON
	Mahasiswa.Kode_Agama = Agama.Kode_Agama
LEFT JOIN Dosen ON
	Jurusan.Kode_Jurusan = Dosen.Kode_Jurusan
LEFT JOIN Type_Dosen ON
	Dosen.Kode_Type_Dosen = Type_Dosen.Kode_Type_Dosen
where Kode_Mahasiswa = 'M001';

--- PRACTICE NO.10
Select *
FROM Mahasiswa
LEFT JOIN Nilai ON
	Mahasiswa.Kode_Mahasiswa = Nilai.Kode_Mahasiswa

--- PRACTICE NO.11
Select *
FROM Mahasiswa
JOIN Nilai ON
	Mahasiswa.Kode_Mahasiswa = Nilai.Kode_Mahasiswa
WHERE 	
	Nilai = (select min(Nilai) from Nilai)
	or Nilai = (select max(Nilai) from Nilai)
	or Nilai > (select avg(Nilai) from Nilai)
	or Nilai < (select avg(Nilai) from Nilai)

--- PRACTICE NO.12
ALTER TABLE Jurusan ADD Biaya Decimal(18,4)

Select *
FROM Jurusan

--- PRACTiCE NO.13
--- CARA 1 ---
UPDATE Jurusan
SET Biaya = 1500000 Where Nama_Jurusan = 'Teknik Informatika'
UPDATE Jurusan
SET Biaya = 1550000 Where Nama_Jurusan = 'Management Informatika'
UPDATE Jurusan
SET Biaya = 1475000 Where Nama_Jurusan = 'Sistem Informasi'
UPDATE Jurusan
SET Biaya = 1350000 Where Nama_Jurusan = 'Sistem Komputer'
UPDATE Jurusan
SET Biaya = 1535000 Where Nama_Jurusan = 'Komputer Akuntasi'

--- CARA 2 ---
UPDATE Jurusan
SET Biaya = Case ID
	WHEN 1 THEN 1500000
	WHEN 2 THEN 1550000
	WHEN 3 THEN 1475000
	WHEN 4 THEN 1350000
	WHEN 5 THEN 1535000

--- CARA 3 ---
UPDATE Jur
	SET Jur.Biaya = VtBiaya.Biaya
FROM Jurusan Jur
	JOIN
	(SELECT 'J001' Kode, 1500000 Biaya
	UNION
	SELECT 'J002' Kode, 1550000 Biaya
	UNION
	SELECT 'J003' Kode, 1475000 Biaya
	UNION
	SELECT 'J004' Kode, 1350000 Biaya
	UNION
	SELECT 'J005' Kode, 1535000 Biaya) VtBiaya ON
Jur.Kode_Jurusan = VtBiaya.Kode


--- Practice No.14
Select Nama_Jurusan,Biaya
FROM Jurusan
--- SESUAI SOAL
SELECT *
FROM Jurusan
WHERE 	
	Biaya = (select min(Biaya) from Jurusan)
	or Biaya = (select max(Biaya) from Jurusan)
	or Biaya > (select avg(Biaya) from Jurusan)
	or Biaya < (select avg(Biaya) from Jurusan)
--- MIN & MAX
SELECT *
FROM Jurusan
WHERE 	
	Biaya = (select min(Biaya) from Jurusan)
	or Biaya = (select max(Biaya) from Jurusan)
--- AVERAGE
SELECT *
FROM Jurusan
WHERE
	Biaya = (select avg(Biaya) from Jurusan) 

--- DIATAS AVG
SELECT *
FROM Jurusan
WHERE
	Biaya > (select avg(Biaya) from Jurusan)

--- DIBAWAH AVG
SELECT *
FROM Jurusan
WHERE
	Biaya < (select avg(Biaya) from Jurusan)






