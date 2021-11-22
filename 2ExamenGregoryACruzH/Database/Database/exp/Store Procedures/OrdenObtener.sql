CREATE PROCEDURE exp.OrdenObtener
      @IdOrden int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     E.IdOrden,
     E.CantidadProducto,
     E.Estado

    FROM exp.Orden E
    WHERE
    (@IdOrden IS NULL OR IdOrden=@IdOrden)

END