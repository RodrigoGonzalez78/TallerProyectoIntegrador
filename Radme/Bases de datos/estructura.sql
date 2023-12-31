create database [classroom_manager]

go

USE [classroom_manager]
GO
/****** Object:  Table [dbo].[aula]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aula](
	[id_aula] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[capacidad] [int] NOT NULL,
	[id_ubicacion] [int] NOT NULL,
	[id_tipo] [int] NOT NULL,
	[activa] [varchar](2) NOT NULL,
	[cantComputadoras] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[aula_equipamiento]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[aula_equipamiento](
	[id_aula] [int] NOT NULL,
	[id_equipamiento] [int] NOT NULL,
	[disponible] [varchar](2) NOT NULL,
 CONSTRAINT [PKaula_equipamiento] PRIMARY KEY CLUSTERED 
(
	[id_aula] ASC,
	[id_equipamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[dias_semana]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dias_semana](
	[id_dias] [int] NOT NULL,
	[dias] [varchar](30) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_dias] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[equipamiento]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[equipamiento](
	[id_equipamiento] [int] IDENTITY(1,1) NOT NULL,
	[recurso] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_equipamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[horas]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[horas](
	[id_hora] [int] NOT NULL,
	[horario] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_hora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[materias]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[materias](
	[id_materia] [int] IDENTITY(1,1) NOT NULL,
	[materia] [varchar](30) NOT NULL,
	[activo] [varchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_materia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periodo](
	[id_periodo] [int] IDENTITY(1,1) NOT NULL,
	[periodo_nombre] [varchar](20) NOT NULL,
	[fecha_desde] [datetime] NOT NULL,
	[fecha_hasta] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_periodo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reserva]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reserva](
	[id_reserva] [int] IDENTITY(1,1) NOT NULL,
	[id_hora] [int] NOT NULL,
	[id_usuario] [int] NOT NULL,
	[id_aula] [int] NOT NULL,
	[id_dia] [int] NOT NULL,
	[id_materia] [int] NOT NULL,
	[activo] [varchar](2) NOT NULL,
	[id_periodo] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_reserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoSala]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoSala](
	[id_sala] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_sala] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tipoUsuario]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tipoUsuario](
	[id_tipoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ubicacion]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ubicacion](
	[id_ubicacion] [int] IDENTITY(1,1) NOT NULL,
	[lugar] [varchar](20) NOT NULL,
	[activo] [varchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_ubicacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 16/11/2023 0:54:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[dni] [int] NOT NULL,
	[nombre] [varchar](20) NOT NULL,
	[apellido] [varchar](20) NOT NULL,
	[correo] [varchar](50) NOT NULL,
	[id_tipoUsuario] [int] NOT NULL,
	[desactivar] [varchar](2) NOT NULL,
	[password] [varchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[correo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[aula] ADD  DEFAULT ('NO') FOR [activa]
GO
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [DF_usuario_desactivar]  DEFAULT ('NO') FOR [desactivar]
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_tipo])
REFERENCES [dbo].[tipoSala] ([id_sala])
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_ubicacion])
REFERENCES [dbo].[ubicacion] ([id_ubicacion])
GO
ALTER TABLE [dbo].[aula]  WITH CHECK ADD FOREIGN KEY([id_ubicacion])
REFERENCES [dbo].[ubicacion] ([id_ubicacion])
GO
ALTER TABLE [dbo].[aula_equipamiento]  WITH CHECK ADD  CONSTRAINT [fk_aula] FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[aula_equipamiento] CHECK CONSTRAINT [fk_aula]
GO
ALTER TABLE [dbo].[aula_equipamiento]  WITH CHECK ADD  CONSTRAINT [fk_equipamiento] FOREIGN KEY([id_equipamiento])
REFERENCES [dbo].[equipamiento] ([id_equipamiento])
GO
ALTER TABLE [dbo].[aula_equipamiento] CHECK CONSTRAINT [fk_equipamiento]
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_aula])
REFERENCES [dbo].[aula] ([id_aula])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_dia])
REFERENCES [dbo].[dias_semana] ([id_dias])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_hora])
REFERENCES [dbo].[horas] ([id_hora])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_materia])
REFERENCES [dbo].[materias] ([id_materia])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuario] ([id_usuario])
GO
ALTER TABLE [dbo].[reserva]  WITH CHECK ADD  CONSTRAINT [reserva_FK_id_periodo] FOREIGN KEY([id_periodo])
REFERENCES [dbo].[Periodo] ([id_periodo])
GO
ALTER TABLE [dbo].[reserva] CHECK CONSTRAINT [reserva_FK_id_periodo]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD FOREIGN KEY([id_tipoUsuario])
REFERENCES [dbo].[tipoUsuario] ([id_tipoUsuario])
GO
