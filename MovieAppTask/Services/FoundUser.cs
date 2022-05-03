using System;
using System.Collections.Generic;
using System.Linq;
using Domain.InMemoryRepository;
using Domain.Entities;
using MovieAppRepository;
using MovieAppRepository.InMemoryRepository;
namespace Services
{
    public static class FoundUser
    {

        public static User FindUser(List<User> usersList, string userName, string password)
        {
            foreach (User user in usersList)
            {
                if (String.Equals(userName, user.UserName, StringComparison.InvariantCultureIgnoreCase) &&
                    String.Equals(password, user.Password))
                {
                    return user;
                }
            }

            return null;
        }

    }
}
