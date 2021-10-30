/*CREATE TABLE [dbo].[Fisico]
(
   IdFisico INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Fisico PRIMARY KEY CLUSTERED(IdFisico),
	Fisico varchar(50) NULL
	   CONSTRAINT FK_Fisico_Detalle FOREIGN KEY(IdDetalle) REFERENCES dbo.Detalle(IdDetalle)

)WITH (DATA_COMPRESSION = PAGE)
GO

*/

/* !!!!!!!!!!!!!!!!!!!!!!! Profe no se porque me da error en KEY(IdDetalle) !!!!!!!!!!!!!!!!!!!!!!! */