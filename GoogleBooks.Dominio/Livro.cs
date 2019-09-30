using GoogleBooks.RavenDB;
using System;

namespace GoogleBooks.Dominio
{
    public class Livro
    {

        public Livro()
        {
            //Inserir LivroService aqui
            //IoC
        }

        public string Id { get; private set; }
        public string Autor { get; set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public int Paginas { get; private set; }
        public string UrlImagem { get; private set; }

        public virtual void FavoritarLivro(Usuario usuario)
        {
            LivroFavorito favorito = new LivroFavorito(this, usuario);

        }

        public virtual void DesfavoritarLivro()
        {

        }
    }
}
