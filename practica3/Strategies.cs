namespace practica3;

public class ComparacionPorLegajo : IComparable
{
    public Numero legajo;
    public ComparacionPorLegajo(int legajo)
    {
        this.legajo = new Numero(legajo);
    }

    public bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo.getValor() == otro_alumno.getLegajo().getValor();
    }

    public bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo.getValor() > otro_alumno.getLegajo().getValor();
    }

    public bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return legajo.getValor() < otro_alumno.getLegajo().getValor();
    }
}

public class ComparacionPorPromedio : IComparable
{

    public Numero promedio;
    public ComparacionPorPromedio(int promedio)
    {
        this.promedio = new Numero(promedio);
    }

    public bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return promedio.getValor() == otro_alumno.getPromedio().getValor();
    }

    public bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return promedio.getValor() > otro_alumno.getPromedio().getValor();
    }

    public bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return promedio.getValor() < otro_alumno.getPromedio().getValor();
    }
}

public class ComparacionPorDni : IComparable
{

    public Numero dni;
    public ComparacionPorDni(int dni)
    {
        this.dni = new Numero(dni);
    }

    public bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni.getValor() == otro_alumno.getDNI().getValor();
    }

    public bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni.getValor() > otro_alumno.getDNI().getValor();
    }

    public bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni.getValor() < otro_alumno.getDNI().getValor();
    }
}