using System.ComponentModel.DataAnnotations;

namespace T3_Grupo02.Models
{
    public class Libro
    {
        [Key]
        public int id {  get; set; }
        public string titulo { get; set; }
        public string autor { get; set; }
        public string tema { get; set; }
        public string editorial { get; set; }
        public int aniopublicacion { get; set; }
        public int paginas { get; set; }
        public string categoria { get; set; }

    }
}
