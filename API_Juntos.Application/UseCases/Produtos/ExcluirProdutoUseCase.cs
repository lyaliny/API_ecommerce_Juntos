using API_Juntos.Application.Models.Produtos.ExcluirProduto;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Produtos
{
    public class ExcluirProdutoUseCase : IUseCaseAsync<ExcluirProdutoRequest, ExcluirProdutoResponse>
    {
        private readonly IProdutoRepository _repository;
        private readonly IMapper _mapper;

        public ExcluirProdutoUseCase(IProdutoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ExcluirProdutoResponse> ExecuteAsync(ExcluirProdutoRequest request)
        {
            var produto = await _repository.ListarPorId(request.Id); //busca pelo id pra saber qual vai deletar
            await _repository.Excluir(produto); //chama no repository o excluir, passando o identificado como parâmetro
            return new ExcluirProdutoResponse(); //só pq tem que retornar algo??? - o response é vazio

        }
    }
}
