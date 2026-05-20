namespace practica5;

public interface IAlumno
{
    public string mostrarCalificacion();
    public Numero getCalificacion();
    public Numero getLegajo();
    public Cadena getNombre();
    public int responderPregunta(int pregunta);
    public void setCalificacion(Numero c);
}
