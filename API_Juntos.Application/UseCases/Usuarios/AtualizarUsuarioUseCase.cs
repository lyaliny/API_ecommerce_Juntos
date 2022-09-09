using API_Juntos.Application.Models.Usuario.AtualizarUsuario;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Usuarios
{
    public class AtualizarUsuarioUseCase : IUseCaseAsync<AtualizarUsuarioRequest, AtualizarUsuarioResponse>
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public AtualizarUsuarioUseCase(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
      
        public async Task<AtualizarUsuarioResponse> ExecuteAsync(AtualizarUsuarioRequest request)
        {
            var usuario = await _repository.ListarPorIdParaAtualizar(request.Id); //acessa o repositório para chamar o método listar por id para identificar os dados do usuário atualizar
                                                                                  //é realmente necessário criar outro método? não poderia apenas listar por id para acessar qual vai modificar?

            //como especificar o dado que vai atualizar de acordo com o que se deseja? colocar de cada propriedade???? 
            //usuario.Nome = (?????);
            //usuario.Email = (?????);
            //usuario.Telefone = (?????);
            //usuario.Endereco = (?????);

            //mapeamento??

            await _repository.Atualizar(usuario); //ACESSA REPOSITÓRIO PARA CHAMAR MÉTODO DE ATUALIZAÇÃO
            return new AtualizarUsuarioResponse();

        }

    }
}
