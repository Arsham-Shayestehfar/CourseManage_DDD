using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

namespace DDD.Domain.ValueObjects
{
    public record UserName
    {
        public string Value { get; }
        public UserName(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new UsernameNullOrEmptyException();
            }


            Value = value;
        }

        public static implicit operator string(UserName username) => username.Value;
        public static implicit operator UserName(string username) => new(username);
    }
}
