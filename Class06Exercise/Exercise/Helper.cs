using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Job Occupation { get; set; }
		public List<Dog> Dogs { get; set; }

		public Person(string firstName, string lastName, int age, Job occupation)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Occupation = occupation;
			Dogs = new List<Dog>();
		}
	}

	public class Dog
	{
		public string Name { get; set; }
		public string Color { get; set; }
		public int Age { get; set; }
		public Race Race { get; set; }

		public Dog(string name, string color, int age, Race race)
		{
			Name = name;
			Color = color;
			Age = age;
			Race = race;
		}
	}

	public enum Race
	{
		Boxer,
		Bulldog,
		Collie,
		Dalmatian,
		Doberman,
		Mutt,
		Mudi,
		Pointer,
		Pug,
		Plott
	}

	public enum Job
	{
		Archivist,
		Waiter,
		Choreographer,
		Developer,
		Dentist,
		Sculptor,
		Interpreter,
		Barber
	}

}
