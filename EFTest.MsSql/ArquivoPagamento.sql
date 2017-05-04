CREATE TABLE [dbo].[ArquivoPagamento]
(
    [InstrucaoPagamentoId] BIGINT NOT NULL PRIMARY KEY, 
    [DS_Conteudo] VARCHAR(MAX) NOT NULL,
	CONSTRAINT [FK_ArquivoPagamento_InstrucaoPagamento] FOREIGN KEY ([InstrucaoPagamentoId]) REFERENCES [InstrucaoPagamento]([Id])
)
