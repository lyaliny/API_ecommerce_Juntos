using API_Juntos.Application.Models.InserirUsuario;
using API_Juntos.Application.Models.Usuario.AtualizarUsuario;
using API_Juntos.Application.Models.Usuario.ExcluirUsuario;
using API_Juntos.Application.Models.Usuario.ListarUsuario;
using API_Juntos.Application.Models.Usuario.ListarUsuarioPorId;
using API_Juntos.Application.Models.Usuario.ListarUsuarios;
using API_Juntos.Application.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos.Controllers
{
    [ApiController]
    [Route("api/usuarios")]
    public class UsuarioController : ControllerBase
    {
        public readonly IUseCaseAsync<InserirUsuarioRequest, InserirUsuarioResponse> _useCaseInserir;
        public readonly IUseCaseAsync<AtualizarUsuarioRequest, AtualizarUsuarioResponse> _useCaseAtualizar;
        private readonly IUseCaseAsync<ExcluirUsuarioRequest, ExcluirUsuarioResponse> _useCaseExcluir;
        private readonly IUseCaseAsync<ListarUsuarioPorIdRequest, ListarUsuarioPorIdResponse> _useCaseListarPorId;
        private readonly IUseCaseAsync<ListarUsuariosRequest, List<ListarUsuariosResponse>> _useCaseListarUsuarios;

        public UsuarioController(IUseCaseAsync<InserirUsuarioRequest, InserirUsuarioResponse> useCaseInserir,
            IUseCaseAsync<AtualizarUsuarioRequest, AtualizarUsuarioResponse> useCaseAtualizar,
            IUseCaseAsync<ExcluirUsuarioRequest, ExcluirUsuarioResponse> useCaseExcluir,
            IUseCaseAsync<ListarUsuarioPorIdRequest, ListarUsuarioPorIdResponse> useCaseListarPorId,
            IUseCaseAsync<ListarUsuariosRequest, List<ListarUsuariosResponse>> useCaseListarUsuarios)
        {
            _useCaseInserir = useCaseInserir;
            _useCaseAtualizar = useCaseAtualizar;
            _useCaseExcluir = useCaseExcluir;
            _useCaseListarPorId = useCaseListarPorId;
            _useCaseListarUsuarios = useCaseListarUsuarios;

        }

        [HttpPost]
        public async Task<ActionResult<InserirUsuarioResponse>> Post([FromBody] InserirUsuarioRequest request)
        {
            return await _useCaseInserir.ExecuteAsync(request); //acessa usecase passando as dados do request para execução do método
        }

        [HttpPut("atualizacao_usuario/{id:int}")]
        public async Task<ActionResult<AtualizarUsuarioResponse>> Put([FromRoute] int id) 
        {
            return await _useCaseAtualizar.ExecuteAsync(new AtualizarUsuarioRequest() { Id = id }); //(NÃO ENTENDI MUITO BEM PORQUE SERIA DESTE MODO, AO INVÉS DE PASSAR UM REQUEST)
        }
       
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<ExcluirUsuarioResponse>> Delete([FromRoute] int id)
        {
            return await _useCaseExcluir.ExecuteAsync(new ExcluirUsuarioRequest() { Id = id });
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ListarUsuarioPorIdResponse>> Get([FromQuery] int id)
        {
            return await _useCaseListarPorId.ExecuteAsync(new ListarUsuarioPorIdRequest() { Id = id});

        }

        [HttpGet("listar_todos")]
        public async Task<ActionResult<List<ListarUsuariosResponse>>> Get([FromQuery] ListarUsuariosRequest request)
        {
            return await _useCaseListarUsuarios.ExecuteAsync(request); //é preciso manter o request acima???
        }

    }
}
