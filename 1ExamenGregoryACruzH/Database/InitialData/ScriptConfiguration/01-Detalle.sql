DROP TABLE IF EXISTS #DetalleTemp

SELECT 
IdDetalle, Detalle INTO #DetalleTemp
FROM (
VALUES
(1, 'Fisico'),
(2, 'Juridico')
)AS TEMP (IdDetalle, Detalle)


----ACTUALIZAR DATOS---
UPDATE P SET
  P.Detalle= TM.Detalle
FROM Dbo.Detalle P
INNER JOIN #DetalleTemp TM
    ON P.IdDetalle= TM.IdDetalle


----INSERTAR DATOS---

SET IDENTITY_INSERT dbo.Detalle ON

INSERT INTO dbo.Detalle(
IdDetalle, Detalle)
SELECT
IdDetalle, Detalle
FROM #DetalleTemp


EXCEPT
SELECT
IdDetalle, Detalle
FROM dbo.Detalle


SET IDENTITY_INSERT dbo.Detalle OFF

GO
