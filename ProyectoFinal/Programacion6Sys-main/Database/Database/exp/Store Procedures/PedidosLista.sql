CREATE PROCEDURE [exp].[PedidosLista]
AS
BEGIN
SET NOCOUNT ON

SELECT
IdCodigo,
FechaPedido,
Cantidad,
SubTotal,
Envio,
Iva,
Total

FROM Pedidos
/*WHeRE Estado=1*/

END