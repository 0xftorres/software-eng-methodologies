namespace practica5;

public class StudentAdapter : Student
{
    private IAlumno alumno;

    public StudentAdapter(IAlumno a)
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
        return ((IComparable)this.alumno).sosIgual((IComparable)other.alumno);
    }

    public bool lessThan(Student student)
    {
        StudentAdapter other = (StudentAdapter)student;
        return ((IComparable)this.alumno).sosMenor((IComparable)other.alumno);
    }

    public bool greaterThan(Student student)
    {
        StudentAdapter other = (StudentAdapter)student;
        return ((IComparable)this.alumno).sosMayor((IComparable)other.alumno);
    }
}