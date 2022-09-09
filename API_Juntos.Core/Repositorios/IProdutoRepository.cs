using API_Juntos.Core.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Core.Repositorios
{
    public interface IProdutoRepository:IRepository<Produto>
    {
        //listar produtos com vencimento próximo(como fazer? qual parâmetro) e quantidade em estoque - define estratégias de vendas
        //quantidade em estoque - define estratégia de abastecimento
        //quantas vendas no período - define estratégia de abastecimento
        //quais clientes compraram o produto no período - personalizar ofertas/premiações

        //produtos devolvidos
        //listar entrada de produtos por data
    }
}
