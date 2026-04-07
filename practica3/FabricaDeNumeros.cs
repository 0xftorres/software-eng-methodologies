namespace practica3;

public class FabricaDeNumeros: FabricaDeComparables
{
    public FabricaDeNumeros() {}

    public override IComparable crearAleatorio()
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        return gen.numeroAleatorio(9999999);
    }

    public override IComparable crearPorTeclado()
    {
        LectorDeDatos lector = new LectorDeDatos();

        Console.WriteLine("Ingrese el numero:");
        return new Numero(lector.numeroPorTeclado());
    }
}