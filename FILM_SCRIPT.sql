USE [master]
GO
/****** Object:  Database [Film]    Script Date: 27-08-2019 13:27:27 ******/
CREATE DATABASE [Film]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Film', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.ASPITSQLSERVER\MSSQL\DATA\Film.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Film_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.ASPITSQLSERVER\MSSQL\DATA\Film_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Film] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Film].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Film] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Film] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Film] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Film] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Film] SET ARITHABORT OFF 
GO
ALTER DATABASE [Film] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Film] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Film] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Film] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Film] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Film] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Film] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Film] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Film] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Film] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Film] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Film] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Film] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Film] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Film] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Film] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Film] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Film] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Film] SET  MULTI_USER 
GO
ALTER DATABASE [Film] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Film] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Film] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Film] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Film] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Film', N'ON'
GO
ALTER DATABASE [Film] SET QUERY_STORE = OFF
GO
USE [Film]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [Film]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 27-08-2019 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](15) NOT NULL,
	[Description] [ntext] NULL,
	[Picture] [image] NULL,
	[UseerId] [int] NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 27-08-2019 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[filmid] [int] IDENTITY(1,1) NOT NULL,
	[titel] [nvarchar](50) NOT NULL,
	[land] [nvarchar](50) NULL,
	[year] [int] NOT NULL,
	[genre] [nvarchar](50) NOT NULL,
	[oscars] [int] NOT NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[filmid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FilmFan]    Script Date: 27-08-2019 13:27:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FilmFan](
	[id] [int] NOT NULL,
	[navn] [nvarchar](50) NOT NULL,
	[adresse] [nvarchar](50) NOT NULL,
	[alder] [int] NOT NULL,
 CONSTRAINT [PK_FilmFan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Film] ON 

INSERT [dbo].[Film] ([filmid], [titel], [land], [year], [genre], [oscars]) VALUES (15, N'E.T.', N'USA', 1982, N'Sci-Fi', 4)
INSERT [dbo].[Film] ([filmid], [titel], [land], [year], [genre], [oscars]) VALUES (16, N'Taxi', N'Frankrig', 1998, N'Komedie', 0)
INSERT [dbo].[Film] ([filmid], [titel], [land], [year], [genre], [oscars]) VALUES (18, N'Sult', N'Danmark', 1966, N'Thriller', 1)
INSERT [dbo].[Film] ([filmid], [titel], [land], [year], [genre], [oscars]) VALUES (19, N'Leon ', N'Frankrig', 1994, N'Action', 0)
INSERT [dbo].[Film] ([filmid], [titel], [land], [year], [genre], [oscars]) VALUES (20, N'Hard Boiled', N'Kina', 1992, N'Action', 0)
INSERT [dbo].[Film] ([filmid], [titel], [land], [year], [genre], [oscars]) VALUES (21, N'1984', N'UK', 1984, N'Sci-Fi', 2)
INSERT [dbo].[Film] ([filmid], [titel], [land], [year], [genre], [oscars]) VALUES (22, N'Seven', N'USA', 1995, N'Thriller', 1)
SET IDENTITY_INSERT [dbo].[Film] OFF
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (1, N'IA', N'(bobby) First Place', 6)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (2, N'Bo', N'Mads Strasse', 82)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (3, N'Ingolf', N'Mads Gade', 62)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (4, N'Kasper', N'Mads Vej', 21)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (5, N'Torkild', N'Mads Vænget', 42)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (6, N'MathiasVej10', N'(bobby) 32', 32)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (7, N'5094', N'(Sage) SagenStreat 1', 5094)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (8, N'John Kingston', N'Morgan st. 15', 29)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (9, N'Ains', N'(Sage) SagenStreet', 897345)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (10, N'magona', N'(Sage) SagenStreet', 897345)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (11, N'Johanne Kirstine', N'Morgan st. 21', 22)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (12, N'viola', N'(Sage) SagenStreet', 897345)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (13, N'yta', N'(Sage) SagenStreet', 897345)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (14, N'hallo', N'(Sage) SagenStreet', 897345)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (15, N'moo', N'(Sage) SagenStreet', 897345)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (16, N'Joe Joestar', N'Morgan st. 9', 25)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (17, N'Jeiner Far', N'MathiasVej100', 66)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (18, N'Valmar Jørgensen', N'MathiasVej101', 22)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (19, N'Ricky', N' Patrick street', 24)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (20, N'Jalmar Valmar', N'MathiasVej105', 54)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (21, N'Melanie Mikkelsen', N'Morgan st. 36', 23)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (22, N'Micky', N' Patrick street', 27)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (23, N'lil per', N'MathiasVej11', 11)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (24, N'Rick', N' Patrick street', 64)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (25, N'Claus Jensen', N'Morgan st. 34', 69)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (26, N'Admiral Jarl', N'MathiasVej115', 50)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (27, N'Karl Jarl', N'MathiasVej114', 65)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (28, N'Morty', N' Patrick street 23', 17)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (29, N'Brian Bonderøv', N'Mads Hjørnet', 31)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (30, N'Slim Shady', N'Morgan st. 56', 40)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (31, N'Rick', N'Mads Boulevard', 57)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (32, N'Mr Pickles', N' Patrick street 38', 18)
INSERT [dbo].[FilmFan] ([id], [navn], [adresse], [alder]) VALUES (33, N'Kenn', N' Patrick street 68', 18)
USE [master]
GO
ALTER DATABASE [Film] SET  READ_WRITE 
GO
