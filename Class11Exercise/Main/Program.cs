using System;
using System.Collections.Generic;
using Domain.Models.Entities;
using Repository;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dog dog = new Dog();
            Console.WriteLine("Please enter your dog's breed:");
            dog.Breed = Console.ReadLine();
            Console.WriteLine("Please enter your dog's age:");
            dog.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your dog's color:");
            dog.Color = Console.ReadLine();

            IGenericRepository<Dog> repository = new FileSystemGenericRepository<Dog>();
            repository.Insert(dog);

            List<Dog> currentlySavedDog = repository.GetAll();

            Console.WriteLine("~~~~~~~~~~Dog stats~~~~~~~~~~~~~~~~~~");

            foreach (Dog myDog in currentlySavedDog)
            {
                Console.WriteLine($"Id:{myDog.Id} \nBreed:{myDog.Breed} \nColor:{myDog.Color}\nAge:{myDog.Age}");
            }
            ClearConsole();
        }
        private static void ClearConsole()
        {
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadLine();

            Console.Clear();
        }
    }
}
