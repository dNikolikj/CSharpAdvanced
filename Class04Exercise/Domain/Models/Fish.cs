using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
 public class Fish:Pet
    {

        public string Color { get; set; }   
        public double Size { get; set; }

        public Fish(string name, string type, int age, string color, double size) : base(name, type, age)
        {
            Color = color;
            Size = size;
        }

        public override string PrintInfo()
        {
            return $"{Name}\n-{Type}\n-{Size}m\n-{Color} ";
        }
    }
}
