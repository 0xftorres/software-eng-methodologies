namespace practica2;

public class Alumno: Persona
{
    public int legajo;
    public int promedio;
    public IComparable estrategia;

    public Alumno(string n, int d, int l, int p): base(n,d)
    {
        nombre = n;
        dni = d;
        legajo = l;
        promedio = p;

        estrategia = new ComparacionPorDni(dni);
    }

    public void setEstrategia(IComparable e)
    {
        estrategia = e;
    }

    public int getLegajo()
    {
        return legajo;
    }

    public int getPromedio()
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
