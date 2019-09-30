using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleBooks.Dominio
{
    public class LivroFavorito
    {
        public LivroFavorito(Livro livro, Usuario usuario)
        {
            Id = Guid.NewGuid().ToString();
            Livro = livro;
            Usuario = usuario;
        }

        public string Id { get; private set; }
        public Livro Livro { get; private set; }
        public Usuario Usuario { get; private set; }

    }
}
