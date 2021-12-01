USE [LoanCalculator]
GO
/****** Object:  Table [dbo].[LoanHistory]    Script Date: 12/1/2021 13:12:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoanHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 4) NOT NULL,
	[PropertyValue] [decimal](18, 4) NOT NULL,
	[Result] [decimal](18, 4) NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_LoanHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
