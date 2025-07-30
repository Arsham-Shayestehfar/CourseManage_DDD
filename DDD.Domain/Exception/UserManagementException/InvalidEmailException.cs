using DDD.Shared.Abstraction.Exceptions;

namespace ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

internal class InvalidEmailException : DDD.Shared.Abstraction.Exceptions.UserManagementExceptions
{
    public InvalidEmailException() : base("Email Is Inavlid...!")
    {
    }
}
