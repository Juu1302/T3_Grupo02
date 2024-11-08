using System.ComponentModel.DataAnnotations;

namespace T3_Grupo02.Models
{
    public class Libro
    {
        [Key]
        public int id {  get; set; }

        [Required(ErrorMessage ="El Titulo del libro es obligatorio")]
        public string titulo { get; set; }

        [Required(ErrorMessage = "El Autor del libro es obligatorio")]
        public string autor { get; set; }

        [Required(ErrorMessage = "El Tema del libro es obligatorio")]
        public string tema { get; set; }

        [Required(ErrorMessage = "El Editorial del libro es obligatorio")]
        public string editorial { get; set; }

        [Required(ErrorMessage = "El Año de publicacion es obligatorio")]
        [Range(1900, 3000, ErrorMessage = "El Año debe ser de entre 1900 a 3000")]
        public int aniopublicacion { get; set; }

        [Required(ErrorMessage = "Las paginas son obligatorio")]
        [Range(10, 1000, ErrorMessage = "El libro debe tener de entre 10 a 1000 paginas")]
        public int paginas { get; set; }

        [Required(ErrorMessage = "La categoria del libro es obligatoria")]
        public string categoria { get; set; }

    }
}
