using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public static  class DogShelter
    {

        public static List<Dog> ShelteredDogs { get; set; } = new List<Dog>();

        public static void PrintAllDogs()
        {
            Console.WriteLine("The following dogs are sheltered: ");
            foreach (var dog in ShelteredDogs)
            {
                Console.WriteLine($"{dog.Name}");
            }
        }
    }
}
