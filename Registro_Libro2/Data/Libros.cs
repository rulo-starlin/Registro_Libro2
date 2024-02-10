
namespace Registro_Libro2.Data
{
    public class Libros
    {
        // Propiedades del libro
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public string ISBN { get; set; }

        // Constructor
        public  Libros(string titulo, string autor, int añoPublicacion, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            ISBN = isbn;
        }

        // Método para mostrar información del libro
        public void MostrarInformacion()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Autor: {Autor}");
            Console.WriteLine($"Año de Publicación: {AñoPublicacion}");
            Console.WriteLine($"ISBN: {ISBN}");
        }
    }
}
