using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Primitives
{
    public abstract class BaseEntity
    {
        public BaseId Id { get;private set; }


        protected BaseEntity(BaseId id)
        {
            Id = id;
        }
    }
    
}
