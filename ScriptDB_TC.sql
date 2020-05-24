USE [TrabajoDeCampo]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 24/05/2020 18:53:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Cod_Bitacora] [int] NOT NULL,
	[Cod_Usuario] [int] NOT NULL,
	[Cod_Evento] [tinyint] NOT NULL,
	[FechaEvento] [datetime] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Cod_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[Cod_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Cod_TipoCliente] [tinyint] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Cod_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[Cod_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Permiso] [varchar](100) NULL,
 CONSTRAINT [PK_permiso] PRIMARY KEY CLUSTERED 
(
	[Cod_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Cliente]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Cliente](
	[Cod_TipoCliente] [tinyint] IDENTITY(1,1) NOT NULL,
	[Detalle_TipoCliente] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoCliente] PRIMARY KEY CLUSTERED 
(
	[Cod_TipoCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipo_Usuario](
	[Cod_Tipo] [tinyint] IDENTITY(1,1) NOT NULL,
	[DescripcionTipo] [varchar](20) NULL,
 CONSTRAINT [PK_Tipo] PRIMARY KEY CLUSTERED 
(
	[Cod_Tipo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Cod_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](70) NOT NULL,
	[Mail] [varchar](70) NOT NULL,
	[Contraseña] [varchar](max) NULL,
	[Cod_Tipo] [tinyint] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Cod_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario_Cliente]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario_Cliente](
	[Cod_Usuario] [int] NOT NULL,
	[Cod_Cliente] [int] NOT NULL,
 CONSTRAINT [PK_UsuarioCliente] PRIMARY KEY CLUSTERED 
(
	[Cod_Usuario] ASC,
	[Cod_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([Cod_Usuario])
REFERENCES [dbo].[Usuario] ([Cod_Usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_TipoCliente] FOREIGN KEY([Cod_TipoCliente])
REFERENCES [dbo].[Tipo_Cliente] ([Cod_TipoCliente])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_TipoCliente]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_TipoUsuario] FOREIGN KEY([Cod_Tipo])
REFERENCES [dbo].[Tipo_Usuario] ([Cod_Tipo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_TipoUsuario]
GO
ALTER TABLE [dbo].[Usuario_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioCliente_Cliente] FOREIGN KEY([Cod_Cliente])
REFERENCES [dbo].[Cliente] ([Cod_Cliente])
GO
ALTER TABLE [dbo].[Usuario_Cliente] CHECK CONSTRAINT [FK_UsuarioCliente_Cliente]
GO
ALTER TABLE [dbo].[Usuario_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioCliente_Usuario] FOREIGN KEY([Cod_Usuario])
REFERENCES [dbo].[Usuario] ([Cod_Usuario])
GO
ALTER TABLE [dbo].[Usuario_Cliente] CHECK CONSTRAINT [FK_UsuarioCliente_Usuario]
GO
/****** Object:  StoredProcedure [dbo].[pr_Insertar_Usuario]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Insertar_Usuario]
@Nombre VARCHAR(70),
@Mail VARCHAR(70),
@Contraseña VARCHAR(MAX),
@Cod_Tipo TINYINT
AS

INSERT INTO dbo.USUARIO (Nombre, Mail, Contraseña, Cod_Tipo)
VALUES (@Nombre, @Mail, @Contraseña, 1)
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_Cliente]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_Cliente]
@Cod_Usuario INT
AS
SELECT u.Cod_Usuario, u.Nombre, u.Mail, u.Cod_Tipo, tu.DescripcionTipo, c.Cod_Cliente, tc.Cod_TipoCliente, tc.Detalle_TipoCliente
FROM dbo.Usuario u
	JOIN dbo.Tipo_Usuario tu ON u.Cod_Tipo = tu.Cod_Tipo
	JOIN dbo.Usuario_Cliente uc ON u.Cod_Usuario = uc.Cod_Usuario
	JOIN dbo.Cliente c ON uc.Cod_Cliente = c.Cod_Cliente
	JOIN dbo.Tipo_Cliente tc ON c.Cod_TipoCliente = tc.Cod_TipoCliente 
WHERE u.Cod_Usuario = @Cod_Usuario
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_UsuarioLogin]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_UsuarioLogin]
@Mail VARCHAR(70),
@Contraseña VARCHAR(MAX)
AS
SELECT u.Cod_Usuario, u.Nombre, u.Mail, Contraseña, u.Cod_Tipo, tu.DescripcionTipo
FROM dbo.Usuario u
	JOIN dbo.Tipo_Usuario tu ON u.Cod_Tipo = tu.Cod_Tipo
WHERE u.Mail = @Mail AND Contraseña = @Contraseña
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_UsuarioPorCod]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_UsuarioPorCod]
@Cod_Usuario INT
AS
SELECT u.Cod_Usuario, u.Nombre, u.Mail, Contraseña, u.Cod_Tipo, tu.DescripcionTipo
FROM dbo.Usuario u
	JOIN dbo.Tipo_Usuario tu ON u.Cod_Tipo = tu.Cod_Tipo
WHERE u.Cod_Usuario = @Cod_Usuario
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_UsuarioPorMail]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_UsuarioPorMail]
@Mail VARCHAR(70)
AS
SELECT u.Cod_Usuario, u.Nombre, u.Mail, Contraseña, u.Cod_Tipo, tu.DescripcionTipo
FROM dbo.Usuario u
	JOIN dbo.Tipo_Usuario tu ON u.Cod_Tipo = tu.Cod_Tipo
WHERE u.Mail = @Mail
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_Usuarios]    Script Date: 24/05/2020 18:54:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_Usuarios]
AS
SELECT u.Cod_Usuario, u.Nombre, u.Mail, Contraseña, u.Cod_Tipo, tu.DescripcionTipo
FROM dbo.Usuario u
	JOIN dbo.Tipo_Usuario tu ON u.Cod_Tipo = tu.Cod_Tipo
GO



USE [TrabajoDeCampo]
GO
SET IDENTITY_INSERT [dbo].[Tipo_Cliente] ON 
GO
INSERT [dbo].[Tipo_Cliente] ([Cod_TipoCliente], [Detalle_TipoCliente]) VALUES (1, N'STANDARD')
GO
INSERT [dbo].[Tipo_Cliente] ([Cod_TipoCliente], [Detalle_TipoCliente]) VALUES (2, N'PREMIUM')
GO
SET IDENTITY_INSERT [dbo].[Tipo_Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Cliente] ON 
GO
INSERT [dbo].[Cliente] ([Cod_Cliente], [Cod_TipoCliente]) VALUES (1, 2)
GO
INSERT [dbo].[Cliente] ([Cod_Cliente], [Cod_TipoCliente]) VALUES (2, 1)
GO
INSERT [dbo].[Cliente] ([Cod_Cliente], [Cod_TipoCliente]) VALUES (3, 2)
GO
INSERT [dbo].[Cliente] ([Cod_Cliente], [Cod_TipoCliente]) VALUES (4, 1)
GO
SET IDENTITY_INSERT [dbo].[Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Tipo_Usuario] ON 
GO
INSERT [dbo].[Tipo_Usuario] ([Cod_Tipo], [DescripcionTipo]) VALUES (1, N'Cliente')
GO
INSERT [dbo].[Tipo_Usuario] ([Cod_Tipo], [DescripcionTipo]) VALUES (2, N'Administrador')
GO
INSERT [dbo].[Tipo_Usuario] ([Cod_Tipo], [DescripcionTipo]) VALUES (3, N'Web Master')
GO
SET IDENTITY_INSERT [dbo].[Tipo_Usuario] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 
GO
INSERT [dbo].[Usuario] ([Cod_Usuario], [Nombre], [Mail], [Contraseña], [Cod_Tipo]) VALUES (1, N'Ariel', N'ariel@mail.com', N'Admin123123', 2)
GO
INSERT [dbo].[Usuario] ([Cod_Usuario], [Nombre], [Mail], [Contraseña], [Cod_Tipo]) VALUES (2, N'Carlos', N'carlos@mail.com', N'Cliente123123', 1)
GO
INSERT [dbo].[Usuario] ([Cod_Usuario], [Nombre], [Mail], [Contraseña], [Cod_Tipo]) VALUES (3, N'Ezequiel', N'ezequiel@mail.com', N'WebMaster123123', 3)
GO
INSERT [dbo].[Usuario] ([Cod_Usuario], [Nombre], [Mail], [Contraseña], [Cod_Tipo]) VALUES (4, N'Florencia', N'florencia@mail.com', N'Cliente123123', 1)
GO
INSERT [dbo].[Usuario] ([Cod_Usuario], [Nombre], [Mail], [Contraseña], [Cod_Tipo]) VALUES (5, N'Fede', N'fede@mail.com', N'Admin123123', 2)
GO
INSERT [dbo].[Usuario] ([Cod_Usuario], [Nombre], [Mail], [Contraseña], [Cod_Tipo]) VALUES (6, N'ClientePremium', N'clientepre@mail.com', N'Cliente123123', 1)
GO
INSERT [dbo].[Usuario] ([Cod_Usuario], [Nombre], [Mail], [Contraseña], [Cod_Tipo]) VALUES (7, N'ClienteStandard', N'clientestand@mail.com', N'Cliente123123', 1)
GO
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
INSERT [dbo].[Usuario_Cliente] ([Cod_Usuario], [Cod_Cliente]) VALUES (2, 1)
GO
INSERT [dbo].[Usuario_Cliente] ([Cod_Usuario], [Cod_Cliente]) VALUES (4, 2)
GO
INSERT [dbo].[Usuario_Cliente] ([Cod_Usuario], [Cod_Cliente]) VALUES (6, 3)
GO
INSERT [dbo].[Usuario_Cliente] ([Cod_Usuario], [Cod_Cliente]) VALUES (7, 4)
GO
