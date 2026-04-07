namespace practica3;

class Program
{
    public static void Main(string[] args)
    {
        FabricaDeComparables fabrica = new FabricaDeComparables();
        IComparable[] comparables = new IComparable[10];

        for (int i = 0; i < comparables.Length; i++)
        {
            comparables[i] = fabrica.crearAleatorio();
        }

        Console.WriteLine("Comparables aleatorios:");
        foreach (var comparable in comparables)
        {
            Console.WriteLine(comparable);
        }

        Console.WriteLine("\nIngrese datos para crear un alumno por teclado:");
        comparables[0] = FabricaDeAlumnos.crearAlumnoPorTeclado();

        Console.WriteLine("\nAlumno creado por teclado:");
        Console.WriteLine(comparables[0]);

    }
}
