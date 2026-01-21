using System;

namespace TareaPilas
{
    class Program
    {
        // Método principal del programa
        static void Main(string[] args)
        {
        
            // Ejercicio 1
            BalanceoParentesis.Ejecutar();

            Console.WriteLine("\n---------------------------------\n");

            // Ejercicio 2
            TorresDeHanoi.Ejecutar();

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}