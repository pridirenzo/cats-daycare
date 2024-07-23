﻿using CatsDaycare.Domain.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cat
    {
        public Cat() { }

        public string? Name { get; set; }
        public int? Age { get; set; }
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? Id { get; set; }
        public Client? Owner { get; set; }
        public string? FavoriteFood { get; set; }
        public Nanny? Nanny { get; set; }


        // constructor para inicializar
        public Cat(Client owner, Nanny nanny, int id, string name, int age, string favoriteFood)
        {
            Owner = owner;
            Nanny = nanny;
            Id = id;
            Name = name;
            Age = age;
            FavoriteFood = favoriteFood;

        }



    }






}
