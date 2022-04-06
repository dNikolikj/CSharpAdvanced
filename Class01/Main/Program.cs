using System;
using Domain.Models;
using Domain.Enums;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion firstAnimal = new Lion(5, 4, "Simba", EnumsTypeOfAnimals.Carnivore, 44);
            firstAnimal.PrintInfo();
            firstAnimal.FavoriteFood("meat");

            Mouse firstMouse = new Mouse(2, 4, "Jerry", EnumsTypeOfAnimals.Omnivore, false);
            firstMouse.FavoriteFood("Cheese");
            firstMouse.PrintInfo();
            
        }
    }
}
