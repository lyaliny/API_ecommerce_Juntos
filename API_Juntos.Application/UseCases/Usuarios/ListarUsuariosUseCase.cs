using API_Juntos.Application.Models.Usuario.ListarUsuario;
using API_Juntos.Application.Models.Usuario.ListarUsuarios;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Usuarios
{
    public class ListarUsuariosUseCase : IUseCaseAsync<ListarUsuariosRequest, List<ListarUsuariosResponse>>
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public ListarUsuariosUseCase(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<List<ListarUsuariosResponse>> ExecuteAsync(ListarUsuariosRequest request)
        {
            var usuarios = await _repository.ListarTodos();
            var retorno = _mapper.Map<List<ListarUsuariosResponse>>(usuarios);
            return retorno;
        }
    }
}
