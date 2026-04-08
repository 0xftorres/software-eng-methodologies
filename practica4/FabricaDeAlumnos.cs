namespace practica4;

public class FabricaDeAlumnos: FabricaDeComparables
{
    public FabricaDeAlumnos() {}

    public override IComparable crearAleatorio()
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();

        Cadena nombre_alumno = (Cadena)gen.stringAleatorio(7);
        Numero dni_alumno = (Numero)gen.numeroAleatorio(99999999);
        Numero legajo_alumno = (Numero)gen.numeroAleatorio(9999);
        Numero promedio_alumno = (Numero)gen.numeroAleatorio(10);

        IComparable al = new Alumno(nombre_alumno.getValor(), dni_alumno.getValor(), legajo_alumno.getValor(), promedio_alumno.getValor());
        return al;
    }

    public override IComparable crearPorTeclado()
    {
        LectorDeDatos lector = new LectorDeDatos();

        Console.WriteLine("Ingrese el nombre del alumno:");
        string nombre_alumno = lector.stringPorTeclado();

        Console.WriteLine("Ingrese el dni del alumno:");
        int dni_alumno = lector.numeroPorTeclado();

        Console.WriteLine("Ingrese el legajo del alumno:");
        int legajo_alumno = lector.numeroPorTeclado();

        Console.WriteLine("Ingrese el promedio del alumno:");
        int promedio_alumno = lector.numeroPorTeclado();

        IComparable a = new Alumno(nombre_alumno, dni_alumno, legajo_alumno, promedio_alumno);
        return a;
    }
}