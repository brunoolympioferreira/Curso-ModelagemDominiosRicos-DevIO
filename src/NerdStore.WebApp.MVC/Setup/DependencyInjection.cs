using NerdStore.Catalogo.Application.Services;
using NerdStore.Catalogo.Domain;
using NerdStoreCatalogo.Data.Repository;
using NerdStoreCatalogo.Data;
using MediatR;
using NerdStore.Catalogo.Domain.Events;
using NerdStore.Vendas.Application.Commands;
using NerdStore.Vendas.Domain;
using NerdStore.Vendas.Data.Repository;
using NerdStore.Vendas.Data;
using NerdStore.Core.Communication.Mediator;
using NerdStore.Core.Messages.CommonMessages.Notifications;
using NerdStore.Vendas.Application.Events;
using NerdStore.Vendas.Application.Queries;

namespace NerdStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Mediator
            services.AddScoped<IMediatorHandler, MediatrHandler>();

            // Notifications
            services.AddScoped<INotificationHandler<DomainNotification>, DomainNotificationHandler>();

            // Catálogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();

            // Vendas
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoQueries, PedidoQueries>();
            services.AddScoped<IRequestHandler<AdicionarItemPedidoCommand, bool>, PedidoCommandHandler>();
            services.AddScoped<VendasContext>();

            services.AddScoped<INotificationHandler<PedidoRascunhoIniciadoEvent>, PedidoEventHanlder>();
            services.AddScoped<INotificationHandler<PedidoAtualizadoEvent>, PedidoEventHanlder>();
            services.AddScoped<INotificationHandler<PedidoAtualizadoEvent>, PedidoEventHanlder>();
        }
    }
}
