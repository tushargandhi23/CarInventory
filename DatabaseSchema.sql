USE [master]
GO
/****** Object:  Database [CarInventory]    Script Date: 26-09-2018 21:57:22 ******/
CREATE DATABASE [CarInventory]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CarInventory', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CarInventory.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CarInventory_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\CarInventory_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CarInventory] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CarInventory].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CarInventory] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CarInventory] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CarInventory] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CarInventory] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CarInventory] SET ARITHABORT OFF 
GO
ALTER DATABASE [CarInventory] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CarInventory] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CarInventory] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CarInventory] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CarInventory] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CarInventory] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CarInventory] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CarInventory] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CarInventory] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CarInventory] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CarInventory] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CarInventory] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CarInventory] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CarInventory] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CarInventory] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CarInventory] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CarInventory] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CarInventory] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CarInventory] SET  MULTI_USER 
GO
ALTER DATABASE [CarInventory] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CarInventory] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CarInventory] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CarInventory] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [CarInventory]
GO
/****** Object:  Table [dbo].[tbl_cars]    Script Date: 26-09-2018 21:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_cars](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[brand] [varchar](20) NULL,
	[model] [varchar](20) NULL,
	[year] [int] NULL,
	[price] [decimal](18, 2) NULL,
	[is_new] [bit] NULL,
	[created_by] [int] NULL,
	[created_date] [datetime] NULL,
 CONSTRAINT [PK_tbl_cars] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_users]    Script Date: 26-09-2018 21:57:22 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](10) NULL,
	[password] [varchar](6) NULL,
	[created_date] [datetime] NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_cars] ON 
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (1, N'Honda', N'CRV', 2015, CAST(10000.00 AS Decimal(18, 2)), 0, 1, CAST(N'2018-09-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (3, N'asd', N'ad', 0, CAST(0.00 AS Decimal(18, 2)), 0, 1, CAST(N'2018-09-26T05:43:33.493' AS DateTime))
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (4, N'asdasdaad', N'adadaasd', 0, CAST(0.00 AS Decimal(18, 2)), 0, 1, CAST(N'2018-09-26T05:47:26.797' AS DateTime))
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (5, N'tushar', N'gandhi', 0, CAST(0.00 AS Decimal(18, 2)), 0, 1, CAST(N'2018-09-26T05:49:38.617' AS DateTime))
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (6, N'zxc', N'zxc', 0, CAST(0.00 AS Decimal(18, 2)), 0, 1, CAST(N'2018-09-26T05:51:16.547' AS DateTime))
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (7, N'adasd', N'asd', 0, CAST(0.00 AS Decimal(18, 2)), 0, 1, CAST(N'2018-09-26T05:53:24.653' AS DateTime))
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (8, N'Gandhi', N'Tushar', 1987, CAST(101000.00 AS Decimal(18, 2)), 1, 1, CAST(N'2018-09-26T05:59:12.887' AS DateTime))
GO
INSERT [dbo].[tbl_cars] ([id], [brand], [model], [year], [price], [is_new], [created_by], [created_date]) VALUES (9, N'Bently', N'XZ', 2018, CAST(2000000.00 AS Decimal(18, 2)), 1, 6, CAST(N'2018-09-26T20:48:56.150' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tbl_cars] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_users] ON 
GO
INSERT [dbo].[tbl_users] ([id], [user_name], [password], [created_date]) VALUES (1, N'ts', N'test12', CAST(N'2018-09-25T17:45:19.040' AS DateTime))
GO
INSERT [dbo].[tbl_users] ([id], [user_name], [password], [created_date]) VALUES (6, N'kartik', N'kartik', CAST(N'2018-09-26T20:47:55.227' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[tbl_users] OFF
GO
ALTER TABLE [dbo].[tbl_cars]  WITH CHECK ADD  CONSTRAINT [FK_tbl_cars_tbl_users] FOREIGN KEY([created_by])
REFERENCES [dbo].[tbl_users] ([id])
GO
ALTER TABLE [dbo].[tbl_cars] CHECK CONSTRAINT [FK_tbl_cars_tbl_users]
GO
USE [master]
GO
ALTER DATABASE [CarInventory] SET  READ_WRITE 
GO
