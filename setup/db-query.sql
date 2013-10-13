USE [master]
GO
/****** Object:  Database [MusicStore]    Script Date: 10/10/2013 09:51:12 ******/
CREATE DATABASE [MusicStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MusicStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MusicStore.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'MusicStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQLEXPRESS\MSSQL\DATA\MusicStore_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [MusicStore] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MusicStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MusicStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MusicStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MusicStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MusicStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MusicStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [MusicStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MusicStore] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [MusicStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MusicStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MusicStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MusicStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MusicStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MusicStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MusicStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MusicStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MusicStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MusicStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MusicStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MusicStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MusicStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MusicStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MusicStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MusicStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MusicStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MusicStore] SET  MULTI_USER 
GO
ALTER DATABASE [MusicStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MusicStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MusicStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MusicStore] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'MusicStore', N'ON'
GO
USE [MusicStore]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 10/13/2013 10:46:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[albumTitle] [nvarchar](50) NOT NULL,
	[releaseYear] [smallint] NOT NULL,
	[genre] [nvarchar](20) NOT NULL,
	[artistName] [nvarchar](50) NOT NULL,
	[albumArtwork] [nvarchar](50) NULL,
	[price] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Album] ON 

GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (1, N'Piano Man', 1973, N'Rock', N'Billy Joel', N'PianoMan.jpg', CAST(89.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (2, N'52nd Street', 1978, N'Rock', N'Billy Joel', N'52ndStreet.jpg', CAST(149.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (3, N'Turnstiles', 1976, N'Rock', N'Billy Joel', N'Turnstiles.jpg', CAST(89.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (4, N'A Rush of Blood to the Head', 2002, N'Alternative', N'The Killers', N'ARushofBloodtotheHead.jpg', CAST(89.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (5, N'Viva la Vida or Death to All His Friends', 2008, N'Alternative', N'The Killers', N'VivalaVidaorDeathandAllHisFriends.jpg', CAST(44.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (7, N'Sam''s Town', 2006, N'Rock', N'Coldplay', N'SamsTown.jpg', CAST(94.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (8, N'Hot Fuss', 2004, N'Alternative', N'Coldplay', N'HotFuss.jpg', CAST(44.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (9, N'The 20/20 Experience', 2013, N'Soul', N'Justin Timberlake', N'The2020Experience.png', CAST(199.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (10, N'Nothing Was the Same', 2013, N'Rap', N'Drake', N'NothingWasTheSame.png', CAST(149.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [releaseYear], [genre], [artistName], [albumArtwork], [price]) VALUES (11, N'Watch the Throne', 2013, N'Hip-Hop', N'Jay-Z & Kanye West', N'WatchTheThrone.jpg', CAST(149.99 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[Album] OFF
GO
USE [master]
GO
ALTER DATABASE [MusicStore] SET  READ_WRITE 
GO
