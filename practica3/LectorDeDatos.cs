namespace practica3;

public class LectorDeDatos
{
    public LectorDeDatos() {}

    public int numeroPorTeclado()
    {
        return int.Parse(Console.ReadLine());
    }

    public string stringPorTeclado()
    {
        return Console.ReadLine();
    }
}