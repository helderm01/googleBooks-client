using Google.Apis.Books.v1;
using Google.Apis.Services;
using GoogleBooks.Dominio.DTO;
using System.Collections.Generic;

namespace GoogleBooks.Integracoes
{
    public class GoogleBooksService
    {
        public IEnumerable<LivroDTO> PesquisarLivros(string parametros)
        {
            var service = new BooksService(new BaseClientService.Initializer());
            var livrosPesquisados = service.Volumes.List(parametros).Execute();

            foreach (var livro in livrosPesquisados.Items)
            {
                yield return new LivroDTO
                {
                    Id = livro.Id,
                    Descricao = livro.VolumeInfo.Description,
                    Autores = livro.VolumeInfo.Authors,
                    Paginas = livro.VolumeInfo.PageCount.Value,
                    Titulo = livro.VolumeInfo.Title,
                    Url = livro.VolumeInfo.ImageLinks.Thumbnail
                };
            }
        }
    }
}
