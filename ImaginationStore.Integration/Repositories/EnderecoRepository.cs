using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImaginationStore.Domain.Entities;
using NHibernate;

namespace ImaginationStore.Integration.Repositories
{
    public static class EnderecoRepository
    {

        public static void SalvarCategoria(Endereco categoria)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Save(categoria);
                transacao.Commit();
            }
        }

        public static Endereco BuscaProdutoPorCodigo(int id)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            {
                return session.Get<Endereco>(id);
            }
        }
    }
}
