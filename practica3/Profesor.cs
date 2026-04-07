namespace practica3;

public class Profesor: Persona, IObservado
{
    public Numero antiguedad;
    public IComparable estrategia;
    public List<IObservador> observadores;
    public Cadena accion;


    public Profesor(string n, int d, int a): base(n,d)
    {
        nombre = new Cadena(n);
        dni = new Numero(d);
        antiguedad = new Numero(a);

        // Por default es por antiguedad
        estrategia = new ComparacionPorAntiguedad(antiguedad.getValor());

        observadores = new List<IObservador>();
        accion = new Cadena("");
    }

    public void agregarObservador(IObservador o)
    {
        observadores.Add(o);
    }
    
    public void quitarObservador(IObservador o)
    {
        observadores.Remove(o);
    }

    public void notificar()
    {
        foreach(IObservador o in observadores)
        {
            o.actualizar(this);
        }
    }

    public void hablarALaClase()
    {
        Console.WriteLine("\nHablando de algun tema...");
        accion.setValor("hablando");
        notificar();
    }

    public void escribirEnElPizarron()
    {
        Console.WriteLine("\nEscribiendo en el pizarron...");
        accion.setValor("escribiendo");
        notificar();
    }

    public void setEstrategia(IComparable e)
    {
        estrategia = e;
    }

    public Cadena getAccion()
    {
        return accion;
    }

    public Numero getAntiguedad()
    {
        return antiguedad;
    }

    public override bool sosIgual(IComparable c)
    {
        Profesor otro_profesor = (Profesor)c;
        return estrategia.sosIgual(otro_profesor);
    }

    public override bool sosMayor(IComparable c)
    {
        Profesor otro_profesor = (Profesor)c;
        return estrategia.sosMayor(otro_profesor);
    }

    public override bool sosMenor(IComparable c)
    {
        Profesor otro_profesor = (Profesor)c;
        return estrategia.sosMenor(otro_profesor);
    }

    public override string ToString()
    {
        return "Nombre: " + nombre.getValor() + ", dni: " + dni.getValor() + ", antiguedad: " + antiguedad.getValor();
    }
}