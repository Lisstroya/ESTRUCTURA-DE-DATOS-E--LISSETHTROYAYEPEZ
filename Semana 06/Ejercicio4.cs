using System;

public class Ejercicio4
{
    // Clase Nodo
    class Nodo
    {
        public int dato;          // Valor almacenado en el nodo
        public Nodo siguiente;    // Referencia al siguiente nodo
    }

    // Referencia al primer nodo de la lista
    Nodo inicio;

    // Método para insertar un nodo al FINAL de la lista
    public void InsertarFinal(int valor)
    {
        Nodo nuevo = new Nodo();
        nuevo.dato = valor;
        nuevo.siguiente = null;

        // Si la lista está vacía, el nuevo nodo será el inicio
        if (inicio == null)
        {
            inicio = nuevo;
            return;
        }

        // Recorrer la lista hasta llegar al último nodo
        Nodo aux = inicio;
        while (aux.siguiente != null)
        {
            aux = aux.siguiente;
        }

        // Enlazar el último nodo con el nuevo
        aux.siguiente = nuevo;
    }

    // Método que elimina los nodos que estén fuera del rango 
    public void EliminarFueraRango(int min, int max)
    {
        // Eliminar nodos al inicio que estén fuera del rango
        while (inicio != null && (inicio.dato < min || inicio.dato > max))
        {
            inicio = inicio.siguiente;
        }

        // Recorrer el resto de la lista
        Nodo aux = inicio;
        while (aux != null && aux.siguiente != null)
        {
            // Si el siguiente nodo está fuera del rango, se elimina
            if (aux.siguiente.dato < min || aux.siguiente.dato > max)
                aux.siguiente = aux.siguiente.siguiente;
            else
                aux = aux.siguiente; // Avanzar al siguiente nodo
        }
    }

    // Método para mostrar los elementos de la lista
    public void Mostrar()
    {
        Nodo aux = inicio;
        while (aux != null)
        {
            Console.Write(aux.dato + " -> ");
            aux = aux.siguiente;
        }
        Console.WriteLine("null"); 
    }
}