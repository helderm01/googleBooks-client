using System;
using System.Collections.Generic;
using System.Text;

namespace GoogleBooks.Dominio.DTO
{
    public class LivroDTO
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<string> Autores { get; set; }
        public string Url { get; set; }
        public int Paginas { get; set; }
    }
}
