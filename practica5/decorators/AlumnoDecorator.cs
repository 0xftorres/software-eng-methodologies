namespace practica5;

public abstract class AlumnoDecorator : IAlumno
{
    protected IAlumno alumno;

    public AlumnoDecorator(IAlumno a)
    {
        alumno = a;
    }

    public virtual string mostrarCalificacion()
    {
        return alumno.mostrarCalificacion();
    }

    public virtual Numero getCalificacion()
    {
        return alumno.getCalificacion();
    }

    public virtual Numero getLegajo()
    {
        return alumno.getLegajo();
    }
}