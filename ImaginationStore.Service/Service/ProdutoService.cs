using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;

namespace ImaginationStore.Service.Service
{
    public class ProdutoService
    {
        public void SalvarProduto(Produto produto) => ProdutoRepository.SalvarProduto(produto);
    }
}
