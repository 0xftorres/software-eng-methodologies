namespace practica1;

public interface IColeccionable
{
    public int cuantos();
    public IComparable minimo();
    public IComparable maximo();
    public void agregar(IComparable comparable);
    public bool contiene(IComparable comparable);
}