using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ImaginationStore.Domain.Entities
{
    class Produto
    {
        public virtual int Codigo { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual double Valor { get; protected set; }
        public virtual Categoria Categoria { get; protected set; }
        public virtual DateTime DataDeFabricacao { get; protected set; }
        public virtual DateTime DataDeValidade { get; protected set; }
        public virtual int Quantidade { get; protected set; }
    }
}
