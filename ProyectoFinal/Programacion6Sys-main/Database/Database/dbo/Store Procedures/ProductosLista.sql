CREATE PROCEDURE [dbo].[ProductosLista]

AS
	BEGIN
		SET NOCOUNT ON



		SELECT 
		IdProductos,
		Categoria,
		Nombre,
		CantidadDisponible,
		Caracteristicas,
		Estado

		FROM	
			Productos

			WHERE
					Estado=1

END