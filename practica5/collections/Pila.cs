namespace practica5;

using System.Collections.Generic;

public class Pila : IColeccionable, IIterable, IOrdenable
{
    private List<IComparable> datos = new List<IComparable>();

    private IOrdenEnAula1? ordenInicio;
    private IOrdenEnAula2? ordenLlegaAlumno;
    private IOrdenEnAula1? ordenAulaLlena;

    public IIterador CrearIterador()
    {
        return new IteradorPila(datos);
    }

    public void apilar(IComparable elem)
    {
        this.datos.Add(elem);
    }

    public IComparable desapilar()
    {
        int ultimo = this.datos.Count - 1;
        IComparable temp = this.datos[ultimo];
        this.datos.RemoveAt(ultimo);
        return temp;
    }

    public IComparable tope()
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
        foreach (IComparable dato in datos)
        {
            if (dato is IComparable)
            {
                total += 1;
            }
        }
        return total;
    }

    public IComparable minimo()
    {
        IComparable min = this.tope();
        foreach (IComparable dato in datos)
        {
            if (dato.sosMenor(min))
            {
                min = dato;
            }
        }
        return min;
    }

    public IComparable maximo()
    {
        IComparable max = this.tope();
        foreach (IComparable dato in datos)
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
        if (this.cuantos() == 0 && ordenInicio != null)
        {
            ordenInicio.ejecutar();
        }
        
        this.apilar(c);

        if (ordenLlegaAlumno != null)
        {
            ordenLlegaAlumno.ejecutar(c);
        }

        if (this.cuantos() == 40 && ordenAulaLlena != null)
        {
            ordenAulaLlena.ejecutar();
        }
    }

    public bool contiene(IComparable c)
    {
        foreach(IComparable dato in datos)
        {
            if (dato.sosIgual(c))
            {
                return true;
            }
        }
        return false;
    }

    public void setOrdenInicio(IOrdenEnAula1 orden)
    {
        this.ordenInicio = orden;
    }

    public void setOrdenLlegaAlumno(IOrdenEnAula2 orden)
    {
        this.ordenLlegaAlumno = orden;
    }

    public void setOrdenAulaLlena(IOrdenEnAula1 orden)
    {
        this.ordenAulaLlena = orden;
    }
}
