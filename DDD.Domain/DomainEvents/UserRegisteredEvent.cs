using DDD.Domain.Entities.UserManagement;
using DDD.Shared.Abstraction.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.DomainEvents
{
    public record UserRegisteredEvent(User User):IDomainEvent;
    
}
