using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t**Ejercicio 2**");
            // Edad quemada para verificar si es mayor o no
            int edad = 17;
            Console.WriteLine("Edad: 15");
            // Verificar si la edad quemada es mayor o no a 18
            if (edad >= 18)
            {
                Console.WriteLine("La edad  cumple con ser mayor de edad.");
            }
            else
            {
                Console.WriteLine("La edad  no es mayor de edad.");
            }

            Console.WriteLine("\nEjercicio por consola");
            // Pedir al usuario que ingrese su edad
            Console.Write("Ingrese su edad: ");
            int edadIngresar;

            // Validar la entrada del usuario
            while (!int.TryParse(Console.ReadLine(), out edadIngresar))
            {
                Console.WriteLine("Por favor, ingrese un número válido para la edad:");
            }

            // Verificar si la edad ingresada por el usuario es mayor o no a 18
            if (edadIngresar >= 18)
            {
                Console.WriteLine("Usted es mayor de edad.");
            }
            else
            {
                Console.WriteLine("Usted NO es mayor de edad.");
            }

            Console.ReadKey(); // Detener la consola para visualizar el resultado
        }
    }
}
