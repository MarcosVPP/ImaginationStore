using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;

namespace ImaginationStore.Service.Service
{
    public class ClienteService
    {
        public void SalvarCliente(Cliente cliente) => ClienteRepository.SalvarCliente(cliente);
    }
}
