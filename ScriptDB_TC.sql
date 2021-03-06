USE [TrabajoDeCampo]
GO
USE [TrabajoDeCampo]
GO
/****** Object:  Table [dbo].[Bitacora]    Script Date: 25/05/2020 17:18:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bitacora](
	[Cod_Bitacora] [int] IDENTITY(1,1) NOT NULL,
	[Cod_Usuario] [int] NOT NULL,
	[Cod_Evento] [tinyint] NOT NULL,
	[FechaEvento] [datetime] NOT NULL,
 CONSTRAINT [PK_Bitacora] PRIMARY KEY CLUSTERED 
(
	[Cod_Bitacora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso]    Script Date: 25/05/2020 17:18:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso](
	[Cod_Permiso] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
 CONSTRAINT [PK_permiso] PRIMARY KEY CLUSTERED 
(
	[Cod_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permiso_Permiso]    Script Date: 25/05/2020 17:18:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permiso_Permiso](
	[Cod_Permiso_Padre] [int] NULL,
	[Cod_Permiso_Hijo] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipo_Usuario]    Script Date: 25/05/2020 17:18:43 ******/
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
/****** Object:  Table [dbo].[Usuario]    Script Date: 25/05/2020 17:18:43 ******/
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
/****** Object:  Table [dbo].[Usuarios_Permisos]    Script Date: 25/05/2020 17:18:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios_Permisos](
	[Cod_TipoUsuario] [tinyint] NOT NULL,
	[Cod_Permiso] [int] NOT NULL,
 CONSTRAINT [PK_usuarios_permisos] PRIMARY KEY CLUSTERED 
(
	[Cod_TipoUsuario] ASC,
	[Cod_Permiso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bitacora]  WITH CHECK ADD  CONSTRAINT [FK_Bitacora_Usuario] FOREIGN KEY([Cod_Usuario])
REFERENCES [dbo].[Usuario] ([Cod_Usuario])
GO
ALTER TABLE [dbo].[Bitacora] CHECK CONSTRAINT [FK_Bitacora_Usuario]
GO
ALTER TABLE [dbo].[Permiso_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Permiso_Permiso] FOREIGN KEY([Cod_Permiso_Padre])
REFERENCES [dbo].[Permiso] ([Cod_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Permiso] CHECK CONSTRAINT [FK_Permiso_Permiso_Permiso]
GO
ALTER TABLE [dbo].[Permiso_Permiso]  WITH CHECK ADD  CONSTRAINT [FK_Permiso_Permiso_Permiso1] FOREIGN KEY([Cod_Permiso_Hijo])
REFERENCES [dbo].[Permiso] ([Cod_Permiso])
GO
ALTER TABLE [dbo].[Permiso_Permiso] CHECK CONSTRAINT [FK_Permiso_Permiso_Permiso1]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_TipoUsuario] FOREIGN KEY([Cod_Tipo])
REFERENCES [dbo].[Tipo_Usuario] ([Cod_Tipo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_TipoUsuario]
GO
ALTER TABLE [dbo].[Usuarios_Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Permisos_Permiso] FOREIGN KEY([Cod_Permiso])
REFERENCES [dbo].[Permiso] ([Cod_Permiso])
GO
ALTER TABLE [dbo].[Usuarios_Permisos] CHECK CONSTRAINT [FK_Usuarios_Permisos_Permiso]
GO
ALTER TABLE [dbo].[Usuarios_Permisos]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Permisos_Usuarios] FOREIGN KEY([Cod_TipoUsuario])
REFERENCES [dbo].[Tipo_Usuario] ([Cod_Tipo])
GO
ALTER TABLE [dbo].[Usuarios_Permisos] CHECK CONSTRAINT [FK_Usuarios_Permisos_Usuarios]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Insertar_Bitacora]
@Cod_Usuario INT,
@Cod_Evento TINYINT
AS

INSERT INTO dbo.Bitacora (Cod_Usuario,Cod_Evento,FechaEvento)
VALUES (@Cod_Usuario, @Cod_Evento, GETDATE())
GO
/****** Object:  StoredProcedure [dbo].[pr_Insertar_Permiso]    Script Date: 25/05/2020 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Insertar_Permiso]
@Nombre VARCHAR(100)
AS

INSERT INTO dbo.Permiso(Nombre) VALUES (@Nombre)
GO
/****** Object:  StoredProcedure [dbo].[pr_Insertar_Usuario]    Script Date: 25/05/2020 17:19:08 ******/
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

