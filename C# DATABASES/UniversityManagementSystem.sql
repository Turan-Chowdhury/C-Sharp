USE [master]
GO
/****** Object:  Database [UniversityManagementSystem]    Script Date: 10/22/2022 4:51:19 PM ******/
CREATE DATABASE [UniversityManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'UniversityManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UniversityManagementSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'UniversityManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\UniversityManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [UniversityManagementSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [UniversityManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [UniversityManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [UniversityManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [UniversityManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [UniversityManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [UniversityManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [UniversityManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [UniversityManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [UniversityManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [UniversityManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [UniversityManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [UniversityManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [UniversityManagementSystem] SET QUERY_STORE = OFF
GO
USE [UniversityManagementSystem]
GO
/****** Object:  Table [dbo].[Departments]    Script Date: 10/22/2022 4:51:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Code] [nvarchar](50) NULL,
	[Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_Departments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 10/22/2022 4:51:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[RegNo] [nvarchar](50) NULL,
	[PhoneNo] [nvarchar](13) NULL,
	[Email] [nvarchar](30) NULL,
	[DepartmentId] [int] NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[StudentWithDept]    Script Date: 10/22/2022 4:51:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[StudentWithDept]
AS
SELECT s.Id AS StudentId, s.Name AS StudentName, s.RegNo, s.PhoneNo, s.Email, d.Id AS DeptId, d.Name AS DeptName, d.Code FROM
Students AS s JOIN Departments AS d ON s.DepartmentId = d.Id
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 10/22/2022 4:51:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Code] [nvarchar](50) NULL,
	[Credit] [numeric](18, 2) NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Enroll]    Script Date: 10/22/2022 4:51:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enroll](
	[StudentId] [int] NULL,
	[CourseId] [int] NULL,
	[EnrollDate] [date] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([Id], [Name], [Code], [Credit]) VALUES (1, N'Programming C', N'C', CAST(3.00 AS Numeric(18, 2)))
INSERT [dbo].[Courses] ([Id], [Name], [Code], [Credit]) VALUES (2, N'Data Structure', N'DS', CAST(4.00 AS Numeric(18, 2)))
INSERT [dbo].[Courses] ([Id], [Name], [Code], [Credit]) VALUES (3, N'C++', N'C++', CAST(4.00 AS Numeric(18, 2)))
INSERT [dbo].[Courses] ([Id], [Name], [Code], [Credit]) VALUES (4, N'DataBase', N'DB', CAST(3.00 AS Numeric(18, 2)))
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Departments] ON 

INSERT [dbo].[Departments] ([Id], [Code], [Name]) VALUES (1, N'CSE', N'Computer Science & Engineering')
INSERT [dbo].[Departments] ([Id], [Code], [Name]) VALUES (2, N'PHY', N'Physics')
INSERT [dbo].[Departments] ([Id], [Code], [Name]) VALUES (3, N'ENG', N'English')
INSERT [dbo].[Departments] ([Id], [Code], [Name]) VALUES (4, N'CHE', N'Chemistry')
SET IDENTITY_INSERT [dbo].[Departments] OFF
GO
SET IDENTITY_INSERT [dbo].[Students] ON 

INSERT [dbo].[Students] ([Id], [Name], [RegNo], [PhoneNo], [Email], [DepartmentId]) VALUES (1, N'Turan', N'123-434', N'01834853438', N'turan@gmail.com', 1)
INSERT [dbo].[Students] ([Id], [Name], [RegNo], [PhoneNo], [Email], [DepartmentId]) VALUES (2, N'Zia', N'123-438', N'01876694690', N'zia@gmail.com', 4)
INSERT [dbo].[Students] ([Id], [Name], [RegNo], [PhoneNo], [Email], [DepartmentId]) VALUES (3, N'abc', N'123-543', N'463465634', N'abcde@gmail.com', 3)
INSERT [dbo].[Students] ([Id], [Name], [RegNo], [PhoneNo], [Email], [DepartmentId]) VALUES (4, N'dd', N'123-12399', N'5452565223', N'dddddddd@gamil.com', 2)
INSERT [dbo].[Students] ([Id], [Name], [RegNo], [PhoneNo], [Email], [DepartmentId]) VALUES (8, N'xx', N'123-763', N'456789643', N'xxx@gmail.com', 4)
INSERT [dbo].[Students] ([Id], [Name], [RegNo], [PhoneNo], [Email], [DepartmentId]) VALUES (9, N'karim''s', N'123-473', N'4534635345', N'karim@gmail.com', 2)
SET IDENTITY_INSERT [dbo].[Students] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Students]    Script Date: 10/22/2022 4:51:19 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Students] ON [dbo].[Students]
(
	[RegNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Departments]  WITH CHECK ADD  CONSTRAINT [FK_Departments_Departments] FOREIGN KEY([Id])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Departments] CHECK CONSTRAINT [FK_Departments_Departments]
GO
ALTER TABLE [dbo].[Enroll]  WITH CHECK ADD  CONSTRAINT [FK_Enroll_Courses] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Courses] ([Id])
GO
ALTER TABLE [dbo].[Enroll] CHECK CONSTRAINT [FK_Enroll_Courses]
GO
ALTER TABLE [dbo].[Enroll]  WITH CHECK ADD  CONSTRAINT [FK_Enroll_Students] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Students] ([Id])
GO
ALTER TABLE [dbo].[Enroll] CHECK CONSTRAINT [FK_Enroll_Students]
GO
ALTER TABLE [dbo].[Students]  WITH CHECK ADD  CONSTRAINT [FK_Students_Departments] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Departments] ([Id])
GO
ALTER TABLE [dbo].[Students] CHECK CONSTRAINT [FK_Students_Departments]
GO
USE [master]
GO
ALTER DATABASE [UniversityManagementSystem] SET  READ_WRITE 
GO
