namespace practica3;

// Ejercicio 7: Habría que crear una fábrica de
// coleccionables, y una fabrica para cada
// coleccionable mencionado (Pila, cola, etc.)

// Ejercicio 10: Habría que crear una fabrica de Personas.

class Program
{
    public static void Main(string[] args)
    {
        Pila p = new Pila();

        //llenar(p, "alumno");
        //informar(p, "alumno");

        llenar(p, "profesor");
        informar(p, "profesor");
    }

    public static void llenar(IColeccionable c, string opcion)
    {
        for(int i = 0; i < 20; i++)
        {
            IComparable fabricado = FabricaDeComparables.crearAleatorio(opcion);
            c.agregar(fabricado);
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
