using DDD.Domain.Entities.PaymentManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.PaymentManegement
{
    public class InvoiceFactory : IInvoiceFactory
    {
        public Invoice Create(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId)
        {
         return new Invoice (id, amount, date, userId, courseId);
        }
    }
}
