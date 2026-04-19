namespace practica4;

public class StudentAdapter : Student
{
    private Alumno alumno;

    public StudentAdapter(Alumno a)
    {
        alumno = a;
    }

    public string getName()
    {
        return alumno.getNombre().getValor();
    }

    public int yourAnswerIs(int question)
    {
        return alumno.responderPregunta(question);
    }

    public void setScore(int score)
    {
        alumno.setCalificacion(new Numero(score));
    }

    public string showResult()
    {
        return alumno.ToString();
    }

    public bool equals(Student student)
    {
        StudentAdapter other = (StudentAdapter)student;
        return alumno.sosIgual(other.alumno);
    }

    public bool lessThan(Student student)
    {
        StudentAdapter other = (StudentAdapter)student;
        return alumno.sosMenor(other.alumno);
    }

    public bool greaterThan(Student student)
    {
        StudentAdapter other = (StudentAdapter)student;
        return alumno.sosMayor(other.alumno);
    }
}