------- NOMOR 3 --------
CREATE DATABASE DBPenerbit
USE DBPenerbitselect *from tblPengarang INSERT INTO tblPengarang (Kd_Pengarang, Nama_Pengarang, Alamat, Kota, Kelamin)  Values  ('P0001', 'Ashadi',  'Jl. Beo 25', 'Yogya', 'P'),
('P0002', 'Rian', 'Jl. Solo 123', 'Yogya', 'P'),
('P0003', 'Suwadi', 'Jl. Semangka 13', 'Bandung', 'P'),
('P0004', 'Siti', 'Jl. Durian 15', 'Solo', 'W'),
('P0005', 'Amir', 'Jl. Gajah 33', 'Kudus', 'P'),
('P0006', 'Suparman', 'Jl. Harimau 25', 'Jakarta', 'P'),
('P0007', 'Jaja', 'Jl. Singa 7', 'Bandung', 'P'),
('P0008', 'Saman', 'Jl. Naga 12', 'Yogya', 'P'),
('P0009', 'Anwar', 'Jl. Tidar 6A', 'Magelang', 'P'),
('P0010', 'Fatmawati', 'Jl. Renjana 4', 'Bogor', 'W')

--- Soal No.3A
Select Kd_Pengarang, Nama_Pengarang
FROM tblPengarang
ORDER BY Nama_Pengarang -- urutan sesuai alfabet nama pengarang
ORDER BY Kd_Pengarang -- urutan sesuai kode pengarang

--- Soal No.3B
Select Kota,Kd_Pengarang, Nama_Pengarang
FROM tblPengarang
ORDER BY Kota

--- Soal No.3C
select COUNT(Nama_Pengarang)as Jumlah_Pengarang 
from tblPengarang

--- Soal No.3D
Select Kota, COUNT(Kota) as Jumlah_Kota
From tblPengarang
GROUP BY Kota

--- Soal No.3E
Select Kota, COUNT(Kota) as Jumlah_Kota
From tblPengarang
GROUP BY Kota
HAVING COUNT(Kota) > 1

--- Soal No.3F
Select 
	Max(Kd_Pengarang) as Maximum,
	MIN(Kd_Pengarang) as Minimum
From tblPengarang

------- NOMOR 4 --------
INSERT INTO tblGaji
(Kd_Pengarang, Nama_Pengarang, Gaji)

Values
('P0002', 'Rian', 600.000),
('P0005', 'Amir', 700.000),
('P0004', 'Siti', 500.000),
('P0003', 'Suwadi', 1000000),
('P0010', 'Fatmawati', 600000),
('P0008', 'Saman', 750000)
