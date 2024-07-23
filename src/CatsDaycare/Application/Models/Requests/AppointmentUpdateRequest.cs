using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class AppointmentUpdateRequest
    {
        [Required]
        public DateOnly? Date { get; set; }
        [Required]
        public Cat? Cat { get; set; }
    }
}
