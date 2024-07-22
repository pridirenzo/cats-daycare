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

        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Appointment> ScheduledAppointments { get; set; } = new List<Appointment>();
        public string PhoneNumber { get; set; }
    }
}
