using System;
using Domain.Models;

namespace Main
{
    public class Program
    {
        static void Main(string[] args)
        {

            Dog firstDog = new Dog("Sparky", "Maltese",9, true, "Meat");
            Dog secondDog = new Dog("Freud", "Huskey", 10,false, "Carbs");

            Cat firstCat = new Cat("Bella", "Persian", 5, true, true);
            Cat secondCat = new Cat("Madonna", "Maine cooun", 3, false, false);

            Fish firstFish = new Fish("Nemo", "GoldFish", 2, "Gold", 2.5);
            Fish secondFish = new Fish("Bubbles", "YellowTang", 1, "Yellow", 1.5);

            Console.WriteLine("~~~~~~~~Dogs~~~~~~~~~~~~~~~");
            PetStore<Dog> dogPetstore = new PetStore<Dog>();
            dogPetstore.Add(firstDog);
            dogPetstore.Add(secondDog);
            dogPetstore.BuyPet("Freud");
            dogPetstore.PrintPets();

            firstDog.FavFood();

            Console.WriteLine("~~~~~~~~Cats~~~~~~~~~~~~~~~");
            PetStore<Cat> catPetStore = new PetStore<Cat>();
            catPetStore.Add(firstCat);
            catPetStore.Add(secondCat);
            catPetStore.BuyPet("Bella");
            catPetStore.PrintPets();
            firstCat.HowManyLivesLeft();
            firstCat.IsItLazy(firstCat);

            Console.WriteLine("~~~~~~~~~~Fish~~~~~~~~~~~~");

            PetStore<Fish> fishPetStore = new PetStore<Fish>();
            fishPetStore.Add(firstFish);
            fishPetStore.Add(secondFish);
            fishPetStore.PrintPets();
            
        }
    }
}
