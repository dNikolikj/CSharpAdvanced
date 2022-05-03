using System;
using System.Collections.Generic;
using Domain.Enums;


namespace Domain.Entities
{
    public class Movie : BaseEntity
    {
        private static int s_lastEntityId = 0;
        private string _rating;
        public string Title { get; set; }
        public long Year { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Person { get; set; }
        public string Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value == "G".ToLower()
                    || value == "PG".ToLower()
                    || value == "PG-13".ToLower()
                    || value == "R".ToLower()
                    || value == "NR".ToLower())
                {
                    _rating = value;
                } else
                {
                    _rating = "NR";
                }


            }
        }
        public Movie(string title, long year, List<Genre> genres, List<Person> cast, string rating)
        {
            Title = title;
            Year = year;
            Genres = genres;
            Person = cast;
            Rating = rating;
        }


        public override void GetInfo()
        {
            Console.WriteLine($"The movie {Title} has been realeased in {Year}, it is characterized as:");
            foreach (Genre genre in Genres)
            {
                Console.WriteLine(genre);
            }
            Console.WriteLine($@"People that made ""{Title}"" happen are: ");
            foreach (Person person in Person)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName}");
                
            }
    
        }

        protected override int GetNextUserId()
        {
            return ++s_lastEntityId;
        }
    }
}
