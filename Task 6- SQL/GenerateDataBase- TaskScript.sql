USE [Internship]
GO
/****** Object:  UserDefinedFunction [dbo].[GetCompany]    Script Date: 7/22/2020 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[GetCompany] (@url VARCHAR(250))
RETURNS VARCHAR(250)
AS BEGIN
    DECLARE @Work VARCHAR(250)

    SET @Work = @url

    SET @Work = REPLACE(@Work, 'www.', '')
    SET @Work = REPLACE(@Work, '.com', '')

    RETURN @work
END
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 7/22/2020 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[MiddleName] [nvarchar](50) NULL,
	[LastName] [varchar](100) NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Gender] [bit] NULL,
	[EmailAddress] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Holiday]    Script Date: 7/22/2020 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Holiday](
	[HolidayId] [int] IDENTITY(1,1) NOT NULL,
	[HolidayStartDate] [date] NOT NULL,
	[HolidayEndDate] [date] NOT NULL,
	[EmployeeId] [int] NOT NULL,
	[CountryId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HolidayId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[EmployeeHolidays2019]    Script Date: 7/22/2020 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[EmployeeHolidays2019] AS
SELECT e.[EmployeeId], ([FirstName] + ' ' + [LastName]) as [Name]
FROM [dbo].[Employee] AS e
INNER JOIN [dbo].[Holiday] AS h
	on e.[EmployeeId] = h.[EmployeeId]
WHERE [HolidayStartDate] BETWEEN '1/1/2019' AND '12/31/2019'
GO
/****** Object:  Table [dbo].[Country]    Script Date: 7/22/2020 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [varchar](255) NULL,
	[RiskId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmpTest]    Script Date: 7/22/2020 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmpTest](
	[EmpId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NULL,
 CONSTRAINT [PK_EmpTest] PRIMARY KEY CLUSTERED 
(
	[EmpId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Country] ON 
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (1, N'Romania', 1)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (2, N'England', 2)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (3, N'Italy', 3)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (4, N'Spain', 2)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (5, N'USA', 1)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (6, N'India', 1)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (7, N'Russia', 1)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (8, N'Brasil', 1)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (9, N'France', 3)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (10, N'Germany', 3)
GO
INSERT [dbo].[Country] ([CountryId], [CountryName], [RiskId]) VALUES (11, N'Belgium', 3)
GO
SET IDENTITY_INSERT [dbo].[Country] OFF
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (1, N'Alexandru', N'A', N'Grigoras', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'alexandru.grigoras@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (2, N'Andrei', N'B', N'Stefan', CAST(N'1999-02-02T00:00:00.000' AS DateTime), 1, N'andrei.stefan@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (3, N'Ioan', N'C', N'Tugui', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'ioan.tugui@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (4, N'Sebastian', N'D', N'Herciu', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'sebastian.herciu@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (5, N'Lucian ', N'E', N' Livint', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'lucian.livint@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (6, N' Bogdan', N'F', N' Ciubotaru', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'bogdan.ciubotaru@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (7, N'Marian ', N'G', N' Noroc', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'marian.noroc@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (8, N' Alexandru', N'H', N' Agape', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'alexandru.agape@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (9, N'Stefan ', N'I', N' Tugui', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'stefan.tugui@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (10, N' Sergiu', N'J', N' Radeanu', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'sergiu.radeanu@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (11, N' Cristian', N'K', N' Chircan', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'cristian.chircan@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (12, N' Camelia', N'L', N' Onu', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'camelia.onu@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (13, N' Adriana', N'M', N'Plecan ', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'adriana.plecan@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (14, N' Ioana', N'N', N' Iftimie', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'ioana.iftimie@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (15, N' Alina', N'O', N' Costea', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'alina.costea@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (17, N'Intern1', N'Ion', N'Dorel', CAST(N'1999-01-01T00:00:00.000' AS DateTime), 1, N'dorel@endava.com')
GO
INSERT [dbo].[Employee] ([EmployeeId], [FirstName], [MiddleName], [LastName], [DateOfBirth], [Gender], [EmailAddress]) VALUES (18, N'Monica', N'H', N'Popescu', CAST(N'1998-12-12T00:00:00.000' AS DateTime), 0, N'monica@endava.com')
GO
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[EmpTest] ON 
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (1, N'Grigoras')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (2, N'Stefan')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (3, N'Tugui')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (4, N'Herciu')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (5, N' Livint')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (6, N' Ciubotaru')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (7, N' Noroc')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (8, N' Agape')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (9, N' Tugui')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (10, N' Radeanu')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (11, N' Chircan')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (12, N' Onu')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (13, N'Plecan ')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (14, N' Iftimie')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (15, N' Costea')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (16, N'Dorel')
GO
INSERT [dbo].[EmpTest] ([EmpId], [Name]) VALUES (17, N'Popescu')
GO
SET IDENTITY_INSERT [dbo].[EmpTest] OFF
GO
SET IDENTITY_INSERT [dbo].[Holiday] ON 
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (1, CAST(N'2018-01-01' AS Date), CAST(N'2018-01-10' AS Date), 1, 2)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (2, CAST(N'2019-01-31' AS Date), CAST(N'2019-02-05' AS Date), 2, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (3, CAST(N'2019-01-31' AS Date), CAST(N'2019-02-07' AS Date), 3, 5)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (4, CAST(N'2020-01-31' AS Date), CAST(N'2020-02-07' AS Date), 4, 7)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (5, CAST(N'2020-02-15' AS Date), CAST(N'2020-02-22' AS Date), 5, 9)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (6, CAST(N'2017-01-31' AS Date), CAST(N'2017-02-05' AS Date), 6, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (7, CAST(N'2016-01-31' AS Date), CAST(N'2016-02-07' AS Date), 7, 9)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (8, CAST(N'2020-03-01' AS Date), CAST(N'2020-03-08' AS Date), 8, 10)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (9, CAST(N'2020-02-15' AS Date), CAST(N'2020-02-22' AS Date), 9, 11)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (10, CAST(N'2018-01-01' AS Date), CAST(N'2018-01-10' AS Date), 8, 2)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (11, CAST(N'2019-01-31' AS Date), CAST(N'2019-02-05' AS Date), 9, 3)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (12, CAST(N'2019-01-31' AS Date), CAST(N'2019-02-07' AS Date), 10, 2)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (13, CAST(N'2020-01-31' AS Date), CAST(N'2020-02-07' AS Date), 11, 9)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (14, CAST(N'2020-05-15' AS Date), CAST(N'2020-05-22' AS Date), 5, 10)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (15, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 2, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (16, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 3, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (17, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 4, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (18, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 5, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (19, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 6, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (20, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 7, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (21, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 8, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (22, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 9, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (23, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 10, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (24, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 11, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (25, CAST(N'2013-08-25' AS Date), CAST(N'2013-08-29' AS Date), 12, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (26, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 2, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (27, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 3, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (28, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 4, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (29, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 5, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (30, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 6, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (31, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 7, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (32, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 8, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (33, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 9, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (34, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 10, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (35, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 11, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (36, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 12, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (37, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 2, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (38, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 3, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (39, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 4, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (40, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 5, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (41, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 6, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (42, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 7, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (43, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 8, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (44, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 9, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (45, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 10, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (46, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 11, 1)
GO
INSERT [dbo].[Holiday] ([HolidayId], [HolidayStartDate], [HolidayEndDate], [EmployeeId], [CountryId]) VALUES (47, CAST(N'2015-08-25' AS Date), CAST(N'2015-08-29' AS Date), 12, 1)
GO
SET IDENTITY_INSERT [dbo].[Holiday] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__49A147407BC5C0BC]    Script Date: 7/22/2020 11:12:32 AM ******/
ALTER TABLE [dbo].[Employee] ADD UNIQUE NONCLUSTERED 
(
	[EmailAddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_Gender]  DEFAULT ((1)) FOR [Gender]
GO
ALTER TABLE [dbo].[Holiday] ADD  DEFAULT (getdate()) FOR [HolidayStartDate]
GO
ALTER TABLE [dbo].[Holiday] ADD  DEFAULT (getdate()) FOR [HolidayEndDate]
GO
ALTER TABLE [dbo].[Holiday]  WITH CHECK ADD FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
ALTER TABLE [dbo].[Holiday]  WITH CHECK ADD FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employee] ([EmployeeId])
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [Risk_Ck] CHECK  (([RiskId]>=(0) AND [RiskId]<=(100)))
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [Risk_Ck]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeWithHolidays]    Script Date: 7/22/2020 11:12:32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetEmployeeWithHolidays]
	@Year int
