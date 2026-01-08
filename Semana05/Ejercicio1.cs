using System;
using System.Collections.Generic;

class Ejercicio1
{
    public void Ejecutar()
    {
        //Lista de Asignaturas
        List<string> asignaturas = new List<string>
        {
            "Matemáticas", "Lenguaje", "Química", "Historia", "Fisica"
        };

        Console.WriteLine("Asignaturas del curso:");
        foreach (string asignatura in asignaturas)
        {
            Console.WriteLine(asignatura);
        }
    }
}