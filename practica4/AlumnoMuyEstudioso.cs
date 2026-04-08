namespace practica4;

public class AlumnoMuyEstudioso: Alumno
{
    public AlumnoMuyEstudioso(string n, int d, int l, int p): base(n, d, l, p)
    {
        estrategia = new ComparacionPorDni(d);
    }

    public override int responderPregunta(int pregunta)
    {
        return pregunta % 3;
    }

}