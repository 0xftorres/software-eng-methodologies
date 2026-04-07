namespace practica3;

public class FabricaDeNumeros: FabricaDeComparables
{
    public FabricaDeNumeros() {}

    public override Numero crearAleatorio()
    {
        return (Numero)this.crearAleatorioPreseteado();
    }
}