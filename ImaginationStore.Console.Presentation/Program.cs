using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;
using System;

namespace ImaginationStore.Console.Presentation
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Variavel para buscar a chave primaria de qualquer classe
            var id = 0;

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


            //System.Console.WriteLine("Indique quantos clientes serão cadastrados: ");
            //var QuantidadeACadastrar = Convert.ToInt16(System.Console.ReadLine());
            //while (QuantidadeACadastrar > 0)
            //{
            //    System.Console.WriteLine("Escreva um ID para cadastrar: ");
            //    var codigo = Convert.ToInt32(System.Console.ReadLine());

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var nome = System.Console.ReadLine();

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //  var telefone = Convert.ToInt16(System.Console.ReadLine());

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //  var filiacao = System.Console.ReadLine();

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var status = System.Console.ReadLine();

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var endereco = System.Console.ReadLine();

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var limitedecredito = Convert.Decimal(System.Console.ReadLine());

            //    var newclientes = new clientes(codigo, nome, telefone, filiacao, status, endereco, limitedecredito);
            //    SalvarClientes(newCclientes);
            //}

            //System.Console.WriteLine("Indique quantos endereços serão cadastrados: ");
            //var QuantidadeACadastrar = Convert.ToInt16(System.Console.ReadLine());
            //while (QuantidadeACadastrar > 0)
            //{
            //    System.Console.WriteLine("Escreva um ID para cadastrar: ");
            //    var codigo = Convert.ToInt32(System.Console.ReadLine());

            //    System.Console.WriteLine("Escreva uma rua para a categoria: ");
            //    var Rua = System.Console.ReadLine();

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //  var cep = Convert.ToInt16(System.Console.ReadLine());

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //  var numero = Convert.ToInt16(System.Console.ReadLine());

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var bairro = System.Console.ReadLine();

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var cidade = System.Console.ReadLine();

            //    System.Console.WriteLine("Escreva um nome para a categoria: ");
            //    var estado = System.Console.ReadLine();

            //    var newclientes = new clientes(codigo, nome, telefone, filiacao, status, endereco, limitedecredito);
            //    SalvarClientes(newCclientes);
            //}


            ////Buscar classes via ID
            //Busca categoria via ID
            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um ID para buscar uma categoria: ");
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

            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um Codigo para buscar um Cliente: ");
            //    ID = Convert.ToInt32(System.Console.ReadLine());

            //    
            //    if (id > 0)
            //    {
            //        BuscarCliente();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um Codigo valido para Categoria ser Cliente");
            //    }
            //}

            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um Codigo para buscar um Endereço: ");
            //    ID = Convert.ToInt32(System.Console.ReadLine());

            //    
            //    if (id > 0)
            //    {
            //        BuscarEnderco();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um codigo valido para Endereço ser buscado");
            //    }
            //}  

            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um Codigo para buscar um Fornecedor: ");
            //    ID = Convert.ToInt32(System.Console.ReadLine());

            //    
            //    if (id > 0)
            //    {
            //        BuscarFornecedor();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um codigo valido para Fornecedor ser buscado");
            //    }
            //}

            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um Codigo para buscar um Fornecedor: ");
            //    ID = Convert.ToInt32(System.Console.ReadLine());

            //    
            //    if (id > 0)
            //    {
            //        BuscarFornecedor();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um codigo valido para Fornecedor ser buscado");
            //    }
            //}

            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um Codigo para buscar um Pedido: ");
            //    ID = Convert.ToInt32(System.Console.ReadLine());

            //    
            //    if (id > 0)
            //    {
            //        BuscarPedido();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um codigo valido para Pedido ser buscado");
            //    }
            //}

            //while (id <= 0)
            //{
            //    System.Console.WriteLine("Escreva um Codigo para buscar um Produto: ");
            //    ID = Convert.ToInt32(System.Console.ReadLine());

            //    
            //    if (id > 0)
            //    {
            //        BuscarProduto();
            //    }
            //    else
            //    {
            //        System.Console.WriteLine("Escreva um codigo valido para Produto ser buscado");
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
            void BuscarCategoria()
            {
                System.Console.WriteLine(CategoriaRepository.BuscaProdutoPorCodigo(id).nome);

            }


            //"Break point" para poder ver a tela ao finalziar todas as ações
            System.Console.ReadLine();

        }
    }
}
