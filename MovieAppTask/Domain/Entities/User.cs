using System;
using System.Collections.Generic;


namespace Domain.Entities
{
    public class User : BaseEntity
    {
        private static int s_lastEntityId = 0;
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<Movie> MovieLibrary { get; set; } = new List<Movie>(); 
        public User(string userName, string password)
        {
            UserName = userName;
            Password = password;
            
        }
        public override void GetInfo()
        {
            Console.WriteLine($"Welcome {UserName}!");
        }

        protected override int GetNextUserId()
        {
            return ++s_lastEntityId;
        }
        public void ListOfMovies()
        {
            if (MovieLibrary.Count == 0) return;
            Console.WriteLine($"{UserName} the following movies are part of your library:");
            foreach (Movie movie in MovieLibrary)
            {
                Console.WriteLine(movie.Title);
            }
        }
    }
}
