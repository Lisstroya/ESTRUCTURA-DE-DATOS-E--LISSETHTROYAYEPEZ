using System;

namespace Semana10

{
    class Program
    {
        static void Main(string[] args)
        {
            CampañaVacunacion proceso = new CampañaVacunacion();
            proceso.Ejecutar();

            Console.WriteLine("\nProceso finalizado.");
            Console.ReadKey();
        }
    }
}
