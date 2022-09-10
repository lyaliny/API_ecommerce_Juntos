using API_Juntos.Application.Models.Pedidos.ListarPedidos;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Pedidos
{
    public class ListarPedidosUseCase : IUseCaseAsync<ListarPedidosRequest, List<ListarPedidosResponse>>
    {
        private readonly IPedidoRepository _repository;
        private readonly IMapper _mapper;

        public ListarPedidosUseCase(IPedidoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ListarPedidosResponse>> ExecuteAsync(ListarPedidosRequest request)
        {
            var pedidos = await _repository.ListarTodos();
            var retorno = _mapper.Map<List<ListarPedidosResponse>>(pedidos);
            return retorno;
        }
    }
}
