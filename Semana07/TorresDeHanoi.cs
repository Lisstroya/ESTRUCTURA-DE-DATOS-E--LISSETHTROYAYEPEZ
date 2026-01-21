using System;
using System.Collections.Generic;

namespace TareaPilas
{
    class TorresDeHanoi
    {
        // Método que ejecuta el ejercicio 
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 2: Torres de Hanoi\n");

            int discos = 3; // Número de discos

            // Cada torre se representa con una pila
            Stack<int> origen = new Stack<int>();
            Stack<int> auxiliar = new Stack<int>();
            Stack<int> destino = new Stack<int>();

            // Se cargan los discos en la torre origen
            for (int i = discos; i >= 1; i--)
            {
                origen.Push(i);
            }

            Console.WriteLine($"Resolviendo Torres de Hanoi con {discos} discos:\n");

            // Llamada al algoritmo
            MoverDiscos(discos, origen, destino, auxiliar, 'A', 'C', 'B');
        }

        // Método recursivo que resuelve el problema de Hanoi
        private static void MoverDiscos(
            int n,
            Stack<int> origen,
            Stack<int> destino,
            Stack<int> auxiliar,
            char torreOrigen,
            char torreDestino,
            char torreAuxiliar)
        {
            // Caso base: mover un solo disco
            if (n == 1)
            {
                int disco = origen.Pop();
                destino.Push(disco);
                Console.WriteLine($"Mover disco {disco} de {torreOrigen} a {torreDestino}");
                return;
            }

            // Mover n-1 discos a la torre auxiliar
            MoverDiscos(n - 1, origen, auxiliar, destino,
                        torreOrigen, torreAuxiliar, torreDestino);

            // Mover el disco más grande al destino
            int discoMayor = origen.Pop();
            destino.Push(discoMayor);
            Console.WriteLine($"Mover disco {discoMayor} de {torreOrigen} a {torreDestino}");

            // Mover los n-1 discos al destino
            MoverDiscos(n - 1, auxiliar, destino, origen,
                        torreAuxiliar, torreDestino, torreOrigen);
        }
    }
}