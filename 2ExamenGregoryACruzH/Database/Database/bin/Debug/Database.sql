﻿/*
Deployment script for Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "Database"
:setvar DefaultFilePrefix "Database"
:setvar DefaultDataPath "C:\Users\pclap\AppData\Local\Microsoft\VisualStudio\SSDT\Database"
:setvar DefaultLogPath "C:\Users\pclap\AppData\Local\Microsoft\VisualStudio\SSDT\Database"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating Table [exp].[Orden]...';


GO
CREATE TABLE [exp].[Orden] (
    [IdOrden]          INT          IDENTITY (1, 1) NOT NULL,
    [IdProducto]       INT          NOT NULL,
    [CantidadProducto] VARCHAR (50) NOT NULL,
    [Estado]           VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_Orden] PRIMARY KEY CLUSTERED ([IdOrden] ASC)
)
WITH (DATA_COMPRESSION = PAGE);


GO
PRINT N'Creating Table [exp].[Producto]...';


GO
CREATE TABLE [exp].[Producto] (
    [IdProducto]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreProducto] VARCHAR (50) NULL,
    [PrecioProducto] VARCHAR (50) NULL,
    CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED ([IdProducto] ASC)
)
WITH (DATA_COMPRESSION = PAGE);


GO
PRINT N'Creating Foreign Key [exp].[FK_Orden_Producto]...';


GO
ALTER TABLE [exp].[Orden] WITH NOCHECK
    ADD CONSTRAINT [FK_Orden_Producto] FOREIGN KEY ([IdProducto]) REFERENCES [exp].[Producto] ([IdProducto]);


GO
PRINT N'Creating Procedure [exp].[OrdenActualizar]...';


GO
CREATE PROCEDURE [exp].OrdenActualizar
    @IdOrden int,
	@IdProducto int,
	@CantidadProducto varchar(50),
	@Estado varchar(50)

AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	UPDATE exp.Orden SET
	 IdProducto= @IdProducto,
	 CantidadProducto= @CantidadProducto,
	 Estado= @Estado
	WHERE 
	       IdOrden=@IdOrden
	
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
GO
PRINT N'Creating Procedure [exp].[OrdenEliminar]...';


GO
CREATE PROCEDURE [exp].OrdenEliminar
 @IdOrden int


AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
            DELETE FROM exp.Orden WHERE IdOrden=@IdOrden
	
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
GO
PRINT N'Creating Procedure [exp].[OrdenInsertar]...';


GO
CREATE PROCEDURE [exp].OrdenInsertar
	@IdProducto int,	
	@CantidadProducto varchar(50),
	@Estado varchar(50)

AS BEGIN
SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

    BEGIN TRY
	
	INSERT INTO exp.Orden
	(IdProducto,
	 CantidadProducto,
	 Estado
	)
	VALUES
	(
	@IdProducto,
	@CantidadProducto,
	@Estado
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
GO
PRINT N'Creating Procedure [exp].[OrdenObtener]...';


GO
CREATE PROCEDURE [exp].OrdenObtener
      @IdOrden int= NULL
AS BEGIN
  SET NOCOUNT ON

  SELECT 
     E.IdOrden,
     E.CantidadProducto,
     E.Estado

    FROM exp.Orden E
    WHERE
    (@IdOrden IS NULL OR IdOrden=@IdOrden)

END
GO
PRINT N'Creating Procedure [exp].[Productoista]...';


GO
CREATE PROCEDURE [exp].Productoista
AS
	BEGIN
	SET NOCOUNT ON


	SELECT
	 IdProducto,
	 NombreProducto,
	 PrecioProducto
	FROM Producto


	END
GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [exp].[Orden] WITH CHECK CHECK CONSTRAINT [FK_Orden_Producto];


GO
PRINT N'Update complete.';


GO
