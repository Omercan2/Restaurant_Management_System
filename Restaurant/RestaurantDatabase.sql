USE [master]
GO
/****** Object:  Database [Restaurant]    Script Date: 15.10.2023 17:31:40 ******/
CREATE DATABASE [Restaurant]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Restaurant', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Restaurant.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Restaurant_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Restaurant_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Restaurant] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Restaurant].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Restaurant] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Restaurant] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Restaurant] SET ARITHABORT OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Restaurant] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Restaurant] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Restaurant] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Restaurant] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Restaurant] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Restaurant] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Restaurant] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Restaurant] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Restaurant] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Restaurant] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Restaurant] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Restaurant] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Restaurant] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Restaurant] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Restaurant] SET RECOVERY FULL 
GO
ALTER DATABASE [Restaurant] SET  MULTI_USER 
GO
ALTER DATABASE [Restaurant] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Restaurant] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Restaurant] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Restaurant] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Restaurant] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Restaurant] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Restaurant', N'ON'
GO
ALTER DATABASE [Restaurant] SET QUERY_STORE = OFF
GO
USE [Restaurant]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 15.10.2023 17:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[WaiterID] [int] NOT NULL,
	[OrderAmount] [int] NULL,
	[OrderContents] [nvarchar](200) NULL,
	[OrderTable] [nvarchar](20) NULL,
	[OrderDate] [date] NULL,
	[OrderStatus] [bit] NULL,
	[TableStatus] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 15.10.2023 17:31:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[Surname] [nvarchar](20) NULL,
	[Password] [nvarchar](15) NULL,
	[Job] [nvarchar](15) NULL,
	[Status] [bit] NULL,
	[Email] [nvarchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (9, 11, 220, N'Cola 10TLx1
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx1
Doner 40TLx1
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx1
Baklava 30TLx1
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx1', N'Table 10', CAST(N'2022-08-15' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (12, 11, 200, N'Cola 10TLx0
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx1
Lahmacun 20TLx1
Hamburger 60TLx1
Pizza 80TLx1
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 4', CAST(N'2022-09-16' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (10, 11, 165, N'Cola 10TLx0
Ayran 5TLx1
Gazoz 10TLx1
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx1
Hamburger 60TLx1
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx1
Künefe 45TLx1
Cheesecake 50TLx0', N'Table 6', CAST(N'2022-12-15' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (11, 11, 120, N'Cola 10TLx1
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx1
Baklava 30TLx1
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 3', CAST(N'2022-12-16' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (13, 12, 220, N'Cola 10TLx1
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx1
Doner 40TLx1
Lahmacun 20TLx1
Hamburger 60TLx1
Pizza 80TLx1
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 8', CAST(N'2022-12-16' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (14, 12, 440, N'Cola 10TLx0
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx2
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx4
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx2', N'Table 1', CAST(N'2022-12-16' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (15, 12, 350, N'Cola 10TLx3
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx4
Hamburger 60TLx4
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 7', CAST(N'2022-12-17' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (16, 12, 100, N'Cola 10TLx0
Ayran 5TLx4
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx4
Hamburger 60TL x0
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 1', CAST(N'2022-12-17' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (17, 12, 40, N'Cola 10TLx4
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 2', CAST(N'2022-12-17' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (18, 11, 160, N'Cola 10TLx0
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx4
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx0
Baklava 30TLx4
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 2', CAST(N'2021-12-17' AS Date), 0, 1)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (23, 12, 380, N'Cola 10TLx4
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx3
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx2', N'Table 10', CAST(N'2022-12-19' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (24, 12, 390, N'Cola 10TLx0
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx3
Hamburger 60TLx3
Pizza 80TLx0
Baklava 30TLx2
Tulumba 25TLx0
Künefe 45TLx2
Cheesecake 50TLx0', N'Table 10', CAST(N'2022-12-19' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (26, 12, 60, N'Cola 10TLx2
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx2
Hamburger 60TL x0
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 1', CAST(N'2022-12-19' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (27, 12, 140, N'Cola 10TLx2
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TLx2
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 11', CAST(N'2022-12-19' AS Date), 0, 1)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (19, 12, 150, N'Cola 10TLx0
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx0
Baklava 30TLx1
Tulumba 25TLx1
Künefe 45TLx1
Cheesecake 50TLx1', N'Table 10', CAST(N'2022-12-18' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (20, 12, 270, N'Cola 10TLx0
Ayran 5TLx0
Gazoz 10TLx3
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx3
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 6', CAST(N'2022-12-18' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (29, 11, 30, N'Cola 10TLx3
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 1', CAST(N'2023-10-13' AS Date), 1, 1)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (22, 12, 75, N'Cola 10TLx1
Ayran 5TLx1
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx1
Lahmacun 20TLx1
Hamburger 60TL x0
Pizza 80TLx0
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx0', N'Table 6', CAST(N'2022-12-19' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (21, 12, 290, N'Cola 10TLx3
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx0
Doner 40TLx0
Lahmacun 20TLx0
Hamburger 60TL x0
Pizza 80TLx2
Baklava 30TLx0
Tulumba 25TLx0
Künefe 45TLx0
Cheesecake 50TLx2', N'Table 1', CAST(N'2022-12-19' AS Date), 1, 0)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (25, 12, 520, N'Cola 10TLx3
Ayran 5TLx0
Gazoz 10TLx2
Fanta 10TLx0
Doner 40TLx2
Lahmacun 20TLx3
Hamburger 60TLx3
Pizza 80TLx0
Baklava 30TLx2
Tulumba 25TLx0
Künefe 45TLx2
Cheesecake 50TLx0', N'Table 7', CAST(N'2022-12-19' AS Date), 0, 1)
INSERT [dbo].[Orders] ([ID], [WaiterID], [OrderAmount], [OrderContents], [OrderTable], [OrderDate], [OrderStatus], [TableStatus]) VALUES (28, 12, 295, N'Cola 10TLx1
Ayran 5TLx0
Gazoz 10TLx0
Fanta 10TLx1
Doner 40TLx1
Lahmacun 20TLx1
Hamburger 60TLx1
Pizza 80TLx1
Baklava 30TLx0
Tulumba 25TLx1
Künefe 45TLx0
Cheesecake 50TLx1', N'Table 9', CAST(N'2022-12-20' AS Date), 0, 1)
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (1, N'Ömer Can', N'Çetinkaya', N'010203', N'Admin', 1, N'omer@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (2, N'Harun enes', N'Çetinkaya', N'112233', N'Cashier', 1, N'harun@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (11, N'Hüseyin Oğuz', N'Çetinkaya', N'445566', N'Waiter', 1, N'huseyin@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (12, N'Necati', N'Gün', N'778899', N'Waiter', 1, N'necati@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (13, N'Mehmet', N'Çavuş', N'114477', N'KitchenWorker', 1, N'cavus@gmail.com')
INSERT [dbo].[Staff] ([ID], [Name], [Surname], [Password], [Job], [Status], [Email]) VALUES (16, N'Muhammet', N'Çağlar', N'225588', N'Cashier', 1, N'caglar@gmail.com')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
USE [master]
GO
ALTER DATABASE [Restaurant] SET  READ_WRITE 
GO
