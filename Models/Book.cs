using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibreriaDigitalAPI.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        [Required]
        public string Autor { get; set; }

        public int AnioPublicacion { get; set; }

        public string? ImagenPortada { get; set; }

        [Range(1,5)]
        public int Calificacion { get; set; }

        public string? Resena { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

        public User? User { get; set; }
    }
}
