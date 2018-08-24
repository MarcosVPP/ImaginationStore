using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;

namespace ImaginationStore.Service.Service
{
    public class FornecedorService
    {
        public void SalvarFornecedor(Fornecedor fornecedor) => FornecedorRepository.SalvarFornecedor(fornecedor);
    }
}