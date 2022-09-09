using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Produtos
{
    public class ListarProdutoPorIdUseCase : IUseCaseAsync<ListarProdutoPorIdRequest, ListarProdutoPorIdResponse>
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ListarProdutoPorIdUseCase(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListarProdutoPorIdResponse> ExecuteAsync(ListarProdutoPorIdRequest request)
        {
            var produto = await _repository.ListarPorId(request.Id);

            var retorno = (ListarProdutoPorIdResponse)null; //POR QUE A ESCRITA É DESSA MANEIRA?
            if (produto != null)
            {
                retorno = _mapper.Map<ListarProdutoPorIdResponse>(retorno);
            }
            return await Task.FromResult(retorno);
        }
    }
}
