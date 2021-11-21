CREATE TABLE exp.Producto
(
	IdProducto INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Producto PRIMARY KEY CLUSTERED(IdProducto),
	NombreProducto varchar(50) NULL,
	PrecioProducto varchar(50) NULL
	   
)WITH (DATA_COMPRESSION = PAGE)
GO
