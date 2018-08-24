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

        public static void SalvarCategoria(Cliente categoria)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Save(categoria);
                transacao.Commit();
            }
        }

        public static Cliente BuscaProdutoPorCodigo(int id)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            {
                return session.Get<Cliente>(id);
            }
        }
    }
}
