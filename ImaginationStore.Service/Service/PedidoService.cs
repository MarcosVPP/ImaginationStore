using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;

namespace ImaginationStore.Service.Service
{
    public class PedidoeService
    {
        public void SalvarPedido(Pedido pedido) => PedidoRepository.SalvarPedido(pedido);
    }
}
