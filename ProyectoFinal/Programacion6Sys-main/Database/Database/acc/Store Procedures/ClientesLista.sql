CREATE PROCEDURE [acc].[ClientesLista]
AS
BEGIN
SET NOCOUNT ON

SELECT
IdClientes, 
IdCodigo,
Nombre , 
Apellidos,
Direccion,
Fecha, 
Telefono,
Cedula

FROM Clientes
/*WHeRE Estado=1*/

END