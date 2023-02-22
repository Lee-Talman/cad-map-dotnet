USE [CADDB]
GO

/****** Object:  Table [dbo].[BlocksWithAttributes]    Script Date: 2/22/2023 10:44:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[BlocksWithAttributes](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[InsPtX] [decimal](18, 8) NOT NULL,
	[InsPtY] [decimal](18, 8) NOT NULL,
	[BlockName] [varchar](50) NULL,
	[ExtX] [decimal](18, 8) NULL,
	[ExtY] [decimal](18, 8) NULL,
	[Layer] [varchar](50) NULL,
	[Rotation] [real] NULL,
	[Attributes] [varchar](max) NULL,
	[Created] [datetime] NULL,
	[Modified] [datetime] NULL,
	[IsDeleted] [bit] NULL,
	[Deleted] [datetime] NULL,
 CONSTRAINT [PK_BlocksWithAttributes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


