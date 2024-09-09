using System;
using System.Collections;

namespace TextQueryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un ArrayList para almacenar las cadenas
            ArrayList cadenas = new ArrayList();
            string input;

            // Recoger cadenas de texto del usuario
            Console.WriteLine("Introduce cadenas de texto. Para terminar, introduce una cadena vacía.");

            while (true)
            {
                Console.Write("Introduce una cadena: ");
                input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    // Salir del bucle si la cadena está vacía
                    break;
                }

                // Añadir la cadena al ArrayList
                cadenas.Add(input);
            }

            // Cambiar a modo de consulta
            Console.WriteLine("\nModo de consulta activado.");
            while (true)
            {
                Console.Write("Introduce un número para consultar (o 0 para salir): ");
                string consulta = Console.ReadLine();
                if (int.TryParse(consulta, out int indice))
                {
                    if (indice == 0)
                    {
                        // Salir del programa si el número es 0
                        break;
                    }
                    else if (indice > 0 && indice <= cadenas.Count)
                    {
                        // Mostrar la cadena en la posición especificada
                        Console.WriteLine($"Cadena en la posición {indice}: {cadenas[indice - 1]}");
                    }
                    else
                    {
                        // Indicar si el número está fuera del rango
                        Console.WriteLine("Número fuera del rango. Intenta de nuevo.");
                    }
                }
                else
                {
                    // Indicar si la entrada no es un número válido
                    Console.WriteLine("Entrada no válida. Introduce un número.");
                }
            }
        }
    }
}
