namespace practica5
{
    public class OrdenLlegaAlumno : IOrdenEnAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula a)
        {
            this.aula = a;
        }

        public void ejecutar(IComparable comparable)
        {
            if (comparable is IAlumno alumno)
            {
                StudentAdapter adaptador = new StudentAdapter(alumno);

                this.aula.nuevoAlumno(adaptador);
            }
        }
    }
}