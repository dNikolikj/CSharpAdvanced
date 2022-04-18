using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
   public  class Dog
    {
        private static int _iD = 0;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }


        public Dog(string name, string color)
        {
            Id = GetId();
            Name = name;
            Color = color;
        }


        public void Bark()
        {
            Console.WriteLine($"{Name} is barking , smelled a mystery!");
        }
        
        public static bool Validate(Dog dog)
        {
            if (dog.Id <= 0 || dog.Name.Length <= 1 || dog.Color == string.Empty)
            {
                Console.WriteLine("Please enter  name and color!");
                
                return false;
            }
            Console.WriteLine($" {dog.Id}). {dog.Name} - {dog.Color} ");
            return true;
        }

        private static int GetId()
        {
            return ++_iD;
        }
    }
}
