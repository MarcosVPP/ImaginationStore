using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImaginationStore.Domain.Entities;
using NHibernate;

namespace ImaginationStore.Integration.Repositories
{
    public static class ProdutoRepository
    {

        public static void SalvarProduto(Produto produto)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Save(produto);
                transacao.Commit();
            }
        }

        public static Produto BuscaProdutoPorCodigo(int id)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            {
<<<<<<< HEAD
                //IList<Categoria> 
=======
                
>>>>>>> 247520987a5e45e67f7dcabc3de7534a606043ef
                return session.Get<Produto>(id);
            }
        }
    }
}