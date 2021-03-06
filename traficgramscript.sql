CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AffiliateLanguages]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AffiliateLanguages](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_AffiliateLanguages] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Affiliates]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Affiliates](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[InstaLink] [nvarchar](max) NULL,
	[TotalFollwers] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[WANumber] [nvarchar](max) NULL,
	[AddintionDate] [datetime2](7) NOT NULL,
	[PaymentForPost] [float] NOT NULL,
	[PaymentForPostPlusStory] [float] NOT NULL,
	[PaymentForStory] [float] NOT NULL,
	[AffiliateLanguageId] [int] NULL,
	[CatagoryId] [int] NULL,
 CONSTRAINT [PK_Affiliates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedOn] [datetime2](7) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](450) NOT NULL,
	[ProviderKey] [nvarchar](450) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](450) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Campaigns]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campaigns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](max) NULL,
	[TargetImpression] [float] NOT NULL,
	[TotalBudget] [float] NOT NULL,
	[TotalLinkClicked] [float] NULL,
	[TotalFollowerIncreament] [float] NULL,
	[ClientId] [int] NOT NULL,
	[CreationDate] [datetime2](7) NOT NULL,
	[FinishingDate] [datetime2](7) NOT NULL,
	[Remarks] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[BitlyLink] [nvarchar](max) NULL,
 CONSTRAINT [PK_Campaigns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Catagories]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Catagories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Catagories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[WANumber] [nvarchar](max) NULL,
	[Link] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Status] [int] NOT NULL,
	[AddintionDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expenses](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Details] [nvarchar](max) NULL,
	[CampaignId] [int] NULL,
	[Amount] [float] NOT NULL,
	[ExpenceDate] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Posts]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Posts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[PostTypeId] [int] NOT NULL,
	[AffiliateId] [int] NOT NULL,
	[CampaignId] [int] NOT NULL,
	[PostReached] [float] NOT NULL,
	[StoryViewed] [float] NOT NULL,
	[ImpressionGenerated] [float] NOT NULL,
	[ReactionGenerated] [nvarchar](max) NULL,
	[CommentsGenerated] [nvarchar](max) NULL,
	[PaidAmount] [float] NOT NULL,
 CONSTRAINT [PK_Posts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PostTypes]    Script Date: 7/24/2021 8:40:48 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_PostTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210707131249_InititalMigration', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210707161429_AffiliatesAdded', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210707175423_AffiliatesUpdated1', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210707182623_AffiliatesUpdated2', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210707205045_ClientAdded', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210708095658_CampaignsAdded', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210708102741_PostAdded', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210708111408_campaignDataSomeNullable', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210709094736_ExpenceAdded', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210710102816_PaymentVariationAddedForAffiliate', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210710130252_ExpenceDate', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210710172147_COmmentsChar', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210710173955_followerssChar', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713163609_CatagoryAndLanguageAdded', N'2.2.3-servicing-35854')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210713170249_CatagoryAndLanguageUpdated', N'2.2.3-servicing-35854')
SET IDENTITY_INSERT [dbo].[AffiliateLanguages] ON 

INSERT [dbo].[AffiliateLanguages] ([Id], [Name], [Status]) VALUES (1, N'Malayalam', 1)
INSERT [dbo].[AffiliateLanguages] ([Id], [Name], [Status]) VALUES (2, N'English ', 1)
INSERT [dbo].[AffiliateLanguages] ([Id], [Name], [Status]) VALUES (3, N'Tamil', 1)
INSERT [dbo].[AffiliateLanguages] ([Id], [Name], [Status]) VALUES (4, N'Hindi', 1)
SET IDENTITY_INSERT [dbo].[AffiliateLanguages] OFF
SET IDENTITY_INSERT [dbo].[Affiliates] ON 

INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (12, N'Popcorn creations', N'https://www.instagram.com/popcorncreations__/', N'345K', N'Nil', 1, N'9747703853', CAST(N'2021-07-19T03:39:29.4425643' AS DateTime2), 150, 250, 100, 1, 2)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (13, N'Mollywood Gallery', N'https://www.instagram.com/mollywoodgallery/', N'135K', N'Nil', 1, N'9497247745', CAST(N'2021-07-19T03:40:58.6003825' AS DateTime2), 150, 250, 100, 1, 2)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (14, N'Mallu.Viral', N'https://www.instagram.com/mallu.viral/', N'138K', N'Nil', 1, N'9207364653', CAST(N'2021-07-19T03:43:24.5402905' AS DateTime2), 200, 300, 100, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (15, N'Mallu Thug Lyf', N'https://www.instagram.com/mallu_thug.lyf/', N'236K', N'Nil', 1, N'6282325883', CAST(N'2021-07-19T03:45:52.0000000' AS DateTime2), 200, 350, 150, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (16, N'BGM Junkbox', N'https://www.instagram.com/bgm_junkbox/', N'300K', N'Nil', 1, N'8590669100', CAST(N'2021-07-19T03:47:29.9823955' AS DateTime2), 0, 0, 150, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (17, N'Tr Media Works', N'https://www.instagram.com/tr_media_works_/', N'157K', N'Nil', 1, N'9633077770', CAST(N'2021-07-19T03:49:15.4933445' AS DateTime2), 0, 0, 100, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (18, N'Insta 4 Bgm ', N'https://www.instagram.com/insta4bgm/', N'113K', N'Nil', 1, N'Nil', CAST(N'2021-07-19T03:50:52.4316080' AS DateTime2), 0, 0, 100, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (19, N'Thottavan Bgm', N'https://www.instagram.com/tho_ttavan_bgm/', N'111K', N'Nil', 1, N'9074027147', CAST(N'2021-07-19T03:53:03.1257549' AS DateTime2), 150, 100, 50, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (20, N'Girls V/S Boys', N'https://www.instagram.com/boys_vs_girls_trolls/', N'107K', N'Nil', 1, N'7907084471', CAST(N'2021-07-19T03:56:22.1070498' AS DateTime2), 200, 300, 100, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (21, N'KTU  Trolls', N'https://www.instagram.com/troll.ktu.official/', N'176K', N'Nil', 1, N'8606180013', CAST(N'2021-07-19T04:00:23.0745795' AS DateTime2), 400, 600, 200, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (22, N'Mallu1.0', N'https://www.instagram.com/mallu1.0/', N'113K', N'Nil', 1, N'7012320250', CAST(N'2021-07-19T04:21:49.2015600' AS DateTime2), 300, 500, 200, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (23, N'Kerala Riders Team', N'https://www.instagram.com/kerala_riders_team/', N'160K', N'Nil', 1, N'8113977934', CAST(N'2021-07-19T04:28:02.1537219' AS DateTime2), 150, 250, 100, 1, 7)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (24, N'Riders_Gallery', N'https://www.instagram.com/riders__gallery/', N'108K', N'Nil', 1, N'9847308998', CAST(N'2021-07-19T04:30:05.3232689' AS DateTime2), 0, 0, 100, 1, 6)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (25, N'Yathrakkar', N'https://www.instagram.com/yathrakaar/', N'141K', N'Nil', 1, N'9946117489', CAST(N'2021-07-19T04:56:33.0108786' AS DateTime2), 250, 400, 150, 1, 6)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (26, N'Status Bhrantanmar', N'https://www.instagram.com/status_branthanmar/', N'102K', N'Nil', 1, N'9074610342', CAST(N'2021-07-19T04:58:17.7835158' AS DateTime2), 200, 250, 50, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (27, N'Malayalamtrollunlimited', N'https://www.instagram.com/malayalamtrollunlimited/', N'93K', N'Nil', 1, N'9544979202', CAST(N'2021-07-19T05:00:49.0507746' AS DateTime2), 150, 200, 50, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (28, N'Asifikka Uyir', N'https://www.instagram.com/asif.ikka_uyir/', N'70.4K', N'Nil', 1, N'7510303661', CAST(N'2021-07-19T05:06:56.9156900' AS DateTime2), 70, 100, 30, 1, 2)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (29, N'Comment Pokki', N'https://www.instagram.com/comment.pokki/', N'55.1K', N'Nil', 1, N'8848950972', CAST(N'2021-07-19T05:08:45.9787129' AS DateTime2), 150, 250, 100, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (30, N'Pubg noob world', N'https://www.instagram.com/pubgnoobworld_trolls/', N'18.3K', N'Nil', 1, N'9074081823', CAST(N'2021-07-19T05:12:46.0330407' AS DateTime2), 40, 60, 20, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (31, N'Trolling House', N'https://www.instagram.com/trolling_house/', N'47.2K', N'Nil', 1, N'9633862986', CAST(N'2021-07-19T05:14:36.9433805' AS DateTime2), 70, 100, 30, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (32, N'Yathra Premikal Official', N'https://www.instagram.com/yathra_premikal/', N'130K', N'Nil', 1, N'8921911034', CAST(N'2021-07-19T05:18:12.5743933' AS DateTime2), 0, 0, 200, 1, 6)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (33, N'Sed aayi Mwoluse', N'https://www.instagram.com/sed.aayi.mwoluse/', N'53.6K', N'Nil', 1, N'Nil', CAST(N'2021-07-19T05:22:05.3154297' AS DateTime2), 100, 150, 50, 1, 4)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (34, N'Movie.cutz', N'https://www.instagram.com/movie.cutz/', N'58.2K', N'Nil', 1, N'7510358846', CAST(N'2021-07-19T06:09:02.2853179' AS DateTime2), 80, 100, 20, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (35, N'Kilukkam Petti', N'https://www.instagram.com/kilukkan.petti/', N'60K ', N'Nil', 1, N'7510358846', CAST(N'2021-07-19T06:10:41.6255589' AS DateTime2), 80, 100, 20, 1, 2)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (36, N'remanan.media', N'https://www.instagram.com/remanan.media/', N'55.1K', N'Nil', 1, N'Nil', CAST(N'2021-07-19T06:13:38.9786960' AS DateTime2), 80, 100, 20, 1, 3)
INSERT [dbo].[Affiliates] ([Id], [Name], [InstaLink], [TotalFollwers], [Email], [Status], [WANumber], [AddintionDate], [PaymentForPost], [PaymentForPostPlusStory], [PaymentForStory], [AffiliateLanguageId], [CatagoryId]) VALUES (37, N'psycho Simon', N'https://www.instagram.com/_psycho_simon/', N'59.2K', N'Nil', 1, N'Nil', CAST(N'2021-07-19T06:17:51.4160950' AS DateTime2), 100, 130, 30, 1, 3)
SET IDENTITY_INSERT [dbo].[Affiliates] OFF
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp], [Description], [CreatedOn]) VALUES (N'a682b56a-6135-4111-a0k0-bdec547e3waz', N'Admin', N'ADMIN', N'da9a3b0e-8b6f-8529-71d0-4fd255e23f15', N'Has All Permissions', CAST(N'2020-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8ab6ee61-f36c-41b1-ae27-dbb23cbfb507', N'a682b56a-6135-4111-a0k0-bdec547e3waz')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'8ab6ee61-f36c-41b1-ae27-dbb23cbfb507', N'Admin', N'ADMIN', N'test@mail.com', N'TEST@MAIL.COM', 0, N'AQAAAAEAACcQAAAAEOJVsHUa611Khzkcg/zXgZ8EeegKhZAyW2eVPMzWJiToPuR45aBwuID99TNJ91JPxg==', N'5TDMS5CNA2GYJK2URB4GDOCQI2NI7EHJ', N'26d21881-0a3a-44ab-aa4d-10664ace1e2d', NULL, 0, 0, NULL, 0, 0)
SET IDENTITY_INSERT [dbo].[Campaigns] ON 

INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (7, N'Trial Campaign', 30000, 540, 0, 460, 4, CAST(N'2021-07-19T06:26:47.4723363' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'Nil')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (8, N'Campaign-1', 100000, 1800, 0, 880, 4, CAST(N'2021-07-19T06:39:38.0218686' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'Nil')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (9, N'Campaign-2', 100000, 1800, 0, 1150, 4, CAST(N'2021-07-19T07:12:43.5814217' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'Nil')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (10, N'Campaign-3', 100000, 1300, 0, 1500, 4, CAST(N'2021-07-19T07:23:39.7627573' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'Nil')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (11, N'Campaign 4', 100000, 1300, 0, 1372, 4, CAST(N'2021-07-19T07:34:48.2616403' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'Nil')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (12, N'Trial Campaign', 30000, 540, 0, 670, 1, CAST(N'2021-07-19T08:11:08.4514116' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'Nil')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (13, N'Campaign-1', 100000, 1800, 0, 1479, 1, CAST(N'2021-07-19T08:51:16.8209702' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'NIL')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (14, N'Trial Campaign', 30000, 500, 0, 510, 2, CAST(N'2021-07-23T23:28:16.3079098' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'NIL')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (15, N'Trial Campaign', 30000, 540, 620, 0, 10, CAST(N'2021-07-23T23:34:03.4547470' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'NIL')
INSERT [dbo].[Campaigns] ([Id], [Title], [TargetImpression], [TotalBudget], [TotalLinkClicked], [TotalFollowerIncreament], [ClientId], [CreationDate], [FinishingDate], [Remarks], [Status], [BitlyLink]) VALUES (16, N'Trial Campaign', 30000, 540, 176, 142, 6, CAST(N'2021-07-23T23:42:14.6945989' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), NULL, 1, N'NIL')
SET IDENTITY_INSERT [dbo].[Campaigns] OFF
SET IDENTITY_INSERT [dbo].[Catagories] ON 

INSERT [dbo].[Catagories] ([Id], [Name], [Status]) VALUES (1, N'BGM PAGE', 0)
INSERT [dbo].[Catagories] ([Id], [Name], [Status]) VALUES (2, N'Entertainment Page', 1)
INSERT [dbo].[Catagories] ([Id], [Name], [Status]) VALUES (3, N'BGM Page', 1)
INSERT [dbo].[Catagories] ([Id], [Name], [Status]) VALUES (4, N'Troll Page', 1)
INSERT [dbo].[Catagories] ([Id], [Name], [Status]) VALUES (5, N'Story teller', 1)
INSERT [dbo].[Catagories] ([Id], [Name], [Status]) VALUES (6, N'Travel Pages', 1)
INSERT [dbo].[Catagories] ([Id], [Name], [Status]) VALUES (7, N'Riders Page', 1)
SET IDENTITY_INSERT [dbo].[Catagories] OFF
SET IDENTITY_INSERT [dbo].[Clients] ON 

INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (1, N'StartStreaming', N'0', N'https://www.instagram.com/start_streaming/', N'Nil', 1, CAST(N'2021-07-10T20:12:30.0952111' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (2, N'GiftHubKerala', N'0', N'https://www.instagram.com/start_streaming/', N'Nil', 1, CAST(N'2021-07-10T20:16:00.2649868' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (3, N'Autoaid', N'O', N'https://instagram.com/autoaidindia?utm_medium=copy_link', N'Nil', 1, CAST(N'2021-07-18T00:10:38.3055954' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (4, N'Case stories ', N'O', N'https://instagram.com/casestoriez?utm_medium=copy_link', N'Nil', 1, CAST(N'2021-07-18T00:11:12.3936517' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (5, N'English Mithra', N'0', N'https://instagram.com/englishmithraofficial?utm_medium=copy_link', N'Nil', 1, CAST(N'2021-07-18T00:12:17.1291156' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (6, N'Cardamom', N'Nil', N'https://www.instagram.com/cardamomofficial_/', N'Nil', 1, CAST(N'2021-07-19T05:50:13.7083586' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (7, N'White Collar', N'Nil', N'https://www.instagram.com/whitecollar.co/', N'Nil', 1, CAST(N'2021-07-19T05:51:02.9322450' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (8, N'Nifty 50 Stocks', N'Nil', N'https://www.instagram.com/nifty_50_stocks/', N'Nil', 1, CAST(N'2021-07-19T05:51:57.8625987' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (9, N'The Incomet', N'Nil', N'https://www.instagram.com/theincomet/', N'Nil', 1, CAST(N'2021-07-19T05:52:49.8226840' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (10, N'Ace Money app', N'Nil', N'https://www.instagram.com/acemoney.in/', N'Nil', 1, CAST(N'2021-07-19T05:54:18.1497346' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (11, N'Step Coin', N'Nil', N'https://www.instagram.com/stepcoin_app/', N'Nil', 1, CAST(N'2021-07-19T05:55:11.8160990' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (12, N'Save Box', N'Nil', N'https://www.instagram.com/savebox.in/', N'Nil', 1, CAST(N'2021-07-19T05:56:04.5839794' AS DateTime2))
INSERT [dbo].[Clients] ([Id], [Name], [WANumber], [Link], [Email], [Status], [AddintionDate]) VALUES (13, N'FixDerma Skincare', N'Nil', N'https://www.instagram.com/fixderma.skincare/', N'Nil', 1, CAST(N'2021-07-19T05:58:23.9242193' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Clients] OFF
SET IDENTITY_INSERT [dbo].[Posts] ON 

INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (12, N'Case Stories Trial', 2, 29, 7, 0, 21784, 21784, N'effective', N'Good', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (13, N'Case Stories Trial', 3, 35, 7, 11387, 1989, 13376, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (14, N'Case Stories Trial', 1, 34, 7, 6500, 0, 6500, N'ok', N'ok', 80)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (15, N'CaseStories-1', 1, 12, 8, 40982, 0, 40982, N'ok', N'ok', 150)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (16, N'CaseStories-1', 3, 28, 8, 23614, 3683, 27297, N'ok', N'ok', 180)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (17, N'CaseStories-1', 2, 20, 8, 0, 17173, 17173, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (18, N'CaseStories-1', 2, 16, 8, 0, 20556, 20556, N'ok', N'ok', 150)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (19, N'CaseStories-1', 2, 27, 8, 0, 7091, 7091, N'ok', N'ok', 50)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (20, N'CaseStories-1', 2, 21, 8, 0, 17969, 17969, N'ok', N'ok', 200)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (21, N'Case stories-2', 3, 15, 9, 51202, 16683, 67885, N'ok', N'ok', 350)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (22, N'Case stories-2', 3, 14, 9, 11310, 17800, 29110, N'ok', N'ok', 300)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (23, N'Case stories-2', 2, 22, 9, 0, 24200, 24200, N'ok', N'ok', 200)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (24, N'Case stories-2', 3, 30, 9, 3455, 3623, 7078, N'ok', N'ok', 60)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (25, N'Case Stories-3', 3, 20, 10, 14768, 9509, 24277, N'ok', N'ok', 300)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (26, N'Case Stories-3', 3, 13, 10, 8814, 11054, 19868, N'ok', N'ok', 250)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (27, N'Case Stories-3', 1, 29, 10, 13218, 0, 13218, N'ok', N'ok', 150)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (28, N'Case Stories-3', 3, 12, 10, 42525, 21900, 64425, N'ok', N'ok', 250)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (29, N'Case stories-4', 3, 14, 11, 9053, 10151, 19204, N'ok', N'ok', 300)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (30, N'Case stories-4', 2, 22, 11, 0, 25000, 25000, N'ok', N'ok', 200)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (31, N'Case stories-4', 3, 15, 11, 21083, 35100, 56183, N'ok', N'ok', 350)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (32, N'Case stories-4', 3, 31, 11, 4816, 3392, 8208, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (33, N'Case stories-4', 2, 37, 11, 0, 4171, 4171, N'ok', N'ok', 50)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (34, N'Start Streaming trial', 2, 29, 12, 0, 15100, 15100, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (35, N'Start Streaming trial', 1, 28, 12, 10259, 0, 10259, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (36, N'Start Streaming trial', 3, 31, 12, 6359, 3526, 9885, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (37, N'StartStreaming-1', 3, 12, 13, 27794, 21300, 49094, N'ok', N'ok', 250)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (38, N'StartStreaming-1', 2, 22, 13, 0, 28500, 28500, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (39, N'StartStreaming-1', 3, 19, 13, 13031, 5994, 19025, N'ok', N'ok', 250)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (40, N'StartStreaming-1', 2, 17, 13, 0, 18800, 18800, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (41, N'StartStreaming-1', 2, 18, 13, 0, 12089, 12089, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (42, N'Gifthubkeralatrial', 3, 29, 14, 7532, 19323, 26855, N'ok', N'ok', 250)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (43, N'Gifthubkeralatrial', 2, 18, 14, 0, 14574, 14574, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (44, N'Acemoney trial campaign', 2, 12, 15, 0, 18500, 18500, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (45, N'Acemoney trial campaign', 2, 29, 15, 0, 17100, 17100, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (46, N'cardamom trial', 2, 29, 16, 0, 11111, 11111, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (47, N'cardamom trial', 2, 18, 16, 0, 12200, 12200, N'ok', N'ok', 100)
INSERT [dbo].[Posts] ([Id], [Name], [PostTypeId], [AffiliateId], [CampaignId], [PostReached], [StoryViewed], [ImpressionGenerated], [ReactionGenerated], [CommentsGenerated], [PaidAmount]) VALUES (48, N'cardamom trial', 3, 28, 16, 7832, 5564, 13396, N'ok', N'ok', 110)
SET IDENTITY_INSERT [dbo].[Posts] OFF
SET IDENTITY_INSERT [dbo].[PostTypes] ON 

INSERT [dbo].[PostTypes] ([Id], [Name]) VALUES (1, N'Post Only')
INSERT [dbo].[PostTypes] ([Id], [Name]) VALUES (2, N'Story Only')
INSERT [dbo].[PostTypes] ([Id], [Name]) VALUES (3, N'Post + Story')
SET IDENTITY_INSERT [dbo].[PostTypes] OFF