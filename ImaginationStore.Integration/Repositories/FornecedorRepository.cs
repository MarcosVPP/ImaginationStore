using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImaginationStore.Domain.Entities;
using NHibernate;

namespace ImaginationStore.Integration.Repositories
{
    public static class FornecedorRepository
    {

        public static void SalvarFornecedor(Fornecedor fornecedor)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Save(fornecedor);
                transacao.Commit();
            }
        }

        public static Fornecedor BuscaFornecedorPorCnpj(int id)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            {
                return session.Get<Fornecedor>(id);
            }
        }
    }
}