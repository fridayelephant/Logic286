USE InventoryDb

--Soal
--Note jumlah penjualan = qty * hrg, jumlah produk = qty

Select * FROM Product
Select * FROM Selling
Select * FROM Outlet
--01 Tampilkan jumlah penjualan barang peroutlet per-tanggal
Select
	Product.Nama as Product,
	Outlet.Nama as Nama_Outlet,
	Sell.SellingDate,
	SUM(Quantity*Harga) as Jumlah_Penjualan 
from Product

JOIN Selling as Sell ON
	Product.Kode = Sell.KodeProduct

JOIN Outlet ON
	Sell.KodeOutlet = Outlet.Kode
	
GROUP BY Product.Nama,Outlet.Nama,Sell.SellingDate

--02 Tapilkan jumlah penjualan per tahun
Select 
	Sell.SellingDate as Selling_Date,
	SUM(Quantity*Harga) as Jumlah_Penjualan

from Selling as Sell

JOIN Product ON
	Product.Kode = Sell.KodeProduct

JOIN Outlet ON
	Sell.KodeOutlet = Outlet.Kode

GROUP BY Sell.SellingDate	
ORDER BY Sell.SellingDate ASC

--03 Tapilkan jumlah product terlaris dan ter tidak laris per kota
Select 
	Kota.Nama,
	MIN(Quantity*Harga) as Minimum,
	Max(Quantity*Harga) as Maximum

from Kota

JOIN Outlet ON
	Kota.Kode = Outlet.KodeKota

JOIN Selling as Sell ON
	Sell.KodeOutlet = Outlet.Kode

JOIN Product ON
	Product.Kode = Sell.KodeProduct

GROUP BY Kota.Nama

--04 Tapilkan jumlah penjualan per provinsi dan urutkan dari yang terbesar
Select 
	Provinsi.Nama,
	SUM(Quantity*Harga) as Jumlah_Penjualan

from Provinsi

JOIN Kota ON
	Provinsi.Kode = Kota.KodeProvinsi
JOIN Outlet ON
	Kota.Kode = Outlet.KodeKota

JOIN Selling as Sell ON
	Sell.KodeOutlet = Outlet.Kode

JOIN Product ON
	Product.Kode = Sell.KodeProduct

GROUP BY Provinsi.Nama
ORDER BY Jumlah_Penjualan DESC

--05 Tampilan referensi yang tidak sesuai dengan sellingdate
Select * FROM Selling
WHERE Selling.Referensi =


--06 Tampilan jumlah produk terjual pertahun peroutlet
Select
	Outlet.Nama as Nama_Outlet,
	Product.Nama as Nama_Product,
	Sell.SellingDate,
	SUM(Quantity) as Jumlah_Produk

FROM Outlet

JOIN Selling as Sell ON
	Outlet.Kode = Sell.KodeOutlet
JOIN Product ON
	Sell.KodeProduct = Product.Kode

GROUP BY 
	Outlet.Nama,
	Product.Nama,
	Sell.SellingDate

ORDER BY Sell.SellingDate

--07 Tampilan jumlah penjualan peroutlet
Select
	Outlet.Nama as Nama_Outlet,
	SUM(Quantity*Harga) as Jumlah_Penjualan

FROM Outlet

JOIN Selling as Sell ON
	Outlet.Kode = Sell.KodeOutlet
JOIN Product ON
	Sell.KodeProduct = Product.Kode

GROUP BY 
	Outlet.Nama

--08 Tampilan jumlah penjualan per bulan diurutkan berdasar bulan
--09 Tampilan rata-rata jumlah penjualan setiap bulan
--10 Tampilan produk dengan jumlah produk dibawah rata-rata
--11 Tampilan outlet dengan jumlah penjualan dibawah rata-rata
--12 Tampilan kota dengan jumlah penjualan diatas rata-rata