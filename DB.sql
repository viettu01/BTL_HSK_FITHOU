USE [master]
GO
/****** Object:  Database [HSK_QuanLyCuaHangBanDienThoai]    Script Date: 2022-03-27 11:14:00 AM ******/
CREATE DATABASE [HSK_QuanLyCuaHangBanDienThoai]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HSK_QuanLyCuaHangBanDienThoai', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HSK_QuanLyCuaHangBanDienThoai.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HSK_QuanLyCuaHangBanDienThoai_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HSK_QuanLyCuaHangBanDienThoai_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HSK_QuanLyCuaHangBanDienThoai].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET ARITHABORT OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET RECOVERY FULL 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET  MULTI_USER 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HSK_QuanLyCuaHangBanDienThoai', N'ON'
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET QUERY_STORE = OFF
GO
USE [HSK_QuanLyCuaHangBanDienThoai]
GO
/****** Object:  Table [dbo].[tblProducer]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblProducer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[showAllProducer]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllProducer]
AS
	SELECT id AS [Mã nhà sản xuất], name AS [Tên nhà sản xuất]
	FROM dbo.tblProducer
GO
/****** Object:  Table [dbo].[tblAccount]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblAccount](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role] [nvarchar](20) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[fullName] [nvarchar](30) NULL,
	[phone] [varchar](12) NULL,
	[birthday] [datetime] NULL,
	[status] [int] NULL,
 CONSTRAINT [PK__tblAccou__3213E83F1BE8B32D] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[showAllAccount]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllAccount]
AS
	SELECT id AS [ID], role AS [Quyền], username AS [Tên đăng nhập], password AS [Mật khẩu], fullName AS [Họ tên], 
			phone AS [SĐT], birthday AS [Ngày sinh], IIF(status = 1, N'Bình thường', N'Khóa') AS [Trạng thái]
	FROM dbo.tblAccount
GO
/****** Object:  Table [dbo].[tblPhone]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPhone](
	[id] [varchar](255) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[idProducer] [int] NOT NULL,
	[quantity] [int] NOT NULL,
	[price] [float] NULL,
	[color] [nvarchar](20) NULL,
	[rom] [nvarchar](20) NULL,
	[ram] [nvarchar](20) NULL,
	[timeBH] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblDetailBillOut]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetailBillOut](
	[billOutId] [int] NOT NULL,
	[phoneId] [varchar](255) NOT NULL,
	[quantity] [float] NOT NULL,
 CONSTRAINT [PK_tblChiTietXuat] PRIMARY KEY CLUSTERED 
(
	[billOutId] ASC,
	[phoneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBillOut]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBillOut](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[accountId] [int] NOT NULL,
	[customerId] [int] NOT NULL,
	[createdAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[showDoanhThuSanPham]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showDoanhThuSanPham]
AS
	SELECT c.id AS [Mã điện thoại], c.name AS [Tên điện thoại], c.quantity AS [Tồn kho], 
			ISNULL(SUM(b.quantity), 0) AS [Đã bán], ISNULL((c.price * b.quantity), 0) AS [Doanh thu]
	FROM dbo.tblBillOut a 
			JOIN dbo.tblDetailBillOut b ON b.billOutId = a.id
			RIGHT JOIN dbo.tblPhone c ON c.id = b.phoneId
	GROUP BY (c.price * b.quantity),
             c.id,
             c.name,
             c.quantity
GO
/****** Object:  View [dbo].[showDoanhThuSanPhamTheoNgay]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showDoanhThuSanPhamTheoNgay]
AS
	SELECT c.id AS [Mã điện thoại], c.name AS [Tên điện thoại], c.quantity AS [Tồn kho], 
			ISNULL(SUM(b.quantity), 0) AS [Đã bán], ISNULL((c.price * b.quantity), 0) AS [Doanh thu], a.createdAt AS [Ngày bán]
	FROM dbo.tblBillOut a 
			JOIN dbo.tblDetailBillOut b ON b.billOutId = a.id
			RIGHT JOIN dbo.tblPhone c ON c.id = b.phoneId
	GROUP BY ISNULL((c.price * b.quantity), 0),
             c.id,
             c.name,
             c.quantity,
             a.createdAt
GO
/****** Object:  Table [dbo].[tblCustomer]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCustomer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](30) NULL,
	[phone] [nvarchar](12) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[showAllCustomer]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllCustomer]
AS
	SELECT id AS [ID], name AS [Họ tên], phone AS [SĐT]
	FROM dbo.tblCustomer
GO
/****** Object:  Table [dbo].[tblDetailBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblDetailBillIn](
	[billInId] [int] NOT NULL,
	[phoneId] [varchar](255) NOT NULL,
	[price] [float] NOT NULL,
	[quantity] [int] NOT NULL,
 CONSTRAINT [PK_billId_phoneId] PRIMARY KEY CLUSTERED 
(
	[billInId] ASC,
	[phoneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblBillIn](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[accountId] [int] NOT NULL,
	[createdAt] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[showAllBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllBillIn]
AS
	SELECT c.id AS [Mã hóa đơn], d.fullName AS [Người tạo], c.createdAt AS [Ngày tạo], ISNULL(SUM(b.quantity * b.price), 0) AS [Thành tiền]
	FROM dbo.tblPhone a 
			JOIN dbo.tblDetailBillIn b ON b.phoneId = a.id
			RIGHT JOIN dbo.tblBillIn c ON c.id = b.billInId
			JOIN dbo.tblAccount d ON d.id = c.accountId
	GROUP BY c.id,
             d.fullName,
             c.createdAt
GO
/****** Object:  View [dbo].[showAllDetailBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllDetailBillIn]
AS
SELECT    dbo.tblDetailBillIn.billInId AS [Mã HĐ], dbo.tblDetailBillIn.phoneId AS [Mã ĐT], dbo.tblPhone.name AS [Tên ĐT], dbo.tblDetailBillIn.quantity AS [Số lượng], dbo.tblDetailBillIn.price AS Giá
FROM         dbo.tblDetailBillIn INNER JOIN
                      dbo.tblPhone ON dbo.tblDetailBillIn.phoneId = dbo.tblPhone.id
GO
/****** Object:  View [dbo].[showAllDetailBillOut]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllDetailBillOut]
AS
	SELECT tblBillOut.id AS [Mã HĐ], dbo.tblPhone.id AS [Mã ĐT], dbo.tblPhone.name AS [Tên ĐT], dbo.tblDetailBillOut.quantity AS [Số lượng], 
			dbo.tblPhone.price AS [Đơn giá], dbo.tblPhone.price * dbo.tblDetailBillOut.quantity AS [Thành tiền], 
			IIF(IIF(RIGHT(tblPhone.timeBH, DATALENGTH(tblPhone.timeBH) / 2 - CHARINDEX(' ', tblPhone.timeBH) - 1 + 1) LIKE N'năm', DATEADD(YEAR, CAST(LEFT(tblPhone.timeBH, CHARINDEX(' ',tblPhone.timeBH) - 1) AS INT), createdAt), DATEADD(MONTH, CAST(LEFT(tblPhone.timeBH, CHARINDEX(' ',tblPhone.timeBH) - 1) AS INT), createdAt)) < GETDATE(), N'Hết', N'Còn') AS [Hạn bảo hành]		
	FROM dbo.tblBillOut 
			JOIN dbo.tblDetailBillOut ON dbo.tblBillOut.id = dbo.tblDetailBillOut.billOutId 
			JOIN dbo.tblPhone ON dbo.tblDetailBillOut.phoneId = dbo.tblPhone.id
GO
/****** Object:  View [dbo].[showAllBillOut]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllBillOut]
AS
	SELECT a.id AS [Mã HĐ], d.fullName AS [Người tạo], a.createdAt AS [Ngày tạo], ISNULL(SUM(c.price * b.quantity), 0) AS [Thành tiền]
	FROM dbo.tblBillOut a
			JOIN dbo.tblDetailBillOut b ON b.billOutId = a.id
			JOIN dbo.tblPhone c ON c.id = b.phoneId
			JOIN dbo.tblAccount d ON d.id = a.accountId
	GROUP BY a.id,
             d.fullName,
             a.createdAt
GO
/****** Object:  View [dbo].[showAllPhone]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[showAllPhone]
AS
	SELECT a.id AS [Mã ĐT], a.name AS [Tên ĐT], b.name AS [Hãng], a.quantity AS [SL], a.price AS [Giá], a.color AS [Màu], a.rom AS [Rom], a.ram AS [Ram], a.timeBH AS [Thời gian BH]
	FROM dbo.tblPhone a JOIN dbo.tblProducer b ON b.id = a.idProducer
GO
/****** Object:  View [dbo].[TKĐT]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TKĐT] as
select tblPhone.id as [Mã ĐT],tblPhone.name as [Tên ĐT],tblProducer.name as [Hãng], tblPhone.price as [Giá bán],tblPhone.color as [Màu],tblPhone.rom as[Rom],tblPhone.ram as[Ram],tblPhone.timeBH as[Bảo hành],sum( tblDetailBillOut.quantity) as[SL bán] ,sum(tblPhone.price*tblDetailBillOut.quantity)as [Doanh thu]
,tblPhone.quantity as[SL trong kho],YEAR(tblBillOut.createdAt) AS [Năm]
,MONTH(tblBillOut.createdAt) as[Tháng]
from(tblPhone join tblDetailBillOut on tblPhone.id=tblDetailBillOut.phoneId) join tblBillOut ON dbo.tblBillOut.id = dbo.tblDetailBillOut.billOutId join tblProducer on tblProducer.id=tblPhone.idProducer
group by tblPhone.id,tblPhone.quantity,YEAR(tblBillOut.createdAt),MONTH(tblBillOut.createdAt),tblPhone.name,tblProducer.name, tblPhone.price,tblPhone.color,tblPhone.rom,tblPhone.ram,tblPhone.timeBH
GO
/****** Object:  View [dbo].[TKNV]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TKNV] as
select tblAccount.id as [Mã NV],tblAccount.fullName as [Tên NV],DATEDIFF(year,tblAccount.birthday,getDate())as[Tuổi],sum (tblDetailBillOut.quantity)as [SLĐT bán],sum(tblPhone.price*tblDetailBillOut.quantity)[Doanh thu],YEAR(tblBillOut.createdAt) AS [Năm]
,MONTH(tblBillOut.createdAt) as[Tháng]
from tblAccount join tblBillOut on tblAccount.id=tblBillOut.accountId join tblDetailBillOut on tblBillOut.id=tblDetailBillOut.billOutId join tblPhone on tblPhone.id=tblDetailBillOut.phoneId
group by tblAccount.id,tblAccount.fullName,YEAR(tblBillOut.createdAt) ,MONTH(tblBillOut.createdAt) ,DATEDIFF(year,tblAccount.birthday,getDate())
GO
/****** Object:  View [dbo].[TKKH]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TKKH] as
select tblCustomer.id as [Mã KH],tblCustomer.name AS[Tên KH],sum (tblDetailBillOut.quantity) AS[SLĐT mua],sum(tblPhone.price*tblDetailBillOut.quantity) as[Tổng tiền],YEAR(tblBillOut.createdAt) AS [Năm]
,MONTH(tblBillOut.createdAt) as[Tháng]
from tblCustomer join tblBillOut on tblCustomer.id=tblBillOut.customerId join tblDetailBillOut on tblBillOut.id=tblDetailBillOut.billOutId join tblPhone on tblPhone.id=tblDetailBillOut.phoneId
group by tblCustomer.id,tblCustomer.name,YEAR(tblBillOut.createdAt) ,MONTH(tblBillOut.createdAt) 
GO
/****** Object:  View [dbo].[TKDT]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create view [dbo].[TKDT] as
select YEAR(tblBillOut.createdAt) AS [Năm],MONTH(tblBillOut.createdAt) as[Tháng],sum (tblDetailBillOut.quantity) AS[SLĐT bán],sum(tblPhone.price*tblDetailBillOut.quantity) as[Doanh thu]
from tblDetailBillOut join tblPhone on tblDetailBillOut.phoneId = tblPhone.id join tblBillOut on tblDetailBillOut.billOutId=tblBillOut.id
group by YEAR(tblBillOut.createdAt) ,MONTH(tblBillOut.createdAt) 
GO
SET IDENTITY_INSERT [dbo].[tblAccount] ON 

INSERT [dbo].[tblAccount] ([id], [role], [username], [password], [fullName], [phone], [birthday], [status]) VALUES (1, N'Admin', N'admin', N'123', N'Admin', N'0966871026', CAST(N'2001-10-14T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblAccount] ([id], [role], [username], [password], [fullName], [phone], [birthday], [status]) VALUES (2, N'Nhân viên', N'nv01', N'1234', N'NV01', N'0123456789', CAST(N'2001-03-05T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblAccount] ([id], [role], [username], [password], [fullName], [phone], [birthday], [status]) VALUES (3, N'Nhân viên', N'nv02', N'123', N'NV02', N'0987654321', CAST(N'1998-03-05T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tblAccount] ([id], [role], [username], [password], [fullName], [phone], [birthday], [status]) VALUES (6, N'Nhân viên', N'nv03', N'456', N'Nhân viên số 3', N'0258794613', CAST(N'1989-02-02T00:00:00.000' AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tblAccount] OFF
GO
SET IDENTITY_INSERT [dbo].[tblBillIn] ON 

INSERT [dbo].[tblBillIn] ([id], [accountId], [createdAt]) VALUES (2, 2, CAST(N'2021-03-07T00:00:00.000' AS DateTime))
INSERT [dbo].[tblBillIn] ([id], [accountId], [createdAt]) VALUES (7, 2, CAST(N'2022-03-07T00:00:00.000' AS DateTime))
INSERT [dbo].[tblBillIn] ([id], [accountId], [createdAt]) VALUES (11, 3, CAST(N'2022-03-08T00:00:00.000' AS DateTime))
INSERT [dbo].[tblBillIn] ([id], [accountId], [createdAt]) VALUES (12, 6, CAST(N'2020-05-05T00:00:00.000' AS DateTime))
INSERT [dbo].[tblBillIn] ([id], [accountId], [createdAt]) VALUES (13, 1, CAST(N'2022-03-14T13:48:56.457' AS DateTime))
SET IDENTITY_INSERT [dbo].[tblBillIn] OFF
GO
SET IDENTITY_INSERT [dbo].[tblBillOut] ON 

INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (1, 2, 1, CAST(N'2018-03-02T11:36:36.193' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (2, 3, 2, CAST(N'2022-04-01T11:36:48.633' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (3, 2, 1, CAST(N'2022-03-03T11:36:57.150' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (4, 2, 1, CAST(N'2022-03-02T11:37:03.630' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (9, 2, 2, CAST(N'2018-08-12T16:28:43.797' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (10, 3, 4, CAST(N'2022-03-12T17:15:33.487' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (11, 1, 5, CAST(N'2022-03-12T17:19:06.137' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (12, 1, 2, CAST(N'2017-09-12T17:21:44.267' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (13, 6, 2, CAST(N'2021-03-14T13:47:21.843' AS DateTime))
INSERT [dbo].[tblBillOut] ([id], [accountId], [customerId], [createdAt]) VALUES (14, 1, 5, CAST(N'2018-06-14T13:48:29.573' AS DateTime))
SET IDENTITY_INSERT [dbo].[tblBillOut] OFF
GO
SET IDENTITY_INSERT [dbo].[tblCustomer] ON 

INSERT [dbo].[tblCustomer] ([id], [name], [phone]) VALUES (1, N'Phạm Lê Việt Tú', N'0345678912')
INSERT [dbo].[tblCustomer] ([id], [name], [phone]) VALUES (2, N'Nguyễn Thị Lê', N'0456789123')
INSERT [dbo].[tblCustomer] ([id], [name], [phone]) VALUES (3, N'Nguyễn Văn Tiến', N'0567891234')
INSERT [dbo].[tblCustomer] ([id], [name], [phone]) VALUES (4, N'Hà Thị Hạnh', N'0678912345')
INSERT [dbo].[tblCustomer] ([id], [name], [phone]) VALUES (5, N'Trần Thu Phương', N'0789123456')
INSERT [dbo].[tblCustomer] ([id], [name], [phone]) VALUES (7, N'Trần Bá Nghiệp', N'0123456789')
SET IDENTITY_INSERT [dbo].[tblCustomer] OFF
GO
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (2, N'IP01', 9000000, 5)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (2, N'IP02', 10000000, 1)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (7, N'IP03', 20000000, 4)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (7, N'IP04', 30000000, 1)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (7, N'SS01', 5000000, 1)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (11, N'OPPO01', 3000000, 10)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (11, N'OPPO02', 6000000, 5)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (11, N'SS01', 4000000, 5)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (11, N'SS02', 8500000, 10)
INSERT [dbo].[tblDetailBillIn] ([billInId], [phoneId], [price], [quantity]) VALUES (13, N'IP01', 10000000, 5)
GO
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (1, N'IP01', 2)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (1, N'IP02', 3)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (2, N'IP01', 4)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (2, N'OPPO01', 2)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (2, N'SS02', 4)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (3, N'IP03', 6)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (3, N'OPPO02', 2)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (4, N'IP03', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (4, N'OPPO01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (4, N'SS01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (9, N'OPPO01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (9, N'SS02', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (10, N'IP03', 2)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (10, N'IP04', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (10, N'OPPO01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (10, N'SS01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (10, N'SS02', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (11, N'IP04', 2)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (11, N'OPPO01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (11, N'SS01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (12, N'OPPO01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (12, N'SS01', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (13, N'IP02', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (13, N'IP04', 1)
INSERT [dbo].[tblDetailBillOut] ([billOutId], [phoneId], [quantity]) VALUES (14, N'IP01', 1)
GO
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'IP01', N'Iphone X', 1, 114, 10000000, N'Trắng', N'64GB', N'3GB', N'6 tháng')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'IP02', N'Iphone XS', 1, 0, 11500000, N'Trắng', N'256GB', N'3GB', N'2 năm')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'IP03', N'Iphone 11', 1, 107, 20000000, N'Đỏ', N'128GB', N'3GB', N'1 năm')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'IP04', N'Iphone 12', 1, 96, 30000000, N'Đỏ', N'500 GB', N'4 GB', N'2 năm')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'IP05', N'Iphone XS MAX', 1, 0, 26000000, N'Trắng', N'256GB', N'4GB', N'2 năm')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'OPPO01', N'Oppo reno 5', 3, 55, 9000000, N'Đen', N'128GB', N'8GB', N'1 năm')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'OPPO02', N'Oppo find X', 3, 62, 9000000, N'Xanh ngọc', N'128GB', N'8GB', N'1 năm')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'SS01', N'Samsung s8 +', 2, 47, 5000000, N'Đen', N'64GB', N'4GB', N'1 năm')
INSERT [dbo].[tblPhone] ([id], [name], [idProducer], [quantity], [price], [color], [rom], [ram], [timeBH]) VALUES (N'SS02', N'Samsung S10 +', 2, 78, 10000000, N'Bạc', N'128GB', N'8GB', N'2 năm')
GO
SET IDENTITY_INSERT [dbo].[tblProducer] ON 

INSERT [dbo].[tblProducer] ([id], [name]) VALUES (1, N'Apple')
INSERT [dbo].[tblProducer] ([id], [name]) VALUES (2, N'Samsung')
INSERT [dbo].[tblProducer] ([id], [name]) VALUES (3, N'Oppo')
INSERT [dbo].[tblProducer] ([id], [name]) VALUES (4, N'Xiaomi')
INSERT [dbo].[tblProducer] ([id], [name]) VALUES (11, N'Nokia')
INSERT [dbo].[tblProducer] ([id], [name]) VALUES (12, N'Vivo')
INSERT [dbo].[tblProducer] ([id], [name]) VALUES (13, N'Bphone')
INSERT [dbo].[tblProducer] ([id], [name]) VALUES (14, N'Vertu')
SET IDENTITY_INSERT [dbo].[tblProducer] OFF
GO
ALTER TABLE [dbo].[tblBillOut] ADD  DEFAULT (getdate()) FOR [createdAt]
GO
ALTER TABLE [dbo].[tblDetailBillIn] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[tblDetailBillIn] ADD  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[tblDetailBillOut] ADD  DEFAULT ((1)) FOR [quantity]
GO
ALTER TABLE [dbo].[tblPhone] ADD  DEFAULT ((0)) FOR [quantity]
GO
ALTER TABLE [dbo].[tblPhone] ADD  DEFAULT ((0)) FOR [price]
GO
ALTER TABLE [dbo].[tblBillIn]  WITH CHECK ADD  CONSTRAINT [FK__tblBillIn__accou__300424B4] FOREIGN KEY([accountId])
REFERENCES [dbo].[tblAccount] ([id])
GO
ALTER TABLE [dbo].[tblBillIn] CHECK CONSTRAINT [FK__tblBillIn__accou__300424B4]
GO
ALTER TABLE [dbo].[tblBillOut]  WITH CHECK ADD  CONSTRAINT [FK__tblBillOu__accou__3B75D760] FOREIGN KEY([accountId])
REFERENCES [dbo].[tblAccount] ([id])
GO
ALTER TABLE [dbo].[tblBillOut] CHECK CONSTRAINT [FK__tblBillOu__accou__3B75D760]
GO
ALTER TABLE [dbo].[tblBillOut]  WITH CHECK ADD FOREIGN KEY([customerId])
REFERENCES [dbo].[tblCustomer] ([id])
GO
ALTER TABLE [dbo].[tblDetailBillIn]  WITH CHECK ADD FOREIGN KEY([billInId])
REFERENCES [dbo].[tblBillIn] ([id])
GO
ALTER TABLE [dbo].[tblDetailBillIn]  WITH CHECK ADD FOREIGN KEY([phoneId])
REFERENCES [dbo].[tblPhone] ([id])
GO
ALTER TABLE [dbo].[tblDetailBillOut]  WITH CHECK ADD FOREIGN KEY([billOutId])
REFERENCES [dbo].[tblBillOut] ([id])
GO
ALTER TABLE [dbo].[tblDetailBillOut]  WITH CHECK ADD FOREIGN KEY([phoneId])
REFERENCES [dbo].[tblPhone] ([id])
GO
ALTER TABLE [dbo].[tblPhone]  WITH CHECK ADD FOREIGN KEY([idProducer])
REFERENCES [dbo].[tblProducer] ([id])
GO
/****** Object:  StoredProcedure [dbo].[deleteAccountById]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteAccountById] (@id INT)
AS
BEGIN
	DELETE FROM dbo.tblBillIn WHERE accountId = @id
	DELETE FROM dbo.tblBillOut WHERE accountId = @id
    DELETE FROM dbo.tblAccount WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[deleteBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteBillIn] (@billInId INT)
AS
BEGIN
    DELETE FROM dbo.tblDetailBillIn WHERE billInId = @billInId
	DELETE FROM dbo.tblBillIn WHERE id = @billInId
END
GO
/****** Object:  StoredProcedure [dbo].[deleteCustomerById]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteCustomerById] (@id INT)
AS
BEGIN
	DELETE FROM dbo.tblBillOut WHERE customerId = @id
    DELETE FROM dbo.tblCustomer WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[deletePhoneById]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deletePhoneById] (@id VARCHAR(255))
AS
BEGIN
	DELETE FROM dbo.tblDetailBillIn WHERE phoneId = @id
	DELETE FROM dbo.tblDetailBillOut WHERE phoneId = @id
    DELETE FROM dbo.tblPhone WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[deleteProducerByName]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[deleteProducerByName] (@name NVARCHAR(50))
AS
BEGIN
	DELETE FROM dbo.tblPhone WHERE idProducer = (SELECT id FROM dbo.tblProducer WHERE name = @name)
    DELETE FROM dbo.tblProducer WHERE name = @name
END
GO
/****** Object:  StoredProcedure [dbo].[insertAccount]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertAccount] (@role NVARCHAR(20), @username NVARCHAR(50), @password NVARCHAR(8), 
							@fullName NVARCHAR(30), @phone VARCHAR(12), @birthday DATETIME)
AS
BEGIN
	INSERT INTO dbo.tblAccount (role, username, password, fullName, phone, birthday, status)
	VALUES (@role, @username, @password, @fullName, @phone, @birthday, 1)
END
GO
/****** Object:  StoredProcedure [dbo].[insertBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertBillIn] (@accountId INT)
AS
BEGIN
    INSERT dbo.tblBillIn (accountId, createdAt)
    VALUES (@accountId, GETDATE())
END
GO
/****** Object:  StoredProcedure [dbo].[insertBillOut]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertBillOut] (@accountId INT, @customerId INT)
AS
BEGIN
    INSERT dbo.tblBillOut (accountId, customerId, createdAt)
    VALUES (@accountId, @customerId, GETDATE())
END
GO
/****** Object:  StoredProcedure [dbo].[insertCustomer]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertCustomer] (@name NVARCHAR(30), @phone VARCHAR(12))
AS
BEGIN
	INSERT INTO dbo.tblCustomer (name, phone)
	VALUES (@name, @phone)
END
GO
/****** Object:  StoredProcedure [dbo].[insertDetailBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertDetailBillIn] (@billInId INT, @phoneId VARCHAR(255), @price FLOAT, @quantity INT)
AS
BEGIN
    INSERT dbo.tblDetailBillIn (billInId, phoneId, price, quantity)
    VALUES (@billInId, @phoneId, @price, @quantity)
END
GO
/****** Object:  StoredProcedure [dbo].[insertDetailBillOut]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertDetailBillOut] (@billOutId INT, @phoneId VARCHAR(255), @quantity INT)
AS
BEGIN
    INSERT dbo.tblDetailBillOut (billOutId, phoneId, quantity)
    VALUES (@billOutId, @phoneId, @quantity)
END
GO
/****** Object:  StoredProcedure [dbo].[insertPhone]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertPhone] (@id VARCHAR(255), @name NVARCHAR(255), @idProducer INT, 
						@price FLOAT, @color NVARCHAR(20), @rom NVARCHAR(20), @ram NVARCHAR(20), @timeBH NVARCHAR(20))
AS
BEGIN
	INSERT INTO dbo.tblPhone (id, name, idProducer, quantity, price, color, rom, ram, timeBH)
	VALUES (@id, @name, @idProducer, 0, @price, @color, @rom, @ram, @timeBH)
END
GO
/****** Object:  StoredProcedure [dbo].[insertProducer]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[insertProducer] (@name NVARCHAR(50))
AS
BEGIN
    INSERT INTO dbo.tblProducer(name) VALUES(@name)
END
GO
/****** Object:  StoredProcedure [dbo].[updateAccount]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateAccount] (@id INT, @role NVARCHAR(20), @username NVARCHAR(50), @password VARCHAR(50), 
							@fullName NVARCHAR(30), @phone VARCHAR(12), @birthday DATETIME)
AS
BEGIN
    UPDATE dbo.tblAccount
	SET role = @role, username = @username, password = @password, 
		fullName = @fullName, phone = @phone, birthday = @birthday
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[updateBillIn]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateBillIn] (@billInId INT, @phoneId VARCHAR(255), @quantity INT, @price FLOAT)
AS
BEGIN
    UPDATE dbo.tblDetailBillIn
	SET quantity = @quantity, price = @price
	WHERE billInId = @billInId AND phoneId = @phoneId
END
GO
/****** Object:  StoredProcedure [dbo].[updateCustomer]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateCustomer] (@id INT, @name NVARCHAR(30), @phone VARCHAR(12))
AS
BEGIN
    UPDATE dbo.tblCustomer
	SET name = @name, phone = @phone
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[updatePhone]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updatePhone] (@id VARCHAR(255), @name NVARCHAR(50), @idProducer INT, 
						@price FLOAT, @color NVARCHAR(20), @rom NVARCHAR(20), @ram NVARCHAR(20), @timeBH NVARCHAR(20))
AS
BEGIN
    UPDATE dbo.tblPhone
	SET name = @name, idProducer = @idProducer, price = @price, 
		color = @color, rom = @rom, ram = @ram, timeBH = @timeBH
	WHERE id = @id
END
GO
/****** Object:  StoredProcedure [dbo].[updateProducerName]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[updateProducerName] (@id INT, @name NVARCHAR(50))
AS
BEGIN
    UPDATE dbo.tblProducer
	SET name = @name
	WHERE id = @id
END
GO
/****** Object:  Trigger [dbo].[TrgNhapHang]    Script Date: 2022-03-27 11:14:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TrgNhapHang]
ON [dbo].[tblDetailBillIn]
AFTER INSERT
AS
BEGIN
	UPDATE dbo.tblPhone
	SET quantity = dbo.tblPhone.quantity + (SELECT Inserted.quantity FROM Inserted WHERE Inserted.phoneId = dbo.tblPhone.id)
	FROM dbo.tblPhone JOIN Inserted ON Inserted.phoneId = dbo.tblPhone.id
END
GO
ALTER TABLE [dbo].[tblDetailBillIn] ENABLE TRIGGER [TrgNhapHang]
GO
/****** Object:  Trigger [dbo].[TrgXuatHang]    Script Date: 2022-03-27 11:14:01 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[TrgXuatHang]
ON [dbo].[tblDetailBillOut]
AFTER INSERT
AS
BEGIN
	UPDATE dbo.tblPhone
	SET quantity = dbo.tblPhone.quantity - (SELECT Inserted.quantity FROM Inserted WHERE Inserted.phoneId = dbo.tblPhone.id)
	FROM dbo.tblPhone JOIN Inserted ON Inserted.phoneId = tblPhone.id
END
GO
ALTER TABLE [dbo].[tblDetailBillOut] ENABLE TRIGGER [TrgXuatHang]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[10] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "tblDetailBillIn"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tblPhone"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 170
               Right = 551
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 3504
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'showAllDetailBillIn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'showAllDetailBillIn'
GO
USE [master]
GO
ALTER DATABASE [HSK_QuanLyCuaHangBanDienThoai] SET  READ_WRITE 
GO
