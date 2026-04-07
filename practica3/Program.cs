namespace practica3;

class Program
{
    public static void Main(string[] args)
    {
        Pila p = new Pila();

        llenar(p, "alumno");
        informar(p, "alumno");
        

    }

    public static void llenar(IColeccionable c, string opcion)
    {
        for(int i = 0; i < 20; i++)
        {
            FabricaDeComparables fabAlumnos = new FabricaDeAlumnos();
            IComparable al = fabAlumnos.crearAleatorio();
            c.agregar(al);
        }
    }

    public static void informar(IColeccionable c, string opcion)
    {
        Console.WriteLine("Items: {0}", c.cuantos());
        Console.WriteLine("Minimo: {0}", c.minimo().ToString());
        Console.WriteLine("Maximo: {0}", c.maximo().ToString());
        IComparable fab = FabricaDeComparables.crearPorTeclado(opcion);

        if (c.contiene(fab))
        {
            Console.WriteLine("El item ingresado se encuentra en la coleccion.");
        } else {
            Console.WriteLine("El item ingresado no se encuentra en la coleccion.");
        }
    }

}
