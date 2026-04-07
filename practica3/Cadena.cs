namespace practica3;

public class Cadena: IComparable
{
    public string valor;

    public Cadena(string v)
    {
        valor = v;
    }

    public string getValor()
    {
        return valor;
    }

    public bool sosIgual(IComparable c)
    {
        Cadena otra_cadena = (Cadena)c;
        return valor == otra_cadena.getValor();
    }

    public bool sosMayor(IComparable c)
    {
        Cadena otra_cadena = (Cadena)c;
        return valor.CompareTo(otra_cadena.getValor()) > 0;
    }

    public bool sosMenor(IComparable c)
    {
        Cadena otra_cadena = (Cadena)c;
        return valor.CompareTo(otra_cadena.getValor()) < 0;
    }
}