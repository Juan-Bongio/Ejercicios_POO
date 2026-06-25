namespace Registro_Libros
{
    public class Libro
    {
        private string titulo;
        private string autor;
        private string isbn;
        private int numeroPaginas;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        public string Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public int NumeroPaginas
        {
            get { return numeroPaginas; }
            set { numeroPaginas = value; }
        }

        public Libro(string titulo, string autor, string isbn, int numeroPaginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.numeroPaginas = numeroPaginas;
        }

        public string EsLargo()
        {
            if (numeroPaginas > 300)
            {
                return $"{titulo} es un libro largo";
            }
            else
            {
                return $"{titulo} no es un libro largo";
            }
        }
    }
}