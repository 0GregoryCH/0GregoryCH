CREATE PROCEDURE [exp].Productoista
AS
	BEGIN
	SET NOCOUNT ON


	SELECT
	 IdProducto,
	 NombreProducto,
	 PrecioProducto
	FROM Producto


	END
