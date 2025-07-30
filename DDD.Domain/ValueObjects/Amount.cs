using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToplearnWithDDD.Domain.Exceptions.PaymentManagementExceptions;

namespace DDD.Domain.ValueObjects
{
    public record Amount
    {
        public decimal Value { get; }

        public Amount(decimal value)
        {
            if (value < 0)
            {
                throw new InvalidAmountException();
            }

            Value = value;
        }

        public static implicit operator decimal(Amount amount) => amount.Value;
        public static implicit operator Amount(decimal amount) => new(amount);
    }
}
