using System;
using System.Collections.Generic;

namespace Semana10
{
    public class CampañaVacunacion
    {
        public void Ejecutar()
        {
            
            // Crear conjunto Universo (500 ciudadanos)
          
            HashSet<string> ciudadanos = new HashSet<string>();

            for (int i = 1; i <= 500; i++)
            {
                ciudadanos.Add("Ciudadano " + i);
            }

            
            // Crear conjuntos vacunados
            
            HashSet<string> pfizer = GenerarVacunados(ciudadanos, 75);
            HashSet<string> astrazeneca = GenerarVacunados(ciudadanos, 75);

            
            // Operaciones de teoría de conjuntos
            // Unión (P ∪ A)
            HashSet<string> union = new HashSet<string>(pfizer);
            union.UnionWith(astrazeneca);

            // Intersección (P ∩ A) ambas dosis
            HashSet<string> ambasDosis = new HashSet<string>(pfizer);
            ambasDosis.IntersectWith(astrazeneca);

            // No vacunados  U − (P ∪ A)
            HashSet<string> noVacunados = new HashSet<string>(ciudadanos);
            noVacunados.ExceptWith(union);

            // Solo Pfizer P − A
            HashSet<string> soloPfizer = new HashSet<string>(pfizer);
            soloPfizer.ExceptWith(astrazeneca);

            // Solo AstraZeneca A − P
            HashSet<string> soloAstra = new HashSet<string>(astrazeneca);
            soloAstra.ExceptWith(pfizer);


            // Mostrar resultados
        

            MostrarResultado("Ciudadanos NO vacunados", noVacunados);
            MostrarResultado("Ciudadanos con ambas dosis", ambasDosis);
            MostrarResultado("Ciudadanos solo Pfizer", soloPfizer);
            MostrarResultado("Ciudadanos solo AstraZeneca", soloAstra);
        }

        private HashSet<string> GenerarVacunados(HashSet<string> universo, int cantidad)
        {
            Random rnd = new Random();
            HashSet<string> vacunados = new HashSet<string>();
            List<string> lista = new List<string>(universo);

            while (vacunados.Count < cantidad)
            {
                int indice = rnd.Next(lista.Count);
                vacunados.Add(lista[indice]);
            }

            return vacunados;
        }

        private void MostrarResultado(string titulo, HashSet<string> conjunto)
        {
            Console.WriteLine("\n=================================");
            Console.WriteLine(titulo);
            Console.WriteLine("Total: " + conjunto.Count);
            Console.WriteLine("=================================");

            foreach (var ciudadano in conjunto)
            {
                Console.WriteLine(ciudadano);
            }
        }
    }
}