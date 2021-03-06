USE [master]
GO
/****** Object:  Database [db_mahasiswa286]    Script Date: 29/04/2022 15:11:44 ******/
CREATE DATABASE [db_mahasiswa286]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_mahasiswa286', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_mahasiswa286.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'db_mahasiswa286_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\db_mahasiswa286_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [db_mahasiswa286] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_mahasiswa286].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_mahasiswa286] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_mahasiswa286] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_mahasiswa286] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_mahasiswa286] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_mahasiswa286] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET RECOVERY FULL 
GO
ALTER DATABASE [db_mahasiswa286] SET  MULTI_USER 
GO
ALTER DATABASE [db_mahasiswa286] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_mahasiswa286] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_mahasiswa286] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_mahasiswa286] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [db_mahasiswa286] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_mahasiswa286', N'ON'
GO
USE [db_mahasiswa286]
GO
/****** Object:  Table [dbo].[Agama]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Agama](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Agama] [char](5) NOT NULL,
	[Deskripsi] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Agama] PRIMARY KEY CLUSTERED 
(
	[Kode_Agama] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dosen]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dosen](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Dosen] [char](5) NOT NULL,
	[Nama_Dosen] [varchar](300) NULL,
	[Kode_Jurusan] [char](5) NOT NULL,
	[Kode_Type_Dosen] [char](5) NOT NULL,
 CONSTRAINT [PK_Dosen] PRIMARY KEY CLUSTERED 
(
	[Kode_Dosen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Jurusan]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Jurusan](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Jurusan] [char](5) NOT NULL,
	[Nama_Jurusan] [varchar](50) NOT NULL,
	[Status_Jurusan] [varchar](100) NOT NULL,
	[Biaya] [decimal](18, 4) NULL,
 CONSTRAINT [PK_Jurusan] PRIMARY KEY CLUSTERED 
(
	[Kode_Jurusan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mahasiswa]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mahasiswa](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Mahasiswa] [char](5) NOT NULL,
	[Nama_Mahasiswa] [varchar](100) NOT NULL,
	[Alamat] [varchar](200) NOT NULL,
	[Kode_Agama] [char](5) NOT NULL,
	[Kode_Jurusan] [char](5) NOT NULL,
 CONSTRAINT [PK_Mahasiswa] PRIMARY KEY CLUSTERED 
(
	[Kode_Mahasiswa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Nilai]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Nilai](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Mahasiswa] [char](5) NOT NULL,
	[Kode_Ujian] [char](5) NOT NULL,
	[Nilai] [decimal](8, 2) NOT NULL,
 CONSTRAINT [PK_Nilai] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Type_Dosen]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Type_Dosen](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Type_Dosen] [char](5) NOT NULL,
	[Deskripsi] [varchar](20) NULL,
 CONSTRAINT [PK_Type_Dosen] PRIMARY KEY CLUSTERED 
(
	[Kode_Type_Dosen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ujian]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ujian](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Ujian] [char](5) NOT NULL,
	[Nama_Ujian] [varchar](50) NOT NULL,
	[Status_Ujian] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Ujian] PRIMARY KEY CLUSTERED 
(
	[Kode_Ujian] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  View [dbo].[View_Practice_Soal09]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Practice_Soal09]
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

GO
/****** Object:  View [dbo].[View_Practice_Soal10]    Script Date: 29/04/2022 15:11:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create view [dbo].[View_Practice_Soal10]
as
Select*
FROM Mahasiswa
GO
ALTER TABLE [dbo].[Dosen]  WITH CHECK ADD  CONSTRAINT [FK_Dosen_Jurusan] FOREIGN KEY([Kode_Jurusan])
REFERENCES [dbo].[Jurusan] ([Kode_Jurusan])
GO
ALTER TABLE [dbo].[Dosen] CHECK CONSTRAINT [FK_Dosen_Jurusan]
GO
ALTER TABLE [dbo].[Dosen]  WITH CHECK ADD  CONSTRAINT [FK_Dosen_Type_Dosen] FOREIGN KEY([Kode_Type_Dosen])
REFERENCES [dbo].[Type_Dosen] ([Kode_Type_Dosen])
GO
ALTER TABLE [dbo].[Dosen] CHECK CONSTRAINT [FK_Dosen_Type_Dosen]
GO
ALTER TABLE [dbo].[Mahasiswa]  WITH CHECK ADD  CONSTRAINT [FK_Mahasiswa_Agama] FOREIGN KEY([Kode_Agama])
REFERENCES [dbo].[Agama] ([Kode_Agama])
GO
ALTER TABLE [dbo].[Mahasiswa] CHECK CONSTRAINT [FK_Mahasiswa_Agama]
GO
ALTER TABLE [dbo].[Mahasiswa]  WITH CHECK ADD  CONSTRAINT [FK_Mahasiswa_Jurusan] FOREIGN KEY([Kode_Jurusan])
REFERENCES [dbo].[Jurusan] ([Kode_Jurusan])
GO
ALTER TABLE [dbo].[Mahasiswa] CHECK CONSTRAINT [FK_Mahasiswa_Jurusan]
GO
ALTER TABLE [dbo].[Nilai]  WITH CHECK ADD  CONSTRAINT [FK_Nilai_Mahasiswa] FOREIGN KEY([Kode_Mahasiswa])
REFERENCES [dbo].[Mahasiswa] ([Kode_Mahasiswa])
GO
ALTER TABLE [dbo].[Nilai] CHECK CONSTRAINT [FK_Nilai_Mahasiswa]
GO
ALTER TABLE [dbo].[Nilai]  WITH CHECK ADD  CONSTRAINT [FK_Nilai_Ujian] FOREIGN KEY([Kode_Ujian])
REFERENCES [dbo].[Ujian] ([Kode_Ujian])
GO
ALTER TABLE [dbo].[Nilai] CHECK CONSTRAINT [FK_Nilai_Ujian]
GO
USE [master]
GO
ALTER DATABASE [db_mahasiswa286] SET  READ_WRITE 
GO
