USE [StudentRecords]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 18-Jun-23 6:48:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Age] [int] NULL,
 CONSTRAINT [pk_stid] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (1, N'Sheheryar', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (2, N'Hassan', 23)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (3, N'rayan khan', 28)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (4, N'yaseen', 20)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (5, N'jamali', 3)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (6, N'khabib', 34)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (7, N'zeeshan', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (8, N'ali', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (9, N'jawad', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (10, N'rehmat', 12)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (11, N'jawad2', 32)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (12, N'rayan2', 33)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (13, N'ahmed', 30)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (14, N'sarshar izhar', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (15, N'khan', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (16, N'hamza', 33)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (17, N'waheed', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (18, N'kamran', 22)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (19, N'furkan', 33)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (20, N'naveed', 33)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (21, N'kamal', 33)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (22, N'salman', 33)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (1004, N'rayan', 123)
GO
INSERT [dbo].[Student] ([Id], [Name], [Age]) VALUES (2004, N'hadi', 22)
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
