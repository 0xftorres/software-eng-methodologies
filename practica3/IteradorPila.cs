namespace practica3;

public class IteradorPila : IIterador
{
    private List<IComparable> datos;
    private int indice;

    public IteradorPila(List<IComparable> d)
    {
        datos = d;
        this.primero();
    }

    public void primero()
    {
        indice = datos.Count() - 1;
    }

    public IComparable actual()
    {
        return datos[indice];
    }

    public void siguiente()
    {
        indice--;
    }

    public bool fin()
    {
        return indice < 0;
    }
}