INSERT INTO dbo.Usuario(Nombre, Mail, Contraseña, Cod_Tipo)
VALUES (@Nombre, @Mail, @Contraseña, 1)
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_Permisos]    Script Date: 25/05/2020 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_Permisos]
AS
BEGIN
	SELECT pp.Cod_Permiso_Hijo AS Cod_Permiso,ph.Nombre
	FROM Permiso p
	JOIN Permiso_Permiso pp ON p.Cod_Permiso = pp.Cod_Permiso_Padre
	JOIN Permiso ph ON pp.Cod_Permiso_Hijo = ph.Cod_Permiso
	UNION
	SELECT p.Cod_Permiso,p.Nombre
	FROM Permiso p
	LEFT JOIN Permiso_Permiso pp ON p.Cod_Permiso = pp.Cod_Permiso_Padre
	ORDER BY Nombre
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_PermisosPorTipoUsuario]    Script Date: 25/05/2020 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_PermisosPorTipoUsuario]
@TipoUsuario tinyint
AS
BEGIN
	SELECT pp.Cod_Permiso_Hijo AS Cod_Permiso,ph.Nombre
	FROM Permiso p
	JOIN Permiso_Permiso pp ON p.Cod_Permiso = pp.Cod_Permiso_Padre
	JOIN Permiso ph ON pp.Cod_Permiso_Hijo = ph.Cod_Permiso
	JOIN Usuarios_Permisos up ON p.Cod_Permiso = up.Cod_Permiso
	JOIN Tipo_Usuario tu ON up.Cod_TipoUsuario = tu.Cod_Tipo
	WHERE tu.Cod_Tipo = @TipoUsuario
	UNION
	SELECT p.Cod_Permiso AS Cod_Permiso,p.Nombre
	FROM Permiso p
	LEFT JOIN Permiso_Permiso pp ON p.Cod_Permiso = pp.Cod_Permiso_Padre
	JOIN Usuarios_Permisos up ON p.Cod_Permiso = up.Cod_Permiso
	JOIN Tipo_Usuario tu ON up.Cod_TipoUsuario = tu.Cod_Tipo
	WHERE tu.Cod_Tipo = @TipoUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_TiposUsuario]    Script Date: 25/05/2020 17:19:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[pr_Listar_TiposUsuario]
AS
SELECT Cod_Tipo, DescripcionTipo
FROM dbo.Tipo_Usuario
ORDER BY DescripcionTipo
GO
/****** Object:  StoredProcedure [dbo].[pr_Listar_UsuarioLogin]    Script Date: 25/05/2020 17:19:08 ******/
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
/****** Object:  StoredProcedure [dbo].[pr_Listar_UsuarioPorCod]    Script Date: 25/05/2020 17:19:08 ******/
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
/****** Object:  StoredProcedure [dbo].[pr_Listar_UsuarioPorMail]    Script Date: 25/05/2020 17:19:08 ******/
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
/****** Object:  StoredProcedure [dbo].[pr_Listar_Usuarios]    Script Date: 25/05/2020 17:19:08 ******/
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
SET IDENTITY_INSERT [dbo].[Tipo_Usuario] ON 
GO
INSERT [dbo].[Tipo_Usuario] ([Cod_Tipo], [DescripcionTipo]) VALUES (1, N'Cliente STANDARD')
GO
INSERT [dbo].[Tipo_Usuario] ([Cod_Tipo], [DescripcionTipo]) VALUES (2, N'Administrador')
GO
INSERT [dbo].[Tipo_Usuario] ([Cod_Tipo], [DescripcionTipo]) VALUES (3, N'Web Master')
GO
INSERT [dbo].[Tipo_Usuario] ([Cod_Tipo], [DescripcionTipo]) VALUES (4, N'Cliente PREMIUM')
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
SET IDENTITY_INSERT [dbo].[Permiso] ON 
GO
INSERT [dbo].[Permiso] ([Cod_Permiso], [Nombre]) VALUES (1, N'Administrar Compra')
GO
INSERT [dbo].[Permiso] ([Cod_Permiso], [Nombre]) VALUES (2, N'Administrar Reserva')
GO
INSERT [dbo].[Permiso] ([Cod_Permiso], [Nombre]) VALUES (3, N'Comprar')
GO
INSERT [dbo].[Permiso] ([Cod_Permiso], [Nombre]) VALUES (4, N'Reservar')
GO
INSERT [dbo].[Permiso] ([Cod_Permiso], [Nombre]) VALUES (5, N'Gestionar Permisos')
GO
INSERT [dbo].[Permiso] ([Cod_Permiso], [Nombre]) VALUES (6, N'Asignar Permisos')
GO
SET IDENTITY_INSERT [dbo].[Permiso] OFF
GO
INSERT [dbo].[Usuarios_Permisos] ([Cod_TipoUsuario], [Cod_Permiso]) VALUES (1, 1)
GO
INSERT [dbo].[Usuarios_Permisos] ([Cod_TipoUsuario], [Cod_Permiso]) VALUES (2, 5)
GO
INSERT [dbo].[Usuarios_Permisos] ([Cod_TipoUsuario], [Cod_Permiso]) VALUES (4, 1)
GO
INSERT [dbo].[Usuarios_Permisos] ([Cod_TipoUsuario], [Cod_Permiso]) VALUES (4, 2)
GO
INSERT [dbo].[Permiso_Permiso] ([Cod_Permiso_Padre], [Cod_Permiso_Hijo]) VALUES (1, 3)
GO
INSERT [dbo].[Permiso_Permiso] ([Cod_Permiso_Padre], [Cod_Permiso_Hijo]) VALUES (2, 4)
GO
