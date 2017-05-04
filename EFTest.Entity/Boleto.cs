using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Entity
{
    public class Boleto
    {
        public long InstrucaoPagamentoId { get; set; }
        public string CodigoBarras { get; set; }
        public DateTime? DataVencimento { get; set; }

        public virtual InstrucaoPagamento InstrucaoPagamentoEntidade { get; set; }
    }
}
