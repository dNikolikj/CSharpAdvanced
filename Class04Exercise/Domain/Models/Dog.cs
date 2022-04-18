using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
  public class Dog : Pet
    {
        public bool IsGoodBoi { get; set; }
        public string FavouriteFood { get; set; }


        public Dog(string name, string type, int age, bool isGoodBoi, string favouriteFood) : base(name, type, age)
        {
            IsGoodBoi = isGoodBoi;
            FavouriteFood = favouriteFood;
        }
        public void FavFood()
        {
            if (FavouriteFood.ToLower() == "meat".ToLower())
            {
                IsGoodBoi = true;
                Console.WriteLine($"{Name} is good boi.");
            }
            else
            {
                IsGoodBoi = false;
                Console.WriteLine($"{Name} is angry because he doesn't like {FavouriteFood}!");
            }

        }

        public override string PrintInfo()
        {
           return $"{Name} is {Type}, and he is {Age} years old.";
        }
    }
}
