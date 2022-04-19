﻿USE [TestDb]
GO

/****** Object:  Table [dbo].[USER]    Script Date: 4/19/2022 4:36:35 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[USER](
	[USER_ID] [int] IDENTITY(1,1) NOT NULL,
	[FIRST_NAME] [varchar](50) NOT NULL,
	[SECOND_NAME] [varchar](50) NULL,
	[BIRTHDAY] [date] NOT NULL,
	[ROLE_ID] [int] NULL,
	[EMAIL] [varchar](50) NOT NULL,
	[CELLPHONE] [varchar](40) NULL,
	[FIRST_SURNAME] [varchar](50) NOT NULL,
	[SECOND_SURNAME] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[USER_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


