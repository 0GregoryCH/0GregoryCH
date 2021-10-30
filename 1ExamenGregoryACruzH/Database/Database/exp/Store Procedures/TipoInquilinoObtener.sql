CREATE PROCEDURE [dbo].TipoInquilinoObtener
      @IdTipoInquilino int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     E.IdTipoInquilino,
     E.Descripcion,
     E.Estado   
    FROM dbo.TipoInquilino E
    WHERE
    (@IdTipoInquilino IS NULL OR IdTipoInquilino=@IdTipoInquilino)

END