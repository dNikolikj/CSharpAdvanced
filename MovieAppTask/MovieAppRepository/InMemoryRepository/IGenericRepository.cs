using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Enums;

namespace Domain.InMemoryRepository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public List<T> GetAll();


        public T GetById(int id);


        public void Insert(T entity);

        public void InsertMany(List<T> entities);

        public void Delete(int id);
        public Movie EditMovie(Movie movie, string title, long year, List<Genre> genres, List<Person> person, string rating);

        public void PrintAll();
    }
}
