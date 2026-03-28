namespace practica1;
// Creado por Federico Torres
// https://github.com/0xftorres

// RTA ejercicio 10: No tuve que cambiar nada, eso es lo bueno
//                   de implementar interfaces.
// RTA ejercicio 14: No funcionó a la primera. Se comparo a los
//                   alumnos por DNI porque Alumno es hijo de Persona.
// RTA ejercicio 16: se podria haber hecho sin interfaces pero
//                   habria sido mas dificil de implementar y no se
//                   podrian haber reutilizado los metodos de Pila
//                   y Cola. Tambien al usar interfaces, se puede
//                   agregar cualquier tipo de coleccion que
//                   implemente IColeccionable sin tener que modificar
//                   el codigo de ColeccionMultiple.

class Program
{
    static void Main(string[] args)
    {
        //Numero n1 = new Numero(10);
        //Numero n2 = new Numero(20);

        //Console.WriteLine(n1.sosMenor(n2));
        //Console.WriteLine(n1.sosMayor(n2));
        //Console.WriteLine(n1.sosIgual(n2));
        //Console.WriteLine();

        Pila pila = new Pila();
        llenar(pila);
        informar(pila);
        //pila.apilar(new Numero(1));
        //pila.apilar(new Numero(2));
        //pila.apilar(new Numero(3));
        //Console.WriteLine(pila.cuantos());
        Console.WriteLine();

        Cola cola = new Cola();
        //cola.encolar(n1);
        //cola.encolar(new Numero(20));
        //cola.encolar(new Numero(30));
        //cola.agregar(new Numero(40));
        llenar(cola);
        informar(cola);
        //Console.WriteLine(cola.cuantos());
        //Console.WriteLine(cola.minimo().getValor());
        //Console.WriteLine(cola.maximo().getValor());
        //Console.WriteLine(cola.contiene(n1));
        Console.WriteLine();


        Pila pila_alumnos = new Pila();
        Cola cola_alumnos = new Cola();
        ColeccionMultiple multiple = new ColeccionMultiple(pila_alumnos, cola_alumnos);
        llenarAlumnos(pila_alumnos);
        llenarAlumnos(cola_alumnos);
        informarAlumnos(multiple);

    }

    public static void llenar(IColeccionable c)
    {
        for (int i = 0; i < 20; i++)
        {
            int rnd = new Random().Next(1, 101);
            Numero random = new Numero(rnd);
            c.agregar(random);
        }
    }

    public static void informar(IColeccionable c)
    {
        Console.WriteLine("Cantidad de elementos: {0}", c.cuantos());
        Console.WriteLine("Minimo: {0}", ((Numero)c.minimo()).getValor());
        Console.WriteLine("Maximo: {0}", ((Numero)c.maximo()).getValor());

        Numero k = new Numero(int.Parse(Console.ReadLine()));
        if (c.contiene(k))
        {
            Console.WriteLine("El elemento leído está en la colección");
        }
        else
        {
            Console.WriteLine("El elemento leído no está en la colección");
        }
    }

    public static void informarAlumnos(IColeccionable c)
    {
        Console.WriteLine("Cantidad de elementos: {0}", c.cuantos());
        Console.WriteLine("Minimo DNI: {0}", ((Alumno)c.minimo()).getDNI());
        Console.WriteLine("Maximo DNI: {0}", ((Alumno)c.maximo()).getDNI());
    
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
