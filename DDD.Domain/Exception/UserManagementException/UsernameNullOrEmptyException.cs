using DDD.Shared.Abstraction.Exceptions;

namespace ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

internal class UsernameNullOrEmptyException : DDD.Shared.Abstraction.Exceptions.UserManagementExceptions
{
    public UsernameNullOrEmptyException( ) : base("Username Can Not Be Empty...!")
    {
    }
}
