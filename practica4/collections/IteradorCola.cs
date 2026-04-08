namespace practica3;

public class IteradorCola : IIterador
{
    private List<IComparable> datos;
    private int indice;

    public IteradorCola(List<IComparable> d)
    {
        datos = d;
        this.primero();
    }

    public void primero()
    {
        indice = 0;
    }

    public IComparable actual()
    {
        return datos[indice];
    }

    public void siguiente()
    {
        indice++;
    }

    public bool fin()
    {
        return indice >= datos.Count;
    }
}