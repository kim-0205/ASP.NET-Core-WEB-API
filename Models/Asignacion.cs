
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPISolution.Models
{
    public class Asignacion
    {
        [Key]
        public int AsignacionId { get; set; }

        [ForeignKey(nameof(Estudiante))]
        public int EstudianteId { get; set; }

        [ForeignKey(nameof(Curso))]
        public int CursoId { get; set; }

        [ForeignKey(nameof(Docente))]
        public int DocenteId { get; set; }

        // Propiedades de navegación
        public Estudiante Estudiante { get; set; } = null!;
        public Curso Curso { get; set; } = null!;
        public Docente Docente { get; set; } = null!;
    }
}
