USE [master]
GO
/****** Object:  Database [QLSinhVien]    Script Date: 05/23/2020 10:13:37 SA ******/
CREATE DATABASE [QLSinhVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSinhVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLSinhVien.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSinhVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLSinhVien_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSinhVien] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSinhVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSinhVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSinhVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSinhVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSinhVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSinhVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSinhVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSinhVien] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSinhVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSinhVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSinhVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSinhVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSinhVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSinhVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSinhVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSinhVien] SET  MULTI_USER 
GO
ALTER DATABASE [QLSinhVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSinhVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSinhVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSinhVien] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [QLSinhVien]
GO
/****** Object:  Table [dbo].[SINHVIEN]    Script Date: 05/23/2020 10:13:37 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINHVIEN](
	[MASV] [nchar](10) NOT NULL,
	[TENSV] [nvarchar](200) NULL,
	[MALOP] [nchar](10) NULL,
	[NGAYSINH] [datetime] NULL,
	[GIOITINH] [nchar](10) NULL,
	[CMND] [nchar](20) NULL,
 CONSTRAINT [PK_SINHVIEN] PRIMARY KEY CLUSTERED 
(
	[MASV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'1         ', N'Nguyễn Quang Huy', N'08DHTH1   ', CAST(0x00008E6F00000000 AS DateTime), N'NAM       ', N'18783783493         ')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'2         ', N'Hồ Văn Đạt', N'08DHTH1   ', CAST(0x00008E6F00000000 AS DateTime), N'NAM       ', N'65436546456         ')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'3         ', N'Nguyễn Hải Nam', N'08DHTH2   ', CAST(0x00008DBF00000000 AS DateTime), N'NAM       ', N'54235345345         ')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'4         ', N'Vương Huỳnh Thanh Tuấn', N'08DHTH2   ', CAST(0x00008D3F00000000 AS DateTime), N'NAM       ', N'54235345345         ')
INSERT [dbo].[SINHVIEN] ([MASV], [TENSV], [MALOP], [NGAYSINH], [GIOITINH], [CMND]) VALUES (N'5         ', N'Lê Vĩnh Khiêm', N'08DHTH1   ', CAST(0x00008D3F00000000 AS DateTime), N'NAM       ', N'34523534534         ')
USE [master]
GO
ALTER DATABASE [QLSinhVien] SET  READ_WRITE 
GO
