namespace practica1;

public class Numero: IComparable
{
    public int valor;

    public Numero(int v)
    {
        valor = v;
    }

    public int getValor()
    {
        return valor;
    }

    public bool sosIgual(IComparable c)
    {
        Numero otro_numero = (Numero)c;
        return valor == otro_numero.getValor();
    }

    public bool sosMayor(IComparable c)
    {
        Numero otro_numero = (Numero)c;
        return valor > otro_numero.getValor();
    }

    public bool sosMenor(IComparable c)
    {
        Numero otro_numero = (Numero)c;
        return valor < otro_numero.getValor();
    }
}