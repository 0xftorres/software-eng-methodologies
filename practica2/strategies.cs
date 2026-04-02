namespace practica2;

public class ComparacionPorLegajo : IComparable
{
    public int legajo;
    public ComparacionPorLegajo(int legajo)
    {
        this.legajo = legajo;
    }

    public bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo == otro_alumno.getLegajo();
    }

    public bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo > otro_alumno.getLegajo();
    }

    public bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo < otro_alumno.getLegajo();
    }
}

public class ComparacionPorPromedio : IComparable
{

    public int promedio;
    public ComparacionPorPromedio(int promedio)
    {
        this.promedio = promedio;
    }

    public bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return promedio == otro_alumno.getPromedio();
    }

    public bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return promedio > otro_alumno.getPromedio();
    }

    public bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return promedio < otro_alumno.getPromedio();
    }
}