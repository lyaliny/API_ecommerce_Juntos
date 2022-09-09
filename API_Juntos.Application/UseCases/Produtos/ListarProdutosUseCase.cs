using API_Juntos.Application.Models.Produtos.ListarProdutos;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Produtos
{
    public class ListarProdutosUseCase : IUseCaseAsync<ListarProdutosRequest, List<ListarProdutosResponse>>
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ListarProdutosUseCase(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ListarProdutosResponse>> ExecuteAsync(ListarProdutosRequest request)
        {
            var produtos = await _repository.ListarTodos();
            var retorno = _mapper.Map<List<ListarProdutosResponse>>(produtos);
            return retorno;
        }
    }
}
