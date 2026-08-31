using System;
namespace LibroCalificaciones2
{
    public class LibroPruebaCalificaciones
    {
        static void Main(string[] args)
        {
            MilibroCalificaciones MyLibro = new MilibroCalificaciones();

            Console.WriteLine("porfavor ingrese el nombre del curso: ");

            string nombreDelCurso = Console.ReadLine();
            Console.WriteLine();

            MyLibro.MostrarMensaje(nombreDelCurso);
        }
    }
}