AS
BEGIN
	DECLARE @i INT = 1
	WHILE(@i < 12)
	BEGIN
		SET @i = @i +1;
		INSERT INTO [dbo].[Holiday]([HolidayStartDate],[HolidayEndDate],[EmployeeId], [CountryId])
		VALUES (DATEADD(year, 1, '2014/08/25'), DATEADD(year, 1, '2014/08/29'),@i, 1)

	END

	SELECT
		(e.[FirstName] + ' ' + e.[LastName]) as [Name],	h.[HolidayStartDate]
	FROM [dbo].[Employee] AS e
	INNER JOIN [dbo].[Holiday] AS h ON e.[EmployeeId] = h.[EmployeeId]
	INNER JOIN [dbo].Country AS c ON h.[CountryId] = c.[CountryId]
	WHERE year([HolidayStartDate]) = @year 
	GROUP BY h.EmployeeId, h.[HolidayStartDate], e.[FirstName],e.[LastName]
	HAVING COUNT(*) > 1
	ORDER BY h.[HolidayStartDate] ASC
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 - High; 2 - Medium; 3 - Low' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Country', @level2type=N'COLUMN',@level2name=N'CountryId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1=High, 2=Medium, 3=Low' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Country', @level2type=N'COLUMN',@level2name=N'RiskId'
GO
