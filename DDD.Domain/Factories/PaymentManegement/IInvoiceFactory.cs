using DDD.Domain.Entities.PaymentManagement;
using DDD.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Factories.PaymentManegement
{
    public interface IInvoiceFactory
    {
        Invoice Create(BaseId id, Amount amount, DateTime date, BaseId userId, BaseId courseId);
    }
}
