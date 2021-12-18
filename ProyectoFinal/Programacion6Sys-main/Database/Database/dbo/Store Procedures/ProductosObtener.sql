CREATE PROCEDURE [dbo].[ProductosObtener]
      @IdProductos int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     P.IdProductos,
     P.Categoria, 
	 P.Nombre,
	 P.CantidadDisponible, 
	 P.Caracteristicas, 
	 P.Estado,
     
     PE.IdCodigo,
     PE.IdClientes, 
	 P.IdProductos,
	 PE.FechaPedido, 
	 PE.Cantidad, 
	 PE.SubTotal, 
	 PE.Envio, 
	 PE.Iva, 
	 PE.Total 

FROM dbo.Productos P
INNER JOIN exp.Pedidos PE
ON PE.IdCodigo = PE.IdCodigo

WHERE
(@IdProductos IS NULL OR P.IdProductos=@IdProductos)



END