namespace ImaginationStore.Domain.Entities
{
    public class Cliente
    {
        public virtual int Codigo { get; protected set; }
        public virtual string Nome { get; protected set; }
        public virtual int Telefone { get; protected set; }
        public virtual string Filizacao { get; protected set; }
        public virtual int Status { get; protected set; }
        public virtual Endereco Endereco { get; protected set; }
        public virtual decimal LimiteDeCredito { get; protected set; }

        //Instancia para poder realziar conexão
        public Cliente() { }

        public Cliente(int codigo, string nome, int telefone, string filizacao, int status, Endereco endereco, decimal limitedecredito)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Telefone = telefone;
            this.Filizacao = filizacao;
            this.Status = status;
            this.Endereco = endereco;
            this.LimiteDeCredito = limitedecredito;

        }
    }
}
