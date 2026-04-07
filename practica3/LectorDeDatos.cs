namespace practica3;

public class LectorDeDatos
{
    public LectorDeDatos() {}

    public int numeroPorTeclado()
    {
        string a = Console.ReadLine();
        if (a == null)
        {
            return 0;
        }
        return int.Parse(a);
    }

    public string stringPorTeclado()
    {
        return Console.ReadLine();
    }
}