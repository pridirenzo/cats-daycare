using CatsDaycare.Domain.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class NannyDto
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public IList<AppointmentDto>? ScheduledAppointments { get; set; } = new List<AppointmentDto>();
        public string? PhoneNumber { get; set; }


        public static NannyDto Create(Nanny Nanny)
        {
            var dto = new NannyDto
            {
                Name = Nanny.Name,
                Surname = Nanny.Surname,
                PhoneNumber = Nanny.PhoneNumber

            };

            foreach (Appointment a in Nanny.ScheduledAppointments)
            {
                dto.ScheduledAppointments?.Add(AppointmentDto.Create(a));


            };

            return dto;
        }


    }

};
