namespace practica1;

public class Alumno: Persona
{
    public int legajo;
    public int promedio;

    public Alumno(string n, int d, int l, int p): base(n,d)
    {
        nombre = n;
        dni = d;
        legajo = l;
        promedio = p;
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
        return legajo == otro_alumno.getLegajo();
    }

    public override bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo > otro_alumno.getLegajo();
    }

    public override bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo < otro_alumno.getLegajo();
    }
}