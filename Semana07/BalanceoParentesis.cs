using System;
using System.Collections.Generic;

namespace TareaPilas
{
    class BalanceoParentesis
    {
        // Método que ejecuta el ejercicio 
        public static void Ejecutar()
        {
            Console.WriteLine("Ejercicio 1: Parentesis balanceados\n");

            string expresion = "(3 + 5 ) * [2 + {4 - (8 + 1)}]";

            Console.WriteLine("Expresión evaluada:");
            Console.WriteLine(expresion + "\n");

            if (EstaBalanceada(expresion))
                Console.WriteLine("Resultado: Formula balanceada.");
            else
                Console.WriteLine("Resultado: Formula no balanceada.");
        }

        // Método que verifica si la expresión está balanceada usando una pila
        private static bool EstaBalanceada(string expresion)
        {
            Stack<char> pila = new Stack<char>();

            foreach (char c in expresion)
            {
                // Si es símbolo de apertura: agregar a la pila
                if (c == '(' || c == '{' || c == '[')
                {
                    pila.Push(c);
                }
                // Si es un símbolo de cierre: verificar correspondencia
                else if (c == ')' || c == '}' || c == ']')
                {
                // Si la pila está vacía, no hay símbolo que cierre
                    if (pila.Count == 0)
                        return false;

                // Obtener ultimo simbolo de apertura y comparar
                    char apertura = pila.Pop();
                    if (!EsParCorrecto(apertura, c))
                        return false;
                }
            }

            // Si la pila queda vacía, la expresión está balanceada
            return pila.Count == 0;
        }

        // Verifica si el símbolo de apertura coincide con el de cierre
        private static bool EsParCorrecto(char apertura, char cierre)
        {
            return (apertura == '(' && cierre == ')') ||
                   (apertura == '{' && cierre == '}') ||
                   (apertura == '[' && cierre == ']');
        }
    }
}