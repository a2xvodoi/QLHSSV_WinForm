USE [master]
GO
/****** Object:  Database [QLSV]    Script Date: 1/8/2022 3:43:36 PM ******/
CREATE DATABASE [QLSV]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSV', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSV.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLSV_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLSV_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QLSV] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSV].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSV] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSV] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSV] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSV] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSV] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSV] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSV] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSV] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSV] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSV] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLSV] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSV] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSV] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSV] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSV] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSV] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSV] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSV] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSV] SET  MULTI_USER 
GO
ALTER DATABASE [QLSV] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSV] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSV] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSV] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QLSV] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QLSV] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSV', N'ON'
GO
ALTER DATABASE [QLSV] SET QUERY_STORE = OFF
GO
USE [QLSV]
GO
/****** Object:  Table [dbo].[DienGiaDinh]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienGiaDinh](
	[MaSV] [char](10) NOT NULL,
	[HoNgheo] [bit] NOT NULL,
	[TBLS] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhenThuong]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuong](
	[MaKy] [int] NOT NULL,
	[MaSV] [char](10) NOT NULL,
	[MaKhoaHoc] [int] NOT NULL,
	[HocBong] [bit] NOT NULL,
	[MaLop] [int] NOT NULL,
	[MaKhoa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKy] ASC,
	[MaSV] ASC,
	[MaKhoaHoc] ASC,
	[MaLop] ASC,
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Khoa]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khoa](
	[MaKhoa] [int] IDENTITY(1,1) NOT NULL,
	[TenKhoa] [nvarchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoaHoc]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoaHoc](
	[MaKhoaHoc] [int] IDENTITY(1,1) NOT NULL,
	[KhoaHoc] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKhoaHoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyHoc]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyHoc](
	[MaKy] [int] IDENTITY(1,1) NOT NULL,
	[TenKy] [nvarchar](20) NOT NULL,
	[NamHoc] [int] NOT NULL,
 CONSTRAINT [PK__KyHoc__2725CF49ED6D2B6A] PRIMARY KEY CLUSTERED 
(
	[MaKy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KyLuat]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KyLuat](
	[MaKy] [int] NOT NULL,
	[MaSV] [char](10) NOT NULL,
	[MaKhoaHoc] [int] NOT NULL,
	[KyLuat] [bit] NOT NULL,
	[MucKyLuat] [nvarchar](50) NULL,
	[MaLop] [int] NOT NULL,
	[MaKhoa] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKy] ASC,
	[MaSV] ASC,
	[MaKhoaHoc] ASC,
	[MaLop] ASC,
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LopHoc]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LopHoc](
	[MaLop] [int] IDENTITY(1,1) NOT NULL,
	[MaKhoa] [int] NOT NULL,
	[TenLop] [char](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLop] ASC,
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[MaSV] [char](10) NOT NULL,
	[MaKhoaHoc] [int] NOT NULL,
	[MaLop] [int] NOT NULL,
	[MaKhoa] [int] NOT NULL,
	[TenSV] [nvarchar](30) NOT NULL,
	[NgaySinh] [datetime] NOT NULL,
	[CMT] [char](12) NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[TonGiao] [nvarchar](15) NOT NULL,
	[DienThoai] [char](15) NOT NULL,
	[QuocTich] [nvarchar](15) NOT NULL,
	[Que] [nvarchar](20) NOT NULL,
	[TrinhDo] [nvarchar](15) NOT NULL,
	[DanToc] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC,
	[MaKhoaHoc] ASC,
	[MaLop] ASC,
	[MaKhoa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [char](10) NOT NULL,
	[Password] [char](15) NOT NULL,
 CONSTRAINT [PK__TaiKhoan__27250070337BF310] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinBo]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinBo](
	[MaSV] [char](10) NOT NULL,
	[TenBo] [nvarchar](30) NULL,
	[NgheNghiepBo] [nvarchar](20) NULL,
	[NamSinhBo] [char](4) NULL,
	[QueQuanBo] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThongTinMe]    Script Date: 1/8/2022 3:43:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThongTinMe](
	[MaSV] [char](10) NOT NULL,
	[TenMe] [nvarchar](30) NULL,
	[NgheNghiepMe] [nvarchar](20) NULL,
	[NamSinhMe] [char](4) NULL,
	[QueQuanMe] [nvarchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Khoa] ON 

INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (1, N'Công nghệ thông tin')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (2, N'Cơ khí')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (3, N'Kế toán')
INSERT [dbo].[Khoa] ([MaKhoa], [TenKhoa]) VALUES (4, N'Điện tử')
SET IDENTITY_INSERT [dbo].[Khoa] OFF
GO
SET IDENTITY_INSERT [dbo].[KhoaHoc] ON 

INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [KhoaHoc]) VALUES (1, N'K13       ')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [KhoaHoc]) VALUES (2, N'K14       ')
INSERT [dbo].[KhoaHoc] ([MaKhoaHoc], [KhoaHoc]) VALUES (3, N'K15       ')
SET IDENTITY_INSERT [dbo].[KhoaHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[KyHoc] ON 

INSERT [dbo].[KyHoc] ([MaKy], [TenKy], [NamHoc]) VALUES (1, N'Học kỳ 1', 1)
INSERT [dbo].[KyHoc] ([MaKy], [TenKy], [NamHoc]) VALUES (2, N'Học kỳ 2', 1)
INSERT [dbo].[KyHoc] ([MaKy], [TenKy], [NamHoc]) VALUES (3, N'Học kỳ 1', 2)
SET IDENTITY_INSERT [dbo].[KyHoc] OFF
GO
SET IDENTITY_INSERT [dbo].[LopHoc] ON 

INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (1, 1, N'CNTT01    ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (2, 1, N'CNTT02    ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (3, 1, N'CNTT03    ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (4, 2, N'CK01      ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (5, 2, N'CK02      ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (6, 2, N'CK03      ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (7, 3, N'KT01      ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (8, 3, N'KT02      ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (9, 3, N'KT03      ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (10, 4, N'DT01      ')
INSERT [dbo].[LopHoc] ([MaLop], [MaKhoa], [TenLop]) VALUES (11, 4, N'DT02      ')
SET IDENTITY_INSERT [dbo].[LopHoc] OFF
GO
INSERT [dbo].[SinhVien] ([MaSV], [MaKhoaHoc], [MaLop], [MaKhoa], [TenSV], [NgaySinh], [CMT], [GioiTinh], [TonGiao], [DienThoai], [QuocTich], [Que], [TrinhDo], [DanToc]) VALUES (N'2018601977', 1, 1, 1, N'Nguyễn Đức Việt', CAST(N'2000-06-12T00:00:00.000' AS DateTime), N'10149181011 ', 1, N'Thiên Chúa Giáo', N'0941024192     ', N'Việt Nam', N'Nam Định', N'Đại học', N'Kinh')
GO
SET IDENTITY_INSERT [dbo].[TaiKhoan] ON 

INSERT [dbo].[TaiKhoan] ([MaTK], [UserName], [Password]) VALUES (1, N'admin     ', N'admin          ')
INSERT [dbo].[TaiKhoan] ([MaTK], [UserName], [Password]) VALUES (2, N'a2xvodoi  ', N'admin          ')
INSERT [dbo].[TaiKhoan] ([MaTK], [UserName], [Password]) VALUES (3, N'quachan   ', N'admin          ')
SET IDENTITY_INSERT [dbo].[TaiKhoan] OFF
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD FOREIGN KEY([MaSV], [MaKhoaHoc], [MaLop], [MaKhoa])
REFERENCES [dbo].[SinhVien] ([MaSV], [MaKhoaHoc], [MaLop], [MaKhoa])
GO
ALTER TABLE [dbo].[KhenThuong]  WITH CHECK ADD  CONSTRAINT [FK__KhenThuong__MaKy__3B75D760] FOREIGN KEY([MaKy])
REFERENCES [dbo].[KyHoc] ([MaKy])
GO
ALTER TABLE [dbo].[KhenThuong] CHECK CONSTRAINT [FK__KhenThuong__MaKy__3B75D760]
GO
ALTER TABLE [dbo].[KyLuat]  WITH CHECK ADD FOREIGN KEY([MaSV], [MaKhoaHoc], [MaLop], [MaKhoa])
REFERENCES [dbo].[SinhVien] ([MaSV], [MaKhoaHoc], [MaLop], [MaKhoa])
GO
ALTER TABLE [dbo].[KyLuat]  WITH CHECK ADD  CONSTRAINT [FK__KyLuat__MaKy__3A81B327] FOREIGN KEY([MaKy])
REFERENCES [dbo].[KyHoc] ([MaKy])
GO
ALTER TABLE [dbo].[KyLuat] CHECK CONSTRAINT [FK__KyLuat__MaKy__3A81B327]
GO
ALTER TABLE [dbo].[LopHoc]  WITH CHECK ADD FOREIGN KEY([MaKhoa])
REFERENCES [dbo].[Khoa] ([MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaLop], [MaKhoa])
REFERENCES [dbo].[LopHoc] ([MaLop], [MaKhoa])
GO
ALTER TABLE [dbo].[SinhVien]  WITH CHECK ADD FOREIGN KEY([MaKhoaHoc])
REFERENCES [dbo].[KhoaHoc] ([MaKhoaHoc])
GO
USE [master]
GO
ALTER DATABASE [QLSV] SET  READ_WRITE 
GO
