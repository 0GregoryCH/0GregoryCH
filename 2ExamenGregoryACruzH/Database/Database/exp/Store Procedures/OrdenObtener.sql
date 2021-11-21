CREATE PROCEDURE [dbo].OrdenObtener
      @IdOrden int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     E.IdOrden,
     E.CantidadProducto,
     E.Estado

    FROM dbo.Orden E
    WHERE
    (@IdOrden IS NULL OR IdOrden=@IdOrden)

END