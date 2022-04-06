using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;

namespace Domain.Models
{
    public class Mouse:Animal
    {
        public string FavFoodMouse { get; set; }
        public bool isEaten { get; set; }


        public Mouse(int age, int numberOfLegs, string name, EnumsTypeOfAnimals typeOfAnimal,bool isEaten) :base( age,  numberOfLegs,  name,  typeOfAnimal)
        {
            isEaten = true;
        }
        public override void FavoriteFood(string food)
        {
            FavFoodMouse = food;
            Console.WriteLine($"The animal {Name} eats {food}.");
        }
    }
}
