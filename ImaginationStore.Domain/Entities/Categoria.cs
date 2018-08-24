﻿namespace ImaginationStore.Domain.Entities
{
    public class Categoria
    {
        public virtual int Codigo { get; protected set; }
        public virtual string Nome { get; protected set; }

        public Categoria() { }

        public Categoria(int codigo, string nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }
    }
}
