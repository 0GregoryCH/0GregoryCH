CREATE PROCEDURE [acc].[ClientesObtener]
      @IdClientes int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     PE.IdCodigo,
     C.IdClientes,
	 C.Nombre,
	 C.Apellidos,
	 C.Direccion,
	 C.Fecha,
	 C.Telefono,
	 C.Cedula,
     
     PE.IdCodigo, 
	 PE.IdClientes,
	 PE.FechaPedido, 
	 PE.Cantidad, 
	 PE.SubTotal, 
	 PE.Envio, 
	 PE.Iva, 
	 PE.Total 


FROM acc.Clientes C
INNER JOIN exp.Pedidos PE
ON PE.IdCodigo= PE.IdCodigo
WHERE
(@IdClientes IS NULL OR C.IdClientes=@IdClientes)



END