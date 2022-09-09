using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Infra.Repositorios
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public Task Atualizar(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Task Excluir(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Task Inserir(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> ListarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Usuario> ListarPorIdParaAtualizar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Usuario>> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
