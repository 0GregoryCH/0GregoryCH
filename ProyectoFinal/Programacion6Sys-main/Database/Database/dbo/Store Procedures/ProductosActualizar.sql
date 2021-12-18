CREATE PROCEDURE [dbo].[ProductosActualizar]
    	@IdProductos int,
		@IdCodigo int,
		@Categoria varchar(50),
		@Nombre varchar(50),
		@CantidadDisponible int,
		@Caracteristicas varchar(50),
		@Estado	bit


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE dbo.Productos SET
	IdCodigo = @IdCodigo,
	Categoria = @Categoria,
	Nombre = @Nombre,
	CantidadDisponible = @CantidadDisponible,
	Caracteristicas = @Caracteristicas,
	Estado	= @Estado		
				
				
				
				
				
	WHERE 
	       IdProductos=@IdProductos
	
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