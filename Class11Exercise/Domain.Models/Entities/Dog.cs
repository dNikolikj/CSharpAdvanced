using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models.Entities
{
    public class Dog:BaseEntity
    {
        private static int s_lastEntityId = 0;
        public string Breed { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        protected override int GetNextEntityId()
        {
            return ++s_lastEntityId;
        }
    }
}
