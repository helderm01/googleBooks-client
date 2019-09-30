using GoogleBooks.Integracoes;
using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var authService = new GoogleAuthService();

            var auth = authService.Login().GetAwaiter().GetResult();
            //authService.RefreshToken(auth).GetAwaiter().GetResult();

            var livros = new GoogleBooksService().PesquisarLivros("Use a cabeça!");

            foreach (var item in livros)
            {
            }

            Console.ReadKey();
        }
    }
}
