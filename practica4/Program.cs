namespace practica4;


class Program
{
    public static void Main(string[] args)
    {
        Teacher t = new Teacher();

        Cola c = new Cola();
        llenar(c, "alumno");

        // los 10 primeros son estudiosos
        for (int i=0; i<10; i++)
        {
            Alumno e = (Alumno)c.desencolar();
            AlumnoMuyEstudioso a = new AlumnoMuyEstudioso(e.getNombre().getValor(), e.getDni().getValor(), e.getLegajo().getValor(), e.getPromedio().getValor());
            c.encolar(a);
        }

        // adaptar a StudentAdapter
        IIterador iterador = ((IIterable)c).CrearIterador();
        while(!iterador.fin()){
            Alumno a = (Alumno)iterador.actual();
			StudentAdapter alumno_adaptado = new StudentAdapter(a);
            t.goToClass(alumno_adaptado);
			iterador.siguiente();
		}

        t.teachingAClass();

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
