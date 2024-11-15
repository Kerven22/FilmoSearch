using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmoSearch.Entities.Models
{
    public class Actor
    {
        [Column("ActorId")]
        public Guid ActorId { get; set; }

        [Required(ErrorMessage = "First name is a required field!")]
        [MaxLength(30, ErrorMessage = "Maximum lengt for the First name is 30 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Second name is a required field!")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Second name is 30 characters!")]
        public string SecondName { get; set; }

        public string? Country { get; set; }
        [Required(ErrorMessage = "Age is reqiered field!")]
        public byte Age { get; set; }

        public string? UrlFotography { get; set; }

        public  ICollection<Film> Films { get; set; }
    }
}
