using System;


namespace ImaginationStore.Domain.Entities
{
    public class Produto
    {
        public virtual int Codigo { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual decimal Valor { get; protected set; }
        public virtual Categoria Categoria { get; protected set; }
        public virtual DateTime DataDeFabricacao { get; protected set; }
        public virtual DateTime DataDeValidade { get; protected set; }
        public virtual int Quantidade { get; protected set; }
        public virtual Fornecedor Fornecedor { get; protected set; }

        public Produto() { }

        public Produto(int codigo, string nome, decimal valor, DateTime datadefabricacao, DateTime datadevalidade, int quantidade, Fornecedor fornecedor)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Valor = valor;
            this.DataDeFabricacao = datadefabricacao;
            this.DataDeValidade = datadevalidade;
            this.Quantidade = quantidade;
            this.Fornecedor = fornecedor;
        }

    }
}
