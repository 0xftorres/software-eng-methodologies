namespace practica4;

public class FabricaDeProfesores: FabricaDeComparables
{
    public FabricaDeProfesores() {}

    public override IComparable crearAleatorio()
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

        Cadena nombre_profesor = (Cadena)gen.stringAleatorio(7);
        Numero dni_profesor = (Numero)gen.numeroAleatorio(99999999);
        Numero antiguedad_profesor = (Numero)gen.numeroAleatorio(60);

        IComparable p = new Profesor(nombre_profesor.getValor(), dni_profesor.getValor(), antiguedad_profesor.getValor());
        return p;
    }

    public override IComparable crearPorTeclado()
    {
        LectorDeDatos lector = new LectorDeDatos();

        Console.WriteLine("Ingrese el nombre del profesor:");
        string nombre_profesor = lector.stringPorTeclado();

        Console.WriteLine("Ingrese el dni del profesor:");
        int dni_profesor = lector.numeroPorTeclado();

        Console.WriteLine("Ingrese la antiguedad del profesor:");
        int antiguedad_profesor = lector.numeroPorTeclado();

        IComparable p = new Profesor(nombre_profesor, dni_profesor, antiguedad_profesor);
        return p;
    }
}