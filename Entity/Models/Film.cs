using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class Film
    {
        [Key]
        public Guid FilmId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public DateOnly CreationDate { get; set; }
    }
}
