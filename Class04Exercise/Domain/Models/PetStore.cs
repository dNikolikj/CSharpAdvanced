using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PetStore<T> where T : Pet
    {

        private List<T> _animals;

        public PetStore()
        {
            _animals = new List<T>();
        }

        public void PrintPets()
        {
            for (int i = 0; i < _animals.Count; i++)
            {
                if (_animals.Count == 0)
                {
                    Console.WriteLine("The store is closed, there are no animals for adoption.");
                }
                else
                {
                   
                    Console.WriteLine($"{i + 1}) {_animals[i].PrintInfo()}");
                    
                }


            }
        }

        public void BuyPet( string name)
        {
            try { 
           var animal = _animals.Single(x => string.Equals(x.Name, name, StringComparison.OrdinalIgnoreCase));
            _animals.Remove(animal);
            Console.WriteLine($"{name} is ready for adoption");
            } catch
            {
                Console.WriteLine($"{name} it is already adopted!");
            }


        }
        public void Add(T animal)
        {
            _animals.Add(animal);
        }

        public void AddMany(List<T> animals)
        {
            _animals.AddRange(animals);
        }
    }
}
