using System;
using Domain.Models;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // checking the iD is redundant because i am generating it. 
            Dog firstDog = new Dog("Sparky", "brown");
            Dog secondDog = new Dog("Jack", "white");
            Dog thirdDog = new Dog("Buddy", "yellow");

            Dog.Validate(thirdDog);
            DogShelter.ShelteredDogs.Add(firstDog);
            DogShelter.ShelteredDogs.Add(secondDog);
            DogShelter.ShelteredDogs.Add(thirdDog);
            DogShelter.PrintAllDogs();
        }
    }
}
