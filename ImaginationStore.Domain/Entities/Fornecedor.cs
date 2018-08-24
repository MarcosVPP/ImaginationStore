using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImaginationStore.Domain.Entities
{
    public class Fornecedor
    {
        public virtual int CNPJ { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual int Telefone { get; protected set; }
        public virtual Endereco Endereco { get; protected set; }

        public Fornecedor() { }

        public Fornecedor(int cnpj, string nome, int telefone, Endereco endereco)
        {
            this.CNPJ = cnpj;
            this.Nome = nome;
            this.Endereco = endereco;
        }
    }
}
