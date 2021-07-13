USE [master]
GO
/****** Object:  Database [BloodBankDb]    Script Date: 6/28/2021 4:56:20 PM ******/
CREATE DATABASE [BloodBankDb]

GO
ALTER DATABASE [BloodBankDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BloodBankDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BloodBankDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BloodBankDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BloodBankDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BloodBankDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BloodBankDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [BloodBankDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BloodBankDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BloodBankDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BloodBankDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BloodBankDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BloodBankDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BloodBankDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BloodBankDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BloodBankDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BloodBankDb] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BloodBankDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BloodBankDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BloodBankDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BloodBankDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BloodBankDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BloodBankDb] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BloodBankDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BloodBankDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BloodBankDb] SET  MULTI_USER 
GO
ALTER DATABASE [BloodBankDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BloodBankDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BloodBankDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BloodBankDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BloodBankDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BloodBankDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BloodBankDb] SET QUERY_STORE = OFF
GO
USE [BloodBankDb]
GO
/****** Object:  Table [dbo].[BloodTbl]    Script Date: 6/28/2021 4:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodTbl](
	[BGroup] [varchar](5) NOT NULL,
	[BStock] [int] NOT NULL,
 CONSTRAINT [PK_BloodTbl] PRIMARY KEY CLUSTERED 
(
	[BGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dashboard]    Script Date: 6/28/2021 4:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dashboard](
	[TotalDonor] [int] NOT NULL,
	[TotalTransfers] [int] NOT NULL,
	[TotalBlood] [int] NOT NULL,
	[TypeBloodA+] [int] NOT NULL,
	[TypeBloodA-] [int] NOT NULL,
	[TypeBloodB+] [int] NOT NULL,
	[TypeBloodB-] [int] NOT NULL,
	[TypeBloodO+] [int] NOT NULL,
	[TypeBloodO-] [int] NOT NULL,
	[TypeBloodAB+] [int] NOT NULL,
	[TypeBloodAB-] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonorTbl]    Script Date: 6/28/2021 4:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonorTbl](
	[DNum] [int] IDENTITY(1,1) NOT NULL,
	[DName] [nvarchar](50) NOT NULL,
	[DAge] [int] NOT NULL,
	[DGender] [varchar](10) NOT NULL,
	[DPhone] [varchar](50) NOT NULL,
	[DAdress] [nvarchar](50) NOT NULL,
	[DBGroup] [varchar](5) NOT NULL,
 CONSTRAINT [PK_DonorTbl] PRIMARY KEY CLUSTERED 
(
	[DNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginTbl]    Script Date: 6/28/2021 4:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginTbl](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoginTbl] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientTbl]    Script Date: 6/28/2021 4:56:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientTbl](
	[PNum] [int] IDENTITY(1,1) NOT NULL,
	[PName] [nvarchar](50) NOT NULL,
	[PAge] [int] NOT NULL,
	[PPhone] [varchar](10) NOT NULL,
	[PGender] [varchar](10) NOT NULL,
	[PBGroup] [varchar](5) NOT NULL,
	[PAdrress] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PatientTbl] PRIMARY KEY CLUSTERED 
(
	[PNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'A+', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'A-', 1)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'AB+', 1)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'AB-', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'B+', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'B-', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'O+', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'O-', 0)
GO
INSERT [dbo].[Dashboard] ([TotalDonor], [TotalTransfers], [TotalBlood], [TypeBloodA+], [TypeBloodA-], [TypeBloodB+], [TypeBloodB-], [TypeBloodO+], [TypeBloodO-], [TypeBloodAB+], [TypeBloodAB-]) VALUES (11, 6, 8, 3, 2, 1, 0, 0, 0, 2, 0)
GO
SET IDENTITY_INSERT [dbo].[DonorTbl] ON 
GO
INSERT [dbo].[DonorTbl] ([DNum], [DName], [DAge], [DGender], [DPhone], [DAdress], [DBGroup]) VALUES (15, N'Nam', 21, N'Male', N'0927847182', N'Nghe An', N'O+')
GO
INSERT [dbo].[DonorTbl] ([DNum], [DName], [DAge], [DGender], [DPhone], [DAdress], [DBGroup]) VALUES (16, N'Trang', 18, N'Female', N'0293719591', N'Thach That', N'O-')
GO
INSERT [dbo].[DonorTbl] ([DNum], [DName], [DAge], [DGender], [DPhone], [DAdress], [DBGroup]) VALUES (17, N'Dat', 21, N'Male', N'0183918427', N'Ha Noi
', N'B-')
GO
SET IDENTITY_INSERT [dbo].[DonorTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[LoginTbl] ON 
GO
INSERT [dbo].[LoginTbl] ([ID], [UserName], [Password]) VALUES (1, N'admin', N'admin')
GO
INSERT [dbo].[LoginTbl] ([ID], [UserName], [Password]) VALUES (2, N'doctor', N'doctor')
GO
SET IDENTITY_INSERT [dbo].[LoginTbl] OFF
GO
SET IDENTITY_INSERT [dbo].[PatientTbl] ON 
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PBGroup], [PAdrress]) VALUES (18, N'B', 2, N'2', N'Female', N'A+', N'B')
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PBGroup], [PAdrress]) VALUES (20, N'Linh', 24, N'0182746272', N'Male', N'A+', N'Hung Yen')
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PBGroup], [PAdrress]) VALUES (21, N'Tai ', 23, N'2819382910', N'Female', N'B-', N'Bac Giang')
GO
SET IDENTITY_INSERT [dbo].[PatientTbl] OFF
GO
USE [master]
GO
ALTER DATABASE [BloodBankDb] SET  READ_WRITE 
GO
