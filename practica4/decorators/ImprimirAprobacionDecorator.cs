namespace practica4;

public class ImprimirAprobacionDecorator : AlumnoDecorator
{

    public ImprimirAprobacionDecorator(IAlumno a) : base(a){}


    public override string mostrarCalificacion()
    {
        string calificacion = base.mostrarCalificacion();
        int nota_numerica = alumno.getCalificacion().getValor();
        string nota = "";
        if (nota_numerica >= 7)
        {
            nota = "(PROMOCIÓN)";
        } else if(nota_numerica >= 4 && nota_numerica < 7)
        {
            nota = "(APROBADO)";
            
        }
        else
        {
            nota = "(DESAPROBADO)";
        }
        return string.Format("{0} {1}", base.mostrarCalificacion(), nota);
    }
}