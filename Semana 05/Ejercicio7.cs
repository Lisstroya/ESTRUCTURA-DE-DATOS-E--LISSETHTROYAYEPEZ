using System;
using System.Collections.Generic;

class Ejercicio7
{
    public void Ejecutar()
    {
        //Crear lista con el abecedario
        List<char> abecedario = new List<char>();

        for (char letra = 'A'; letra <= 'Z'; letra++)
        {
            abecedario.Add(letra);
        }

        // Eliminar posiciones múltiplos de 3 
        for (int i = abecedario.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0)
            {
                abecedario.RemoveAt(i);
            }
        }

        Console.WriteLine("Abecedario resultante:");
        Console.WriteLine(string.Join(", ", abecedario));
    }
}
