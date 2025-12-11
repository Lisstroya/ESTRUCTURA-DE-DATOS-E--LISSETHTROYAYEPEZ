using System;

namespace FigurasGeometricas
{
    public class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }
        public double Lado3 { get; set; }
        
        public Triangulo(double baseTri, double altura, double lado1, double lado2, double lado3)
        {
            Base = baseTri;
            Altura = altura;
            Lado1 = lado1;
            Lado2 = lado2;
            Lado3 = lado3;
        }
        
        public double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
        
        public double CalcularPerimetro()
        {
            return Lado1 + Lado2 + Lado3;
        }
    }
}