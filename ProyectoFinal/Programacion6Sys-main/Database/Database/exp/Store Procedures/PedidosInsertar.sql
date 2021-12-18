CREATE PROCEDURE [exp].[PedidosInsertar]
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

INSERT INTO exp.Pedidos
(IdClientes,
IdProductos,
FechaPedido,
Cantidad,
SubTotal,
Envio,
Iva,
Total

)
VALUES
(
@IdClientes,
@IdProductos,
@FechaPedido,
@Cantidad,
@SubTotal,
@Envio,
@Iva,
@Total

)

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