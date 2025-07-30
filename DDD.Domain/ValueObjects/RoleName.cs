using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

namespace DDD.Domain.ValueObjects
{
    public class RoleName
    {
        public string Value { get; }
        public RoleName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new RoleNameNullOrEmptyException();
            }


            Value = value;
        }

        public static implicit operator string(RoleName role) => role.Value;
        public static implicit operator RoleName(string role) => new(role);
    }
}
