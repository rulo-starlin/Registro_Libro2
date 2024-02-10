
using Registro_Libro2.Data;

namespace Registro_Libro2.Data

{
    public class RegistroLibros
    {

        // Lista para almacenar los libros registrados
        private readonly List<Libros> librosRegistrados;

        // Constructor
        public RegistroLibros()
        {
            librosRegistrados = new List<Libros>();
        }

        // Método para agregar un libro al registro
        public void AgregarLibro(Libros libro)
        {
            librosRegistrados.Add(libro);
            Console.WriteLine("Libro registrado con éxito.");
        }
        public List<Libros> ObtenerLibros()
        {
            return librosRegistrados;
        }
        // Nuevo método para registrar un libro
        public void RegistrarLibro(string titulo, string autor, int añoPublicacion, string isbn)
        {
            Libros nuevoLibro = new(titulo, autor, añoPublicacion, isbn);
            librosRegistrados.Add(nuevoLibro);
            Console.WriteLine("Libro registrado con éxito.");
        }
        // Método para mostrar todos los libros en el registro
        public void MostrarLibros()
        {
            Console.WriteLine("Libros Registrados:");
            foreach (var libro in librosRegistrados)
            {
                libro.MostrarInformacion();
                Console.WriteLine();
            }
        }
        // Método para obtener la lista de libros registrados
        
    }
    // Nuevo método para registrar un libro
   
}


//public partial class Program
//{
//    static void Main()
//    {
//        // Ejemplo de uso
//        RegistroLibros registro = new RegistroLibros();

//        Libros libro1 = new Libros("Cien años de soledad", "Gabriel García Márquez", 1967, "978-0307474728");
//        Libros libro2 = new Libros("To Kill a Mockingbird", "Harper Lee", 1960, "978-0061120084");

//        registro.AgregarLibro(libro1);
//        registro.AgregarLibro(libro2);

//        registro.MostrarLibros();
//    }
//}


