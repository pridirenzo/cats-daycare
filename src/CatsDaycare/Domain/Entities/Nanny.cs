using Domain.Entities;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsDaycare.Domain.Entites
{
    public class Nanny : User
    {
        public Nanny() { }

        public string? Name { get; set; }
        public string? Surname { get; set; }
        public IList<Appointment>? ScheduledAppointments { get; set; } = new List<Appointment>();
        public string? PhoneNumber { get; set; }


        public Nanny(string name, string surname, string phoneNumber, IList<Appointment> appointments)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            ScheduledAppointments = appointments ?? new List<Appointment>();
        }



    }
}
