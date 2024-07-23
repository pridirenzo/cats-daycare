using CatsDaycare.Domain.Entites;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ClientDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public IList<AppointmentDto>? ScheduledAppointments { get; set; } = new List<AppointmentDto>();
        public string? PhoneNumber { get; set; }
        public IList<CatDto>? Cats { get; set; } = new List<CatDto>();


        public static ClientDto Create(Client Client)
        {

            var dto = new ClientDto(); // creo objeto
            dto.Name = Client.Name;
            dto.Surname = Client.Surname;
            dto.PhoneNumber = Client.PhoneNumber;

            // relleno lista de Client con objetos CatDto 
            foreach (Cat c in Client.Cats)
            {
                dto.Cats?.Add(CatDto.Create(c));
            }

            // relleno lista de Client con objetos appointmentDto
            foreach (Appointment a in Client.ScheduledAppointments)
            {
                dto.ScheduledAppointments?.Add(AppointmentDto.Create(a));
            }

            return dto;

        }


    };

};
