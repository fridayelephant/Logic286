USE [db_mahasiswa286]
GO
/****** Object:  Table [dbo].[Agama]    Script Date: 27/04/2022 16:09:46 ******/
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
/****** Object:  Table [dbo].[Dosen]    Script Date: 27/04/2022 16:09:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dosen](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Kode_Dosen] [char](5) NOT NULL,
	[Nama_Dosen] [varchar](100) NOT NULL,
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
/****** Object:  Table [dbo].[Jurusan]    Script Date: 27/04/2022 16:09:46 ******/
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
 CONSTRAINT [PK_Jurusan] PRIMARY KEY CLUSTERED 
(
	[Kode_Jurusan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mahasiswa]    Script Date: 27/04/2022 16:09:46 ******/
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
/****** Object:  Table [dbo].[Nilai]    Script Date: 27/04/2022 16:09:46 ******/
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
/****** Object:  Table [dbo].[Type_Dosen]    Script Date: 27/04/2022 16:09:46 ******/
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
/****** Object:  Table [dbo].[Ujian]    Script Date: 27/04/2022 16:09:46 ******/
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
