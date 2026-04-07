namespace practica3;

public class FabricaDeNumeros: FabricaDeComparables
{
    public FabricaDeNumeros() {}

    public override IComparable crearAleatorio()
    {
        return (Numero)crearAleatorioPreseteado();
    }
}