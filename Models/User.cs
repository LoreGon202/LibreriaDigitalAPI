using System.ComponentModel.DataAnnotations;

namespace LibreriaDigitalAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}
