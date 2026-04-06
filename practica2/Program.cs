namespace practica2;

class Program
{
    public static void Main(string[] args)
    {
        //Cola cola = new Cola();
        Pila pila = new Pila();
        //Conjunto conjunto = new Conjunto();

        llenarAlumnos(pila);
        //llenarAlumnos(cola);
        //llenarAlumnos(conjunto);

        //Console.WriteLine("COLA:");
        //imprimirElementos(cola);

        //Console.WriteLine("CONJUNTO:");
        //imprimirElementos(conjunto);

        Console.WriteLine("Comparar por DNI:");
        Console.WriteLine("PILA:");
        informarAlumnos(pila);

        Console.WriteLine("Comparar por legajo:");
        cambiarEstrategia(pila, "legajo");
        informarAlumnos(pila);

        Console.WriteLine("Comparar por promedio:");
        cambiarEstrategia(pila, "promedio");
        informarAlumnos(pila);

    }

    public static void cambiarEstrategia(IColeccionable c, string e)
    {
        IIterador iterador = ((IIterable)c).CrearIterador();

        while(!iterador.fin()){
            if (e=="legajo") {
                ComparacionPorLegajo est_leg = new ComparacionPorLegajo(((Alumno)iterador.actual()).getLegajo());
                ((Alumno)iterador.actual()).setEstrategia(est_leg);
            } else if (e=="promedio") {
                ComparacionPorPromedio est_prom = new ComparacionPorPromedio(((Alumno)iterador.actual()).getPromedio());
                ((Alumno)iterador.actual()).setEstrategia(est_prom);
            } else if (e=="dni") {
                ComparacionPorDni est_dni = new ComparacionPorDni(((Alumno)iterador.actual()).getDNI());
                ((Alumno)iterador.actual()).setEstrategia(est_dni);
            }

            iterador.siguiente();
        }
    }

    public static void imprimirElementos(IColeccionable c)
    {
        IIterador iterador = ((IIterable)c).CrearIterador();

        while(!iterador.fin()){
			Console.WriteLine(iterador.actual().ToString());
			iterador.siguiente();
		}
    }

    public static void informarAlumnos(IColeccionable c)
    {
        Console.WriteLine("Cantidad de elementos: {0}", c.cuantos());
        Console.WriteLine("Minimo: {0}", ((Alumno)c.minimo()).ToString());
        Console.WriteLine("Maximo: {0}", ((Alumno)c.maximo()).ToString());
    
    }

    public static void llenarAlumnos(IColeccionable c)
    {
        Random random = new Random();
        string[] nombres = { "Fede", "Juan", "Ana", "Luis", "Sofia" };
        
        for (int i = 0; i < 20; i++)
        {
            // Nombre
            int rnd_n = random.Next(1, nombres.Count());
            string nombre_azar = nombres[rnd_n];

            // DNI
            int dni_azar = random.Next(1, 50000);

            // Legajo
            int legajo_azar = random.Next(1, 9999);

            // Promedio
            int promedio_azar = random.Next(1, 10);

            c.agregar(new Alumno(nombre_azar, dni_azar, legajo_azar, promedio_azar));
        }
    }
}
