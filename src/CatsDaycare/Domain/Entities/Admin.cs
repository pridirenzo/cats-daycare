using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsDaycare.Domain.Entites
{
    public class Admin : User
    {
        public Admin() { }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? UserRole { get; set; }   // discriminator

        public Admin(int id, string username, string password, string email, string userRole)
        {
            Id = id;
            Username = username;
            Password = password;
            Email = email;
            UserRole = userRole;

        }

    };


}
