using API_Juntos.Application.Models.Pedidos.ExcluirPedidos;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    public class ExcluirPedidoUseCase : IUseCaseAsync<ExcluirPedidoRequest, ExcluirPedidoResponse>
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public ExcluirPedidoUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ExcluirPedidoResponse> ExecuteAsync(ExcluirPedidoRequest request)
        {
            var pedido = await _repository.ListarPorId(request.Id);
            await  _repository.Excluir(pedido);
            return new ExcluirPedidoResponse();

        }
    }
}
