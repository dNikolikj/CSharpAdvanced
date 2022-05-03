using System;
using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Enums;


namespace Domain.InMemoryRepository
{
   public  class GenericDb<T> : IGenericRepository<T> where T : BaseEntity
    {
        public List<T> EntityTable { get; }

       public GenericDb()
        {
            EntityTable = new List<T>();
        }

        public List<T> GetAll()
        {
            return EntityTable;
        }

        public T GetById(int id)
        {
           return EntityTable.FirstOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
             EntityTable.Add(entity);
            Console.WriteLine($"Item was added in the {entity.GetType().Name} database!");
        }

        public void InsertMany(List<T> entities)
        {
           EntityTable.AddRange(entities);
            Console.WriteLine($"{entities.Count} items were added in the {typeof(T).Name} database!");
        }

        public void PrintAll()
        {
            foreach (var entity in EntityTable)
            {
                entity.GetInfo();
            }
        }
        public Movie EditMovie(Movie movie, string title, long year, List<Genre> genres, List<Person> person, string rating)
        {
            for (int i = 0; i < EntityTable.Count; i++)
            {
                
                if (EntityTable[i].Id == movie.Id)
                {

                    return new Movie(title,year,genres,person,rating);
                }
            }
            return null;
        }
      

       
        public void Delete(int id)
        {
            try
            {
                T userToBeDeleted = EntityTable.FirstOrDefault(x => x.Id == id);

                
                if (userToBeDeleted != null)
                {
                    
                    EntityTable.Remove(userToBeDeleted);
                }
            } catch {
                Console.WriteLine("The user is not found!");
            }
        }

        
    }
}
