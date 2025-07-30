using DDD.Shared.Abstraction.Exceptions;

namespace ToplearnWithDDD.Domain.Exceptions.PaymentManagementExceptions;

internal class InvalidAmountException : PaymentManagementException
{
    public InvalidAmountException() : base("Amount Can Not Be Negative...!")
    {
    }
}
