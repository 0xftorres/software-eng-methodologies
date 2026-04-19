namespace practica4;

public class ImprimirCuadroDecorator : AlumnoDecorator
{
    public ImprimirCuadroDecorator(IAlumno a) : base(a){}


    public override string mostrarCalificacion()
    {
        string final = "";
        int cantidad_de_chars = base.mostrarCalificacion().Length;
        for (int i = 0; i < cantidad_de_chars + 12; i++)
        {
            final += "*";
        }
        final += "\n*     " + base.mostrarCalificacion() + "     *\n";
        for (int i = 0; i < cantidad_de_chars + 12; i++)
        {
            final += "*";
        }
        return final;
    }
}