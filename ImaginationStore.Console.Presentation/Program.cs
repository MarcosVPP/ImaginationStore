using ImaginationStore.Domain.Entities;
using System;

namespace ImaginationStore.Console.Presentation
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variavel para buscar a chave primaria de qualquer classe
            // var id = 0;

            ////Entradas para salvar classes
            //Salvar categoria
            //System.Console.WriteLine("Indique quantos produtos serão cadastrados: ");
            //var QuantidadeACadastrar = Convert.ToInt32(System.Console.ReadLine());
            //while (QuantidadeACadastrar > 0)
            //{
            //    System.Console.WriteLine("Escreva um ID para cadastrar: ");
            //    var codigo = Convert.ToInt32(System.Console.ReadLine());

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var nome = System.Console.ReadLine();

            //    var newCategoria = new Categoria(codigo, nome);
            //    SalvarCategoria(newCategoria);
            //}


            ////Buscar classes via ID
            //Busca categoria via ID
            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um ID para buscar categoria: ");
            //    ID = Convert.ToInt32(System.Console.ReadLine());

            //    //Validação ID Categoria
            //    if (id > 0)
            //    {
            //        BuscarCategoria();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um ID valido para Categoria ser buscada");
            //    }
            //}


            ////Metodos salvar
            //void SalvarCategoria(Categoria categoria)
            //{
            //    new CategoriaService().SalvarCategoria(categoria);
            //}

            //void SalvarCliente(Cliente cliente)
            //{
            //    new ClienteService().SalvarCliente(cliente);
            //}

            //void SalvarEndereco(Endereco endereco)
            //{
            //    new EnderecoService().SalvarEndereco(endereco);
            //}

            //void SalvarEndereco(Endereco endereco)
            //{
            //    new EnderecoService().SalvarEndereco(endereco);
            //}

            //void SalvarFornecedor(Fornecedor fornecedor)
            //{
            //    new EnderecoFornecedor().SalvarFornecedor(fornecedor);
            //}

            //void SalvarPedido(Pedido pedido)
            //{
            //    new EnderecoPedido().SalvarPedido(pedido);
            //}

            //void SalvarProduto(Produto produto)
            //{
            //    new EnderecoProduto().SalvarProduto(produto);
            //}


            ////Classe para buscar Categoria por ID somente
            //void BuscarCategoria()
            //{
            //    System.Console.WriteLine(CategoriaRepository.BuscaProdutoPorCodigo(id).Nome);

            //}


            //"Break point" para poder ver a tela ao finalziar todas as ações
            System.Console.ReadLine();

        }
    }
}
