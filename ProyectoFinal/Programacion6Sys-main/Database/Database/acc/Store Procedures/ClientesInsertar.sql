CREATE PROCEDURE [acc].[ClienteInsertar]	
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
	
	INSERT INTO acc.Clientes
	(IdCodigo,
	 Nombre,
	 Apellidos,
	 Direccion,
	 Fecha,
	 Telefono,
	 Cedula 
	)
	VALUES
	(
	@IdCodigo,
	@Nombre,
	@Apellidos,
	@Direccion,
	@Fecha,
	@Telefono,
	@Cedula
	)

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



