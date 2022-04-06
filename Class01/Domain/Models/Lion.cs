using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Models
{
    public class Lion:Animal
    {

        public string FavFoodLion { get; set; }
        public int Mass { get; set; }

        public Lion(int age, int numberOfLegs, string name, EnumsTypeOfAnimals typeOfAnimal, int mass):base(age,  numberOfLegs,  name,  typeOfAnimal)
        {
            Mass = mass;
        }
        public void Bark()
        {
            Console.WriteLine($"{Name} is barking..");
        }



        public override void FavoriteFood(string food)
        {
            FavFoodLion = food;
            Console.WriteLine($"The animal {Name} eats {food}.");
        }



    }
}
