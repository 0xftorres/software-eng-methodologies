namespace practica5;

public abstract class Persona : IComparable
{
    public Cadena nombre;
    public Numero dni;

    public Persona(string n, int d){
        dni = new Numero(d);
        nombre = new Cadena(n);
    }

    public Cadena getNombre()
    {
        return nombre;
    }

    public Numero getDNI()
    {
        return dni;
    }

    public virtual bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni.getValor() == otro_alumno.getDNI().getValor();
    }

    public virtual bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni.getValor() > otro_alumno.getDNI().getValor();
    }

    public virtual bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni.getValor() < otro_alumno.getDNI().getValor();
    }

    public override string ToString()
    {
        return "Nombre: " + nombre.getValor() + ", DNI: " + dni.getValor();
    }
}