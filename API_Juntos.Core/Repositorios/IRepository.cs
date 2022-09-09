using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Core.Repositorios
{
    public interface IRepository<T>
    {
            Task Inserir(T obj);
            Task Atualizar(T obj);
            Task<IEnumerable<T>> ListarTodos();
            Task<T> ListarPorId(int id);
            Task Excluir(T obj);
            Task <T> ListarPorIdParaAtualizar(int id); //é realmente necessário criar outro método? não poderia apenas listar por id para acessar qual vai modificar?
        
    }
}
