using API_Juntos.Application.Models.Produtos.AdicionarProduto;
using API_Juntos.Core.Entidades;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Produtos
{
    public class InserirProdutoUseCase : IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse>
    {
       
            private readonly IProdutoRepository _repository;
            private readonly IMapper _mapper;

            public InserirProdutoUseCase(IProdutoRepository repository, IMapper mapper)
            {
                _repository = repository;
                _mapper = mapper;
            }

            public async Task<InserirProdutoResponse> ExecuteAsync(InserirProdutoRequest request)
            {
                //validar com o fluent validation?
                if (request == null)
                { return null; }

                var produto = _mapper.Map<Produto>(request); //mapeando o que chega do request para Produto

                await _repository.Inserir(produto); //acessa instância do repositório,chamando método Inserir(), passando os dados do mapeamento como parâmetro
                return new InserirProdutoResponse();
            }
        
    }
}
