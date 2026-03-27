namespace practica1;

using System.Collections.Generic;

public class Pila : IColeccionable
{
    private List<Numero> datos = new List<Numero>();

    public void apilar(Numero elem)
    {
        this.datos.Add(elem);
    }

    public Numero desapilar()
    {
        int ultimo = this.datos.Count - 1;
        Numero temp = this.datos[ultimo];
        this.datos.RemoveAt(ultimo);
        return temp;
    }

    public Numero tope()
    {
        return this.datos[this.datos.Count - 1];
    }

    public bool esVacia()
    {
        return this.datos.Count == 0;
    }

    public int cantidadElementos()
    {
        return this.datos.Count;
    }

    public int cuantos()
    {
        int total = 0;
        foreach (Numero dato in datos)
        {
            if (dato is IComparable)
            {
                total += 1;
            }
        }
        return total;
    }

    public Numero minimo()
    {
        Numero min = new Numero(99999);
        foreach (Numero dato in datos)
        {
            if (dato.sosMenor(min))
            {
                min = dato;
            }
        }
        return min;
    }

    public Numero maximo()
    {
        Numero max = new Numero(0);
        foreach (Numero dato in datos)
        {
            if (dato.sosMayor(max))
            {
                max = dato;
            }
        }
        return max;
    }

    public void agregar(IComparable c)
    {
        this.apilar((Numero)c);
    }

    public bool contiene(IComparable c)
    {
        return datos.Contains((Numero)c);
    }
}

public class Cola : IColeccionable
{
    private List<Numero> datos = new List<Numero>();

    public void encolar(Numero elem)
    {
        this.datos.Add(elem);
    }

    public Numero desencolar()
    {
        Numero temp = this.datos[0];
        this.datos.RemoveAt(0);
        return temp;
    }

    public Numero tope()
    {
        return this.datos[0];
    }

    public bool esVacia()
    {
        return this.datos.Count == 0;
    }

    public int cantidadElementos()
    {
        return this.datos.Count;
    }

    public int cuantos()
    {
        int total = 0;
        foreach (Numero dato in datos)
        {
            if (dato is IComparable)
            {
                total += 1;
            }
        }
        return total;
    }

    public Numero minimo()
    {
        Numero min = new Numero(99999);
        foreach (Numero dato in datos)
        {
            if (dato.sosMenor(min))
            {
                min = dato;
            }
        }
        return min;
    }

    public Numero maximo()
    {
        Numero max = new Numero(0);
        foreach (Numero dato in datos)
        {
            if (dato.sosMayor(max))
            {
                max = dato;
            }
        }
        return max;
    }

    public void agregar(IComparable c)
    {
        this.encolar((Numero)c);
    }

    public bool contiene(IComparable c)
    {
        return datos.Contains((Numero)c);
    }
}
