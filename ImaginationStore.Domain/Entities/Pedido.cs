using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginationStore.Domain.Entities
{
    public class Pedido
    {
        public virtual int Codigo { get; protected set; }
        public virtual Produto Produto { get; protected set; }
        public virtual Cliente Cliente { get; protected set; }
        public virtual DateTime DataDeCriacao { get; protected set; }
        public virtual decimal ValorTotal { get; protected set; }
        public virtual bool Status { get; protected set; }

        public Pedido() { }

        public Pedido(int codigo, Produto produto, Cliente cliente, DateTime datadecriacao, decimal valortotal, bool status)
        {
            this.Codigo = codigo;
            this.Produto = produto;
            this.Cliente = cliente;
            this.DataDeCriacao = datadecriacao;
            this.ValorTotal = valortotal;
            this.Status = status; ;
        }
    }
}
