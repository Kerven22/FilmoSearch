using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmoSearch.Entities.Models
{
    public class Comment
    {
        [Column("CommentId")]
        public Guid CommentId { get; set; }
        [Required(ErrorMessage = "Title is a required field!")]
        [MaxLength(100, ErrorMessage = "Maximum length for the Comment is 100 characters!")]
        public string Title { get; set; }

        [ForeignKey(nameof(Film))]
        public Guid FilmId { get; set; }
        public Film Film { get; set; }

        [ForeignKey(nameof(User))]
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
