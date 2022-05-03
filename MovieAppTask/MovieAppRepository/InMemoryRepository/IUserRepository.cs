using System;
using System.Collections.Generic;
using Domain.InMemoryRepository;
using Domain.Entities;

namespace MovieAppRepository.InMemoryRepository
{
    public interface IUserRepository:IGenericRepository<User>
    {
        bool LogIn(string userName, string password);

        
    }


}
