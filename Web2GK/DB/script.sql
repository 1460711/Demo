USE [master]
GO
/****** Object:  Database [WebGiuaKi]    Script Date: 4/20/2017 10:41:14 AM ******/
CREATE DATABASE [WebGiuaKi]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WebGiuaKi', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WebGiuaKi.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WebGiuaKi_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\WebGiuaKi_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WebGiuaKi] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebGiuaKi].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebGiuaKi] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WebGiuaKi] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WebGiuaKi] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WebGiuaKi] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WebGiuaKi] SET ARITHABORT OFF 
GO
ALTER DATABASE [WebGiuaKi] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WebGiuaKi] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WebGiuaKi] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WebGiuaKi] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WebGiuaKi] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WebGiuaKi] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WebGiuaKi] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WebGiuaKi] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WebGiuaKi] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WebGiuaKi] SET  ENABLE_BROKER 
GO
ALTER DATABASE [WebGiuaKi] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WebGiuaKi] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WebGiuaKi] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WebGiuaKi] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WebGiuaKi] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WebGiuaKi] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WebGiuaKi] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WebGiuaKi] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WebGiuaKi] SET  MULTI_USER 
GO
ALTER DATABASE [WebGiuaKi] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WebGiuaKi] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WebGiuaKi] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WebGiuaKi] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [WebGiuaKi] SET DELAYED_DURABILITY = DISABLED 
GO
USE [WebGiuaKi]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 4/20/2017 10:41:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[MaLoaiSanPham] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSP] [nvarchar](100) NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 4/20/2017 10:41:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [int] IDENTITY(1,1) NOT NULL,
	[TenSP] [nvarchar](100) NULL,
	[MoTa] [nvarchar](200) NULL,
	[XuatXu] [nvarchar](100) NULL,
	[Gia] [int] NULL,
	[SoLuongTon] [int] NULL,
	[NgayNhap] [date] NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[ManHinh] [nvarchar](50) NULL,
	[Ram] [nvarchar](50) NULL,
	[CaMeRa] [nvarchar](max) NULL,
	[MaLoaiSanPham] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[LoaiSanPham] ON 

INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSP]) VALUES (1, N'Iphone')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSP]) VALUES (2, N'SamSung')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSP]) VALUES (3, N'Oppo')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSP]) VALUES (4, N'Sony')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSP]) VALUES (5, N'Nokia')
INSERT [dbo].[LoaiSanPham] ([MaLoaiSanPham], [TenLoaiSP]) VALUES (6, N'Htc')
SET IDENTITY_INSERT [dbo].[LoaiSanPham] OFF
SET IDENTITY_INSERT [dbo].[SanPham] ON 

INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (1, N'Iphone 7 32GB', N'RAM 2GB, Hệ điều hành iOS 10, Bộ nhớ trong 32GB', N'Mỹ', 12790000, 1500, CAST(N'2016-01-06' AS Date), N'\Assets\img\iphone7.jpg', N'Retina HD, 4.7 inches, 1334 x 750 Pixels', N'2GB', N'12 MP', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (2, N'Samsung Galaxy J7', N'RAM 2GB, Hệ điều hành Android', N'China', 6000000, 1000, CAST(N'2016-05-01' AS Date), N'\Assets\img\j7.jpg', N'5.5', N'3GB', N'13MP', 2)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (3, N'Oppo F1s', N'Hỗ trợ 4GB, thiết kế nguyên khối mặt kính cong 2.5D', N'China', 5900000, 500, CAST(N'2016-01-15' AS Date), N'\Assets\img\f1s.jpg', N'	IPS LCD', N'3GB', N'13MP', 3)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (4, N'Sony Z5', N'Màn hình IPS LCD, 5.5 '''', Hệ điều hành Android 6.0', N'Mỹ', 6490000, 150, CAST(N'2016-02-03' AS Date), N'\Assets\img\dtz5.jpg', N'IPS LCD, 5.5 ', N'3GB', N'23MP', 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (5, N'Nokia 6', N'Màn hình IPS LCD, 5.5 '''', Hệ điều hành Android 7.0', N'Mỹ', 6190000, 200, CAST(N'2017-01-02' AS Date), N'\Assets\img\n6.jpg', N'IPS LCD, 5.5 ', N'4GB', N'16MP', 5)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (6, N'Iphone 6 32GB', N'RAM 1GB, Hệ điều hành iOS 10.2, Bộ nhớ trong 32GB', N'Mỹ', 9990000, 150, CAST(N'2017-02-01' AS Date), N'\Assets\img\i6.jpg', N'4.7 inch (1334 x 750 pixels)', N'1GB', N'Chính: 8.0 MP, Phụ: 1.2 MP', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (7, N'Sony Z3', N'RAM 1GB,Hệ điều hành Andoird', N'Đài Loan', 3200000, 200, CAST(N'2016-03-05' AS Date), N'\Assets\img\z3.jpg', N'IPS LCD, 5.2, Full HD', N'2GB', N'20.7MP', 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (8, N'Samsung J5', N'RAM 2GB, Hệ điều hành Android 6.0', N'China', 3090000, 500, CAST(N'2015-05-01' AS Date), N'\Assets\img\j5.jpg', N'Supper AMOLED, 5.2",HD', N'2GB', N'13MP', 2)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (9, N' Iphone 7 Plus 256', N'RAM 3G, ROM :256GB', N'Mỹ', 24990000, 500, CAST(N'2017-01-01' AS Date), N'\Assets\img\7plus.jpg', N'5.5", Retina', N'3GB', N'2x12MP, Sefile: 7MP', 1)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (10, N'Oppo F3 Plus', N'MicroSD, hỗ trợ tối đa 256 GB', N'China', 10690000, 481, CAST(N'2016-09-03' AS Date), N'\Assets\img\f3plus.png', N'	IPS LCD, 6", Full HD', N'2GB', N'16MP', 3)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (12, N'Sony Xperia XZs', N'MicroSD, hỗ trợ tối đa 256 GB,Android 7.0', N'Mỹ', 14990000, 542, CAST(N'2017-09-02' AS Date), N'\Assets\img\sonyzxs.png', N'IPS LCD, 5.2", Full HD', N'4GB', N'19MP', 4)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (13, N'Samsung Galaxy S8', N'Hệ điều hành Android :7.0,CPU:Exynos 8895 8 nhân 64-bit', N'Mỹ', 20990000, 500, CAST(N'2017-01-03' AS Date), N'\Assets\img\s8.jpg', N'Super AMOLED, 6.2", Quad HD', N'4GB', N'12MP', 2)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [MoTa], [XuatXu], [Gia], [SoLuongTon], [NgayNhap], [HinhAnh], [ManHinh], [Ram], [CaMeRa], [MaLoaiSanPham]) VALUES (14, N'HTC U Ultra', N'CPU:Qualcomm Snapdragon 821 4 nhân 64-bit, Màn hình:Super LCD, Chính: 5.7", phụ: 2.05", Quad HD (2K)', N'China', 15990000, 300, CAST(N'2016-01-08' AS Date), N'\Assets\img\ultra.png', N'Super LCD, Chính: 5.7", phụ: 2.05", Quad HD (2K)', N'4GB', N'16MP', 6)
SET IDENTITY_INSERT [dbo].[SanPham] OFF
USE [master]
GO
ALTER DATABASE [WebGiuaKi] SET  READ_WRITE 
GO
