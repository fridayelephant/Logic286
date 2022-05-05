CREATE DATABASE InventoryDb
USE InventoryDb

CREATE TABLE Provinsi (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kode] [char](5) NOT NULL,
	[Nama] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Provinsi] PRIMARY KEY CLUSTERED 
(
	[Kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE Kota (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kode] [char](5) NOT NULL,
	[KodeProvinsi] [char](5) NOT NULL,
	[Nama] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Kota] PRIMARY KEY CLUSTERED 
(
	[Kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Kota]  WITH CHECK ADD  CONSTRAINT [FK_Kota_Provinsi] FOREIGN KEY([KodeProvinsi])
REFERENCES [dbo].[Provinsi] ([Kode])
GO

ALTER TABLE [dbo].[Kota] CHECK CONSTRAINT [FK_Kota_Provinsi]
GO

CREATE TABLE Outlet (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kode] [char](5) NOT NULL,
	[KodeKota] [char](5) NOT NULL,
	[Nama] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Outlet] PRIMARY KEY CLUSTERED 
(
	[Kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Outlet]  WITH CHECK ADD  CONSTRAINT [FK_Outlet_Kota] FOREIGN KEY([KodeKota])
REFERENCES [dbo].[Kota] ([Kode])
GO

ALTER TABLE [dbo].[Outlet] CHECK CONSTRAINT [FK_Outlet_Kota]
GO

CREATE TABLE Product (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kode] [char](5) NOT NULL,
	[Nama] [varchar](30) NOT NULL,
	[Harga] [decimal](18,4) NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Kode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE Selling (
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Referensi] [char](10) NOT NULL,
	[SellingDate] [datetime] NOT NULL,
	[KodeProduct] [char](5) NOT NULL,
	[Quantity] [decimal](18,4) NOT NULL,
	[KodeOutlet] [char](5) NOT NULL,
 CONSTRAINT [PK_Selling] PRIMARY KEY CLUSTERED 
(
	[Referensi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Selling]  WITH CHECK ADD  CONSTRAINT [FK_Product_Selling] FOREIGN KEY([KodeProduct])
REFERENCES [dbo].[Product] ([Kode])
GO

ALTER TABLE [dbo].[Selling]  WITH CHECK ADD  CONSTRAINT [FK_Outlet_Selling] FOREIGN KEY([KodeOutlet])
REFERENCES [dbo].[Outlet] ([Kode])
GO

ALTER TABLE [dbo].[Selling] CHECK CONSTRAINT [FK_Product_Selling]
GO

ALTER TABLE [dbo].[Selling] CHECK CONSTRAINT [FK_Outlet_Selling]
GO

INSERT INTO [dbo].[Provinsi]
           ([Kode]
           ,[Nama])
     VALUES
           ('P0001','DKI Jakarta'),
		   ('P0002','Banten'),
		   ('P0003','Jawa Barat')
GO

SELECT * FROM Provinsi

INSERT INTO [dbo].[Kota]
           ([Kode]
           ,[KodeProvinsi]
           ,[Nama])
     VALUES
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
GO

SELECT * FROM Kota

INSERT INTO [dbo].[Outlet]
           ([Kode]
           ,[KodeKota]
           ,[Nama])
     VALUES
           ('O001','K1003','Jaktim Jaya'),
		   ('O002','K3001','Bek Kota Jaya'),
		   ('O003','K3003','Cikarang Jaya'),
		   ('O004','K2001','TangSel Jaya'),
		   ('O005','K1001','JakPus Jaya'),
		   ('O006','K3002','Bekasi Jaya')
GO

SELECT * FROM Outlet

INSERT INTO [dbo].[Product]
           ([Kode]
           ,[Nama]
           ,[Harga])
     VALUES
           ('P0192','Roti',12500),
		   ('P0112','Sabun',25500),
		   ('P1022','Sampoo',22750),
		   ('P0928','Sandal',17000),
		   ('P2312','Kaos kaki',16550),
		   ('P9289','Pasta gigi',8900),
		   ('P2998','Tissue',35500)
GO

SELECT * FROM Product

INSERT INTO [dbo].[Selling]
           ([Referensi]
           ,[SellingDate]
           ,[KodeProduct]
           ,[Quantity]
           ,[KodeOutlet])
     VALUES
           ('SLS2111001','2021-11-22','P1022',3,'O001'),
		   ('SLS2111002','2021-11-23','P1022',10,'O002'),
		   ('SLS2112001','2021-12-11','P1022',12,'O003'),
           ('SLS2112002','2021-12-11','P1022',1,'O004'),
           ('SLS2201001','2022-01-01','P1022',9,'O005'),
		   ('SLS2201002','2022-01-03','P1022',2,'O006'),
		   ('SLS2202001','2022-02-11','P1022',7,'O001'),
           ('SLS2203001','2022-03-01','P1022',8,'O001'),
		   ('SLS2203002','2022-03-03','P1022',3,'O005'),
		   ('SLS2203003','2022-04-11','P1022',10,'O006'),
		   ('SLS2203004','2022-04-12','P1022',3,'O002'),
		   ('SLS2204005','2022-04-12','P1022',2,'O002'),
		   ('SLS2205001','2022-05-01','P1022',1,'O003'),
		   ('SLS2205002','2022-05-01','P1022',19,'O004'),
		   ('SLS2205008','2022-05-12','P1022',20,'O005'),
		   ('SLS2206001','2022-05-13','P1022',2,'O001'),
		   ('SLS2206009','2022-05-13','P1022',1,'O002'),
		   ('SLS2206011','2022-06-12','P1022',4,'O005'),
		   ('SLS2206012','2022-06-12','P1022',2,'O003')
GO

SELECT * FROM Provinsi
SELECT * FROM Kota
SELECT * FROM Outlet
SELECT * FROM Product
SELECT * FROM Selling

Soal
--Note jumlah penjualan = qty * hrg, jumlah produk = qty
--01 Tapilkan jumlah penjualan barang peroutlet per-tanggal
--02 Tapilkan jumlah penjualan per tahun
--03 Tapilkan jumlah product terlaris dan ter tidak laris per kota
--04 Tapilkan jumlah penjualan per provinsi dan urutkan dari yang terbesar
--05 Tampilan referensi yang tidak sesuai dengan sellingdate
--06 Tampilan jumlah produk terjual pertahun peroutlet
--07 Tampilan jumlah penjualan peroutlet
--08 Tampilan jumlah penjualan per bulan diurutkan berdasar bulan
--09 Tampilan rata-rata jumlah penjualan setiap bulan
--10 Tampilan produk dengan jumlah produk dibawah rata-rata
--11 Tampilan outlet dengan jumlah penjualan dibawah rata-rata
--12 Tampilan kota dengan jumlah penjualan diatas rata-rata
