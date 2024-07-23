using CatsDaycare.Domain.Entites;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class AppointmentDto
    {
        public DateOnly? Date { get; set; }
        public Nanny? Nanny { get; set; }
        public Client? Client { get; set; }
        public int? Id { get; set; }
        public Cat? Cat { get; set; }


        public static AppointmentDto Create(Appointment Appointment)
        {
            var dto = new AppointmentDto();

            dto.Date = Appointment.Date;
            dto.Nanny = Appointment.Nanny;
            dto.Client = Appointment.Client;
            dto.Id = Appointment.Id;
            dto.Cat = Appointment.Cat;

            return dto;
        }

    }
}
