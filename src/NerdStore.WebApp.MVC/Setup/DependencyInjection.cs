using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Domain;
using NerdStore.Core.Bus;
using NerdStoreCatalogo.Data.Repository;
using NerdStoreCatalogo.Data;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            //Domain Bus(Mediator)
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            //Catálogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();
        }
    }
}
