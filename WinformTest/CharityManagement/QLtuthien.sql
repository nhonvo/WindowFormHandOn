USE [TestQLTK]
GO
Create DATABASE QLSVTuthien
USE QLSVTuthien
GO
/****** Object: Table [dbo].[TaiKhoan] Script Date: 10/26/2021 23:34:12
******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
[STK] [nvarchar](10) NOT NULL,
[TenNH] [nvarchar](150) NOT NULL,
[SoDuDauKy] [decimal](18, 0) NOT NULL,
CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED
(
[STK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY =
OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[TaiKhoan] ([STK], [TenNH], [SoDuDauKy]) VALUES (N'1111111746',
N'VCB - Ngân hàng TMCP Ngoại thương Việt Nam', CAST(200 AS Decimal(18, 0)))
INSERT [dbo].[TaiKhoan] ([STK], [TenNH], [SoDuDauKy]) VALUES (N'1111111812',
N'VietinBank-Ngân hàng TMCP Công Thương Việt Nam', CAST(100 AS Decimal(18,
0)))
/****** Object: Table [dbo].[GiaoDich] Script Date: 10/26/2021 23:34:12
******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaoDich](
[Id] [int] IDENTITY(1,1) NOT NULL,
[SoTien] [int] NOT NULL,
[NoiDung] [nvarchar](255) NULL,
[STK] [nvarchar](10) NOT NULL,
CONSTRAINT [PK_GiaoDich] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY =
OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[GiaoDich] ON
INSERT [dbo].[GiaoDich] ([Id], [SoTien], [NoiDung], [STK]) VALUES (1, 100,
N'Ủng hộ miền trung', N'1111111746')
INSERT [dbo].[GiaoDich] ([Id], [SoTien], [NoiDung], [STK]) VALUES (2, -50,
N'Rút chi tiền đợt 1', N'1111111746')
INSERT [dbo].[GiaoDich] ([Id], [SoTien], [NoiDung], [STK]) VALUES (3, 120,
N'ủng hộ miền trung', N'1111111746')
INSERT [dbo].[GiaoDich] ([Id], [SoTien], [NoiDung], [STK]) VALUES (4, 80,
N'ủng hộ miền trung', N'1111111812')
INSERT [dbo].[GiaoDich] ([Id], [SoTien], [NoiDung], [STK]) VALUES (5, 180,
N'ủng hộ miền trung', N'1111111812')
SET IDENTITY_INSERT [dbo].[GiaoDich] OFF