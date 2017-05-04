CREATE TABLE [dbo].[InstrucaoPagamento]
(
	[Id] BIGINT NOT NULL PRIMARY KEY identity, 
    [DS_Descricao] VARCHAR(80) NOT NULL, 
    [VL_Valor] DECIMAL(18, 2) NOT NULL,
)
