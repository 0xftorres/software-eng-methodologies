namespace practica3;

public abstract class FabricaDeComparables
{
    public FabricaDeComparables() {}

    public abstract IComparable crearAleatorio();

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
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        return gen.numeroAleatorio(99999999);
    }

    public static IComparable crearPorTeclado(string tipo)
    {
        LectorDeDatos lector = new LectorDeDatos();

        if (tipo == "dni") {
            return new Numero(lector.numeroPorTeclado());
        } else if (tipo == "legajo") {
            return new Numero(lector.numeroPorTeclado());
        } else if (tipo == "promedio") {
            return new Numero(lector.numeroPorTeclado());
        } else if (tipo == "nombre") {
            return new Cadena(lector.stringPorTeclado());
        }

        return new Numero(0);
    }
}