using System;
using System.Collections.Generic;

class Ejercicio4
{
    public void Ejecutar()
    {
        List<int> numeros = new List<int>();
    
    //Pedir 5 numeros de la loteria y mostrarlos ordenados
        Console.WriteLine("Ingrese 5 números de la lotería:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros.Add(int.Parse(Console.ReadLine()));
        }
    //Ordenar la lista de menor a mayor
        numeros.Sort();

        Console.WriteLine("Números ordenados de menor a mayor:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}