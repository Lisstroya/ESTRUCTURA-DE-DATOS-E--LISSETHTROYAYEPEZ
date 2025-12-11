using System;

namespace FigurasGeometricas
{
    // La clase Cuadrado representa un cuadrado geométrico
    // Tiene un atributo llamado "Lado" que define el tamaño del cuadrado
    public class Cuadrado
    {
        // Propiedad que guarda el valor del lado del cuadrado
        public double Lado { get; set; }

        // Constructor de la clase: sirve para crear un cuadrado con un valor inicial de lado
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Método que calcula el área del cuadrado usando la fórmula Lado * Lado
        public double CalcularArea()
        {
            return Lado * Lado;
        }

        // Método que calcula el perímetro multiplicando el lado por 4
        public double CalcularPerimetro()
        {
            return 4 * Lado;
        }
    }
}