using System;
using System.Collections.Generic;
using System.Linq;
using Domain.InMemoryRepository;
using Domain.Entities;
using MovieAppRepository;
using MovieAppRepository.InMemoryRepository;

namespace Services
{
    public static class UserRepositoryExtensions
    {

        public static void Login(List<User> usersList, string username, string password)
        {
            User foundUser = FoundUser.FindUser(usersList, username, password);
            if (foundUser == null)
            {
                Console.WriteLine($"Invalid credentials!");
            }
            else
            {
                Console.WriteLine($"Welcome {foundUser.UserName}. Here are your movies:");
                foreach (var movie in foundUser.MovieLibrary)
                {
                    Console.WriteLine(movie.Title);
                }
            }
        }


        public static string Register(this IUserRepository userRepository)
        {
            string userName = null;
           
            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.Write("Please enter your desired user name: ");
                userName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.WriteLine("User name cannot be empty!");
                }
            }
            string password = null;
         
            while (string.IsNullOrWhiteSpace(password))
            {
                Console.Write("Please enter your desired password:");
                password = Console.ReadLine();
                if (string.IsNullOrEmpty(password))
                {
                    Console.WriteLine("Password cannot be empty!");
                }
            }

            string passwordConfirmation = null;
            
            while (string.IsNullOrWhiteSpace(passwordConfirmation))
            {
                Console.Write("Please confirm your password:");
                passwordConfirmation = Console.ReadLine();
                if (passwordConfirmation != password)
                {
                    Console.WriteLine("Password do not match! Please try again.");
                }
            }
            userRepository.Insert(new User(userName, password));

           
            return userName;
        }
    }
}
