namespace MiParcialitoB.Models
{
    public class Inscripcion
    {
        public int Id { get; set; }
        public int EstudianteID { get; set; }
        public Estudiante Estudiante{ get; set; }

        public int CursoID { get; set; }
        public Curso Curso { get; set; }
    }
}
