using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.InMemoryRepository;
using Domain.Enums;


namespace MovieAppRepository.InMemoryRepository
{
    public class UserRepository : GenericDb<User>, IUserRepository
    {
      

        bool IUserRepository.LogIn(string userName, string password)
        {
            throw new NotImplementedException();
        }
        public void UpdateUser(User user)
        {
            for (int i = 0; i < EntityTable.Count; i++)
            {
               
                if (EntityTable[i].Id == user.Id)
                {
                  
                    EntityTable[i].UserName = user.UserName;
                    EntityTable[i].Password = user.Password;

                    
                    break;
                }
            }
        }
    }
}
