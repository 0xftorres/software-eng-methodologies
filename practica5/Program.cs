namespace practica5;


class Program
{
    public static void Main(string[] args)
    {
        /*
        Teacher t = new Teacher();

        Aula aula = new Aula();

        IOrdenEnAula1 ordenInicio = new OrdenInicio(aula);
        ordenInicio.ejecutar();

        Cola c = new Cola();
        llenar(c, "alumno");

        // los 10 primeros son estudiosos
        for (int i=0; i<10; i++)
        {
            IAlumno e = (IAlumno)c.desencolar();
            Persona p = (Persona)e;

            AlumnoMuyEstudioso a = new AlumnoMuyEstudioso(
                p.getNombre().getValor(),
                (int)p.getDNI().getValor(),
                (int)e.getLegajo().getValor(),
                0
            );
            c.encolar(a);
        }

        IOrdenEnAula2 ordenLlega = new OrdenLlegaAlumno(aula);

        // adaptar a StudentAdapter
        IIterador iterador = ((IIterable)c).CrearIterador();
        while(!iterador.fin()){
            IAlumno a = (IAlumno)iterador.actual();
			StudentAdapter alumno_adaptado = new StudentAdapter(a);
            t.goToClass(alumno_adaptado);
            ordenLlega.ejecutar((IComparable)a);
			iterador.siguiente();
		}

        IOrdenEnAula1 ordenLlena = new OrdenAulaLlena(aula);
        ordenLlena.ejecutar();

        t.teachingAClass();*/

        Aula aula1 = new Aula();
        Pila pila = new Pila();

        pila.setOrdenInicio(new OrdenInicio(aula1));
        pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula1));
        pila.setOrdenAulaLlena(new OrdenAulaLlena(aula1));

        // alumnos
        llenar(pila, "alumno");

        // estudiosos
        llenar(pila, "estudioso");
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
