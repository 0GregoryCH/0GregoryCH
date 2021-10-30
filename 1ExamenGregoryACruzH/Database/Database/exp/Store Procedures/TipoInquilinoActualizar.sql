CREATE PROCEDURE [dbo].[TipoInquilinoActualizar]
    @IdTipoInquilino int,
	@Descripcion varchar(250),
	@Estado Bit

AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE dbo.TipoInquilino SET
	 Descripcion=@Descripcion,
	 Estado=@Estado
	WHERE 
	       IdTipoInquilino=@IdTipoInquilino
	
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