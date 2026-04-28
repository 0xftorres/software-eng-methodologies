namespace practica5;

public interface IIterador
{
    public void primero();
    public void siguiente();
    public bool fin();
    public IComparable actual();
}