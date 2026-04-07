namespace practica3;

public class FabricaDeAlumnos: FabricaDeComparables
{
    public FabricaDeAlumnos() {}

    public override Alumno crearAleatorio()
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        Alumno al = new Alumno(crearAleatorio("nombre"), crearAleatorio("dni"), crearAleatorio("legajo"), crearAleatorio("promedio"));
        return al;
    }
}