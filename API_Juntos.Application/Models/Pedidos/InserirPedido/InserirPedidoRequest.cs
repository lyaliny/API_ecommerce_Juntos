using API_Juntos.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Models.Pedidos.InserirPedido
{
    public class InserirPedidoRequest
    {
        // o  somatório do total vem internamente do sistema, por isso não cabe colocar  ValorPedido 
        public DateTime DataPedido { get; set; }
        public List<Produto> Produtos { get; set; }
        public int IdUsuario { get; set; }
    }
}
