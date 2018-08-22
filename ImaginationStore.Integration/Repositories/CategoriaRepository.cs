using ImaginationStore.Domain.Entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginationStore.Integration.Repositories
{
    public static class CategoriaRepository
    {

        public static void SalvarCategoria(Categoria categoria)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Save(categoria);
                transacao.Commit();
            }
        }

        public static Categoria BuscaPorId(int id)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            {
                return session.Get<Categoria>(id);
            }
        }
    }
}
