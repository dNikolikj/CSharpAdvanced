using System;
using System.Collections.Generic;
using System.Text;
using Domain.Enums;


namespace Domain.Models
{
    public class Animal
    {
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }
        public string Name { get; set; }
        public string FavFood { get; set; }
        public EnumsTypeOfAnimals TypeOfAnimal { get; set; }

        public Animal()
        {

        }
        public Animal(int age, int numberOfLegs, string name, EnumsTypeOfAnimals typeOfAnimal)
        {
            Age = age;
            NumberOfLegs = numberOfLegs;
            Name = name;
            TypeOfAnimal = typeOfAnimal;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{Name} is {Age} years old , and it is {TypeOfAnimal}" );
        }

        public virtual void FavoriteFood(string food)
        {
            FavFood = food;
            Console.WriteLine($"The animal {Name} eats {food}.");
        }
    }
}
