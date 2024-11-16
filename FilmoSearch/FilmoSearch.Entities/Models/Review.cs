using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmoSearch.Entities.Models
{
    public class Review
    {
        [Key]
        [Column("ReviewId")]
        public Guid ReviewId { get; set; }

        [Required(ErrorMessage = "Review description is a required field!")]
        public string Description { get; set; }

        [ForeignKey(nameof(Film))]
        public Guid FilmId { get; set; }
        public Film? Film { get; set; }
    }
}
