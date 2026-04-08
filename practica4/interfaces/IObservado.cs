namespace practica4;

public interface IObservado
{
    public void agregarObservador(IObservador o);
    public void quitarObservador(IObservador o);
    public void notificar();
}