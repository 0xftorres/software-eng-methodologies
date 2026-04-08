namespace practica4;

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
        
        Profesor profesor = new Profesor("Fede", 12348775, 15);
        for(int i = 1; i <= 20; i++)
        {
            Alumno alumno = (Alumno)FabricaDeComparables.crearAleatorio("alumno");
            profesor.agregarObservador(alumno);
        }
        dictadoDeClases(profesor);
    }

    public static void dictadoDeClases(Profesor profesor)
    {
        for(int i = 1; i <= 5; i++)
        {
            profesor.hablarALaClase();
            profesor.escribirEnElPizarron();
        }
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
