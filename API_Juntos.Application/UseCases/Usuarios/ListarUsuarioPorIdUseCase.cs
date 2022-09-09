using API_Juntos.Application.Models.Usuario.ListarUsuarioPorId;
using API_Juntos.Core.Repositorios;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.UseCases.Usuarios
{
    public class ListarUsuarioPorIdUseCase : IUseCaseAsync<ListarUsuarioPorIdRequest, ListarUsuarioPorIdResponse>
    {
        private readonly IUsuarioRepository _repository;
        private readonly IMapper _mapper;

        public ListarUsuarioPorIdUseCase(IUsuarioRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<ListarUsuarioPorIdResponse> ExecuteAsync(ListarUsuarioPorIdRequest request)
        {
            var usuario = await _repository.ListarPorId(request.Id);

            var retorno = (ListarUsuarioPorIdResponse)null; //POR QUE A ESCRITA É DESSA MANEIRA?
            if (usuario != null)
            {
                retorno = _mapper.Map<ListarUsuarioPorIdResponse>(retorno);
            }
            return  await Task.FromResult(retorno);
        }
    }
}
