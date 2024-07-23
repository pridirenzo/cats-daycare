using CatsDaycare.Domain.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class CatCreateRequest
    {
        [Required]
        public string? Name { get; set; } = string.Empty;
        [Required]
        public int? Age { get; set; } 
        [Required]
        public string? FavoriteFood { get; set; } = string.Empty;


    }
}
