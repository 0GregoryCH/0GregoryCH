CREATE TABLE [dbo].[TipoIdentificacion]
(
   IdTipoIdentificacion INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_TipoIdentificacion PRIMARY KEY CLUSTERED(IdTipoIdentificacion),
	TipoIdentificacion varchar(50) NULL

)WITH (DATA_COMPRESSION = PAGE)
GO