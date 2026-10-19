using System.ComponentModel.DataAnnotations;

namespace WebAPISolution.Models
{
    public class Estudiante
    {
        [Key]
        [Required]

        public int EstudianteId { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "Este campo es requerido")]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Required]
        [StringLength(150)]
        public string Direccion { get; set; }
    }
}
