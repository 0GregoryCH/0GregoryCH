CREATE PROCEDURE [exp].[PedidosActualizar]
@IdCodigo int,
@IdClientes int,
@IdProductos int,
@FechaPedido Datetime,
@Cantidad int,
@SubTotal DECIMAL(18,2),
@Envio DECIMAL(18,2),
@Iva DECIMAL(18,2),
@Total DECIMAL(18,2)

AS BEGIN
SET NOCOUNT ON

BEGIN TRANSACTION TRASA

BEGIN TRY

UPDATE exp.Pedidos SET
IdProductos= @IdProductos,
FechaPedido= @FechaPedido,
Cantidad=@Cantidad,
SubTotal=@SubTotal,
Envio= @Envio,
Iva=@Iva,
Total=@Total
WHERE
IdCodigo=@IdCodigo

COMMIT TRANSACTION TRASA
SELECT 0 AS CodeError, '' AS MsgError

END TRY

BEGIN CATCH

SELECT
ERROR_NUMBER() AS CodeError,
ERROR_MESSAGE() AS MsgError

ROLLBACK TRANSACTION TRASA

END CATCH


END