using API_Juntos.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Models.Pedidos.ListarPedidos
{
    public class ListarPedidosResponse
    {
        public int Id { get; set; }
        public decimal ValorPedido { get; set; }
        public DateTime DataPedido { get; set; }
        public List<Produto> Produtos { get; set; }
        public int IdUsuario { get; set; }
    }
}
