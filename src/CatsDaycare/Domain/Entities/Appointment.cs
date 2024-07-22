using CatsDaycare.Domain.Entites;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CatsDaycare.Domain.Entites
{ 
    public class Appointment
    {
        public Appointment() { }

        public DateOnly Date { get; set; }
        public Nanny Nanny { get; set; }
        public Client Client { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Cat Cat { get; set; }
    }
}
