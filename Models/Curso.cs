using System.ComponentModel.DataAnnotations.Schema;

namespace MiParcialitoB.Models
{
    public class Curso
    {
        public int CursoID { get; set; }

        [Column(TypeName = "varchar(255)")]
        public string? NombreCurso { get; set; }

        public ICollection<Inscripcion> Inscripciones { get; set; }
    }
}