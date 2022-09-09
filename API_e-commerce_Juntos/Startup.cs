using API_Juntos.Application.Mappings;
using API_Juntos.Application.Models.InserirUsuario;
using API_Juntos.Application.Models.Produtos.AdicionarProduto;
using API_Juntos.Application.Models.Produtos.AtualizarProduto;
using API_Juntos.Application.Models.Produtos.ListarProdutoPorId;
using API_Juntos.Application.Models.Usuario.AtualizarUsuario;
using API_Juntos.Application.Models.Usuario.ExcluirUsuario;
using API_Juntos.Application.Models.Usuario.ListarUsuario;
using API_Juntos.Application.Models.Usuario.ListarUsuarioPorId;
using API_Juntos.Application.Models.Usuario.ListarUsuarios;
using API_Juntos.Application.UseCases;
using API_Juntos.Application.UseCases.Produtos;
using API_Juntos.Application.UseCases.Usuarios;
using API_Juntos.Core.Repositorios;
using API_Juntos.Infra.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_e_commerce_Juntos
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IUseCaseAsync<InserirUsuarioRequest, InserirUsuarioResponse>, InserirUsuarioUseCase>();
            services.AddTransient<IUseCaseAsync<AtualizarUsuarioRequest, AtualizarUsuarioResponse>, AtualizarUsuarioUseCase>();
            services.AddTransient<IUseCaseAsync<ExcluirUsuarioRequest, ExcluirUsuarioResponse>, ExcluirUsuarioUseCase>();
            services.AddTransient<IUseCaseAsync<ListarUsuarioPorIdRequest, ListarUsuarioPorIdResponse>, ListarUsuarioPorIdUseCase>();
            services.AddTransient<IUseCaseAsync<ListarUsuariosRequest, List<ListarUsuariosResponse>>, ListarUsuariosUseCase>();
            services.AddTransient<IUseCaseAsync<InserirProdutoRequest, InserirProdutoResponse>, InserirProdutoUseCase > ();
            services.AddTransient<IUseCaseAsync<AtualizarProdutoRequest, AtualizarProdutoResponse>, AtualizarProdutoUseCase>();
            services.AddTransient<IUseCaseAsync<ListarProdutoPorIdRequest, ListarProdutoPorIdResponse>, ListarProdutoPorIdUseCase>();
            

            services.AddAutoMapper(typeof(MappingProfile)); //SERIA MAIS ADEQUADO O TRANSIENT OU SCOPED?

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API_e_commerce_Juntos", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API_e_commerce_Juntos v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
