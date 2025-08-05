using DDD.Domain.Entities.UserManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.UserManagement
{
    public interface IRoleFactory
    {
       Role Create(BaseId id, RoleName roleName);
    }
}
