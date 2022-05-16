using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models.Entities;

namespace Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        List<T> GetAll();

        void Insert(T entity);
    }
}
