USE [CADDB]
GO

/****** Object:  Table [dbo].[Plines]    Script Date: 2/15/2023 12:59:51 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Plines](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Layer] [varchar](50) NOT NULL,
	[Linetype] [varbinary](50) NULL,
	[Length] [real] NULL,
	[Coordinates] [varchar](max) NOT NULL,
	[IsClosed] [bit] NULL,
	[Created] [datetime] NULL,
	[Modified] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[Deleted] [datetime] NULL,
 CONSTRAINT [PK_Plines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


