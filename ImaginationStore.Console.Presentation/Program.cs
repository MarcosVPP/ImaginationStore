using ImaginationStore.Domain.Entities;
using ImaginationStore.Service.Service;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginationStore.Console.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {
            var categoria = new Categoria
            {
                Nome = "Teste"
            };

            new CategoriaService().SalvarCategoria(categoria);
            //System.Console.WriteLine(new CategoriaRepository().BuscaPorId(1).Nome);

            System.Console.ReadLine();
        }
    }
}
