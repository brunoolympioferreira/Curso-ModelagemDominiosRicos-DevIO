using NerdStore.Core.Messages;

namespace NerdStore.Vendas.Application.Events
{
    public class PedidoAtualizadoEvent : Event
    {
        public Guid ClienteId { get; private set; }
        public Guid PedidoId { get; private set; }
        public decimal ValotTotal { get; private set; }

        public PedidoAtualizadoEvent(Guid clienteId, Guid pedidoId, decimal valotTotal)
        {
            AggregateId = pedidoId;
            ClienteId = clienteId;
            PedidoId = pedidoId;
            ValotTotal = valotTotal;
        }
    }
}
