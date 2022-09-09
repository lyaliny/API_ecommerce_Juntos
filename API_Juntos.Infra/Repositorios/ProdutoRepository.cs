using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Repositorios
{
    public class ProdutoRepository : IProdutoRepository
    {
        public Task Atualizar(Produto obj)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Produto obj)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(Produto obj)
        {
            throw new NotImplementedException();
        }

        public Task<Produto> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
