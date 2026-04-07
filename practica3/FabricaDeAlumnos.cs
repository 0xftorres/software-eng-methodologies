namespace practica3;

public class FabricaDeAlumnos: FabricaDeComparables
{
    public FabricaDeAlumnos() {}

    public override IComparable crearAleatorio()
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

        Cadena nombre_alumno = (Cadena)crearAleatorio("nombre");
        Numero dni_alumno = (Numero)crearAleatorio("dni");
        Numero legajo_alumno = (Numero)crearAleatorio("legajo");
        Numero promedio_alumno = (Numero)crearAleatorio("promedio");

        IComparable al = new Alumno(nombre_alumno.getValor(), dni_alumno.getValor(), legajo_alumno.getValor(), promedio_alumno.getValor());
        return al;
    }
}