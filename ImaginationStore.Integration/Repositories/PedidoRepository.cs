using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImaginationStore.Domain.Entities;
using NHibernate;

namespace ImaginationStore.Integration.Repositories
{
    public static class PedidoRepository
    {

        public static void SalvarPedido(Pedido pedido)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                ITransaction transacao = session.BeginTransaction();
                session.Save(pedido);
                transacao.Commit();
            }
        }

        public static Pedido BuscaPedidoPorCodigo(int id)
        {
            using (ISession session = NHibernateHelper.AbreSession())
            {
                return session.Get<Pedido>(id);
            }
        }
    }
}