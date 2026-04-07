namespace practica2;

public abstract class Persona : IComparable
{
    public string nombre;
    public int dni;

    public Persona(string n, int d){
        dni = d;
        nombre = n;
    }

    public string getNombre()
    {
        return nombre;
    }

    public int getDNI()
    {
        return dni;
    }

    public virtual bool sosIgual(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni == otro_alumno.getDNI();
    }

    public virtual bool sosMayor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni > otro_alumno.getDNI();
    }

    public virtual bool sosMenor(IComparable c)
    {
        Alumno otro_alumno = (Alumno)c;
        return dni < otro_alumno.getDNI();
    }

    public virtual string ToString()
    {
        return "Nombre: " + nombre + ", DNI: " + dni;
    }
}