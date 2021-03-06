USE [master]
GO
/****** Object:  Database [cs6232-g3]    Script Date: 3/30/2022 8:52:00 AM ******/
DROP DATABASE IF EXISTS [cs6232-g3]
GO

CREATE DATABASE [cs6232-g3]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs6232-g3', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g3.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs6232-g3_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\cs6232-g3_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [cs6232-g3] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs6232-g3].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs6232-g3] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs6232-g3] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs6232-g3] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs6232-g3] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs6232-g3] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs6232-g3] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs6232-g3] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs6232-g3] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs6232-g3] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs6232-g3] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs6232-g3] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs6232-g3] SET  ENABLE_BROKER 
GO
ALTER DATABASE [cs6232-g3] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs6232-g3] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs6232-g3] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs6232-g3] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs6232-g3] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs6232-g3] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs6232-g3] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs6232-g3] SET RECOVERY FULL 
GO
ALTER DATABASE [cs6232-g3] SET  MULTI_USER 
GO
ALTER DATABASE [cs6232-g3] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs6232-g3] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs6232-g3] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs6232-g3] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs6232-g3] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs6232-g3] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs6232-g3', N'ON'
GO
ALTER DATABASE [cs6232-g3] SET QUERY_STORE = OFF
GO
USE [cs6232-g3]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccountID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	
 CONSTRAINT [PK_AccountID] PRIMARY KEY CLUSTERED 
