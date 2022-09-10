using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    public class InserirPedidoUseCase : IUseCaseAsync<InserirPedidoRequest, InserirPedidoResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public InserirPedidoUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<InserirPedidoResponse> ExecuteAsync(InserirPedidoRequest request)
        {
            if (request == null)
            { return null; }

            var pedido = _mapper.Map<Pedido>(request);

            await _repository.Inserir(pedido);

            return new InserirPedidoResponse();

        }
        // VER ONDE SOMAR O VALOR DOS ITENS PARA QUE SE OBTENHA O TOTAL DO PEDIDO????? MÉTODO NA INTERFACE?
    }
}
