using Domain.Entities;
using Domain.Entities.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatsDaycare.Domain.Entites
{
    public class Client : User
    {
        public Client() { }

        public string? Name { get; set; } 
        public string? Surname { get; set; }
        public IList<Appointment>? ScheduledAppointments { get; set; } = new List<Appointment>();
        public string? PhoneNumber { get; set; }
        public IList<Cat>? Cats { get; set; } = new List<Cat>();

        public Client(string name, string surname, string phoneNumber, IList<Appointment> appointments, IList<Cat> cats)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Cats = cats ?? new List<Cat>();
            ScheduledAppointments = appointments ?? new List<Appointment>();

            // ?? operador coalescencia nula, si el primero es nulo se pasa al segundo
        }





    }
}
