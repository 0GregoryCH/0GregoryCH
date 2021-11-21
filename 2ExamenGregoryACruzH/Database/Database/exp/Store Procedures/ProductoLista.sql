CREATE PROCEDURE [dbo].Productoista
AS
	BEGIN
	SET NOCOUNT ON


	SELECT
	 IdProducto,
	 NombreProducto,
	 PrecioProducto
	FROM Producto


	END
