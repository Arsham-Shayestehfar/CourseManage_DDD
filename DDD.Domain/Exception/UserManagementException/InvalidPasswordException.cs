using DDD.Shared.Abstraction.Exceptions;

namespace ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

internal class InvalidPasswordException : DDD.Shared.Abstraction.Exceptions.UserManagementExceptions
{
    public InvalidPasswordException() : base("Password Is Invalid...!")
    {
    }
}
