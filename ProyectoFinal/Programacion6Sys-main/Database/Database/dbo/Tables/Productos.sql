CREATE TABLE [dbo].[Productos]
(
	IdProductos INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Productos PRIMARY KEY CLUSTERED(IdProductos)
  , IdCodigo INT NOT NULL CONSTRAINT FK_Pedidos_Productos FOREIGN KEY(IdProductos)
     REFERENCES exp.Pedidos(IdCodigo)
  , Categoria VARCHAR(50) NOT NULL
  , Nombre VARCHAR(50) NOT NULL
  , CantidadDisponible INT
  , Caracteristicas VARCHAR(50) NOT NULL
  , Estado BIT
)
WITH (DATA_COMPRESSION = PAGE)
GO
