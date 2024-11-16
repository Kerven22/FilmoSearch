using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmoSearch.Entities.Models
{
    public class Film
    {
        [Key]
        [Column("FilmId")]
        public Guid FilmId { get; set; }

        [Required(ErrorMessage = "Title is a required field!")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Title is 30 characters!")]
        public string Title { get; set; }
        public string Url { get; set; }
        public string Country { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public Review Review { get; set; }

        public ICollection<Actor> Actors { get; set; }

        [InverseProperty(nameof(Comment.Film))]
        public ICollection<Comment> Comments { get; set; }

    }
}
