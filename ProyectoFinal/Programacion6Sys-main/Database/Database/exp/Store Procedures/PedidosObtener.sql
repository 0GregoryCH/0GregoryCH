CREATE PROCEDURE [exp].[PedidosObtener]
@IdCodigo int = null

As Begin
SET NOCOUNT ON

SELECT
PE.IdCodigo,
PE.FechaPedido,
PE.Cantidad,
PE.SubTotal,
PE.Envio,
PE.Iva,
PE.Total,

C.IdClientes,

P.IdProductos


FROM exp.Pedidos PE
INNER JOIN acc.Clientes C
ON PE.IdClientes= C.IdClientes
INNER JOIN dbo.Productos P
ON PE.IdProductos= P.IdProductos



WHERE
(@IdCodigo IS NULL OR PE.IdCodigo=@IdCodigo)



END