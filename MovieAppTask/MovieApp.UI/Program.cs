using System;
using System.Collections.Generic;
using Domain.InMemoryRepository;
using Domain.Entities;
using Domain.Enums;
using MovieAppRepository.InMemoryRepository;
using Services;
namespace MovieApp.UI
{
    public class Program
    {
   
        static void Main(string[] args)
        {
            GenericDb<Movie> movieDb = new GenericDb<Movie>();
            GenericDb<Person> personDb = new GenericDb<Person>();
            IUserRepository userRepository = new UserRepository();

            List<Person> castBlackMass = new List<Person>()
            {
                new Person("Johnny","Depp",57,new List<Role>{Role.Actor}),
                new Person( "Dakota", "Johnson",33, new List<Role>{Role.Actor} ),
                new Person("Benedict","Cumberbatch",55, new List<Role>{Role.Actor}),
                new Person("Scott", "Cooper", 52, new List<Role>{Role.Director} ),
            };

            List<Person> castInception = new List<Person>()
            {
                new Person("Leonardo","DiCaprio",48,new List<Role>{Role.Actor,Role.Producer}),
                new Person( "Joseph", "Gordon-Levitt",35, new List<Role>{Role.Actor,Role.Producer} ),
                new Person("Eliot","Page",55, new List<Role>{Role.Actor}),
                new Person("Christopher", "Nolan", 52, new List<Role>{Role.Director} ),
            };
            Movie blackMass = new Movie("Black Mass", 2015, new List<Genre> { Genre.Drama, Genre.Crime },
                new List<Person> { castBlackMass[0], castBlackMass[1], castBlackMass[2], castBlackMass[3] }, "G");
            Movie inception = new Movie("Inception", 2010, new List<Genre> { Genre.Action, Genre.Fantasy, Genre.Adventure },
                new List<Person> { castInception[0], castInception[1], castInception[2], castInception[3] }, "PG");
            blackMass.GetInfo();
            ClearConsole.ConsoleCleared();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            inception.GetInfo();
            ClearConsole.ConsoleCleared();
            movieDb.Insert(blackMass);
            movieDb.Insert(inception);
            personDb.InsertMany(castInception);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            movieDb.PrintAll();
            ClearConsole.ConsoleCleared();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            personDb.PrintAll();
            ClearConsole.ConsoleCleared();
            User firstUser = new User("Ronald", "HappilyEverAfter");
            User secondUser = new User("Bill", "FisForFamily");
            firstUser.MovieLibrary.Add(inception);
            firstUser.MovieLibrary.Add(blackMass);
            secondUser.MovieLibrary.Add(inception);
            secondUser.MovieLibrary.Add(blackMass);
            List<User> users = new List<User> { firstUser, secondUser };
            Console.WriteLine("Enter username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter password");
            string password = Console.ReadLine();

            User foundUser = FoundUser.FindUser(users, username, password);
            if (foundUser == null)
            {
                Console.WriteLine($"Invalid credentials!");
            }
            else
            {
                Console.WriteLine($"Welcome {foundUser.UserName}. Here is your movie library");
                foreach (var movie in foundUser.MovieLibrary)
                {
                    Console.WriteLine(movie.Title);
                }

            }
            ClearConsole.ConsoleCleared();
            userRepository.Insert(firstUser);
            userRepository.Insert(secondUser);

            while (true)
            {
               
                Console.WriteLine("Welcome to Imdb!");
                Console.WriteLine("~~~~~~~~~~~~~~");
                Console.WriteLine("1) Log in");
                Console.WriteLine("2) Register");
              
                var guestInput = Console.ReadLine();

                switch (guestInput)
                {

                    case "1":

                        
                            Console.WriteLine("Enter username");
                            string username1 = Console.ReadLine();

                            Console.WriteLine("Enter password");
                            string password1 = Console.ReadLine();

                            UserRepositoryExtensions.Login(users, username1, password1);

                            ClearConsole.ConsoleCleared();
                            break;
                        
                    case "2":

                        var registeredUser = userRepository.Register();

                        Console.WriteLine($"Successfully registered user {registeredUser}!");

                        ClearConsole.ConsoleCleared();

                        break;

                    default:
                        Console.WriteLine("Invalid input, try again");
                        continue;


                }
                break;
            }
        }
    }
}
