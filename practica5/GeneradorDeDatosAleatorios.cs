namespace practica5;

public class GeneradorDeDatosAleatorios
{
    public GeneradorDeDatosAleatorios() {}

    public Numero numeroAleatorio(int max)
    {
        Random random = new Random();
        return new Numero(random.Next(0, max));
    }

    public Cadena stringAleatorio(int cant)
    {
        string chars = "abcdefghijklmnopqrstuvwxyz";
        Random random = new Random();
        string r = new string(Enumerable.Repeat(chars, cant).Select(s => s[random.Next(s.Length)]).ToArray());
        return new Cadena(r);
    }
}