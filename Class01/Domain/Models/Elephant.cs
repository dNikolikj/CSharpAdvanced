using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Models
{
    public class Elephant:Animal
    {
        public string FavFoodElephant { get; set; }
        public override void FavoriteFood(string food)
        {
            FavFoodElephant = food;
            Console.WriteLine($"The animal {Name} eats {food}.");
        }
    }
}
