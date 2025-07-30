using DDD.Shared.Abstraction.Exceptions;

namespace ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

internal class EmailNullOrEmptyException : DDD.Shared.Abstraction.Exceptions.UserManagementExceptions
{
    public EmailNullOrEmptyException() : base("Email Can Not Be Empty..!")
    {
    }
}
