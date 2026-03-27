namespace practica1;

public interface IColeccionable
{
    public int cuantos();
    public Numero minimo();
    public Numero maximo();
    public void agregar(IComparable comparable);
    public bool contiene(IComparable comparable);
}