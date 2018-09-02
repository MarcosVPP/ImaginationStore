using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImaginationStore.Domain.Entities;
using NHibernate;

namespace ImaginationStore.Integration.Repositories
{
    public static class ClienteRepository
    {

        public static void SalvarCliente(int clientecodigo, string nomeCliente, int telefonecliente, string filiacaocliente,decimal limitedecreditoCliente, Cliente cliente)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Save(cliente);
                transacao.Commit();
            }
        }

        public static Cliente BuscaClientePorCodigo(int Codigo)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            {
                return session.Get<Cliente>(Codigo);
            }
        }

        public static void ExcluiCliente(Cliente cliente)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Delete(cliente);
                transacao.Commit();
            }
                
        }

        public static void AtualizaCliente(Cliente cliente)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Update(cliente);
                transacao.Commit();
            }

        }
    }
}
