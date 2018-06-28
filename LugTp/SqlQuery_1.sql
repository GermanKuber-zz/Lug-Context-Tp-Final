USE PEPE
GO
/****** Object:  User [idargentina]    Script Date: 06/28/2018 01:12:03 ******/
CREATE USER [idargentina] FOR LOGIN [idargentina] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Personas]    Script Date: 06/28/2018 01:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Apellido] [nvarchar](50) NULL,
	[Direccion] [nvarchar](50) NULL,
	[Telefono] [nvarchar](50) NULL,
	[Cargo] [nvarchar](50) NULL,
	[Profesion] [nvarchar](50) NULL,
	[Legajo] [nvarchar](50) NULL,
	[CuotaAlDia] [bit] NULL,
	[Descriminator] [nvarchar](50) NULL,
 CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personas] ON
INSERT [dbo].[Personas] ([Id], [Nombre], [Apellido], [Direccion], [Telefono], [Cargo], [Profesion], [Legajo], [CuotaAlDia], [Descriminator]) VALUES (102, N'PrimeR docente', N'Docente con apellido', N'Alguna ', N'111', N'Adjunto', N'Profesor claro', NULL, NULL, N'Docente')
INSERT [dbo].[Personas] ([Id], [Nombre], [Apellido], [Direccion], [Telefono], [Cargo], [Profesion], [Legajo], [CuotaAlDia], [Descriminator]) VALUES (103, N'Segundo docente', N'Docente con apellido', N'Alguna ', N'111', N'Titular', N'Profesor claro', NULL, NULL, N'Docente')
INSERT [dbo].[Personas] ([Id], [Nombre], [Apellido], [Direccion], [Telefono], [Cargo], [Profesion], [Legajo], [CuotaAlDia], [Descriminator]) VALUES (105, N'Pepe', N'Juan', N'Alguna', N'11', NULL, NULL, N'2222', 0, N'Alumno')
SET IDENTITY_INSERT [dbo].[Personas] OFF
/****** Object:  Table [dbo].[Cursos]    Script Date: 06/28/2018 01:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Duracion] [int] NULL,
	[Docente_Id] [int] NOT NULL,
 CONSTRAINT [PK_Cursos_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cursos] ON
INSERT [dbo].[Cursos] ([Id], [Nombre], [Duracion], [Docente_Id]) VALUES (17, N'MateamticaR', 8, 103)
INSERT [dbo].[Cursos] ([Id], [Nombre], [Duracion], [Docente_Id]) VALUES (20, N'FIsica', 8, 103)
INSERT [dbo].[Cursos] ([Id], [Nombre], [Duracion], [Docente_Id]) VALUES (21, N'LUG', 19, 103)
SET IDENTITY_INSERT [dbo].[Cursos] OFF
/****** Object:  Table [dbo].[Curso_Alumno]    Script Date: 06/28/2018 01:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso_Alumno](
	[Alumno_Id] [int] NOT NULL,
	[Curso_Id] [int] NOT NULL,
 CONSTRAINT [PK_Curso_Alumno] PRIMARY KEY CLUSTERED 
(
	[Alumno_Id] ASC,
	[Curso_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Curso_Alumno] ([Alumno_Id], [Curso_Id]) VALUES (105, 17)
INSERT [dbo].[Curso_Alumno] ([Alumno_Id], [Curso_Id]) VALUES (105, 20)
/****** Object:  Table [dbo].[Unidades]    Script Date: 06/28/2018 01:12:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unidades](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tema] [nvarchar](50) NULL,
	[Descripcion] [nvarchar](50) NULL,
	[Curso_Id] [int] NULL,
 CONSTRAINT [PK_Unidad] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Unidades] ON
INSERT [dbo].[Unidades] ([Id], [Tema], [Descripcion], [Curso_Id]) VALUES (1, N'Execeptions', N'Descripcion', 21)
INSERT [dbo].[Unidades] ([Id], [Tema], [Descripcion], [Curso_Id]) VALUES (2, N'Files', NULL, 21)
SET IDENTITY_INSERT [dbo].[Unidades] OFF
/****** Object:  ForeignKey [FK_Unidades_Cursos]    Script Date: 06/28/2018 01:12:03 ******/
ALTER TABLE [dbo].[Unidades]  WITH CHECK ADD  CONSTRAINT [FK_Unidades_Cursos] FOREIGN KEY([Curso_Id])
REFERENCES [dbo].[Cursos] ([Id])
GO
ALTER TABLE [dbo].[Unidades] CHECK CONSTRAINT [FK_Unidades_Cursos]
GO
/****** Object:  ForeignKey [FK_Cursos_Personas]    Script Date: 06/28/2018 01:12:03 ******/
ALTER TABLE [dbo].[Cursos]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Personas] FOREIGN KEY([Docente_Id])
REFERENCES [dbo].[Personas] ([Id])
GO
ALTER TABLE [dbo].[Cursos] CHECK CONSTRAINT [FK_Cursos_Personas]
GO
/****** Object:  ForeignKey [FK_Curso_Alumno_Personas]    Script Date: 06/28/2018 01:12:03 ******/
ALTER TABLE [dbo].[Curso_Alumno]  WITH CHECK ADD  CONSTRAINT [FK_Curso_Alumno_Personas] FOREIGN KEY([Alumno_Id])
REFERENCES [dbo].[Personas] ([Id])
GO
ALTER TABLE [dbo].[Curso_Alumno] CHECK CONSTRAINT [FK_Curso_Alumno_Personas]
GO
