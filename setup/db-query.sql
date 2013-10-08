USE [master]
GO
/****** Object:  Database [MusicStore]    Script Date: 10/8/2013 11:08:11 ******/
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
USE [MusicStore]
GO
/****** Object:  Table [dbo].[Album]    Script Date: 10/8/2013 11:08:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Album](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[albumTitle] [nvarchar](50) NOT NULL,
	[yearOfRelease] [smallint] NOT NULL,
	[genre] [nvarchar](50) NOT NULL,
	[artistID] [int] NOT NULL,
	[albumArtwork] [nvarchar](50) NULL,
	[price] [decimal](8, 2) NULL,
 CONSTRAINT [PK_Album] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Artist]    Script Date: 10/8/2013 11:08:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artist](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[artistName] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_Artist] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tracklist]    Script Date: 10/8/2013 11:08:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tracklist](
	[albumID] [int] NOT NULL
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Album] ON 

GO
INSERT [dbo].[Album] ([ID], [albumTitle], [yearOfRelease], [genre], [artistID], [albumArtwork], [price]) VALUES (1, N'Piano Man', 1973, N'Rock', 1, N'PianoMan.jpg', CAST(89.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [yearOfRelease], [genre], [artistID], [albumArtwork], [price]) VALUES (2, N'52nd Street', 1978, N'Rock', 1, N'52ndStreet.jpg', CAST(149.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [yearOfRelease], [genre], [artistID], [albumArtwork], [price]) VALUES (3, N'Turnstiles', 1976, N'Rock', 1, N'Turnstiles.jpg', CAST(89.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [yearOfRelease], [genre], [artistID], [albumArtwork], [price]) VALUES (4, N'A Rush of Blood to the Head', 2002, N'Alternative', 2, N'ARushofBloodtotheHead.jpg', CAST(89.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [yearOfRelease], [genre], [artistID], [albumArtwork], [price]) VALUES (5, N'Viva la Vida or Death to All His Friends', 2008, N'Alternative', 2, N'VivalaVidaorDeathandAllHisFriends.jpg', CAST(44.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [yearOfRelease], [genre], [artistID], [albumArtwork], [price]) VALUES (7, N'Sam''s Town', 2006, N'Rock', 3, N'SamsTown.jpg', CAST(94.99 AS Decimal(8, 2)))
GO
INSERT [dbo].[Album] ([ID], [albumTitle], [yearOfRelease], [genre], [artistID], [albumArtwork], [price]) VALUES (8, N'Hot Fuss', 2004, N'Alternative', 3, N'HotFuss.jpg', CAST(44.99 AS Decimal(8, 2)))
GO
SET IDENTITY_INSERT [dbo].[Album] OFF
GO
SET IDENTITY_INSERT [dbo].[Artist] ON 

GO
INSERT [dbo].[Artist] ([ID], [artistName]) VALUES (1, N'Billy Joel')
GO
INSERT [dbo].[Artist] ([ID], [artistName]) VALUES (2, N'Coldplay')
GO
INSERT [dbo].[Artist] ([ID], [artistName]) VALUES (3, N'The Killers')
GO
SET IDENTITY_INSERT [dbo].[Artist] OFF
GO
ALTER TABLE [dbo].[Album]  WITH CHECK ADD  CONSTRAINT [FK_Album_Artist] FOREIGN KEY([artistID])
REFERENCES [dbo].[Artist] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Album] CHECK CONSTRAINT [FK_Album_Artist]
GO
ALTER TABLE [dbo].[Tracklist]  WITH CHECK ADD  CONSTRAINT [FK_Tracklist_Album] FOREIGN KEY([albumID])
REFERENCES [dbo].[Album] ([ID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Tracklist] CHECK CONSTRAINT [FK_Tracklist_Album]
GO
USE [master]
GO
ALTER DATABASE [MusicStore] SET  READ_WRITE 
GO