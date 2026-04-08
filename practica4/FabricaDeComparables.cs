namespace practica3;

public abstract class FabricaDeComparables
{

    public abstract IComparable crearAleatorio();
    public abstract IComparable crearPorTeclado();

    public static IComparable crearAleatorio(string tipo)
    {
        FabricaDeComparables fab = null;

        if(tipo=="alumno") {
            fab = new FabricaDeAlumnos();
        } else if (tipo == "numero") {
            fab = new FabricaDeNumeros();
        } else if (tipo == "profesor") {
            fab = new FabricaDeProfesores();
        } else {
            return null;
        }

        return fab.crearAleatorio();
    }

    /*
    public static IComparable crearAleatorioPreseteado()
    {
        GeneradorDeDatosAleatorios gen = new GeneradorDeDatosAleatorios();
        return gen.numeroAleatorio(99999999);
    }*/

    public static IComparable crearPorTeclado(string tipo)
    {
        FabricaDeComparables fab = null;
        
        if (tipo=="alumno") {
            fab = new FabricaDeAlumnos();
        } else if (tipo == "numero") {
            fab = new FabricaDeNumeros();
        } else if (tipo == "profesor") {
            fab = new FabricaDeProfesores();
        } else {
            return null;
        }

        return fab.crearPorTeclado();
    }
}