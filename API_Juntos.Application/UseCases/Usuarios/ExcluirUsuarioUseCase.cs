using API_Juntos.Application.Models.Usuario.ExcluirUsuario;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Usuarios
{
    public class ExcluirUsuarioUseCase : IUseCaseAsync<ExcluirUsuarioRequest, ExcluirUsuarioResponse>
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public ExcluirUsuarioUseCase(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ExcluirUsuarioResponse> ExecuteAsync(ExcluirUsuarioRequest request)
        {
            var usuario = await _repository.ListarPorId(request.Id); //busca pelo id pra saber qual vai deletar
            //mapeamento???
            await _repository.Excluir(usuario); //chama no repository o excluir, passando o identificado como parâmetro
            return new ExcluirUsuarioResponse(); //só pq tem que retornar algo??? - o response é vazio

        }
    }
}
