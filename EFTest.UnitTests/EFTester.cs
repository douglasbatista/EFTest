using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EFTest.Data;
using System.Linq;
using System.Data.Entity;
using EFTest.Entity;

namespace EFTest.UnitTests
{
    [TestClass]
    public class EFTester
    {
        private const string _connectionString = @"Data Source=LAPTOP-NQKA8KH9;Initial Catalog=EFTeste;Integrated Security=True;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public DatabaseContext Context { get; set; }

        [TestInitialize]
        public void Initialize()
        {
            Context = new DatabaseContext(_connectionString);
        }

        [TestMethod]
        public void TestMethod1()
        {
            InstrucaoPagamento instrucaoPagamento = new InstrucaoPagamento()
            {
                Descricao = "pagamento teste",
                Valor = 10.90m
            };

            Context.InstrucoesPagamento.Add(instrucaoPagamento);
            Context.SaveChanges();

            var arquivoPagamento = new ArquivoPagamento()
            {
                Conteudo = "teste conteudo",
                InstrucaoPagamentoId = instrucaoPagamento.Id
            };

            arquivoPagamento.InstrucaoPagamento = instrucaoPagamento;

            Context.ArquivosPagamento.Add(arquivoPagamento);
            //Context.InstrucoesPagamento.Attach(instrucaoPagamento);
            Context.SaveChanges();

            var pagamento = Context.InstrucoesPagamento.First(p => p.Valor == 10.90m);

            Assert.IsNotNull(pagamento);

            Boleto boleto = new Boleto()
            {
                InstrucaoPagamentoEntidade = instrucaoPagamento,
                InstrucaoPagamentoId = instrucaoPagamento.Id,
                CodigoBarras = "54654654654654645"
            };
            Context.Boletos.Add(boleto);
            Context.SaveChanges();

            var boletos = Context.Boletos.AsQueryable();

            var boletoQuery = from b in boletos
                                   where b.CodigoBarras == "54654654654654645"
                                   select b;

            var boletoConsultado = boletoQuery.Include(p => p.InstrucaoPagamentoEntidade)
                .Include(p => p.InstrucaoPagamentoEntidade.ArquivoPagamentoEntidade).FirstOrDefault();
            
            Assert.IsNotNull(boletoConsultado);
            Assert.IsNotNull(boletoConsultado.InstrucaoPagamentoEntidade);
            Assert.IsNotNull(boletoConsultado.InstrucaoPagamentoEntidade.ArquivoPagamentoEntidade);
        }
    }
}
