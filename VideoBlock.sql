USE [VideoBlock]
GO
/****** Object:  Table [dbo].[Actor]    Script Date: 25/02/2021 1:13:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actor](
	[actorID] [int] NOT NULL,
	[nombreActor] [varchar](200) NOT NULL,
	[fechaNacimiento] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[actorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Alquiler]    Script Date: 25/02/2021 1:13:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquiler](
	[alquilerID] [int] NOT NULL,
	[clienteID] [int] NULL,
	[fechaAlquiler] [datetime] NOT NULL,
	[fechaDevolucion] [datetime] NOT NULL,
	[valorAlquiler] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[alquilerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 25/02/2021 1:13:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[clienteID] [int] NOT NULL,
	[nombre] [varchar](200) NOT NULL,
	[direccion] [varchar](200) NOT NULL,
	[telefono] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[clienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Peliculas]    Script Date: 25/02/2021 1:13:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Peliculas](
	[tipopeliculaID] [int] NULL,
	[actorID] [int] NULL,
	[id_peliculas] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_peliculas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPelicula]    Script Date: 25/02/2021 1:13:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPelicula](
	[tipopeliculaID] [int] NOT NULL,
	[categoria] [varchar](200) NOT NULL,
	[titulo] [varchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tipopeliculaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alquiler]  WITH CHECK ADD FOREIGN KEY([clienteID])
REFERENCES [dbo].[Cliente] ([clienteID])
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD FOREIGN KEY([actorID])
REFERENCES [dbo].[Actor] ([actorID])
GO
ALTER TABLE [dbo].[Peliculas]  WITH CHECK ADD FOREIGN KEY([tipopeliculaID])
REFERENCES [dbo].[TipoPelicula] ([tipopeliculaID])
GO
/****** Object:  StoredProcedure [dbo].[ListarPeliculas]    Script Date: 25/02/2021 1:13:40 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ListarPeliculas]

as

select  b.categoria AS CATEGORIA, b.titulo as TITULO,c.nombreActor as Nombre_Actor, c.fechaNacimiento
from Peliculas a inner join TipoPelicula b on(a.tipopeliculaID = b.tipopeliculaID)
inner join Actor c on(a.actorID = c.actorID)

GO
