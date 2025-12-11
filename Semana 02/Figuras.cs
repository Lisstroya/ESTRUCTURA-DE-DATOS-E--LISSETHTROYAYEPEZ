using System;

namespace FigurasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== CALCULADORA DE FIGURAS ===\n");
            
            Cuadrado miCuadrado = new Cuadrado(5);
            Console.WriteLine($"Cuadrado de lado 5:");
            Console.WriteLine($"Área: {miCuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro: {miCuadrado.CalcularPerimetro()}\n");
            
            Triangulo miTriangulo = new Triangulo(4, 3, 3, 4, 5);
            Console.WriteLine($"Triángulo (base=4, altura=3, lados 3-4-5):");
            Console.WriteLine($"Área: {miTriangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {miTriangulo.CalcularPerimetro()}");
            
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}