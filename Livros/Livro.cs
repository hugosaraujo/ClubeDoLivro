using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeDoLivro.Livros
{
    public class Livro
    {
        public string Titulo { get; private set; }
        public string Autor { get; set; }
        public string Isbn { get; private set; }
        public int AnoPublicacao { get; set; }
        public string Categoria { get; set; }
        public int QtdPaginas { get; set; }
        public string PaisPublicacao { get; set; }

        public Livro(string titulo, string isbn)
        {
            this.Titulo = titulo; 
            this.Isbn = isbn; 
        }
    }
}
