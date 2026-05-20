namespace practica5;

public class AlumnoProxy : Persona, IAlumno
{
    public Numero legajo;
    public Numero promedio;
    public IComparable estrategia;
    public Numero calificacion;
    public bool esEstudioso;

    private Alumno? alumnoReal = null;

    public AlumnoProxy(string n, int d, int l, int p, bool muyEstudioso): base(n, d)
    {
        dni = new Numero(d);
        legajo = new Numero(l);
        promedio = new Numero(p);
        calificacion = new Numero(0);

        // Por default es por DNI
        estrategia = new ComparacionPorDni(dni.getValor());
    }

    public string mostrarCalificacion()
    {
        return this.nombre.getValor() + "        " + this.calificacion.getValor();
    }

    public int responderPregunta(int pregunta)
    {
        if (alumnoReal == null)
        {
            Console.WriteLine("        --(Esto e un proxy)--");
            if (esEstudioso)
            {
                alumnoReal = new AlumnoMuyEstudioso(nombre.getValor(), dni.getValor(), legajo.getValor(), promedio.getValor());
            }
            else
            {
                alumnoReal = new Alumno(nombre.getValor(), dni.getValor(), legajo.getValor(), promedio.getValor());
            }
        }

        return alumnoReal.responderPregunta(pregunta);
    }

    public void actualizar(IObservado o)
    {
        Profesor p = (Profesor)o;
        if (p.getAccion().getValor() == "hablando")
        {
            prestarAtencion();
        }
        else if (p.getAccion().getValor() == "escribiendo")
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
        string[] distracciones = { "Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel" };
        Random rand = new Random();
        int i = rand.Next(distracciones.Length);
        Console.WriteLine("Alumno {0} (legajo: {1}): {2}", nombre.getValor(), legajo.getValor(), distracciones[i]);
    }

    public override bool sosIgual(IComparable c)
    {
        return dni.getValor() == ((Persona)c).getDNI().getValor();
    }

    public override bool sosMayor(IComparable c)
    {
        return dni.getValor() > ((Persona)c).getDNI().getValor();
    }

    public override bool sosMenor(IComparable c)
    {
        return dni.getValor() < ((Persona)c).getDNI().getValor();
    }

    public void setEsEstudioso(bool estudioso)
    {
        esEstudioso = estudioso;
    }

    public override string ToString()
    {
        //return "Nombre: " + nombre.getValor() + ", DNI: " + dni.getValor() + ", Legajo: " + legajo.getValor() + ", Promedio: " + promedio.getValor() + ", Calificacion: " + calificacion.getValor();

        ImprimirLegajoDecorator im_legajo = new ImprimirLegajoDecorator(this);
        ImprimirNotaDecorator im_nota = new ImprimirNotaDecorator(im_legajo);
        ImprimirAprobacionDecorator im_aprobacion = new ImprimirAprobacionDecorator(im_nota);
        ImprimirCuadroDecorator im_cuadro = new ImprimirCuadroDecorator(im_aprobacion);
        return im_cuadro.mostrarCalificacion();
    }

    public void setCalificacion(Numero c)
    {
        this.calificacion = c;
        if (this.alumnoReal != null)
        {
            ((Alumno)this.alumnoReal).setCalificacion(c);
        }
    }

    public Numero getCalificacion()
    {
        return calificacion;
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
}