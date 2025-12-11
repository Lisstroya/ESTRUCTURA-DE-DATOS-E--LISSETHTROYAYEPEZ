using System;

namespace RegistroEstudiante
{
    class Estudiante
    {
        public int ID { get; set; }
        public string Nombres { get; set; } = "";
        public string Apellidos { get; set; } = "";
        public string Direccion { get; set; } = "";
        public string[] Telefonos { get; set; } = new string[3];

        public void MostrarInformacion()
        {
            Console.WriteLine("\n=== INFORMACIÓN DEL ESTUDIANTE ===");
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Nombres: {Nombres}");
            Console.WriteLine($"Apellidos: {Apellidos}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine("Teléfonos:");
            
            for (int i = 0; i < Telefonos.Length; i++)
            {
                Console.WriteLine($"  Teléfono {i + 1}: {Telefonos[i]}");
            }
            Console.WriteLine("==================================\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante = new Estudiante();
            
            Console.WriteLine("REGISTRO DE ESTUDIANTE");
            Console.WriteLine("======================\n");
            
            Console.Write("Ingrese ID del estudiante: ");
            estudiante.ID = Convert.ToInt32(Console.ReadLine());
            
            // CORREGIDO: Agregar ?? "" para evitar null
            Console.Write("Ingrese nombres: ");
            estudiante.Nombres = Console.ReadLine() ?? "";
            
            Console.Write("Ingrese apellidos: ");
            estudiante.Apellidos = Console.ReadLine() ?? "";
            
            Console.Write("Ingrese dirección: ");
            estudiante.Direccion = Console.ReadLine() ?? "";
            
            Console.WriteLine("\nIngrese 3 números de teléfono:");
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Teléfono {i + 1}: ");
                estudiante.Telefonos[i] = Console.ReadLine() ?? "";
            }
            
            estudiante.MostrarInformacion();
            
            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}