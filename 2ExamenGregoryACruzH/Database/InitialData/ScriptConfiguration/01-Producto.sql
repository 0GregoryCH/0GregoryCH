DROP TABLE IF EXISTS #ProductoTemp

SELECT 
IdProducto, Descripcion INTO #ProductoTemp
FROM (
VALUES
(1, 'NOMBRE PRODUCTO'),
(2, 'PRECIO PRODUCTO')
)AS TEMP (IdProducto, NombreProducto, PrecioProducto)


----ACTUALIZAR DATOS---
UPDATE P SET
  P.NombreProducto= TM.NombreProducto
FROM Dbo.Producto P
INNER JOIN #ProductoTemp TM
    ON P.IdProducto= TM.IdProducto

UPDATE P SET
  P.PrecioProducto= TM.PrecioProducto
FROM Dbo.Producto P
INNER JOIN #ProductoTemp TM
    ON P.IdProducto= TM.IdProducto


----INSERTAR DATOS---

SET IDENTITY_INSERT dbo.Producto ON

INSERT INTO dbo.Producto(
IdProducto, NombreProducto, PrecioProducto)
SELECT
IdProducto, NombreProducto, PrecioProducto
FROM #ProductoTemp


EXCEPT
SELECT
IdProducto, NombreProducto, PrecioProducto
FROM dbo.Producto


SET IDENTITY_INSERT dbo.Producto OFF

GO