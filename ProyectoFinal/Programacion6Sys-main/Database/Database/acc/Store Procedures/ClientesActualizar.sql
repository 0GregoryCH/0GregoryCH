CREATE PROCEDURE [acc].[ClientesActualizar]
    @IdClientes int,	
	@IdCodigo int,
	@Nombre VARCHAR(50),
	@Apellidos VARCHAR(50),
	@Direccion VARCHAR(50),
	@Fecha DATETIME,
	@Telefono VARCHAR(50),
	@Cedula VARCHAR(50)


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE acc.Clientes SET
	 IdCodigo= @IdCodigo,
	 Nombre= @Nombre,
	 Apellidos= @Apellidos,
	 Direccion=@Direccion,
	 Fecha= @Fecha,
	 Telefono=@Telefono,
	 Cedula= @Cedula
	WHERE 
	       IdClientes=@IdClientes
	
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