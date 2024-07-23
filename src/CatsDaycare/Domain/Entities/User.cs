using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.User
{
    public abstract class User
    {
        public User() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set;  }
        public string? Username { get; set; }
        public string? Password { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public Enum? UserRole { get; set; }    // discriminator
    }
}
