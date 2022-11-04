using System.ComponentModel.DataAnnotations;

namespace WebApiUniversidad.Entities
{
    public class Curso
    {
        [Key]
        public int CursoId { get; set; }

        [Required]
        [StringLength(50)]
        public int Nombre { get; set; }


    }
}