(
	[AccountID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CategoryID] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Phone] [varchar](12) NOT NULL,
	[Sex] [varchar](10) NOT NULL,
	[Address1] [varchar](50) NOT NULL,
	[Address2] [varchar](50) NULL,
	[City] [varchar](50) NOT NULL,
	[State] [char](2) NOT NULL,
	[ZipCode] [varchar](20) NOT NULL,
	[AccountID] [int] NOT NULL,
	[Employee_type] [varchar](10) NOT NULL,
	[Active] [tinyint] NOT NULL,
 CONSTRAINT [PK_EmployeesID] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Furnitures]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Furnitures](
	[FurnitureID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[StyleID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Description] [varchar](70) NOT NULL,
	[Daily_rental_rate] [money] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_FurnitureID] PRIMARY KEY CLUSTERED 
(
	[FurnitureID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[MemberID] [int] IDENTITY(1,1) NOT NULL,
	[Fname] [varchar](50) NOT NULL,
	[Lname] [varchar](50) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[Phone] [varchar](12) NOT NULL,
	[Sex] [varchar](10) NOT NULL,
	[Address1] [varchar](50) NOT NULL,
	[Address2] [varchar](50) NULL,
	[City] [varchar](50) NOT NULL,
	[State] [char](2) NOT NULL,
	[ZipCode] [varchar](20) NOT NULL,
 CONSTRAINT [PK_MemberID] PRIMARY KEY CLUSTERED 
(
	[MemberID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentalTransactions]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentalTransactions](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[RentDate] [datetime] NOT NULL,
	[DueDate] [datetime] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[MemberID] [int] NOT NULL,
 CONSTRAINT [PK_RentalTransactionID] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedItems]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedItems](
	[RentedItemsID] [int] IDENTITY(1,1) NOT NULL,
	[RentalTransactionID] [int] NOT NULL,
	[SequenceNo] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[FurnitureID] [int] NOT NULL,
 CONSTRAINT [PK_RentedItemsID] PRIMARY KEY CLUSTERED 
(
	[RentedItemsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnTransaction]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnTransaction](
	[TransactionID] [int] IDENTITY(1,1) NOT NULL,
	[RentedItemsID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ReturnTransactionID] PRIMARY KEY CLUSTERED 
(
	[TransactionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[States]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[States](
	[StateCode] [char](2) NOT NULL,
	[StateName] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[StateCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Styles]    Script Date: 3/30/2022 8:52:00 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Styles](
	[StyleID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StyleID] PRIMARY KEY CLUSTERED 
(
	[StyleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([AccountID], [Username], [Password]) VALUES (1, N'dnacy', N'g0pwm6JTTr4+4Tl/1Pe9KIsqzB0goI1shi3NmbbwRAA=')
INSERT [dbo].[Accounts] ([AccountID], [Username], [Password]) VALUES (2, N'fandrew', N'g0pwm6JTTr4+4Tl/1Pe9KIsqzB0goI1shi3NmbbwRAA=')
INSERT [dbo].[Accounts] ([AccountID], [Username], [Password]) VALUES (3, N'ljanet', N'g0pwm6JTTr4+4Tl/1Pe9KIsqzB0goI1shi3NmbbwRAA=')
INSERT [dbo].[Accounts] ([AccountID], [Username], [Password]) VALUES (4, N'pmargaret', N'g0pwm6JTTr4+4Tl/1Pe9KIsqzB0goI1shi3NmbbwRAA=')
INSERT [dbo].[Accounts] ([AccountID], [Username], [Password]) VALUES (5, N'bsteven', N'g0pwm6JTTr4+4Tl/1Pe9KIsqzB0goI1shi3NmbbwRAA=')
INSERT [dbo].[Accounts] ([AccountID], [Username], [Password]) VALUES (6, N'smichael', N'g0pwm6JTTr4+4Tl/1Pe9KIsqzB0goI1shi3NmbbwRAA=')
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (1, N'Bed')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (2, N'Cabinet')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (3, N'Chair')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (4, N'Chest')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (5, N'Desk')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (6, N'Table')
INSERT [dbo].[Categories] ([CategoryID], [Name]) VALUES (7, N'Clock')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode], [AccountID], [Employee_type], [Active]) VALUES (1, N'Davolio', N'Nancy', CAST(N'1968-12-08' AS Date), N'206-555-9857', N'Female', N'507 - 20th Ave.', NULL, N'Seattle', N'WA', N'98122', 1, N'Regular', 1)
INSERT [dbo].[Employees] ([EmployeeID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode], [AccountID], [Employee_type], [Active]) VALUES (2, N'Fuller', N'Andrew', CAST(N'1952-02-19' AS Date), N'206-555-9482', N'Male', N'908 W. Capital Way', N'by Zip way', N'Tacoma', N'WA', N'98401', 2, N'Admin', 1)
INSERT [dbo].[Employees] ([EmployeeID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode], [AccountID], [Employee_type], [Active]) VALUES (3, N'Leverling', N'Janet', CAST(N'1963-08-30' AS Date), N'206-555-3412', N'Female', N'722 Moss Bay Blvd.', NULL, N'Kirkland', N'WA', N'98033', 3, N'Regular', 1)
INSERT [dbo].[Employees] ([EmployeeID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode], [AccountID], [Employee_type], [Active]) VALUES (4, N'Peacock', N'Margaret', CAST(N'1958-09-19' AS Date), N'206-555-8122', N'Female', N'4110 Old Redmond Rd.', NULL, N'Redmond', N'WA', N'98052', 4, N'Regular', 0)
INSERT [dbo].[Employees] ([EmployeeID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode], [AccountID], [Employee_type], [Active]) VALUES (5, N'Buchanan', N'Steven', CAST(N'1955-03-04' AS Date), N'715-554-8480', N'Male', N'14 Garrett Hill', N'SW1 8JR', N'Clint', N'NJ', N'87892', 5, N'Admin', 1)
INSERT [dbo].[Employees] ([EmployeeID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode], [AccountID], [Employee_type], [Active]) VALUES (6, N'Suyama', N'Michael', CAST(N'1963-07-02' AS Date), N'715-557-7730', N'Male', N'331 Park Ave S', NULL, N'New York', N'NY', N'86692', 6, N'Regular',0)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Furnitures] ON 

INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (1, N'Cradle', 1, 1, N'Antique Bed', 15.0000, 50)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (2, N'Trundle bed', 2, 1, N'Vintage Bed', 30.0000, 15)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (3, N'Basket chair', 3, 3, N'Tradition Basket chair', 7.0000, 30)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (4, N'Bath chair', 2, 3, N'Vintage Bath Chair', 14.5000, 23)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (5, N'Curule chair', 2, 3, N'Vintage Curule Chair', 22.0000, 21)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (6, N'Couch', 1, 3, N'Antique couch', 17.0000, 34)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (7, N'Dresser', 3, 4, N'Tradition Dresser', 15.0000, 8)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (8, N'Commode', 1, 4, N'Antique Dresser', 17.0000, 12)
INSERT [dbo].[Furnitures] ([FurnitureID], [Name], [StyleID], [CategoryID], [Description], [Daily_rental_rate], [Quantity]) VALUES (9, N'Console', 1, 1, N'Traditional Table', 20.0000, 12)
SET IDENTITY_INSERT [dbo].[Furnitures] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (1, N'Nash', N'Albert', CAST(N'2003-05-11' AS Date), N'132-448-1892', N'Male', N'Ap #376-7341 Cursus. Avenue', NULL, N'Norman', N'NY', N'24134')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (2, N'Grady', N'Moses', CAST(N'1974-11-12' AS Date), N'677-186-6387', N'Female', N'4857 Eu Rd.', NULL, N'Hartford', N'WA', N'42006')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (3, N'Fay', N'Maxwell', CAST(N'1984-09-02' AS Date), N'146-877-3277', N'Male', N'414-9313 Ut St.', NULL, N'Carson', N'NY', N'47558')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (4, N'Kenneth', N'Wooten', CAST(N'1981-02-11' AS Date), N'927-990-1681', N'Male', N'Ap #284-1451 Feugiat Road', NULL, N'Billings', N'WA', N'84138')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (5, N'Bell', N'Noble', CAST(N'1996-06-02' AS Date), N'252-352-3417', N'Female', N'212-4306 Fringilla. Rd.', NULL, N'Columbus', N'CO', N'34231')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (6, N'Brittany', N'Kennedy', CAST(N'2001-03-12' AS Date), N'618-251-7824', N'Female', N'Ap #588-6166 Enim. St.', NULL, N'Frankfort', N'CO', N'16271')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (7, N'Leroy', N'Ward', CAST(N'2002-01-07' AS Date), N'297-393-4615', N'Female', N'P.O. Box 754, 1403 Nascetur St.', NULL, N'Wichita', N'TX', N'39326')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (8, N'Hayes', N'Shepherd', CAST(N'2002-10-16' AS Date), N'153-483-9575', N'Female', N'8453 In Av.', NULL, N'Jonesboro', N'TX', N'21866')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (9, N'Benjamin', N'Crosby', CAST(N'1999-11-27' AS Date), N'686-857-4470', N'Female', N'Ap #526-948 Ridiculus Road', NULL, N'Columbus', N'NJ', N'36178')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (10, N'Kylynn', N'Kim', CAST(N'1987-08-06' AS Date), N'964-478-3755', N'Female', N'Ap #712-5222 Erat Rd.', NULL, N'Annapolis', N'Fl', N'65342')
INSERT [dbo].[Members] ([MemberID], [Fname], [Lname], [DateOfBirth], [Phone], [Sex], [Address1], [Address2], [City], [State], [ZipCode]) VALUES (11, N'Illiana', N'Moran', CAST(N'2000-12-01' AS Date), N'231-398-3657', N'Female', N'846-7047 Mus. Ave', NULL, N'Grand Island', N'FL', N'43483')
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
SET IDENTITY_INSERT [dbo].[RentalTransactions] ON 

INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (1, CAST(N'2022-01-08T00:00:00.000' AS DateTime), CAST(N'2022-02-08T00:00:00.000' AS DateTime), 1, 2)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (2, CAST(N'2022-01-08T00:00:00.000' AS DateTime), CAST(N'2022-03-18T00:00:00.000' AS DateTime), 3, 2)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (3, CAST(N'2022-01-08T00:00:00.000' AS DateTime), CAST(N'2022-05-08T00:00:00.000' AS DateTime), 6, 3)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (4, CAST(N'2022-02-08T00:00:00.000' AS DateTime), CAST(N'2022-03-08T00:00:00.000' AS DateTime), 6, 2)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (5, CAST(N'2022-02-08T00:00:00.000' AS DateTime), CAST(N'2022-07-08T00:00:00.000' AS DateTime), 6, 1)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (6, CAST(N'2022-02-08T00:00:00.000' AS DateTime), CAST(N'2022-04-08T00:00:00.000' AS DateTime), 1, 3)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (7, CAST(N'2022-03-08T00:00:00.000' AS DateTime), CAST(N'2022-04-08T00:00:00.000' AS DateTime), 4, 2)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (8, CAST(N'2022-03-08T00:00:00.000' AS DateTime), CAST(N'2022-04-13T00:00:00.000' AS DateTime), 3, 6)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (9, CAST(N'2022-03-08T00:00:00.000' AS DateTime), CAST(N'2022-04-05T00:00:00.000' AS DateTime), 3, 4)
INSERT [dbo].[RentalTransactions] ([TransactionID], [RentDate], [DueDate], [EmployeeID], [MemberID]) VALUES (10, CAST(N'2022-03-11T00:00:00.000' AS DateTime), CAST(N'2022-07-18T00:00:00.000' AS DateTime), 1, 4)
SET IDENTITY_INSERT [dbo].[RentalTransactions] OFF
GO
SET IDENTITY_INSERT [dbo].[RentedItems] ON 

INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (1, 1, 1, 6, 2)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (2, 1, 2, 10, 1)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (3, 1, 3, 4, 3)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (4, 2, 1, 14, 5)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (5, 2, 2, 3, 3)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (6, 3, 1, 6, 1)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (7, 4, 1, 23, 4)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (8, 4, 2, 1, 5)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (9, 5, 1, 4, 2)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (10, 6, 1, 5, 1)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (11, 7, 1, 12, 1)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (12, 8, 1, 15, 3)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (13, 8, 2, 3, 2)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (14, 8, 3, 1, 1)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (15, 9, 1, 2, 5)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (16, 9, 2, 9, 4)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (17, 10, 1, 10, 3)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (18, 10, 2, 4, 1)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (19, 10, 3, 34, 9)
INSERT [dbo].[RentedItems] ([RentedItemsID], [RentalTransactionID], [SequenceNo], [Quantity], [FurnitureID]) VALUES (20, 10, 4, 32, 8)
SET IDENTITY_INSERT [dbo].[RentedItems] OFF
GO
SET IDENTITY_INSERT [dbo].[ReturnTransaction] ON 

INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (1, 1, 6, 1, CAST(N'2022-02-08T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (2, 2, 10, 1, CAST(N'2022-03-06T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (3, 3, 4, 3, CAST(N'2022-02-08T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (4, 4, 10, 6, CAST(N'2022-03-03T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (5, 9, 4, 6, CAST(N'2022-04-14T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (6, 16, 6, 1, CAST(N'2022-04-15T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (7, 19, 23, 4, CAST(N'2022-04-17T00:00:00.000' AS DateTime))
INSERT [dbo].[ReturnTransaction] ([TransactionID], [RentedItemsID], [Quantity], [EmployeeID], [ReturnDate]) VALUES (8, 19, 4, 4, CAST(N'2022-04-19T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[ReturnTransaction] OFF
GO
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'AK', N'Alaska')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'AL', N'Alabama')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'AR', N'Arkansas')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'AZ', N'Arizona')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'CA', N'California')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'CO', N'Colorado')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'CT', N'Connecticut')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'DC', N'District of Columbia')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'DE', N'Delaware')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'FL', N'Florida')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'GA', N'Georgia')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'HI', N'Hawaii')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'IA', N'Iowa')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'ID', N'Idaho')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'IL', N'Illinois')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'IN', N'Indiana')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'KS', N'Kansas')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'KY', N'Kentucky')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'LA', N'Lousiana')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'MA', N'Massachusetts')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'MD', N'Maryland')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'ME', N'Maine')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'MI', N'Michigan')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'MN', N'Minnesota')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'MO', N'Missouri')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'MS', N'Mississippi')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'MT', N'Montana')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'NC', N'North Carolina')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'ND', N'North Dakota')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'NE', N'Nebraska')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'NH', N'New Hampshire')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'NJ', N'New Jersey')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'NM', N'New Mexico')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'NV', N'Nevada')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'NY', N'New York')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'OH', N'Ohio')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'OK', N'Oklahoma')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'OR', N'Oregon')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'PA', N'Pennsylvania')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'RI', N'Rhode Island')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'SC', N'South Carolina')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'SD', N'South Dakota')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'TN', N'Tennessee')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'TX', N'Texas')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'UT', N'Utah')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'VA', N'Virginia')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'VI', N'Virgin Islands')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'VT', N'Vermont')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'WA', N'Washington')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'WI', N'Wisconsin')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'WV', N'West Virginia')
INSERT [dbo].[States] ([StateCode], [StateName]) VALUES (N'WY', N'Wyoming')
GO
SET IDENTITY_INSERT [dbo].[Styles] ON 

