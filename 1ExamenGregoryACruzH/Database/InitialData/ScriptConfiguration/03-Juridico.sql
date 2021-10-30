DROP TABLE IF EXISTS #JuridicoTemp

SELECT 
IdFisico, IdJuridico, Juridico INTO #JuridicoTemp
FROM (
VALUES
(1,1,'Fisico'),(1,2,'Juridico'))AS TEMP (IdFisico, IdJuridico, Juridico)

----ACTUALIZAR DATOS---
UPDATE P SET
  P.IdFisico=TM.IdFisico,
  P.Juridico= TM.Juridico
FROM Dbo.Juridico P
INNER JOIN #JuridicoTemp TM
    ON P.IdJuridico= TM.IdJuridico


----INSERTAR DATOS---

SET IDENTITY_INSERT dbo.Juridico ON

INSERT INTO dbo.Juridico(
IdCanton, IdJuridico, Juridico)
SELECT
IdCanton, IdJuridico, Juridico
FROM #JuridicoTemp


EXCEPT
SELECT
IdFisico, IdJuridico, Juridico
FROM dbo.Juridico


SET IDENTITY_INSERT dbo.Juridico OFF

GO