using API_Juntos.Application.Models.InserirUsuario;
using API_Juntos.Application.Models.Pedidos.InserirPedido;
using API_Juntos.Application.Models.Produtos.AdicionarProduto;
using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Application.Models.Usuario.ListarUsuarioPorId;
using API_Juntos.Core.Entidades;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Juntos.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<InserirUsuarioRequest, Usuario>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CPF, fonte => fonte.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco));

            CreateMap<Usuario, ListarUsuarioPorIdResponse>()
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.CPF, fonte => fonte.MapFrom(src => src.CPF))
                .ForMember(dest => dest.Email, fonte => fonte.MapFrom(src => src.Email))
                .ForMember(dest => dest.Telefone, fonte => fonte.MapFrom(src => src.Telefone))
                .ForMember(dest => dest.Endereco, fonte => fonte.MapFrom(src => src.Endereco));

            //mapeamento do get all? atualizar? excluir?

            CreateMap<InserirProdutoRequest, Produto>()
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Lote, fonte => fonte.MapFrom(src => src.Lote))
                .ForMember(dest => dest.Validade, fonte => fonte.MapFrom(src => src.Validade))
                .ForMember(dest => dest.QuantidadeEmbalagem, fonte => fonte.MapFrom(src => src.QuantidadeEmbalagem))
                .ForMember(dest => dest.Valor, fonte => fonte.MapFrom(src => src.Valor));

            CreateMap<Produto, ListarProdutoPorIdResponse>()
                .ForMember(dest => dest.Id, fonte => fonte.MapFrom(src => src.Id))
                .ForMember(dest => dest.Nome, fonte => fonte.MapFrom(src => src.Nome))
                .ForMember(dest => dest.Lote, fonte => fonte.MapFrom(src => src.Lote))
                .ForMember(dest => dest.Validade, fonte => fonte.MapFrom(src => src.Validade))
                .ForMember(dest => dest.QuantidadeEmbalagem, fonte => fonte.MapFrom(src => src.QuantidadeEmbalagem))
                .ForMember(dest => dest.Valor, fonte => fonte.MapFrom(src => src.Valor));

            CreateMap<InserirPedidoRequest, Pedido>()
                .ForMember(dest => dest.DataPedido, fonte => fonte.MapFrom(src => src.DataPedido))
                .ForMember(dest => dest.Produtos, fonte => fonte.MapFrom(src => src.Produtos))
                .ForMember(dest => dest.IdUsuario, fonte => fonte.MapFrom(src => src.IdUsuario));
            //seria assim? como colocar as demais infos??????? o valor é gerado internamente, o que entraria aqui?



                
        }
    }
}
