using DDD.Domain.Entities.UserManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.UserManagement
{
    public class UserFactory : IUserFactory
    {
        public User Create(BaseId id, UserName userName, Password password, Email email, bool isConfirmed)
        {
            return new User(id, userName, password, email, isConfirmed);
        }
    }
}
