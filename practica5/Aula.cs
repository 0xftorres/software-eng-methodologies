namespace practica5
{
    public class Aula
    {
        private Teacher? teacher = null;

        public Aula()
        {
            this.teacher = null;
        }

        public void comenzar()
        {
            Console.WriteLine("Aula: Iniciando clase. Se asigna un nuevo profesor");
            this.teacher = new Teacher();
        }

        public void nuevoAlumno(Student alumno)
        {
            if (this.teacher == null)
            {
                Console.WriteLine("No se puede agregar el alumno. Primero iniciar la clase con comenzar()");
                return;
            }

            this.teacher.goToClass(alumno);
        }

        public void claseLista()
        {
            if (this.teacher == null)
            {
                Console.WriteLine("No hay profes asignados para iniciar la clase");
                return;
            }

            Console.WriteLine("Aula: La lista está completa. El profesor inicia la rutina");
            this.teacher.teachingAClass();
        }
    }
}