namespace practica2;

public class Conjunto : IColeccionable, IIterable
{
    private List<IComparable> datos = new List<IComparable>();

    public IIterador CrearIterador()
    {
        return new IteradorConjunto(datos);
    }

    private IComparable buscar(IComparable c)
    {
        foreach (IComparable dato in datos)
        {
            if (dato.sosIgual(c))
            {
                return dato;
            }
        }
        return null;
    }

    public bool pertenece(IComparable c)
    {
        return this.buscar(c) != null;
    }

    public void agregar(IComparable elem)
    {
        if (this.buscar(elem) == null)
        {
            this.datos.Add(elem);
        }
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
        IComparable min = this.datos[0];
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
        IComparable max = this.datos[0];
        foreach (IComparable dato in datos)
        {
            if (dato.sosMayor(max))
            {
                max = dato;
            }
        }
        return max;
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
}
