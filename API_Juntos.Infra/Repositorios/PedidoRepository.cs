using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Repositorios
{
    internal class PedidoRepository : IPedidoRepository
    {
        public Task Atualizar(Pedido obj)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Pedido obj)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(Pedido obj)
        {
            throw new NotImplementedException();
        }

        public Task<Pedido> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Pedido>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
