namespace practica3;

public abstract class FabricaDeComparables
{
    public FabricaDeComparables() {}

    public abstract IComparable crearAleatorio(string tipo);

    public static IComparable crearAleatorio(string tipo)
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

        if (tipo == "dni") {
            return gen.numeroAleatorio(99999999);
        } else if (tipo == "legajo") {
            return gen.numeroAleatorio(9999);
        } else if (tipo == "promedio") {
            return gen.numeroAleatorio(10);
        } else if (tipo == "nombre") {
            return gen.stringAleatorio(7);
        }

        return new Numero(0);
    }

    public static IComparable crearAleatorioPreseteado()
    {
        return new gen.numeroAleatorio(99999999);
    }

    public static string crearPorTeclado(string tipo)
    {
        LectorDeDatos lector = new LectorDeDatos();

        if (tipo == "dni") {
            return lector.numeroPorTeclado();
        } else if (tipo == "legajo") {
            return lector.numeroPorTeclado();
        } else if (tipo == "promedio") {
            return lector.numeroPorTeclado();
        } else if (tipo == "nombre") {
            return lector.stringPorTeclado();
        }

        return new Numero(0);
    }
}