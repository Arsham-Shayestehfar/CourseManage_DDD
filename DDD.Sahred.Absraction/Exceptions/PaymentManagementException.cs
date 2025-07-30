using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Shared.Abstraction.Exceptions
{
    public abstract class PaymentManagementException : Exception
    {
        protected PaymentManagementException(string message) : base(message)
        {

        }
    }
}
