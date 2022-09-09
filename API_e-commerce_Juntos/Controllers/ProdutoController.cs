﻿using API_Juntos.Application.Models.Produtos.AdicionarProduto;
using API_Juntos.Application.Models.Produtos.AtualizarProduto;
using API_Juntos.Application.Models.Produtos.ExcluirProduto;
using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutoController : ControllerBase
    {
        private readonly IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse> _useCaseInserir;
        private readonly IUseCaseAsync<AtualizarProdutoRequest, AtualizarProdutoResponse> _useCaseAtualizar;
        private readonly IUseCaseAsync<ExcluirProdutoRequest, ExcluirProdutoResponse> _useCaseExcluir;
        private readonly IUseCaseAsync<ListarProdutoPorIdRequest, ListarProdutoPorIdResponse> _useCaseListarPorId;

        public ProdutoController(IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse> useCaseInserir,
            IUseCaseAsync<AtualizarProdutoRequest, AtualizarProdutoResponse> useCaseAtualizar,
            IUseCaseAsync<ExcluirProdutoRequest, ExcluirProdutoResponse> useCaseExcluir,
            IUseCaseAsync<ListarProdutoPorIdRequest, ListarProdutoPorIdResponse> useCaseListarPorId)
        {
            _useCaseInserir = useCaseInserir;
            _useCaseAtualizar = useCaseAtualizar;
            _useCaseExcluir = useCaseExcluir;
            _useCaseListarPorId = useCaseListarPorId;
        }

        [HttpPost]
        public async Task<ActionResult<InserirProdutoResponse>> Post([FromBody] InserirProdutoRequest request)
        {
           return await _useCaseInserir.ExecuteAsync(request);
        }

        [HttpPut("atualizacao_produto{id:int}")] 
        public async Task<ActionResult<AtualizarProdutoResponse>> Put([FromRoute] int id) //Seria a melhor maneira?
        {
            return await _useCaseAtualizar.ExecuteAsync(new AtualizarProdutoRequest() { Id = id }); 
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ExcluirProdutoResponse>> Delete([FromRoute] int id)
        {
            return await _useCaseExcluir.ExecuteAsync(new ExcluirProdutoRequest() { Id = id });
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ListarProdutoPorIdResponse>> Get([FromQuery] int id)
        {
            return await _useCaseListarPorId.ExecuteAsync(new ListarProdutoPorIdRequest() { Id = id });

        }





    }
}
