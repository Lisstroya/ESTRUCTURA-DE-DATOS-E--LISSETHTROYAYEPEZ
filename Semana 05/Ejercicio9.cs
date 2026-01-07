using System;
using System.Collections.Generic;

class Ejercicio9
{
    public void Ejecutar()
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower();

        Dictionary<char, int> vocales = new Dictionary<char, int>
        {
            { 'a', 0 },
            { 'e', 0 },
            { 'i', 0 },
            { 'o', 0 },
            { 'u', 0 }
        };
    //Contar vocales
        foreach (char letra in palabra)
        {
            if (vocales.ContainsKey(letra))
            {
                vocales[letra]++;
            }
        }

        Console.WriteLine("Cantidad de vocales:");
        foreach (var vocal in vocales)
        {
            Console.WriteLine($"{vocal.Key}: {vocal.Value}");
        }
    }
}