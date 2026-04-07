namespace practica3;

public class Alumno: Persona
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

        estrategia = new ComparacionPorDni(dni.getValor());
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
        return "Nombre: " + nombre + ", DNI: " + dni + ", Legajo: " + legajo + ", Promedio: " + promedio;
    }
}
