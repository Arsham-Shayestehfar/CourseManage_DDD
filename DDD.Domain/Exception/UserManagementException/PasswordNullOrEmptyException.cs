using DDD.Shared.Abstraction.Exceptions;

namespace ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

internal class PasswordNullOrEmptyException : DDD.Shared.Abstraction.Exceptions.UserManagementExceptions
{
    public PasswordNullOrEmptyException() : base("Password Can Not Be Null Or Empty")
    {
    }
}
