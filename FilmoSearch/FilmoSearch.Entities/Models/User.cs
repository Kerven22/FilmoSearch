using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmoSearch.Entities.Models
{
    public class User
    {
        [Key]
        [Column("UserId")]
        public Guid UserId { get; set; }

        [Required(ErrorMessage = "User Login is a required field!")]
        [MaxLength(100, ErrorMessage = "Maximum length for the Login is 100 characters")]
        public string Login { get; set; }

        [InverseProperty(nameof(Comment.User))]
        public ICollection<Comment>? Comments { get; set; }
    }
}
