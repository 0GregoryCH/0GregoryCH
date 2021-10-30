DROP TABLE IF EXISTS #FisicoTemp

SELECT 
IdFisico, IdDetalle, Fisico  INTO #FisicoTemp
FROM (
VALUES
(1,1,'Juridico'),(2,1,'Fisico'))AS TEMP (IdFisico, IdDetalle, Fisico )


----ACTUALIZAR DATOS---
UPDATE P SET
  P.IdDetalle= TM.IdDetalle,
  P.Fisico= TM.Fisico
FROM Dbo.Fisico P
INNER JOIN #FisicoTemp TM
    ON P.IdFisico= TM.IdFisico


----INSERTAR DATOS---

SET IDENTITY_INSERT dbo.Fisico ON

INSERT INTO dbo.Fisico(
IdFisico, IdDetalle, Fisico )
SELECT
IdFisico, IdDetalle, Fisico 
FROM #FisicoTemp


EXCEPT
SELECT
IdFisico, IdDetalle, Fisico 
FROM dbo.Fisico


SET IDENTITY_INSERT dbo.Fisico OFF

GO

--   DECLARE @VARTEXT VARCHAR(MAX)=NULL

--SELECT
--@VARTEXT=CONCAT(@VARTEXT,'(',
--ISNULL(CAST([COD_CANTON] AS VARCHAR),'NULL'),',',
--ISNULL(CAST([COD_PROVINCIA] AS VARCHAR),'NULL'),',',
--'''',[DES_CANTON],'''','),')
--FROM [dbo].[CANTON]

--SELECT @VARTEXT