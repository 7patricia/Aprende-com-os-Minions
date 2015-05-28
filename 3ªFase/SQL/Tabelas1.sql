USE [master]
GO

/****** Object:  Table [dbo].[Teste]    Script Date: 28/05/2015 11:46:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Teste](
	[id] [nchar](10) NOT NULL,
	[DataRealizacao] [datetime] NOT NULL,
	[Tema] [varchar](50) NOT NULL
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

