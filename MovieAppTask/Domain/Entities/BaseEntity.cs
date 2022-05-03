using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; }

        public BaseEntity()
        {
            Id = GetNextUserId();
        }

        protected abstract int GetNextUserId();

        public abstract void GetInfo();
    }
}
