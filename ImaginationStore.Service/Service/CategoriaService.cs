using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginationStore.Service.Service
{
    public class CategoriaService
    {
        public void SalvarCategoria(Categoria categoria) => CategoriaRepository.SalvarCategoria(categoria);
    }
}
