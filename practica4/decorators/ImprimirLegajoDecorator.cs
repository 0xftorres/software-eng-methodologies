namespace practica4;

public class ImprimirLegajoDecorator : AlumnoDecorator
{
    public ImprimirLegajoDecorator(IAlumno a) : base(a){}


    public override string mostrarCalificacion()
    {
        string calificacion = base.mostrarCalificacion();
        string nombre = calificacion.Split("        ")[0];
        string nota = calificacion.Split("        ")[1];
        return string.Format("{0} ({1})        {2}", nombre, alumno.getLegajo().getValor(), nota);
    }
}
