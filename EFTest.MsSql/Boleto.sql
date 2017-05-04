CREATE TABLE [dbo].[Boleto]
(
	[InstrucaoPagamentoId] bigint NOT NULL PRIMARY KEY,
    [CD_Barras] CHAR(44) NULL, 
    [DT_Vencimento] DATETIME NULL, 
    CONSTRAINT [FK_Boleto_InstrucaoPagamento] FOREIGN KEY ([InstrucaoPagamentoId]) REFERENCES [InstrucaoPagamento]([Id])
)
