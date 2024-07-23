using CatsDaycare.Domain.Entites;
using Domain.Entities;
using Domain.Entities.Enums;
using Domain.Entities.User;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Cat> Cats { get; set; }
        public DbSet<Appointment> Appointments { get; set;  }


        
        // constructor 
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasDiscriminator(u => u.UserRole)
                   .HasValue<Client>(UserType.Client)
                   .HasValue<Nanny>(UserType.Client)
                   .HasValue<Admin>(UserType.Admin);
            // al usar una sola tabla con todos los usuarios, discrimino en tabla por rol

            // cliente y gato
            // un cliente tiene asociados muchos gatos.
            // un gato tiene asociado un solo dueño / cliente
            modelBuilder.Entity<Client>()
                .HasMany(c => c.Cats)
                .WithOne(c => c.Owner);

            // cliente y turno
            // un cliente tiene asociados muchos turnos
            modelBuilder.Entity<Client>()
                .HasMany(c => c.ScheduledAppointments)
                .WithOne(a => a.Client);
            // cada turno esta asociado a un solo cliente

            // nanny y turno
            // un nanny puede tener muchos turnos
            // cada turno pertenece a un solo nanny en particular
            modelBuilder.Entity<Nanny>()
                .HasMany(n => n.ScheduledAppointments)
                .WithOne(s => s.Nanny);

            base.OnModelCreating(modelBuilder);

        }



    }
}
