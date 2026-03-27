namespace practica1;

class Program
{
    static void Main(string[] args)
    {
        Numero n1 = new Numero(10);
        Numero n2 = new Numero(20);

        Console.WriteLine(n1.sosMenor(n2));
        Console.WriteLine(n1.sosMayor(n2));
        Console.WriteLine(n1.sosIgual(n2));
        Console.WriteLine();

        Pila pila = new Pila();
        pila.apilar(new Numero(1));
        pila.apilar(new Numero(2));
        pila.apilar(new Numero(3));
        Console.WriteLine(pila.cuantos());
        Console.WriteLine();

        Cola cola = new Cola();
        cola.encolar(n1);
        cola.encolar(new Numero(20));
        cola.encolar(new Numero(30));
        cola.agregar(new Numero(40));
        Console.WriteLine(cola.cuantos());
        Console.WriteLine(cola.minimo().getValor());
        Console.WriteLine(cola.maximo().getValor());
        Console.WriteLine(cola.contiene(n1));
        Console.WriteLine();


    }
}
