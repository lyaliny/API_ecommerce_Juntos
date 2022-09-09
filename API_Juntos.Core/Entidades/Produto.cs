﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Core.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Lote { get; set; }
        public string Validade { get; set; }
        public decimal QuantidadeEmbalagem{ get; set; }
        public decimal Valor { get; set; }

        //quantidade em estoque????
        //entrada?
        //devolução?


    }
}
