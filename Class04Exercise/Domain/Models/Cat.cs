using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Cat : Pet
    {

        public bool IsLazy { get; set; }
        public int LivesLeft = 9;
        public bool HasAccident { get; set; }
        public Cat(string name, string type, int age, bool isLazy, bool hasAccident):base(name,type,age)
        {
            IsLazy = isLazy;
           HasAccident = hasAccident;
        }
        public override string PrintInfo()
        {
            return $"{Name} is {Type} it is {Age} years old.";
        }
        public void HowManyLivesLeft()
        {
            int result;
            if(HasAccident == true)
            {
                result = --LivesLeft;
                Console.WriteLine($"{Name} has {result} lives left to live.");
            }
           
        }

        public void IsItLazy(Cat cat)
        {
            if(cat.Type.ToLower() == "Persian".ToLower()) { 
                Console.WriteLine($"{cat.Name} it is very lazy");
                  IsLazy = true;
            } else
            {
                IsLazy= false;
            }


        }
    }
}
