CREATE TABLE [exp].[Pedidos]
(
	  IdCodigo INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Pedidos PRIMARY KEY CLUSTERED(IdCodigo)
	, IdClientes INT NOT NULL CONSTRAINT FK_Pedidos_Clientes FOREIGN KEY(IdClientes)
	  REFERENCES acc.Clientes(IdClientes)
	, IdProductos INT NOT NULL CONSTRAINT FK_Pedidos_Productos FOREIGN KEY(IdProductos)
	  References dbo.Productos(IdProductos)
	, FechaPedido DATETIME NOT NULL
	, Cantidad INT NOT NULL
	, SubTotal DECIMAL(18,2) NOT NULL
	, Envio DECIMAL(18,2) NOT NULL
	, Iva DECIMAL(18,2) NOT NULL
	, Total DECIMAL(18,2) NOT NULL

)
WITH (DATA_COMPRESSION = PAGE)
GO