using API_Juntos.Application.Models.Pedidos.AtualizarPedido;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    public class AtualizarPedidoUseCase : IUseCaseAsync<AtualizarPedidoRequest, AtualizarPedidoResponse>

    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public AtualizarPedidoUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<AtualizarPedidoResponse> ExecuteAsync(AtualizarPedidoRequest request)
        {
            var pedido = await _repository.ListarPorIdParaAtualizar(request.Id); //acessa o repositório para chamar o método listar por id para identificar os dados do usuário atualizar
                                                                                  //é realmente necessário criar outro método? não poderia apenas listar por id para acessar qual vai modificar?

            //como especificar o dado que vai atualizar de acordo com o que se deseja? colocar de cada propriedade???? 


            //mapeamento??

            await _repository.Atualizar(pedido); 
            return new AtualizarPedidoResponse();

        }

    }
}
