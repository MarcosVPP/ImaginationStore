namespace ImaginationStore.Domain.Entities
{
    public class Categoria
    {
        public virtual int Codigo { get; set; }
        public virtual string Nome { get; set; }

        public Categoria(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
       }
    }
}
