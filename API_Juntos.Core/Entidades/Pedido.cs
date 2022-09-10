using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Core.Entidades
{
    public class Pedido
    {
        public int Id { get; set; }
        public decimal ValorPedido  { get; set; }
        public DateTime DataPedido  { get; set; }
        public List<Produto> Produtos { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

        //status do pedido????
        

    }
}
