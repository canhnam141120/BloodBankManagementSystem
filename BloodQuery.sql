USE [master]
GO
/****** Object:  Database [BloodBankDb]    Script Date: 7/24/2021 11:34:47 PM ******/
CREATE DATABASE [BloodBankDb]


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
/****** Object:  Table [dbo].[BloodTbl]    Script Date: 7/24/2021 11:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodTbl](
	[BGroup] [char](10) NOT NULL,
	[BStock] [int] NOT NULL,
 CONSTRAINT [PK_BloodTbl] PRIMARY KEY CLUSTERED 
(
	[BGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonationTbl]    Script Date: 7/24/2021 11:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonationTbl](
	[DonateID] [int] IDENTITY(1,1) NOT NULL,
	[DonorID] [int] NOT NULL,
	[VolumeBlood] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[BGroup] [char](10) NULL,
 CONSTRAINT [PK_DonationTbl] PRIMARY KEY CLUSTERED 
(
	[DonateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonorTbl]    Script Date: 7/24/2021 11:34:47 PM ******/
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
	[VolumeBlood] [int] NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_DonorTbl] PRIMARY KEY CLUSTERED 
(
	[DPhone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginTbl]    Script Date: 7/24/2021 11:34:47 PM ******/
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
/****** Object:  Table [dbo].[PatientTbl]    Script Date: 7/24/2021 11:34:47 PM ******/
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
	[PAdrress] [nvarchar](50) NOT NULL,
	[PBGroup] [varchar](5) NOT NULL,
	[PBloodNeed] [int] NOT NULL,
 CONSTRAINT [PK_PatientTbl] PRIMARY KEY CLUSTERED 
(
	[PNum] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transfer_Blood]    Script Date: 7/24/2021 11:34:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transfer_Blood](
	[TransferID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NULL,
	[VolumeBloodTransfer] [int] NULL,
	[Date] [date] NULL,
	[BGroup] [char](10) NULL,
 CONSTRAINT [PK_Transfer_Blood] PRIMARY KEY CLUSTERED 
(
	[TransferID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'A+        ', 350)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'A-        ', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'AB+       ', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'AB-       ', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'B+        ', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'B-        ', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'O+        ', 0)
GO
INSERT [dbo].[BloodTbl] ([BGroup], [BStock]) VALUES (N'O-        ', 0)
GO
SET IDENTITY_INSERT [dbo].[DonorTbl] ON 
GO
INSERT [dbo].[DonorTbl] ([DNum], [DName], [DAge], [DGender], [DPhone], [DAdress], [DBGroup], [VolumeBlood], [Date]) VALUES (32, N'Nam', 21, N'Male', N'0961284654', N'Nghe An', N'A+', 350, CAST(N'2021-07-24' AS Date))
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
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PAdrress], [PBGroup], [PBloodNeed]) VALUES (1, N'Patient1', 18, N'134567', N'Male', N'Address1', N'A+', 750)
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PAdrress], [PBGroup], [PBloodNeed]) VALUES (2, N'Patient2', 20, N'2345', N'Male', N'Ad2', N'A-', 900)
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PAdrress], [PBGroup], [PBloodNeed]) VALUES (3, N'Patient3', 20, N'3456789', N'Female', N'Ad3', N'B+', 1150)
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PAdrress], [PBGroup], [PBloodNeed]) VALUES (4, N'Patient4', 38, N'23456789', N'Male', N'Ad4', N'B-', 2400)
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PAdrress], [PBGroup], [PBloodNeed]) VALUES (5, N'Patient5', 59, N'3456789', N'Female', N'Ad5', N'O+', 1950)
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PAdrress], [PBGroup], [PBloodNeed]) VALUES (7, N'Patient7', 70, N'9929487', N'Male', N'Ad7', N'AB+', 2850)
GO
INSERT [dbo].[PatientTbl] ([PNum], [PName], [PAge], [PPhone], [PGender], [PAdrress], [PBGroup], [PBloodNeed]) VALUES (8, N'Patient8', 49, N'3456789', N'Female', N'Ad8', N'AB-', 3550)
GO
SET IDENTITY_INSERT [dbo].[PatientTbl] OFF
GO
USE [master]
GO
ALTER DATABASE [BloodBankDb] SET  READ_WRITE 
GO
