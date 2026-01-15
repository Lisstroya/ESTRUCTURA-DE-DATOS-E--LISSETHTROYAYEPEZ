class Program
{
    static void Main()
    {
        // ===== EJERCICIO 3 =====
        Console.WriteLine("===== EJERCICIO 3 =====");

        Ejercicio3 ej3 = new Ejercicio3();
        ej3.Insertar(2);
        ej3.Insertar(8);
        ej3.Insertar(3);
        ej3.Insertar(2);

        ej3.Mostrar();

        Console.Write("\nValor a buscar: ");
        int valor = int.Parse(Console.ReadLine());

        int veces = ej3.Buscar(valor);
        if (veces > 0)
            Console.WriteLine($"El valor aparece {veces} veces.");
        else
            Console.WriteLine("El dato no fue encontrado.");

        // ===== EJERCICIO 4 =====
        Console.WriteLine("\n===== EJERCICIO 4 =====");

        Ejercicio4 ej4 = new Ejercicio4();
        Random r = new Random();

        for (int i = 0; i < 50; i++)
            ej4.InsertarFinal(r.Next(100, 400));

        Console.WriteLine("\nLista original:");
        ej4.Mostrar();

        Console.Write("\nMin: ");
        int min = int.Parse(Console.ReadLine());

        Console.Write("Max: ");
        int max = int.Parse(Console.ReadLine());

        ej4.EliminarFueraRango(min, max);

        Console.WriteLine("\nLista filtrada:");
        ej4.Mostrar();

        Console.ReadKey();
    }
}
