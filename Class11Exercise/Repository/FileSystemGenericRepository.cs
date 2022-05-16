using System;
using System.Collections.Generic;
using Domain.Models.Entities;
using System.IO;
using Newtonsoft.Json;


namespace Repository
{
   public class FileSystemGenericRepository<T>:IGenericRepository<T> where T : BaseEntity
    {
        private string _filePath = $"db_{typeof(T).Name}.txt";

        public FileSystemGenericRepository()
        {
            EnsureDbFileExists();
        }

        public List<T> GetAll()
        {
           
            string currentData = File.ReadAllText(_filePath);

           
            List<T> entities = JsonConvert.DeserializeObject<List<T>>(currentData);

           
            return entities;
        }

        public void Insert(T entity)
        {
            
            string currentData = File.ReadAllText(_filePath);

            List<T> currentEntities = JsonConvert.DeserializeObject<List<T>>(currentData);

          
            if (currentEntities == null)
            {
                currentEntities = new List<T>();
            }

           
            currentEntities.Add(entity);

          
            string serializedEntities = JsonConvert.SerializeObject(currentEntities);

         
            File.WriteAllText(_filePath, serializedEntities);
        }

       
        private void EnsureDbFileExists()
        {
            if (!File.Exists(_filePath))
            {
                File.Create(_filePath).Close();
            }
        }
    }
}
