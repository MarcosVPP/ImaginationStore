namespace ImaginationStore.Domain.Entities
{
    public class Endereco
    {
        public virtual int Codigo { get; protected set; }
        public virtual string Rua { get; protected set; }
        public virtual int Cep { get; protected set; }
        public virtual int Numero { get; protected set; }
        public virtual string Bairro { get; protected set; }
        public virtual string Cidade { get; protected set; }
        public virtual string Estado { get; protected set; }

        public Endereco() { }

        public Endereco(int codigo, string rua, int cep, int numero, string bairro, string cidade, string estado)
        {
            this.Codigo = codigo;
            this.Rua = rua;
            this.Cep = cep;
            this.Numero = numero;
            this.Bairro = bairro;
            this.Cidade = cidade;
            this.Estado = estado;
        }
    }
}
