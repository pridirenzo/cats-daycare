using CatsDaycare.Domain.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.Models
{
    public class CatDto
    {
        public string? Name { get; set; }
        public int? Age { get; set; }
        public int? Id { get; set; }
        public Client? Owner { get; set; }
        public string? FavoriteFood { get; set; }
        public Nanny? Nanny { get; set; }


        public static CatDto Create(Cat Cat)
        {
            var dto = new CatDto
            {
                Name = Cat.Name,
                Age = Cat.Age,
                Id = Cat.Id,
                Owner = Cat.Owner,
                FavoriteFood = Cat.FavoriteFood,
                Nanny = Cat.Nanny

            };

            return dto;

        }

    }
}