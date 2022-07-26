USE [universitymanagement]
GO
/****** Object:  Table [dbo].[AkademikPersonel]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AkademikPersonel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Soyad] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Telefon] [nvarchar](11) NULL,
	[Adres] [nvarchar](500) NULL,
	[Durum] [bit] NULL,
	[YetkiId] [int] NULL,
	[TC] [nvarchar](11) NULL,
	[DoğumTarihi] [date] NULL,
	[FakülteId] [int] NULL,
	[BölümId] [int] NULL,
	[UnvanId] [int] NULL,
	[Fakülte] [nvarchar](100) NULL,
	[Bölüm] [nvarchar](100) NULL,
	[Unvan] [nvarchar](100) NULL,
	[KullanıcıAd] [nvarchar](100) NULL,
	[Sifre] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Birim]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Birim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BirimAd] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bolum]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bolum](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FakülteId] [int] NULL,
	[BolumAd] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ders]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DersAd] [nvarchar](100) NULL,
	[FakülteId] [int] NULL,
	[BölümId] [int] NULL,
	[Kredi] [int] NULL,
	[AkademikPersonelId] [int] NULL,
	[Durum] [bit] NULL,
	[AkademikPersonel] [nvarchar](100) NULL,
 CONSTRAINT [PK__Ders__3214EC071EB4BEF1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fakulte]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fakulte](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FakülteAd] [nvarchar](100) NULL,
	[Durum] [bit] NULL,
	[Adres] [nvarchar](500) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[idaripersonel]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[idaripersonel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Soyad] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Telefon] [nvarchar](11) NULL,
	[Adres] [nvarchar](500) NULL,
	[Durum] [bit] NULL,
	[YetkiId] [int] NULL,
	[TC] [nvarchar](11) NULL,
	[DoğumTarihi] [date] NULL,
	[BirimId] [int] NULL,
	[Birim] [nvarchar](100) NULL,
	[KullanıcıAd] [nvarchar](100) NULL,
	[Sifre] [nvarchar](100) NULL,
 CONSTRAINT [PK__idariper__3214EC073C9FC057] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciAd] [nvarchar](100) NULL,
	[Sifre] [nvarchar](50) NULL,
	[YetkiId] [int] NULL,
	[Durum] [bit] NULL,
	[AkademikPersonelId] [int] NULL,
	[idaripersonelId] [int] NULL,
	[ogrenciId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Not]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Not](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SınavId] [int] NULL,
	[OgrenciId] [int] NULL,
	[Harfnotu] [nvarchar](3) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciBilgileri]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciBilgileri](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [nvarchar](100) NULL,
	[Soyad] [nvarchar](100) NULL,
	[Fakülte] [nvarchar](100) NULL,
	[Bölüm] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Telefon] [nvarchar](11) NULL,
	[Adres] [nvarchar](500) NULL,
	[Durum] [bit] NULL,
	[YetkiId] [int] NULL,
	[TC] [nvarchar](11) NULL,
	[DoğumTarihi] [date] NULL,
	[ÖğrenciNo] [nvarchar](20) NULL,
	[BölümId] [int] NULL,
	[FakülteId] [int] NULL,
	[KullanıcıAd] [nvarchar](100) NULL,
	[Sifre] [nvarchar](100) NULL,
 CONSTRAINT [PK__OgrenciB__3214EC073376E14A] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciDers]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciId] [int] NULL,
	[DersId] [int] NULL,
	[Harfnotu] [nvarchar](3) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sınav]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sınav](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciId] [int] NULL,
	[DersId] [int] NULL,
	[Vize] [nvarchar](3) NULL,
	[Final] [nvarchar](3) NULL,
	[Bütünleme] [nvarchar](3) NULL,
	[Harfnotu] [nvarchar](3) NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK__Sınav__3214EC07D8C6EE73] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sınıf]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sınıf](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OgrenciId] [int] NULL,
	[Durum] [bit] NULL,
	[BölümId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unvan]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unvan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UnvanAd] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Yetki]    Script Date: 11.04.2022 15:13:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Yetki](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[YetkiAd] [nvarchar](50) NULL,
	[Durum] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[AkademikPersonel] ON 

INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (7, N'derici', N'derici', N'derici@', N'11111111111', N'derici', 1, 3, N'11111111111', CAST(N'2022-02-04' AS Date), 1, 1, 1, N'aa', N'cc', N'Profesör', N'derici', N'123')
INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (8, N'bilal', N'bilal', N'bilal@', N'11111111111', N'bilal', 1, 3, N'11111111111', CAST(N'2022-02-04' AS Date), 2, 2, 2, N'bb', N'dd', N'Asistan', NULL, NULL)
INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (9, N'murat', N'murat', N'murat@', N'11111111111', N'murat', 1, 3, N'11111111111', CAST(N'2022-03-04' AS Date), 1, 1, 1, N'aa', N'cc', N'Profesör', N'murat', N'123456')
INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (10, N'talha', N'talha', N'talha@', N'11111111111', N'talha', 1, 3, N'11111111111', CAST(N'2022-03-04' AS Date), 1, 1, 1, N'aa', N'cc', N'Profesör', N'talha', N'11111111111')
INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (11, N'emir', N'emir', N'emir@', N'22222222222', N'emir', 1, 3, N'22222222222', CAST(N'2022-03-04' AS Date), 1, 1, 1, N'aa', N'cc', N'Profesör', N'emir', N'33333333333')
INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (12, N'ecem', N'ecem', N'ecem@', N'11111111111', N'ecem', 1, 3, N'11111111111', CAST(N'2022-03-04' AS Date), 1, 1, 1, N'aa', N'cc', N'Profesör', N'ecem', N'123')
INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (13, N'naz', N'naz', N'naz@', N'11111111111', N'naz', 1, 3, N'11111111111', CAST(N'2022-09-05' AS Date), 2, 2, 1, N'bb', N'dd', N'Profesör', N'naz', N'123')
INSERT [dbo].[AkademikPersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [FakülteId], [BölümId], [UnvanId], [Fakülte], [Bölüm], [Unvan], [KullanıcıAd], [Sifre]) VALUES (14, N'hatice', N'baskonus', N'hatice@', N'11111111111', N'haticebsk', 1, 3, N'11111111111', CAST(N'2000-02-02' AS Date), 3, 3, 1, N'spor bilimleri', N'basketbol', N'Profesör', N'haticebsk', N'123')
SET IDENTITY_INSERT [dbo].[AkademikPersonel] OFF
GO
SET IDENTITY_INSERT [dbo].[Birim] ON 

INSERT [dbo].[Birim] ([Id], [BirimAd], [Durum]) VALUES (1, N'Muhasebe', 1)
INSERT [dbo].[Birim] ([Id], [BirimAd], [Durum]) VALUES (4, N'Ögrenci Isleri', 1)
SET IDENTITY_INSERT [dbo].[Birim] OFF
GO
SET IDENTITY_INSERT [dbo].[bolum] ON 

INSERT [dbo].[bolum] ([Id], [FakülteId], [BolumAd], [Durum]) VALUES (1, 2, N'cc', 1)
INSERT [dbo].[bolum] ([Id], [FakülteId], [BolumAd], [Durum]) VALUES (2, 1, N'dd', 1)
INSERT [dbo].[bolum] ([Id], [FakülteId], [BolumAd], [Durum]) VALUES (3, 3, N'basketbol', 1)
SET IDENTITY_INSERT [dbo].[bolum] OFF
GO
SET IDENTITY_INSERT [dbo].[Ders] ON 

INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (2, N'omur', 2, 1, 20, 8, 1, NULL)
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (3, N'matematik', 2, 1, 15, 12, 1, N'ecem ecem')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (4, N'tarih', 1, 1, 10, 11, 1, N'emir emir')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (5, N'fen', 2, 2, 15, 13, 1, N'naz naz')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (6, N'smaç', 3, 3, 10, 8, 1, N'bilal bilal')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (7, N'c#', 1, 1, 3, 7, 1, N'derici derici')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (8, N'java', 2, 2, 5, 7, 1, N'derici derici')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (9, N'turnike', 3, 3, 5, 14, 1, N'hatice baskonus')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (10, N'tenis', 3, 3, 5, 14, 1, N'hatice baskonus')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (11, N'türkçe', 2, 2, 5, 14, 1, N'hatice baskonus')
INSERT [dbo].[Ders] ([Id], [DersAd], [FakülteId], [BölümId], [Kredi], [AkademikPersonelId], [Durum], [AkademikPersonel]) VALUES (12, N'samsun', 2, 2, 5, 14, 1, N'hatice baskonus')
SET IDENTITY_INSERT [dbo].[Ders] OFF
GO
SET IDENTITY_INSERT [dbo].[fakulte] ON 

INSERT [dbo].[fakulte] ([Id], [FakülteAd], [Durum], [Adres]) VALUES (1, N'aa', 1, N'aa')
INSERT [dbo].[fakulte] ([Id], [FakülteAd], [Durum], [Adres]) VALUES (2, N'bb', 1, N'bb')
INSERT [dbo].[fakulte] ([Id], [FakülteAd], [Durum], [Adres]) VALUES (3, N'spor bilimleri', 1, N'spor okullari')
SET IDENTITY_INSERT [dbo].[fakulte] OFF
GO
SET IDENTITY_INSERT [dbo].[idaripersonel] ON 

INSERT [dbo].[idaripersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [BirimId], [Birim], [KullanıcıAd], [Sifre]) VALUES (9, N'murat', N'murat@', N'murat@', N'11111111111', N'murat', 1, 2, N'11111111111', CAST(N'2022-04-01' AS Date), 1, N'Muhasebe', N'murat', N'123')
INSERT [dbo].[idaripersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [BirimId], [Birim], [KullanıcıAd], [Sifre]) VALUES (10, N'ömür', N'ömür', N'ömür@', N'11111111111', N'ömür', 1, 2, N'11111111111', CAST(N'2022-02-04' AS Date), 4, N'Ögrenci Isleri', NULL, NULL)
INSERT [dbo].[idaripersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [BirimId], [Birim], [KullanıcıAd], [Sifre]) VALUES (11, N'sezer', N'sezer', N'sezer@', N'11111111111', N'sezer', 1, 2, N'11111111111', CAST(N'2022-03-04' AS Date), 1, N'Muhasebe', N'sezer', N'123')
INSERT [dbo].[idaripersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [BirimId], [Birim], [KullanıcıAd], [Sifre]) VALUES (12, N'sevde', N'sevde', N'sevde@', N'11111111111', N'sevde', 1, 2, N'11111111111', CAST(N'2022-03-04' AS Date), 1, N'Muhasebe', N'sevde', N'123')
INSERT [dbo].[idaripersonel] ([Id], [Ad], [Soyad], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [BirimId], [Birim], [KullanıcıAd], [Sifre]) VALUES (13, N'ahmet', N'ahmet', N'ahmet@', N'11111111111', N'ahmet', 1, 2, N'11111111111', CAST(N'2022-03-04' AS Date), 1, N'Muhasebe', N'ahmet123', N'123')
SET IDENTITY_INSERT [dbo].[idaripersonel] OFF
GO
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (1, N'onur', N'123456', 1, 1, NULL, NULL, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (2, N'hatice', N'123456', 2, 1, NULL, NULL, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (3, N'beste', N'123456', 3, 1, NULL, NULL, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (4, N'emir', N'33333333333', 3, 1, NULL, NULL, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (5, N'ecem', N'123', 3, 1, 12, NULL, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (7, N'ismail', N'123', 1, 1, NULL, NULL, 24)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (8, N'ahmet123', N'123', 2, 1, NULL, 13, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (9, N'naz', N'123', 3, 1, 13, NULL, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (11, N'salman', N'123', 1, 1, NULL, NULL, 26)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (12, N'sevde', N'123', 1, 1, NULL, NULL, 25)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (13, N'ahmet', N'123', 1, 1, NULL, NULL, 28)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (14, N'haticebsk', N'123', 3, 1, 14, NULL, NULL)
INSERT [dbo].[Kullanicilar] ([Id], [KullaniciAd], [Sifre], [YetkiId], [Durum], [AkademikPersonelId], [idaripersonelId], [ogrenciId]) VALUES (15, N'kutay', N'123', 1, 1, NULL, NULL, 29)
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
GO
SET IDENTITY_INSERT [dbo].[OgrenciBilgileri] ON 

INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (13, N'fatma', N'fatma', N'0', N'0', N'fatma@', N'11111111111', N'fatma', 1, 1, N'11111111111', CAST(N'2022-02-04' AS Date), N'11111111111', 1, 1, NULL, NULL)
INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (23, N'fatih', N'fatih', N'aa', N'cc', N'fatih@', N'11111111111', N'fatih', 1, 1, N'11111111111', CAST(N'2022-03-04' AS Date), N'11111111111', 1, 1, NULL, NULL)
INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (24, N'ismail', N'ismail', N'aa', N'cc', N'ismail@', N'11111111111', N'ismail', 1, 1, N'11111111111', CAST(N'2022-03-04' AS Date), N'11111111111', 1, 1, N'ismail', N'123')
INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (25, N'sevde', N'sevde', N'aa', N'cc', N'sevde@', N'11111111111', N'sevde', 1, 1, N'11111111111', CAST(N'2022-04-01' AS Date), N'123456789', 1, 1, N'sevde', N'123')
INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (26, N'salman', N'salman', N'spor bilimleri', N'basketbol', N'salman@', N'11111111111', N'salman', 1, 1, N'11111111111', CAST(N'2022-06-04' AS Date), N'11111111111', 3, 3, N'salman', N'123')
INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (27, N'sevde', N'sevde', N'spor bilimleri', N'basketbol', N'sevde@', N'11111111111', N'sevde', 1, 1, N'11111111111', CAST(N'2022-07-04' AS Date), N'11111111111', 3, 3, N'sevde', N'123')
INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (28, N'ahmet', N'Sekerci', N'bb', N'dd', N'ahmet@', N'11111111111', N'ahmet', 1, 1, N'11111111111', CAST(N'2020-04-02' AS Date), N'11111111111', 2, 2, N'ahmet', N'123')
INSERT [dbo].[OgrenciBilgileri] ([Id], [Ad], [Soyad], [Fakülte], [Bölüm], [Email], [Telefon], [Adres], [Durum], [YetkiId], [TC], [DoğumTarihi], [ÖğrenciNo], [BölümId], [FakülteId], [KullanıcıAd], [Sifre]) VALUES (29, N'kutay', N'kutay', N'spor bilimleri', N'basketbol', N'kutay@', N'11111111111', N'kutay', 1, 1, N'11111111111', CAST(N'2022-08-04' AS Date), N'11111111111', 3, 3, N'kutay', N'123')
SET IDENTITY_INSERT [dbo].[OgrenciBilgileri] OFF
GO
SET IDENTITY_INSERT [dbo].[OgrenciDers] ON 

INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (1, 24, 4, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (3, 25, 7, NULL, NULL)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (11, 13, 3, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (13, 13, 3, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (17, 25, 4, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (18, 25, 7, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (19, 25, 4, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (20, 25, 7, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (21, 25, 4, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (22, 25, 7, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (23, 25, 7, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (24, 28, 5, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (25, 28, 8, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (26, 28, 5, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (27, 29, 6, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (28, 29, 9, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (29, 28, 11, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (30, 28, 8, NULL, 1)
INSERT [dbo].[OgrenciDers] ([Id], [OgrenciId], [DersId], [Harfnotu], [Durum]) VALUES (31, 28, 12, NULL, 1)
SET IDENTITY_INSERT [dbo].[OgrenciDers] OFF
GO
SET IDENTITY_INSERT [dbo].[Sınav] ON 

INSERT [dbo].[Sınav] ([Id], [OgrenciId], [DersId], [Vize], [Final], [Bütünleme], [Harfnotu], [Durum]) VALUES (1, 28, 5, N'50', NULL, NULL, NULL, 1)
INSERT [dbo].[Sınav] ([Id], [OgrenciId], [DersId], [Vize], [Final], [Bütünleme], [Harfnotu], [Durum]) VALUES (2, 29, 6, N'50', NULL, NULL, NULL, 1)
INSERT [dbo].[Sınav] ([Id], [OgrenciId], [DersId], [Vize], [Final], [Bütünleme], [Harfnotu], [Durum]) VALUES (3, 29, 9, N'40', N'20', N'100', N'', 1)
INSERT [dbo].[Sınav] ([Id], [OgrenciId], [DersId], [Vize], [Final], [Bütünleme], [Harfnotu], [Durum]) VALUES (4, 28, 11, N'30', N'40', N'70', N'FD', 1)
INSERT [dbo].[Sınav] ([Id], [OgrenciId], [DersId], [Vize], [Final], [Bütünleme], [Harfnotu], [Durum]) VALUES (5, 28, 8, N'0', N'0', N'0', NULL, 1)
INSERT [dbo].[Sınav] ([Id], [OgrenciId], [DersId], [Vize], [Final], [Bütünleme], [Harfnotu], [Durum]) VALUES (6, 28, 12, N'50', N'100', N'0', N'', 1)
SET IDENTITY_INSERT [dbo].[Sınav] OFF
GO
SET IDENTITY_INSERT [dbo].[Unvan] ON 

INSERT [dbo].[Unvan] ([Id], [UnvanAd], [Durum]) VALUES (1, N'Profesör', 1)
INSERT [dbo].[Unvan] ([Id], [UnvanAd], [Durum]) VALUES (2, N'Asistan', 1)
SET IDENTITY_INSERT [dbo].[Unvan] OFF
GO
SET IDENTITY_INSERT [dbo].[Yetki] ON 

INSERT [dbo].[Yetki] ([Id], [YetkiAd], [Durum]) VALUES (1, N'Öğrenci', 1)
INSERT [dbo].[Yetki] ([Id], [YetkiAd], [Durum]) VALUES (2, N'İdari Personel', NULL)
INSERT [dbo].[Yetki] ([Id], [YetkiAd], [Durum]) VALUES (3, N'Akademik Personel', NULL)
SET IDENTITY_INSERT [dbo].[Yetki] OFF
GO
ALTER TABLE [dbo].[AkademikPersonel]  WITH CHECK ADD  CONSTRAINT [FK_AkademikPersonel_bolum] FOREIGN KEY([BölümId])
REFERENCES [dbo].[bolum] ([Id])
GO
ALTER TABLE [dbo].[AkademikPersonel] CHECK CONSTRAINT [FK_AkademikPersonel_bolum]
GO
ALTER TABLE [dbo].[AkademikPersonel]  WITH CHECK ADD  CONSTRAINT [FK_AkademikPersonel_fakulte] FOREIGN KEY([FakülteId])
REFERENCES [dbo].[fakulte] ([Id])
GO
ALTER TABLE [dbo].[AkademikPersonel] CHECK CONSTRAINT [FK_AkademikPersonel_fakulte]
GO
ALTER TABLE [dbo].[AkademikPersonel]  WITH CHECK ADD  CONSTRAINT [FK_AkademikPersonel_Unvan] FOREIGN KEY([UnvanId])
REFERENCES [dbo].[Unvan] ([Id])
GO
ALTER TABLE [dbo].[AkademikPersonel] CHECK CONSTRAINT [FK_AkademikPersonel_Unvan]
GO
ALTER TABLE [dbo].[AkademikPersonel]  WITH CHECK ADD  CONSTRAINT [FK_AkademikPersonel_Yetki] FOREIGN KEY([YetkiId])
REFERENCES [dbo].[Yetki] ([Id])
GO
ALTER TABLE [dbo].[AkademikPersonel] CHECK CONSTRAINT [FK_AkademikPersonel_Yetki]
GO
ALTER TABLE [dbo].[bolum]  WITH CHECK ADD  CONSTRAINT [FK_bolum_fakulte] FOREIGN KEY([FakülteId])
REFERENCES [dbo].[fakulte] ([Id])
GO
ALTER TABLE [dbo].[bolum] CHECK CONSTRAINT [FK_bolum_fakulte]
GO
ALTER TABLE [dbo].[Ders]  WITH CHECK ADD  CONSTRAINT [FK_Ders_AkademikPersonel] FOREIGN KEY([AkademikPersonelId])
REFERENCES [dbo].[AkademikPersonel] ([Id])
GO
ALTER TABLE [dbo].[Ders] CHECK CONSTRAINT [FK_Ders_AkademikPersonel]
GO
ALTER TABLE [dbo].[Ders]  WITH CHECK ADD  CONSTRAINT [FK_Ders_bolum] FOREIGN KEY([BölümId])
REFERENCES [dbo].[bolum] ([Id])
GO
ALTER TABLE [dbo].[Ders] CHECK CONSTRAINT [FK_Ders_bolum]
GO
ALTER TABLE [dbo].[Ders]  WITH CHECK ADD  CONSTRAINT [FK_Ders_fakulte] FOREIGN KEY([FakülteId])
REFERENCES [dbo].[fakulte] ([Id])
GO
ALTER TABLE [dbo].[Ders] CHECK CONSTRAINT [FK_Ders_fakulte]
GO
ALTER TABLE [dbo].[idaripersonel]  WITH CHECK ADD  CONSTRAINT [FK_idaripersonel_Birim] FOREIGN KEY([BirimId])
REFERENCES [dbo].[Birim] ([Id])
GO
ALTER TABLE [dbo].[idaripersonel] CHECK CONSTRAINT [FK_idaripersonel_Birim]
GO
ALTER TABLE [dbo].[idaripersonel]  WITH CHECK ADD  CONSTRAINT [FK_idaripersonel_Yetki] FOREIGN KEY([YetkiId])
REFERENCES [dbo].[Yetki] ([Id])
GO
ALTER TABLE [dbo].[idaripersonel] CHECK CONSTRAINT [FK_idaripersonel_Yetki]
GO
ALTER TABLE [dbo].[Kullanicilar]  WITH CHECK ADD  CONSTRAINT [FK_Kullanicilar_AkademikPersonel] FOREIGN KEY([AkademikPersonelId])
REFERENCES [dbo].[AkademikPersonel] ([Id])
GO
ALTER TABLE [dbo].[Kullanicilar] CHECK CONSTRAINT [FK_Kullanicilar_AkademikPersonel]
GO
ALTER TABLE [dbo].[Kullanicilar]  WITH CHECK ADD  CONSTRAINT [FK_Kullanicilar_idaripersonel] FOREIGN KEY([idaripersonelId])
REFERENCES [dbo].[idaripersonel] ([Id])
GO
ALTER TABLE [dbo].[Kullanicilar] CHECK CONSTRAINT [FK_Kullanicilar_idaripersonel]
GO
ALTER TABLE [dbo].[Kullanicilar]  WITH CHECK ADD  CONSTRAINT [FK_Kullanicilar_OgrenciBilgileri] FOREIGN KEY([ogrenciId])
REFERENCES [dbo].[OgrenciBilgileri] ([Id])
GO
ALTER TABLE [dbo].[Kullanicilar] CHECK CONSTRAINT [FK_Kullanicilar_OgrenciBilgileri]
GO
ALTER TABLE [dbo].[Kullanicilar]  WITH CHECK ADD  CONSTRAINT [FK_Kullanicilar_Yetki] FOREIGN KEY([YetkiId])
REFERENCES [dbo].[Yetki] ([Id])
GO
ALTER TABLE [dbo].[Kullanicilar] CHECK CONSTRAINT [FK_Kullanicilar_Yetki]
GO
ALTER TABLE [dbo].[Not]  WITH CHECK ADD  CONSTRAINT [FK_Not_OgrenciBilgileri] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[OgrenciBilgileri] ([Id])
GO
ALTER TABLE [dbo].[Not] CHECK CONSTRAINT [FK_Not_OgrenciBilgileri]
GO
ALTER TABLE [dbo].[Not]  WITH CHECK ADD  CONSTRAINT [FK_Not_Sınav] FOREIGN KEY([SınavId])
REFERENCES [dbo].[Sınav] ([Id])
GO
ALTER TABLE [dbo].[Not] CHECK CONSTRAINT [FK_Not_Sınav]
GO
ALTER TABLE [dbo].[OgrenciBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciBilgileri_bolum] FOREIGN KEY([BölümId])
REFERENCES [dbo].[bolum] ([Id])
GO
ALTER TABLE [dbo].[OgrenciBilgileri] CHECK CONSTRAINT [FK_OgrenciBilgileri_bolum]
GO
ALTER TABLE [dbo].[OgrenciBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciBilgileri_fakulte] FOREIGN KEY([FakülteId])
REFERENCES [dbo].[fakulte] ([Id])
GO
ALTER TABLE [dbo].[OgrenciBilgileri] CHECK CONSTRAINT [FK_OgrenciBilgileri_fakulte]
GO
ALTER TABLE [dbo].[OgrenciBilgileri]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciBilgileri_Yetki] FOREIGN KEY([YetkiId])
REFERENCES [dbo].[Yetki] ([Id])
GO
ALTER TABLE [dbo].[OgrenciBilgileri] CHECK CONSTRAINT [FK_OgrenciBilgileri_Yetki]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDers_Ders] FOREIGN KEY([DersId])
REFERENCES [dbo].[Ders] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDers] CHECK CONSTRAINT [FK_OgrenciDers_Ders]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH CHECK ADD  CONSTRAINT [FK_OgrenciDers_OgrenciBilgileri1] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[OgrenciBilgileri] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDers] CHECK CONSTRAINT [FK_OgrenciDers_OgrenciBilgileri1]
GO
ALTER TABLE [dbo].[Sınav]  WITH CHECK ADD  CONSTRAINT [FK_Sınav_Ders] FOREIGN KEY([DersId])
REFERENCES [dbo].[Ders] ([Id])
GO
ALTER TABLE [dbo].[Sınav] CHECK CONSTRAINT [FK_Sınav_Ders]
GO
ALTER TABLE [dbo].[Sınav]  WITH CHECK ADD  CONSTRAINT [FK_Sınav_OgrenciBilgileri] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[OgrenciBilgileri] ([Id])
GO
ALTER TABLE [dbo].[Sınav] CHECK CONSTRAINT [FK_Sınav_OgrenciBilgileri]
GO
ALTER TABLE [dbo].[Sınav]  WITH CHECK ADD  CONSTRAINT [FK_Sınav_OgrenciBilgileri1] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[OgrenciBilgileri] ([Id])
GO
ALTER TABLE [dbo].[Sınav] CHECK CONSTRAINT [FK_Sınav_OgrenciBilgileri1]
GO
/****** Object:  StoredProcedure [dbo].[akademikpersonelsil]    Script Date: 11.04.2022 15:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[akademikpersonelsil]
@akademikpersonelId int
as 
begin
delete from AkademikPersonel where Id=@akademikpersonelId
delete from Kullanicilar where AkademikPersonelId=@akademikpersonelId
delete from Ders where AkademikPersonelId=@akademikpersonelId
end
GO
/****** Object:  StoredProcedure [dbo].[bolumsil]    Script Date: 11.04.2022 15:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[bolumsil]
@bolumId int 
as 
begin
delete from bolum where Id=@bolumId
delete from AkademikPersonel where BölümId=@bolumId
delete from Ders where BölümId=@bolumId
delete from OgrenciBilgileri where BölümId=@bolumId
end
GO
/****** Object:  StoredProcedure [dbo].[derssil]    Script Date: 11.04.2022 15:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[derssil]
@dersId int 
as 
begin
delete from Ders where Id=@dersId
delete from Sınav where DersId=@dersId
delete from OgrenciDers where DersId=@dersId
end
GO
/****** Object:  StoredProcedure [dbo].[fakultesil]    Script Date: 11.04.2022 15:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[fakultesil]
@fakulteId int 
as 
begin
delete from fakulte where Id=@fakulteId
delete from AkademikPersonel where FakülteId=@fakulteId
delete from OgrenciBilgileri where FakülteId=@fakulteId
delete from bolum where FakülteId=@fakulteId
delete from Ders where FakülteId=@fakulteId
end
GO
/****** Object:  StoredProcedure [dbo].[idaripersonelsil]    Script Date: 11.04.2022 15:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[idaripersonelsil]
@idaripersonelId int
as 
begin
delete from idaripersonel where Id=@idaripersonelId
delete from Kullanicilar where idaripersonelId=@idaripersonelId
end
GO
/****** Object:  StoredProcedure [dbo].[ogrencisil]    Script Date: 11.04.2022 15:13:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ogrencisil] 
@ogrenciId int
as
begin
delete from OgrenciBilgileri where Id=@ogrenciId
delete from Kullanicilar where ogrenciId=@ogrenciId
delete from Sınav where OgrenciId=@ogrenciId
delete from OgrenciDers where OgrenciId=@ogrenciId
end
GO
