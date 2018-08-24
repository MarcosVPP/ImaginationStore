using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;

namespace ImaginationStore.Service.Service
{
    public class EnderecoService
    {
        public void SalvarEndereco(Endereco endereco) => EnderecoRepository.SalvarEndereco(endereco);
    }
}