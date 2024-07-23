using CatsDaycare.Domain.Entites;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class AppointmentCreateRequest
    {
        // que se pida especificar para q fecha es el turno y q gato involucra
        [Required]
        public DateOnly? Date { get; set; }
        [Required]
        public Cat? Cat { get; set; }

    }
}
