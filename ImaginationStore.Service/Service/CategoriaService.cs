using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;

namespace ImaginationStore.Service.Service
{
    public class CategoriaService
    {
        public void SalvarCategoria(Categoria categoria) => CategoriaRepository.SalvarCategoria(categoria);
    }
}
