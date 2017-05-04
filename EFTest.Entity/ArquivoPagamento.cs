using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Entity
{
    public class ArquivoPagamento
    {
        public long InstrucaoPagamentoId { get; set; }
        public string Conteudo { get; set; }

        public virtual InstrucaoPagamento InstrucaoPagamento { get; set; }

    }
}
