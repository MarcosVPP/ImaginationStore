using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;
using ImaginationStore.Service.Service;
using System;

namespace ImaginationStore.Console.Presentation
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variavel para buscar IDcategoria 
            // var IDcategoria = 0;

            ////Salvar Categoria
            System.Console.WriteLine("Indique quantos produtos serão cadastrados: ");
            var QuantidadeACadastrar = Convert.ToInt32(System.Console.ReadLine());
            while (QuantidadeACadastrar > 0)
            {
            System.Console.WriteLine("Escreva um ID para cadastrar: ");
            var codigo = Convert.ToInt32(System.Console.ReadLine());

            System.Console.WriteLine("Escreva um nome para a categoria: ");
            var nome = System.Console.ReadLine();

            var newCategoria = new Categoria(codigo, nome);
            SalvarCategoria(newCategoria);
            }

            //Busca categoria via ID
            //while (IDcategoria <= 0)
            //{
            //    System.Console.WriteLine("Escreva um ID para buscar categoria: ");
            //    IDcategoria = Convert.ToInt32(System.Console.ReadLine());

            //    //Validação ID Categoria
            //    if (IDcategoria > 0)
            //    {
            //        BuscarCategoria();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um ID valido para Categoria ser buscada");
            //    }
            //}

            void SalvarCategoria(Categoria categoria)
            {
                new CategoriaService().SalvarCategoria(categoria);
            }


            //Classe para buscar Categoria por ID somente
            //void BuscarCategoria()
            //{
            //    System.Console.WriteLine(CategoriaRepository.BuscaProdutoPorCodigo(IDcategoria).Nome);

            //}


            //"Break point" para poder ver a tela ao finalziar todas as ações
            System.Console.ReadLine();

        }
    }
}
