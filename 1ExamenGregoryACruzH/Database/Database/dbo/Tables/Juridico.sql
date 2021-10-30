/*CREATE TABLE [dbo].[Juridico]
(
	IdJuridico INT NOT NULL IDENTITY(1,1) CONSTRAINT PK_Juridico PRIMARY KEY CLUSTERED(IdJuridico),
	Juridico varchar(50) NULL
	  CONSTRAINT FK_Juridico_Fisico FOREIGN KEY(IdFisico) REFERENCES dbo.Fisico(IdFisico)
)WITH (DATA_COMPRESSION = PAGE)
GO

*/

/* !!!!!!!!!!!!!!!!!!!!!!! Profe no se porque me da error en KEY(IdFisico) !!!!!!!!!!!!!!!!!!!!!!! */