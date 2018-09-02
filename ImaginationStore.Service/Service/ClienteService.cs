using ImaginationStore.Domain.Entities;
using ImaginationStore.Integration.Repositories;

namespace ImaginationStore.Service.Service
{
    public class ClienteService
    {
        public void SalvarCliente(Cliente cliente) => ClienteRepository.SalvarCliente(cliente);
        public Cliente PostProcura(int codigoCliente) => ClienteRepository.BuscaClientePorCodigo(codigoCliente);
        public void Post(int Clientecodigo, string nomeCliente, int telefonecliente, string filiacaocliente, string limitedecreditoCliente)
        {
            ClienteRepository.SalvarCliente(Clientecodigo, nomeCliente, telefonecliente, filiacaocliente, limitedecreditoCliente);
        }
    }


    //public Cliente Get(int codigoCliente, string nomeCliente, int telefoneCliente, string filicaoCliente, decimal limitedecreditoCliente)
    //{
    //    return ClienteRepository.SalvarCliente(ClienteRepository.SalvarCliente (Cliente.Codigo, nomeCliente, telefoneCliente, filicaoCliente, limitedecreditoCliente));
    //}
}