INSERT [dbo].[Styles] ([StyleID], [Name]) VALUES (1, N'Antique')
INSERT [dbo].[Styles] ([StyleID], [Name]) VALUES (2, N'Vintage')
INSERT [dbo].[Styles] ([StyleID], [Name]) VALUES (3, N'Traditional')
INSERT [dbo].[Styles] ([StyleID], [Name]) VALUES (4, N'Rustic')
INSERT [dbo].[Styles] ([StyleID], [Name]) VALUES (5, N'Art Deco')
INSERT [dbo].[Styles] ([StyleID], [Name]) VALUES (6, N'Retro')
SET IDENTITY_INSERT [dbo].[Styles] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_Accounts_Username]    Script Date: 3/30/2022 8:52:00 AM ******/
ALTER TABLE [dbo].[Accounts] ADD  CONSTRAINT [UK_Accounts_Username] UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UK_RentedItems_RentalTransactionID_SequenceNo]    Script Date: 3/30/2022 8:52:00 AM ******/
ALTER TABLE [dbo].[RentedItems] ADD  CONSTRAINT [UK_RentedItems_RentalTransactionID_SequenceNo] UNIQUE NONCLUSTERED 
(
	[RentalTransactionID] ASC,
	[SequenceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Accounts] FOREIGN KEY([AccountID])
REFERENCES [dbo].[Accounts] ([AccountID])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Accounts]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_States] FOREIGN KEY([State])
REFERENCES [dbo].[States] ([StateCode])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_States]
GO
ALTER TABLE [dbo].[Furnitures]  WITH CHECK ADD  CONSTRAINT [FK_Furnitures_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Furnitures] CHECK CONSTRAINT [FK_Furnitures_Categories]
GO
ALTER TABLE [dbo].[Furnitures]  WITH CHECK ADD  CONSTRAINT [FK_Furnitures_Styles] FOREIGN KEY([StyleID])
REFERENCES [dbo].[Styles] ([StyleID])
GO
ALTER TABLE [dbo].[Furnitures] CHECK CONSTRAINT [FK_Furnitures_Styles]
GO
ALTER TABLE [dbo].[Members]  WITH CHECK ADD  CONSTRAINT [FK_Members_States] FOREIGN KEY([State])
REFERENCES [dbo].[States] ([StateCode])
GO
ALTER TABLE [dbo].[Members] CHECK CONSTRAINT [FK_Members_States]
GO
ALTER TABLE [dbo].[RentalTransactions]  WITH CHECK ADD  CONSTRAINT [FK_RentalTransactions_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[RentalTransactions] CHECK CONSTRAINT [FK_RentalTransactions_Employees]
GO
ALTER TABLE [dbo].[RentalTransactions]  WITH CHECK ADD  CONSTRAINT [FK_RentalTransactions_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([MemberID])
GO
ALTER TABLE [dbo].[RentalTransactions] CHECK CONSTRAINT [FK_RentalTransactions_Members]
GO
ALTER TABLE [dbo].[RentedItems]  WITH CHECK ADD  CONSTRAINT [FK_RentedItems_Furnitures] FOREIGN KEY([FurnitureID])
REFERENCES [dbo].[Furnitures] ([FurnitureID])
GO
ALTER TABLE [dbo].[RentedItems] CHECK CONSTRAINT [FK_RentedItems_Furnitures]
GO
ALTER TABLE [dbo].[RentedItems]  WITH CHECK ADD  CONSTRAINT [FK_RentedItems_RentalTransaction] FOREIGN KEY([RentalTransactionID])
REFERENCES [dbo].[RentalTransactions] ([TransactionID])
GO
ALTER TABLE [dbo].[RentedItems] CHECK CONSTRAINT [FK_RentedItems_RentalTransaction]
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTransaction_Employees] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employees] ([EmployeeID])
GO
ALTER TABLE [dbo].[ReturnTransaction] CHECK CONSTRAINT [FK_ReturnTransaction_Employees]
GO
ALTER TABLE [dbo].[ReturnTransaction]  WITH CHECK ADD  CONSTRAINT [FK_ReturnTransaction_RentedItems] FOREIGN KEY([RentedItemsID])
REFERENCES [dbo].[RentedItems] ([RentedItemsID])
GO
ALTER TABLE [dbo].[ReturnTransaction] CHECK CONSTRAINT [FK_ReturnTransaction_RentedItems]
GO
USE [master]
GO
ALTER DATABASE [cs6232-g3] SET  READ_WRITE 
GO
