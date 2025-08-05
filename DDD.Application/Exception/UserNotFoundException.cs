using DDD.Shared.Abstraction.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Application.Exception
{
    public class UserNotFoundException : UserManagementExceptions
    {
        public UserNotFoundException() : base("User not found")
        {
        }
    }
}
