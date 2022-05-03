using System;
using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Person : BaseEntity
    {
        private static int s_lastEntityId = 0;
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public  List<Role> Roles { get; set; }



        public Person(string firstName, string lastName, int age, List<Role> roles)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Roles = roles;  
            
        }
        public override void GetInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} ({Age}) years old, has the following role/roles: ");
            if (Roles.Count == 0) return;
            foreach (Role role in Roles)
            {
                Console.WriteLine(role);
            }
        }

        protected override int GetNextUserId()
        {
            return ++s_lastEntityId;
        }
    }
}
