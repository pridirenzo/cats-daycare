using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using CatsDaycare.Domain.Entites;

namespace Application.Models
{
    public class AdminDto
    {
        public int? Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        [EmailAddress]
        public string? Email { get; set; }
        public string? UserRole { get; set; }



        public AdminDto Create(int id, string username, string password, string email, string userRole)
        {
            var dto = new AdminDto
            {
                Id = id,
                Username = username,
                Password = password,
                Email = email,
                UserRole = userRole
            };

            return dto;

        }

    }
}
