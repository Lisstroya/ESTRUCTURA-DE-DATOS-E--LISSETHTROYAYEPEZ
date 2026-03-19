using System;

public class ArbolBinario
{
    public Nodo Raiz;

    public Nodo Insertar(Nodo raiz, int valor)
    {
        if (raiz == null)
            return new Nodo(valor);

        if (valor < raiz.Valor)
            raiz.Izquierdo = Insertar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Insertar(raiz.Derecho, valor);

        return raiz;
    }

    public bool Buscar(Nodo raiz, int valor)
    {
        if (raiz == null) return false;

        if (valor == raiz.Valor) return true;

        if (valor < raiz.Valor)
            return Buscar(raiz.Izquierdo, valor);
        else
            return Buscar(raiz.Derecho, valor);
    }

    public void InOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            InOrden(raiz.Izquierdo);
            Console.Write(raiz.Valor + " ");
            InOrden(raiz.Derecho);
        }
    }

    public void PreOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            Console.Write(raiz.Valor + " ");
            PreOrden(raiz.Izquierdo);
            PreOrden(raiz.Derecho);
        }
    }

    public void PostOrden(Nodo raiz)
    {
        if (raiz != null)
        {
            PostOrden(raiz.Izquierdo);
            PostOrden(raiz.Derecho);
            Console.Write(raiz.Valor + " ");
        }
    }

    public int Minimo(Nodo raiz)
    {
        while (raiz.Izquierdo != null)
            raiz = raiz.Izquierdo;

        return raiz.Valor;
    }

    public int Maximo(Nodo raiz)
    {
        while (raiz.Derecho != null)
            raiz = raiz.Derecho;

        return raiz.Valor;
    }

    public int Altura(Nodo raiz)
    {
        if (raiz == null) return -1;

        int izq = Altura(raiz.Izquierdo);
        int der = Altura(raiz.Derecho);

        return Math.Max(izq, der) + 1;
    }

    public Nodo Eliminar(Nodo raiz, int valor)
    {
        if (raiz == null) return null;

        if (valor < raiz.Valor)
            raiz.Izquierdo = Eliminar(raiz.Izquierdo, valor);
        else if (valor > raiz.Valor)
            raiz.Derecho = Eliminar(raiz.Derecho, valor);
        else
        {
            if (raiz.Izquierdo == null) return raiz.Derecho;
            if (raiz.Derecho == null) return raiz.Izquierdo;

            int min = Minimo(raiz.Derecho);
            raiz.Valor = min;
            raiz.Derecho = Eliminar(raiz.Derecho, min);
        }

        return raiz;
    }

    public void Limpiar()
    {
        Raiz = null;
    }
}