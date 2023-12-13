using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t**Ejercicio 4**");
            // Crear un objeto estudiante1
            Estudiante estudiante1 = new Estudiante();
            estudiante1.Nombre = "Jose Imbaquinga   ";
            estudiante1.Edad = 23;
            estudiante1.Carrera = "Ingeniería de Software";

            // Llamar al método MostrarInformacion para el objeto estudiante1
            estudiante1.MostrarInformacion();

            Console.ReadKey(); // Detener la consola para visualizar la salida
        }
    }
}
