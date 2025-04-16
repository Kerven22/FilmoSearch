using System.ComponentModel.DataAnnotations;

namespace Entity.Models
{
    public class User
    {
        [Key]
        public Guid UserId { get; set;  }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
