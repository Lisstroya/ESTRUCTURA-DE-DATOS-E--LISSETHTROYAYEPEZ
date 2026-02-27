using System;
using System.Collections.Generic;

namespace Semana11
{
    public class Traductor
    {
        private Dictionary<string, string> diccionario =
            new Dictionary<string, string>();

        public Traductor()
        {
            InicializarDiccionario();
        }

        private void InicializarDiccionario()
        {
           
            diccionario.Add("time", "tiempo");
            diccionario.Add("person", "persona");
            diccionario.Add("year", "año");
            diccionario.Add("way", "camino");
            diccionario.Add("day", "día");
            diccionario.Add("thing", "cosa");
            diccionario.Add("man", "hombre");
            diccionario.Add("world", "mundo");
            diccionario.Add("life", "vida");
            diccionario.Add("hand", "mano");
            diccionario.Add("eye", "ojo");
            diccionario.Add("woman", "mujer");
        }

        public void Iniciar()
        {
            int opcion;

            do
            {
                Console.WriteLine("\n========== MENÚ ==========");
                Console.WriteLine("1. Traducir una frase");
                Console.WriteLine("2. Agregar palabras al diccionario");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        TraducirFrase();
                        break;

                    case 2:
                        AgregarPalabra();
                        break;
                }

            } while (opcion != 0);
        }

        private void TraducirFrase()
        {
            Console.Write("Ingrese frase: ");
            string frase = Console.ReadLine().ToLower();

            string[] palabras = frase.Split(' ');

            foreach (string palabra in palabras)
            {
                bool encontrada = false;

                foreach (var item in diccionario)
                {
            
                    if (item.Value == palabra)
                    {
                        Console.Write(item.Key + " ");
                        encontrada = true;
                        break;
                    }
                }

                if (!encontrada)
                    Console.Write(palabra + " ");
            }

            Console.WriteLine();
        }
        private void AgregarPalabra()
        {
            Console.Write("Palabra en inglés: ");
            string ingles = Console.ReadLine().ToLower();

            Console.Write("Traducción en español: ");
            string espanol = Console.ReadLine().ToLower();

            if (!diccionario.ContainsKey(ingles))
            {
                diccionario.Add(ingles, espanol);
                Console.WriteLine("Palabra agregada correctamente.");
            }
            else
            {
                Console.WriteLine("La palabra ya existe.");
            }
        }
    }
}