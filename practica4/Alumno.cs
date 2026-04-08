namespace practica4;

public class Alumno: Persona, IObservador
{
    public Numero legajo;
    public Numero promedio;
    public IComparable estrategia;

    public Alumno(string n, int d, int l, int p): base(n,d)
    {
        nombre = new Cadena(n);
        dni = new Numero(d);
        legajo = new Numero(l);
        promedio = new Numero(p);

        // Por default es por DNI
        estrategia = new ComparacionPorDni(dni.getValor());
    }

    public void actualizar(IObservado o)
    {
        Profesor p = (Profesor)o;
        if (p.getAccion().getValor() == "hablando")
        {
            prestarAtencion();
        }
        else if(p.getAccion().getValor() == "escribiendo")
        {
            distraerse();
        }
        else
        {
            // Ante la duda se distrae
            distraerse();
        }
    }

    public void prestarAtencion()
    {
        Console.WriteLine("Alumno {0} (legajo: {1}): Prestando atencion...", nombre.getValor(), legajo.getValor());
    }

    public void distraerse()
    {
        string[] distracciones = {"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
        Random rand = new Random();
        int i = rand.Next(distracciones.Length);
        Console.WriteLine("Alumno {0} (legajo: {1}): {2}", nombre.getValor(), legajo.getValor(), distracciones[i]);
    }

    public void setEstrategia(IComparable e)
    {
        estrategia = e;
    }

    public Numero getLegajo()
    {
        return legajo;
    }

    public Numero getPromedio()
    {
        return promedio;
    }


    public override bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return estrategia.sosIgual(otro_alumno);
    }

    public override bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return estrategia.sosMayor(otro_alumno);
    }

    public override bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return estrategia.sosMenor(otro_alumno);
    }

    public override string ToString()
    {
        return "Nombre: " + nombre.getValor() + ", DNI: " + dni.getValor() + ", Legajo: " + legajo.getValor() + ", Promedio: " + promedio.getValor();
    }
}
