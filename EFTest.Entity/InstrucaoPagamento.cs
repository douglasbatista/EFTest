﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTest.Entity
{
    public class InstrucaoPagamento
    {
        public long Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }

        public virtual ArquivoPagamento ArquivoPagamentoEntidade { get; set; }
    }
}
