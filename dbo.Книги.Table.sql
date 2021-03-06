USE [Экзамен-ПМ.01-Пекин]
GO
/****** Object:  Table [dbo].[Книги]    Script Date: 18.04.2022 10:29:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Книги](
	[КодКниги] [int] IDENTITY(1,1) NOT NULL,
	[Название] [varchar](50) NULL,
	[Жанр] [varchar](50) NULL,
	[Автор] [varchar](50) NULL,
	[КоличествоВМагазине] [int] NULL,
	[КоличествоНаСкладе] [int] NULL,
	[Описание] [nvarchar](max) NULL,
	[Обложка] [varchar](50) NULL,
 CONSTRAINT [PK_Книги] PRIMARY KEY CLUSTERED 
(
	[КодКниги] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
