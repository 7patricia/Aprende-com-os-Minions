USE [master]
GO

/****** Object:  Table [dbo].[Utilizador]    Script Date: 28/05/2015 11:24:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Utilizador](
	[id] [int] NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[NrRespostasCertas] [int] NULL,
	[NrRespostasErradas] [int] NULL,
	[NrSessoesEstudo] [int] NULL,
	[NrTestesRealizados] [int] NULL,
	[GrauDificuldade] [int] NOT NULL,
	[Tamanho Letra] [int] NOT NULL,
 CONSTRAINT [PK_Utilizador] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Utilizador]  WITH CHECK ADD  CONSTRAINT [Administrador] FOREIGN KEY([id])
REFERENCES [dbo].[Utilizador] ([id])
GO

ALTER TABLE [dbo].[Utilizador] CHECK CONSTRAINT [Administrador]
GO


SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


/****** Object:  Table [dbo].[Teste]*/
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



