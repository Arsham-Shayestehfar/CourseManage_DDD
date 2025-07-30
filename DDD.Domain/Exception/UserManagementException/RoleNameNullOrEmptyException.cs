using DDD.Shared.Abstraction.Exceptions;

namespace ToplearnWithDDD.Domain.Exceptions.UserManagementExceptions;

internal class RoleNameNullOrEmptyException : DDD.Shared.Abstraction.Exceptions.UserManagementExceptions
{
    public RoleNameNullOrEmptyException() : base("Role Name Can Not Be Empty...!")
    {
    }
}
