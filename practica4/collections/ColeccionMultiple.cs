namespace practica4;

public class ColeccionMultiple : IColeccionable
{
    public Pila pila;
    public Cola cola;

    public ColeccionMultiple(Pila p, Cola c)
    {
        pila = p;
        cola = c;
    }

    public int cuantos()
    {
        return pila.cuantos() + cola.cuantos();
    }

    public IComparable minimo()
    {
        if (pila.minimo().sosMenor(cola.minimo()))
        {
            return pila.minimo();
        }
        else
        {
            return cola.minimo();
        }
    }

    public IComparable maximo()
    {
        if (pila.maximo().sosMayor(cola.maximo()))
        {
            return pila.maximo();
        }
        else
        {
            return cola.maximo();
        }
    }

    public void agregar(IComparable c)
    {
        // No hace nada
    }

    public bool contiene(IComparable c)
    {
        bool si_pila = pila.contiene(c);
        bool si_cola = cola.contiene(c);

        return si_cola || si_pila;
    }
}